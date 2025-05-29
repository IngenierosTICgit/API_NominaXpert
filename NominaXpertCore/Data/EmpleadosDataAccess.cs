using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolar.Utilities; // LoggingManager
using Npgsql; // NpgsqlConnection, NpgsqlCommand
using NLog; // Logger para el registro de logs
using NominaXpertCore.Model; // Modelo de Empleado
using System.Data;

using ControlEscolar.Data;


namespace NominaXpertCore.Data
{
    public class EmpleadosDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.EmpleadosDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        // Instancia de la clase para el manejo de personas
        private readonly PersonasDataAccess _personasData;

        public EmpleadosDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();

                // Instancia de acceso a datos de personas para operaciones relacionadas
                _personasData = new PersonasDataAccess(); // Inicialización
                _logger.Info("Instancia de EmpleadosDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar EmpleadosDataAccess");
                throw;
            }
        }

        public List<Empleado> ObtenerTodosLosEmpleados(bool soloActivos = true)
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                string query = @"SELECT e.id, e.id_persona, e.puesto, e.departamento, e.sueldo, 
                                       e.tipo_contrato, e.fecha_ingreso, e.fecha_baja, 
                                       e.salario_fijo, e.estatus, 
                                       p.nombre_completo, p.correo, p.telefono, p.fecha_nacimiento, p.curp, p.rfc, p.direccion
                                FROM nomina.empleados e
                                INNER JOIN seguridad.personas p ON e.id_persona = p.id
                                WHERE 1=1";

                if (soloActivos)
                    query += " AND e.estatus = TRUE";

                query += " ORDER BY e.id";

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    Persona persona = new Persona(
                        Convert.ToInt32(row["id_persona"]),
                        row["nombre_completo"].ToString() ?? "",
                        row["correo"].ToString() ?? "",
                        row["telefono"].ToString() ?? "",
                        row["rfc"].ToString() ?? "",
                        row["curp"].ToString() ?? "",
                        row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                        row["direccion"].ToString() ?? "",
                        true
                );


                    Empleado empleado = new Empleado
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdPersona = Convert.ToInt32(row["id_persona"]),
                        Puesto = row["puesto"].ToString() ?? "",
                        Departamento = row["departamento"].ToString() ?? "",
                        Sueldo = Convert.ToDecimal(row["sueldo"]),
                        TipoContrato = row["tipo_contrato"].ToString() ?? "",
                        FechaIngreso = Convert.ToDateTime(row["fecha_ingreso"]),
                        FechaBaja = row["fecha_baja"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_baja"]) : null,
                        SalarioFijo = Convert.ToBoolean(row["salario_fijo"]),
                        Estatus = Convert.ToBoolean(row["estatus"]),
                        DatosPersonales = persona
                   
                };
                    empleados.Add(empleado);
                }
                _logger.Info($"Se obtuvieron {empleados.Count} empleados.");
                return empleados;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener empleados");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


        /// <summary>
        /// Inserta un nuevo empleado en la base de datos
        /// </summary>
        /// <param name="empleado">Empleado a insertar</param>
        /// <returns>ID del empleado insertado</returns>
        public int InsertarEmpleado(Empleado empleado)
        {
            try
            {

                if (empleado?.DatosPersonales == null)
                {
                    _logger.Error("Los datos personales del estudiante son nulos");
                    return -1;
                }
                // Primero insertamos la persona 
                int idPersona = _personasData.InsertarPersona(empleado.DatosPersonales);
                if (idPersona <= 0)
                {
                    _logger.Error($"No se pudo insertar la persona para el estudiante {empleado.Id}");
                    return -1;
                }
                // Actualizar el IdPersona en el objeto estudiante 
                empleado.IdPersona = idPersona;

                // Luego insertamos el empleado 
                string query = @"INSERT INTO nomina.empleados (id_persona, puesto, departamento, sueldo, tipo_contrato, fecha_ingreso, fecha_baja, salario_fijo, estatus)
                                 VALUES (@idPersona, @puesto, @departamento, @sueldo, @tipoContrato, @fechaIngreso, @fechaBaja, @salarioFijo, @estatus) RETURNING id";


                NpgsqlParameter paramIdPersona = _dbAccess.CreateParameter("@idPersona", empleado.IdPersona);
                NpgsqlParameter paramPuesto = _dbAccess.CreateParameter("@puesto", empleado.Puesto);
                NpgsqlParameter paramDepartamento = _dbAccess.CreateParameter("@departamento", empleado.Departamento);
                NpgsqlParameter paramSueldo = _dbAccess.CreateParameter("@sueldo", empleado.Sueldo);
                NpgsqlParameter paramTipoContrato = _dbAccess.CreateParameter("@tipoContrato", empleado.TipoContrato);
                NpgsqlParameter paramFechaIngreso = _dbAccess.CreateParameter("@fechaIngreso", empleado.FechaIngreso);
                NpgsqlParameter paramFechaBaja = _dbAccess.CreateParameter("@fechaBaja", empleado.FechaBaja ?? (object)DBNull.Value);
                NpgsqlParameter paramSalarioFijo = _dbAccess.CreateParameter("@salarioFijo", empleado.SalarioFijo);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@estatus", empleado.Estatus);

                // Establece la conexión a la BD 
                _dbAccess.Connect();

                // Ejecutar la consulta y obtener el ID generado
                object? result =
                    _dbAccess.ExecuteScalar(query, paramIdPersona, paramPuesto, paramDepartamento, paramSueldo,
                                            paramTipoContrato, paramFechaIngreso, paramFechaBaja, paramSalarioFijo,
                                            paramEstatus);

                // Convierte el resultado a entero
                int idEmpleado = Convert.ToInt32(result);
                _logger.Info($"Empleado insertado correctamente con ID: {idEmpleado}");
                return idEmpleado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar el empleado con el nombre {empleado.Id}");
                return -1;
            }
            finally
            {
                // Asegura que se cierre la conexión 
                _dbAccess.Disconnect();
            }
        }


        /// <summary>
        /// Actualiza un empleado existente en la base de datos
        /// </summary>
        /// <param name="empleado">Empleado con los nuevos datos</param>
        /// <returns>Numero de filas afectadas</returns>
        public int ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                string query = @"UPDATE nomina.empleados SET 
                                 id_persona = @idPersona, 
                                 puesto = @puesto, 
                                 departamento = @departamento, 
                                 sueldo = @sueldo, 
                                 tipo_contrato = @tipoContrato, 
                                 fecha_ingreso = @fechaIngreso, 
                                 fecha_baja = @fechaBaja, 
                                 salario_fijo = @salarioFijo, 
                                 estatus = @estatus
                                 WHERE id = @id";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@id", empleado.Id),
                    _dbAccess.CreateParameter("@idPersona", empleado.IdPersona),
                    _dbAccess.CreateParameter("@puesto", empleado.Puesto),
                    _dbAccess.CreateParameter("@departamento", empleado.Departamento),
                    _dbAccess.CreateParameter("@sueldo", empleado.Sueldo),
                    _dbAccess.CreateParameter("@tipoContrato", empleado.TipoContrato),
                    _dbAccess.CreateParameter("@fechaIngreso", empleado.FechaIngreso),
                    _dbAccess.CreateParameter("@fechaBaja", empleado.FechaBaja ?? (object)DBNull.Value),
                    _dbAccess.CreateParameter("@salarioFijo", empleado.SalarioFijo),
                    _dbAccess.CreateParameter("@estatus", empleado.Estatus)
                };

                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);
                _logger.Info($"Empleado actualizado correctamente con ID: {empleado.Id}. Filas afectadas: {rowsAffected}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar el empleado con el nombre {empleado.Puesto}");
                return 0;
            }
        }

        // <summary>
        /// Realiza un borrado lógico de un empleado por su ID (cambia estatus a FALSE)
        /// </summary>
        /// <param name="idEmpleado">ID del empleado a dar de baja</param>
        /// <returns>Número de filas afectadas</returns>
        public int EliminarEmpleado(int idEmpleado)
        {
            try
            {
                string query = "UPDATE nomina.empleados SET estatus = FALSE WHERE id = @idEmpleado";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idEmpleado", idEmpleado)
                };

                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);
                _logger.Info($"Empleado con ID {idEmpleado} dado de baja correctamente. Filas afectadas: {rowsAffected}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al dar de baja el empleado con ID {idEmpleado}");
                return 0;
            }
        }
        public List<Empleado> ObtenerEmpleadosFiltrados(string tipoContrato, bool estatus)
        {
            List<Empleado> empleados = new List<Empleado>();
            try
            {
                // Consulta con dirección incluida
                string query = @"SELECT 
                             e.id, e.id_persona, e.puesto, e.departamento, e.sueldo, 
                             e.tipo_contrato, e.fecha_ingreso, e.fecha_baja, e.salario_fijo, e.estatus,
                             p.nombre_completo, p.correo, p.telefono, p.fecha_nacimiento, p.curp, p.rfc, p.direccion
                         FROM nomina.empleados e
                         INNER JOIN seguridad.personas p ON e.id_persona = p.id
                         WHERE e.tipo_contrato = @tipoContrato AND e.estatus = @estatus";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@tipoContrato", tipoContrato),
            _dbAccess.CreateParameter("@estatus", estatus)
                };

                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                foreach (DataRow row in resultado.Rows)
                {
                    Empleado empleado = MapearEmpleado(row);
                    empleados.Add(empleado);
                }

                return empleados;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener empleados filtrados");
                throw;
            }
        }


        private Empleado MapearEmpleado(DataRow row)
        {
            Persona persona = new Persona(
                Convert.ToInt32(row["id_persona"]),
                row["nombre_completo"].ToString() ?? "",
                row["correo"].ToString() ?? "",
                row["telefono"].ToString() ?? "",
                row["rfc"].ToString() ?? "", // Asegúrate que la consulta traiga `rfc`
                row["curp"].ToString() ?? "",
                row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                row["direccion"].ToString() ?? "",
                true
            );

            Empleado empleado = new Empleado
            {
                Id = Convert.ToInt32(row["id"]),
                IdPersona = Convert.ToInt32(row["id_persona"]),
                Puesto = row["puesto"].ToString() ?? string.Empty,
                Departamento = row["departamento"].ToString() ?? string.Empty,
                Sueldo = Convert.ToDecimal(row["sueldo"]),
                TipoContrato = row["tipo_contrato"].ToString() ?? string.Empty,
                FechaIngreso = Convert.ToDateTime(row["fecha_ingreso"]),
                FechaBaja = row["fecha_baja"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_baja"]) : null,
                SalarioFijo = Convert.ToBoolean(row["salario_fijo"]),
                Estatus = Convert.ToBoolean(row["estatus"]),
                DatosPersonales = persona
            };

            return empleado;
        }
        // Método para verificar si un empleado está activo
        public bool VerificarEmpleadoActivo(int idEmpleado)
        {
            string query = "SELECT estatus FROM nomina.empleados WHERE id = @idEmpleado";

            try
            {
                // Crear el parámetro de la consulta SQL
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                _dbAccess.CreateParameter("@idEmpleado", idEmpleado)
                };

                // Conectar a la base de datos
                _dbAccess.Connect();

                // Ejecutamos la consulta SQL
                object result = _dbAccess.ExecuteScalar(query, parameters);

                // Verificamos si el resultado es nulo o si el empleado no está activo
                if (result != null && Convert.ToBoolean(result))
                {
                    return true; // El empleado está activo
                }
                else
                {
                    return false; // El empleado no está activo o el resultado es nulo
                }
            }
            catch (Exception ex)
            {
                // Capturamos cualquier error que ocurra y lo registramos
                _logger.Error(ex, "Error al verificar el estatus del empleado.");
                throw;
            }
            finally
            {
                // Desconectamos de la base de datos
                _dbAccess.Disconnect();
            }
        }

        // En EmpleadosDataAccess.cs buscamos el Nombre y sueldo del empleado en la bd
        public (string Nombre, decimal SueldoBase, int IdEmpleado, string Estatus) ObtenerNombreYSueldoPorMatricula(string matricula)
        {
            try
            {
                // Consulta SQL para obtener el nombre, sueldo, idEmpleado y estatus del empleado
                string query = @"
                    SELECT p.nombre_completo AS Nombre, e.sueldo AS SueldoBase, e.id AS IdEmpleado, e.estatus AS Estatus
                    FROM nomina.empleados e
                    INNER JOIN seguridad.personas p ON e.id_persona = p.id
                    WHERE e.matricula = @Matricula";  // Buscamos por la matrícula

                NpgsqlParameter paramMatricula = _dbAccess.CreateParameter("@Matricula", matricula);

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramMatricula);

                // Si no se encuentra el empleado con esa matrícula, devolvemos (null, 0, 0, "Inactivo")
                if (resultado.Rows.Count == 0)
                {
                    _logger.Warn($"No se encontró el empleado con matrícula: {matricula}");
                    return (null, 0, 0, "Inactivo");
                }

                DataRow row = resultado.Rows[0];
                string nombre = row["Nombre"].ToString();
                decimal sueldoBase = Convert.ToDecimal(row["SueldoBase"]);
                int idEmpleado = Convert.ToInt32(row["IdEmpleado"]);
                bool estatus = Convert.ToBoolean(row["Estatus"]);

                // Convertir el estatus a "Activo" o "Inactivo" según el valor de estatus (true/false)
                string estatusEmpleado = estatus ? "Activo" : "Inactivo";

                // Devolvemos los valores como un tuple
                return (nombre, sueldoBase, idEmpleado, estatusEmpleado);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener datos del empleado con matrícula: {matricula}");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene un empleado por su ID
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public Empleado ObtenerEmpleadoPorId(int idEmpleado)
        {
            try
            {
                string query = @"
            SELECT e.id, e.id_persona, e.puesto, e.departamento, e.sueldo, 
                   e.tipo_contrato, e.fecha_ingreso, e.fecha_baja, e.salario_fijo, e.estatus,
                   p.nombre_completo, p.correo, p.telefono, p.fecha_nacimiento, p.curp, p.rfc, p.direccion
            FROM nomina.empleados e
            INNER JOIN seguridad.personas p ON e.id_persona = p.id
            WHERE e.id = @idEmpleado";

                NpgsqlParameter param = _dbAccess.CreateParameter("@idEmpleado", idEmpleado);

                _dbAccess.Connect();
                DataTable result = _dbAccess.ExecuteQuery_Reader(query, param);

                if (result.Rows.Count > 0)
                {
                    return MapearEmpleado(result.Rows[0]);
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener el empleado por ID.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}


