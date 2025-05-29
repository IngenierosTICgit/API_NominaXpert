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
    class DeducciónDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.DeduccionDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor de la clase DeducciónDataAccess
        /// </summary>
        public DeducciónDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                _logger.Info("Instancia de DeducciónDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar DeducciónDataAccess");
                throw;
            }
        }

        /// <summary>
        /// Funcion de clase DeduccionDataAccess
        /// </summary>
        /// 
        // Registrar Deducción
        public void RegistrarDeduccion(Deduccion deduccion)
        {
            string query = @"
                INSERT INTO nomina.deducciones (id_nomina, id_tipo, monto)
                VALUES (@idNomina, @idTipo, @monto)";

            try
            {
                if (deduccion.IdNomina <= 0 || deduccion.IdTipo <= 0 || deduccion.Monto <= 0)
                    throw new ArgumentException("Los valores proporcionados son inválidos.");

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@idNomina", deduccion.IdNomina),
                    _dbAccess.CreateParameter("@idTipo", deduccion.IdTipo),
                    _dbAccess.CreateParameter("@monto", deduccion.Monto)
                };

                _dbAccess.Connect();
                _dbAccess.ExecuteNonQuery(query, parameters);

                _logger.Info($"Deducción registrada con éxito para la nómina ID: {deduccion.IdNomina}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al registrar la deducción.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Obtener Deducciones de una nómina
        public List<Deduccion> ObtenerDeduccionesPorNomina(int idNomina)
        {
            List<Deduccion> deducciones = new List<Deduccion>();
            string query = @"SELECT id, id_nomina, id_tipo, monto 
                             FROM nomina.deducciones 
                             WHERE id_nomina = @idNomina";

            try
            {
                if (idNomina <= 0)
                    throw new ArgumentException("La ID de la nómina no es válida.");
                // Verificar si los parámetros son válidos

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                foreach (DataRow row in resultado.Rows)
                {
                    Deduccion deduccion = new Deduccion
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdNomina = Convert.ToInt32(row["id_nomina"]),
                        IdTipo = Convert.ToInt32(row["id_tipo"]),
                        Monto = Convert.ToDecimal(row["monto"])
                    };
                    deducciones.Add(deduccion);
                }

                return deducciones;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las deducciones.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


        // Actualizar Deducción
        public int ActualizarDeduccion(Deduccion deduccion)
        {
            string query = @"
                UPDATE nomina.deducciones
                SET id_tipo = @idTipo, monto = @monto
                WHERE id = @id AND id_nomina = @idNomina";

            try
            {
                if (deduccion.Id <= 0 || deduccion.IdNomina <= 0 || deduccion.IdTipo <= 0 || deduccion.Monto <= 0)
                    throw new ArgumentException("Los valores proporcionados son inválidos.");

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@id", deduccion.Id),
                    _dbAccess.CreateParameter("@idNomina", deduccion.IdNomina),
                    _dbAccess.CreateParameter("@idTipo", deduccion.IdTipo),
                    _dbAccess.CreateParameter("@monto", deduccion.Monto)
                };

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);

                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al actualizar la deducción.");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Eliminar Deducción
        public int EliminarDeduccion(int idDeduccion, int idNomina)
        {
            string query = @"
                DELETE FROM nomina.deducciones
                WHERE id = @id AND id_nomina = @idNomina";

            try
            {
                if (idDeduccion <= 0 || idNomina <= 0)
                    throw new ArgumentException("Los valores proporcionados son inválidos.");

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@id", idDeduccion),
                    _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);

                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al eliminar la deducción.");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
    }
}