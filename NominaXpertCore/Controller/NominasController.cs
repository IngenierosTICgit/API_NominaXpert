using NominaXpertCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaXpertCore.Model;
using NLog;
using NominaXpertCore.Utilities;
using ControlEscolar.Utilities;
using Npgsql;
using System.Data;
using ControlEscolar.Data;
using NominaXpertCore.Business;


namespace NominaXpertCore.Controller
{
    public class NominasController
    {
        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;


        private readonly NominaDataAccess _nominaDataAccess;
        private readonly AuditoriaDataAccess _auditoriaDataAccess;
        private readonly EmpleadosDataAccess _empleadosDataAccess; // Para verificar el estatus del empleado
        private readonly UsuariosDataAccess _usuariosDataAccess; // Para verificar el rol del usuario
        private readonly RegistroJornadaController _registroJornadaController; // Para consultar las horas trabajadas

        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.NominasController");

        public NominasController()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                // Inicialización de las clases de acceso a datos
                _nominaDataAccess = new NominaDataAccess();
                _auditoriaDataAccess = new AuditoriaDataAccess();
                _empleadosDataAccess = new EmpleadosDataAccess();
                _usuariosDataAccess = new UsuariosDataAccess(); // Para validar el rol del usuario
                _registroJornadaController = new RegistroJornadaController(); // Inicializamos el controlador para consultar horas
                _logger.Info("Instancia de NominasDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar EmpleadosDataAccess");
                throw;
            }

        }

        // Método para obtener la última nómina generada para un empleado
        public int ObtenerUltimaNominaGenerada(int idEmpleado)
        {
            return _nominaDataAccess.ObtenerUltimaNominaGenerada(idEmpleado); // Acceder a la base de datos para obtener la ID
        }

        public bool CrearNomina(int idEmpleado, int idUsuario, DateTime periodoInicio, DateTime periodoFin)
        {
            try
            {
                // Verificar que el empleado esté activo
                bool empleadoActivo = _empleadosDataAccess.VerificarEmpleadoActivo(idEmpleado);
                if (!empleadoActivo)
                {
                    throw new Exception("El empleado no está activo.");
                }

                //  Consultar el total de horas trabajadas
                decimal totalHoras = _registroJornadaController.ConsultarTotalHorasTrabajadas(idEmpleado, periodoInicio, periodoFin, idUsuario);
                if (totalHoras == 0)
                {
                    throw new Exception("Las horas trabajadas son 0. No se puede generar la nómina.");
                }

                //  Registrar la nómina en la base de datos y obtener la ID generada
                int idNominaGenerada = _nominaDataAccess.RegistrarNomina(idEmpleado, idUsuario, periodoInicio, periodoFin);  // Aquí obtenemos la ID generada

                // Registrar la auditoría de la acción de alta de la nómina
                string detalleAccion = $"Se creó una nómina para el empleado con ID {idEmpleado} en el periodo {periodoInicio.ToShortDateString()} - {periodoFin.ToShortDateString()} con un total de {totalHoras} horas trabajadas.";
                _auditoriaDataAccess.RegistrarAuditoria(idUsuario, "alta nómina", detalleAccion);

                // Devolver la ID de la nómina generada si todo fue exitoso
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al crear la nómina.");
                return false;
            }
        }

        public bool VerificarPermisosUsuario(int idUsuario)
        {
            try
            {
                // Verificar que el usuario tenga permiso para generar la nómina (rol 1: ADMIN, rol 2: OPERADOR)
                bool usuarioAutorizado = _usuariosDataAccess.PermisoUsuarioGenerarNomina(idUsuario);

                if (!usuarioAutorizado)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar los permisos del usuario con ID {idUsuario}");
                return false;
            }
        }

        // Propiedad para almacenar el valor de totalHoras
        public static decimal TotalHoras { get; set; }

        // Calcular las horas trabajadas y almacenarlas en la propiedad TotalHoras
        public void CalcularTotalHoras(int idEmpleado, DateTime fechaInicio, DateTime fechaFin, int idUsuario)
        {
            decimal totalHoras = _registroJornadaController.ConsultarTotalHorasTrabajadas(idEmpleado, fechaInicio, fechaFin, idUsuario);

            // Almacenamos el valor de las horas trabajadas en la propiedad estática
            TotalHoras = totalHoras;
        }

        /// <summary>
        /// Busca una nómina por su ID.
        /// </summary>
        /// <param name="idNomina"></param>
        /// <returns></returns>
        public NominaConsulta BuscarNominaPorId(int idNomina)
        {
            string query = @"
        SELECT n.id AS IdNomina, e.id AS IdEmpleado, p.nombre_completo AS NombreEmpleado, 
               e.departamento AS Departamento, e.sueldo AS SueldoBase, p.rfc AS RFCEmpleado, 
               n.estado_pago AS EstadoPago, n.fecha_inicio AS FechaInicio, n.fecha_fin AS FechaFin
        FROM nomina.nomina n
        INNER JOIN nomina.empleados e ON n.id_empleado = e.id
        INNER JOIN seguridad.personas p ON e.id_persona = p.id
        WHERE n.id = @idNomina;";

            try
            {
                if (idNomina <= 0)
                    throw new ArgumentException("La ID de la nómina no es válida.");

                var parametros = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                _dbAccess.Connect();
                DataTable dt = _dbAccess.ExecuteQuery_Reader(query, parametros);

                if (dt.Rows.Count == 0)
                    return null;

                var row = dt.Rows[0];

                return new NominaConsulta
                {
                    IdNomina = Convert.ToInt32(row["IdNomina"]),
                    IdEmpleado = Convert.ToInt32(row["IdEmpleado"]),
                    EstadoPago = row["EstadoPago"].ToString(),
                    // Estas dos líneas son cruciales para mostrar las fechas correctas
                    FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                    FechaFin = Convert.ToDateTime(row["FechaFin"]),
                    DatosEmpleado = new Empleado
                    {
                        Id = Convert.ToInt32(row["IdEmpleado"]),
                        Departamento = row["Departamento"].ToString(),
                        Sueldo = Convert.ToDecimal(row["SueldoBase"]),
                        DatosPersonales = new Persona
                        {
                            NombreCompleto = row["NombreEmpleado"].ToString(),
                            Rfc = row["RFCEmpleado"].ToString()
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar la nómina por ID.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


        /// <summary>
        /// Actualiza el estado de pago de una nómina.
        /// </summary>
        /// <param name="idNomina"></param>
        /// <param name="nuevoEstado"></param>
        /// <returns></returns>
        public int ActualizarEstadoPago(int idNomina, string nuevoEstado, int idUsuario)
        {
            try
            {
                // Registrar la auditoría de la acción de actualización del estado de pago
                var nomina = _nominaDataAccess.BuscarNominaPorId(idNomina); // Obtenemos la nómina para detalles adicionales
                if (nomina != null)
                {
                    string detalleAccion = $"Se actualizó el estado de la nómina del empleado [ID: {nomina.IdEmpleado}] " +
                                           $"para el periodo {nomina.FechaInicio.ToShortDateString()} - {nomina.FechaFin.ToShortDateString()} " +
                                           $"a {nuevoEstado}.";

                    // Llamar al método de auditoría para registrar la acción, incluyendo el idUsuario
                    _auditoriaDataAccess.RegistrarAuditoria(idUsuario, "edición de nómina", detalleAccion);
                }

                // Realizar la actualización del estado de pago en la base de datos
                _logger.Info($"NominasController -> ActualizarEstadoPago ejecutado para nómina {idNomina} nuevo estado: {nuevoEstado}");
                return _nominaDataAccess.ActualizarEstadoPago(idNomina, nuevoEstado);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al actualizar el estado de pago.");
                return 0; // Retorna 0 en caso de error
            }
        }

        public int ObtenerRolUsuario(int idUsuario)
        {
            try
            {
                // Obtener el usuario con el idUsuario (suponiendo que tienes un método para obtenerlo)
                var usuario = _usuariosDataAccess.ObtenerUsuarioPorId(idUsuario);

                // Si no existe el usuario, retornar -1 o un valor predeterminado para indicar error
                if (usuario == null)
                {
                    _logger.Warn($"No se encontró el usuario con ID {idUsuario}");
                    return -1;
                }

                // Retornar el id_rol del usuario
                return usuario.IdRol;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener el rol del usuario con ID {idUsuario}");
                return -1; // En caso de error, retorna -1
            }
        }


        // Método para obtener todas las nóminas
        public List<NominaConsulta> DesplegarNominas()
        {
            try
            {
                // Llamamos al método de la capa de acceso a datos para obtener las nóminas
                List<NominaConsulta> nominas = _nominaDataAccess.DesplegarNominas();

                // Verificamos si se obtuvieron nóminas
                if (nominas.Count == 0)
                {
                    _logger.Warn("No se encontraron nóminas.");
                }
                else
                {
                    _logger.Info($"Se obtuvieron {nominas.Count} nóminas.");
                }

                return nominas;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al desplegar las nóminas.");
                throw;
            }

        }

        public List<NominaConsulta> BuscarNominasPorMatriculaYFechas(string matricula, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                // Llamar al DataAccess para obtener las nóminas filtradas
                return _nominaDataAccess.BuscarNominasPorMatriculaYFechas(matricula, fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar las nóminas por matrícula y fechas.");
                throw;
            }
        }

        public bool EliminarNomina(int idNomina)
        {
            try
            {
                // Llamar al DataAccess para eliminar la nómina de la base de datos
                int resultado = _nominaDataAccess.EliminarNomina(idNomina);
                return resultado > 0; // Si se afectaron filas, la eliminación fue exitosa
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al eliminar la nómina.");
                return false;
            }
        }
    

    /// <summary>
/// Verifica si el sueldo base es igual al sueldo mínimo configurado
/// </summary>
/// <param name="sueldoBase">Sueldo base a verificar</param>
/// <returns>True si es igual al mínimo, False si no</returns>
public bool VerificarSueldoIgualMinimo(decimal sueldoBase)
        {
            try
            {
                bool esIgualMinimo = NominaNegocio.VerificarSueldoMinimo(sueldoBase);
                if (esIgualMinimo)
                {
                    _logger.Info($"El sueldo base {sueldoBase} es igual al sueldo mínimo configurado.");
                }
                return esIgualMinimo;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al verificar si el sueldo es igual al mínimo");
                throw;
            }
        }

        /// <summary>
        /// Verifica si el sueldo base es menor al sueldo mínimo configurado
        /// </summary>
        /// <param name="sueldoBase">Sueldo base a verificar</param>
        /// <returns>True si es menor al mínimo, False si no</returns>
        public bool VerificarSueldoMenorMinimo(decimal sueldoBase)
        {
            try
            {
                bool esMenorMinimo = NominaNegocio.VerificarSueldoMenorMinimo(sueldoBase);
                if (esMenorMinimo)
                {
                    _logger.Warn($"El sueldo base {sueldoBase} es menor al sueldo mínimo configurado.");
                }
                return esMenorMinimo;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al verificar si el sueldo es menor al mínimo");
                throw;
            }
        }

        /// <summary>
        /// Obtiene el sueldo mínimo configurado
        /// </summary>
        /// <returns>Valor del sueldo mínimo</returns>
        public decimal ObtenerSueldoMinimo()
        {
            try
            {
                return NominaNegocio.ObtenerSueldoMinimo();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener el sueldo mínimo");
                throw;
            }
        }

        public List<NominaConsulta> BuscarNominasPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                // Validar que la fecha de fin no sea anterior a la fecha de inicio
                if (fechaFin < fechaInicio)
                {
                    throw new ArgumentException("La fecha de fin no puede ser anterior a la fecha de inicio.");
                }

                // Llamar al DataAccess para obtener las nóminas filtradas
                return _nominaDataAccess.BuscarNominasPorFechas(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar nóminas por rango de fechas.");
                throw;
            }
        }
    }
}