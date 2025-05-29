using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolar.Data;
using ControlEscolar.Utilities;
using NLog;
using NominaXpertCore.Model;
using Npgsql;

namespace NominaXpertCore.Data
{
    class BonificacionDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.BonificacionDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor de la clase NominasDataAccess
        /// </summary>

        public BonificacionDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                _logger.Info("Instancia de BonificacionDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar BonificacionDataAccess");
                throw;
            }
        }

        // Registrar Bonificación
        public void RegistrarBonificacion(Bonificacion bonificacion)
        {
            string query = @"
                INSERT INTO nomina.bonificaciones (id_nomina, id_tipo, monto)
                VALUES (@idNomina, @idTipo, @monto)";

            try
            {
                // Verificar si los parámetros son válidos
                if (bonificacion.IdNomina <= 0 || bonificacion.IdTipo <= 0 || bonificacion.Monto <= 0)
                {
                    throw new ArgumentException("Los valores proporcionados son inválidos.");
                }

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@idNomina", bonificacion.IdNomina),
                    _dbAccess.CreateParameter("@idTipo", bonificacion.IdTipo),
                    _dbAccess.CreateParameter("@monto", bonificacion.Monto)
                };

                _dbAccess.Connect();
                _dbAccess.ExecuteNonQuery(query, parameters);

                _logger.Info($"Bonificación registrada con éxito para la nómina ID: {bonificacion.IdNomina}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al registrar la bonificación.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Obtener Bonificaciones de una nómina
        public List<Bonificacion> ObtenerBonificacionesPorNomina(int idNomina)
        {
            List<Bonificacion> bonificaciones = new List<Bonificacion>();
            string query = @"
        SELECT id, id_nomina, id_tipo, monto
        FROM nomina.bonificaciones
        WHERE id_nomina = @idNomina";

            try
            {
                if (idNomina <= 0)
                {
                    throw new ArgumentException("La ID de la nómina no es válida.");
                }

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                 _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                // Si la consulta devuelve filas, agregar las bonificaciones a la lista
                foreach (DataRow row in resultado.Rows)
                {
                    Bonificacion bonificacion = new Bonificacion
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdNomina = Convert.ToInt32(row["id_nomina"]),
                        IdTipo = Convert.ToInt32(row["id_tipo"]),
                        Monto = Convert.ToDecimal(row["monto"])
                    };
                    bonificaciones.Add(bonificacion);
                }

                return bonificaciones;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las bonificaciones.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Eliminar Bonificación
        public int EliminarBonificacion(int idBonificacion, int idNomina)
        {
            string query = @"
                DELETE FROM nomina.bonificaciones
                WHERE id = @id AND id_nomina = @idNomina"; //  id_nomina
            try
            {
                // Validar si el ID de la bonificación es válido
                if (idBonificacion <= 0 || idNomina <= 0)
                {
                    throw new ArgumentException("El ID de la bonificación es inválido.");
                }

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@id", idBonificacion),
                    _dbAccess.CreateParameter("@idNomina", idNomina) // validación por id_nomina
                 };
                ;

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);

                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al eliminar la bonificación.");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Actualizar Bonificación
        public int ActualizarBonificacion(Bonificacion bonificacion)
        {
            string query = @"
                UPDATE nomina.bonificaciones
                SET id_tipo = @idTipo, monto = @monto
                WHERE id = @id AND id_nomina = @idNomina"; ;

            try
            {
                // Validar si los parámetros de la bonificación son válidos
                if (bonificacion.Id <= 0 || bonificacion.IdNomina <= 0 || bonificacion.IdTipo <= 0 || bonificacion.Monto <= 0)
                {
                    throw new ArgumentException("Los valores proporcionados son inválidos.");
                }

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@id", bonificacion.Id),
                    _dbAccess.CreateParameter("@idNomina", bonificacion.IdNomina), // validación por id_nomina
                    _dbAccess.CreateParameter("@idTipo", bonificacion.IdTipo),
                    _dbAccess.CreateParameter("@monto", bonificacion.Monto)
                        };

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);

                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al actualizar la bonificación.");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}
