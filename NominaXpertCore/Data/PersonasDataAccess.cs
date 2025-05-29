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
    public class PersonasDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.PersonasDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor de la clase PersonasDataAccess
        /// </summary>

        public PersonasDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                _logger.Info("Instancia de PersonasDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar PersonasDataAccess");
                throw;
            }
        }

        /// <summary>
        /// Inserta una nueva persona en la base de datos
        /// </summary>
        /// <param name="persona">Persona a insertar</param>
        /// <returns>ID de la persona insertada</returns>
        public int InsertarPersona(Persona persona)
        {
            try
            {
                string query = @"INSERT INTO seguridad.personas (nombre_completo, correo, telefono, fecha_nacimiento, curp, estatus)
                                 VALUES (@NombreCompleto, @Correo, @Telefono, @FechaNacimiento, @Curp, @Estatus) RETURNING id";

                // Crea los parámetros
                NpgsqlParameter paramNombre = _dbAccess.CreateParameter("@NombreCompleto", persona.NombreCompleto);
                NpgsqlParameter paramCorreo = _dbAccess.CreateParameter("@Correo", persona.Correo);
                NpgsqlParameter paramTelefono = _dbAccess.CreateParameter("@Telefono", persona.Telefono);
                NpgsqlParameter paramFechaNac = _dbAccess.CreateParameter("@FechaNacimiento", persona.FechaNacimiento ?? (object)DBNull.Value);
                NpgsqlParameter paramCurp = _dbAccess.CreateParameter("@Curp", persona.Curp);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", persona.Estatus);

                // Establece la conexión a la BD 
                _dbAccess.Connect();

                // Ejecuta la inserción y obtiene el ID generado 
                object? resultado = _dbAccess.ExecuteScalar(query, paramNombre, paramCorreo, paramTelefono,
                                                          paramFechaNac, paramCurp, paramEstatus);
                // Convierte el resultado a entero 
                int idGenerado = Convert.ToInt32(resultado);
                _logger.Info($"Persona insertada correctamente con ID: {idGenerado}");
                return idGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar la persona {persona.NombreCompleto}");
                return -1;
            }
            finally
            {
                // Asegura que se cierre la conexión 
                _dbAccess.Disconnect();
            }
            
        }

        /// <summary>
        /// Actualiza una persona existente en la base de datos
        /// </summary>
        /// <param name="persona">Persona con los nuevos datos</param>
        /// <returns>Numero de filas afectadas</returns>
        public bool ActualizarPersona(Persona persona)
        {
            try
            {
                string query = "UPDATE seguridad.personas " +
                               "SET nombre_completo = @NombreCompleto, " +
                               "correo = @Correo, " +
                               "telefono = @Telefono, " +
                               "fecha_nacimiento = @FechaNacimiento, " +
                               "curp = @Curp, " +
                               "estatus = @Estatus " +
                               "WHERE id = @Id";

                //Crear los parámetros para la consulta
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@Id", persona.Id);
                NpgsqlParameter paramNombre = _dbAccess.CreateParameter("@NombreCompleto", persona.NombreCompleto);
                NpgsqlParameter paramCorreo = _dbAccess.CreateParameter("@Correo", persona.Correo);
                NpgsqlParameter paramTelefono = _dbAccess.CreateParameter("@Telefono", persona.Telefono);
                NpgsqlParameter paramFechaNac = _dbAccess.CreateParameter("@FechaNacimiento", persona.FechaNacimiento ?? (object)DBNull.Value);
                NpgsqlParameter paramCurp = _dbAccess.CreateParameter("@Curp", persona.Curp);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", persona.Estatus);

                //Establece la conexión a la base de datos
                _dbAccess.Connect();
                //Ejecuta la consulta de actualizacion
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, paramId, paramNombre, paramCorreo,
                                                                paramTelefono, paramFechaNac, paramCurp, paramEstatus);

                bool exito = filasAfectadas > 0;
                if (exito)
                {
                    _logger.Info($"Persona actualizada con ID: {persona.Id}");
                }
                else
                {
                    _logger.Warn($"No se encontró persona con ID: {persona.Id}. No se encontro el registro");
                }
                return exito;

            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar persona {persona.Id}");
                return false;
            }
            finally
            {
                //Cierra la conexión a la base de datos
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Verifica si un CURP ya está registrado en la base de datos
        /// </summary>
        /// <param name="curp">CURP a verificar</param>
        /// <returns>True si el CURP ya existe, False en caso contrario</returns>
        public bool ExisteCurp(string curp)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM seguridad.personas WHERE curp = @Curp";
                NpgsqlParameter paramCurp = _dbAccess.CreateParameter("@Curp", curp);

                _dbAccess.Connect();

                object? resultado = _dbAccess.ExecuteScalar(query, paramCurp);
                int count = Convert.ToInt32(resultado);

                return count > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar la existencia del CURP: {curp}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Elimina una persona por su ID
        /// </summary>
        /// <param name="idPersona">ID de la persona a eliminar</param>
        /// <returns>Numero de filas afectadas</returns>
        public int EliminarPersona(int idPersona)
        {
            try
            {
                string query = "DELETE FROM seguridad.personas WHERE id = @IdPersona";
                NpgsqlParameter paramIdPersona = _dbAccess.CreateParameter("@IdPersona", idPersona);

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, paramIdPersona);
                _logger.Info($"Persona con ID {idPersona} eliminada correctamente. Filas afectadas: {rowsAffected}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al eliminar la persona con ID {idPersona}");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        public bool ExisteRFC(string rfc)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM seguridad.personas WHERE rfc = @Rfc";
                NpgsqlParameter paramRfc = _dbAccess.CreateParameter("@Rfc", rfc);
                _dbAccess.Connect();
                object? resultado = _dbAccess.ExecuteScalar(query, paramRfc);
                int count = Convert.ToInt32(resultado);
                return count > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar la existencia del RFC: {rfc}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        public int InsertarPersonaSeguridad(Persona persona)
        {
            try
            {
                string query = "INSERT INTO seguridad.personas (nombre_completo, correo, telefono, direccion, rfc, curp, fecha_nacimiento, estatus) " +
                               "VALUES (@NombreCompleto, @Correo, @Telefono, @Direccion, @RFC, @Curp, @FechaNacimiento, @Estatus) " +
                               "RETURNING id";

                // Crea los parámetros
                NpgsqlParameter paramNombre = _dbAccess.CreateParameter("@NombreCompleto", persona.NombreCompleto);
                NpgsqlParameter paramCorreo = _dbAccess.CreateParameter("@Correo", persona.Correo);
                NpgsqlParameter paramDireccion = _dbAccess.CreateParameter("@Direccion", persona.Direccion);
                NpgsqlParameter paramTelefono = _dbAccess.CreateParameter("@Telefono", persona.Telefono);
                NpgsqlParameter paramFechaNac = _dbAccess.CreateParameter("@FechaNacimiento", persona.FechaNacimiento ?? (object)DBNull.Value);
                NpgsqlParameter paramRFC = _dbAccess.CreateParameter("@RFC", persona.Rfc);
                NpgsqlParameter paramCurp = _dbAccess.CreateParameter("@Curp", persona.Curp);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", persona.Estatus);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la inserción y obtiene el ID generado
                object resultado = _dbAccess.ExecuteScalar(query, paramNombre, paramCorreo, paramTelefono, paramDireccion,
                                                           paramRFC, paramCurp, paramFechaNac, paramEstatus);

                // Convierte el resultado a entero
                int idGenerado = Convert.ToInt32(resultado);
                _logger.Info($"Persona insertada correctamente con ID: {idGenerado}");

                return idGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar la persona {persona.NombreCompleto}");
                return -1;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }
        public bool ActualizarPersonaSeguridad(Persona persona)
        {
            try
            {
                string query = @"
            UPDATE seguridad.personas
            SET nombre_completo = @NombreCompleto,
                correo = @Correo,
                telefono = @Telefono,
                direccion = @Direccion,
                rfc = @RFC,
                curp = @Curp,
                fecha_nacimiento = @FechaNacimiento,
                estatus = @Estatus
            WHERE id = @Id";

                NpgsqlParameter paramId = _dbAccess.CreateParameter("@Id", persona.Id);
                NpgsqlParameter paramNombre = _dbAccess.CreateParameter("@NombreCompleto", persona.NombreCompleto);
                NpgsqlParameter paramCorreo = _dbAccess.CreateParameter("@Correo", persona.Correo);
                NpgsqlParameter paramTelefono = _dbAccess.CreateParameter("@Telefono", persona.Telefono);
                NpgsqlParameter paramDireccion = _dbAccess.CreateParameter("@Direccion", persona.Direccion);
                NpgsqlParameter paramRFC = _dbAccess.CreateParameter("@RFC", persona.Rfc);
                NpgsqlParameter paramCurp = _dbAccess.CreateParameter("@Curp", persona.Curp);
                NpgsqlParameter paramFechaNacimiento = _dbAccess.CreateParameter("@FechaNacimiento", persona.FechaNacimiento ?? (object)DBNull.Value);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", persona.Estatus);

                _dbAccess.Connect();

                int filasAfectadas = _dbAccess.ExecuteNonQuery(query,
                    paramId, paramNombre, paramCorreo, paramTelefono, paramDireccion,
                    paramRFC, paramCurp, paramFechaNacimiento, paramEstatus);

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar la persona con ID {persona.Id}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}
