using ControlEscolar.Data;
using ControlEscolar.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Npgsql;

namespace NominaXpertCore.Data
{
    public class RegistroJornadaDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.NominaDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor de la clase RegistroJornadaDataAccess
        /// </summary>

        public RegistroJornadaDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                _logger.Info("Instancia de NominaDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar NominaDataAccess");
                throw;
            }
        }

        // Crear un nuevo registro de jornada

        public decimal ObtenerTotalHorasTrabajadas(int idEmpleado, DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"
        SELECT COALESCE(ROUND(SUM(horas), 2), 0) AS totalHoras
        FROM nomina.registro_jornada
        WHERE id_empleado = @idEmpleado
        AND fecha BETWEEN @fechaInicio AND @fechaFin";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idEmpleado", idEmpleado),
            _dbAccess.CreateParameter("@fechaInicio", fechaInicio.Date),
            _dbAccess.CreateParameter("@fechaFin", fechaFin.Date)
                };

                _dbAccess.Connect();

                object result = _dbAccess.ExecuteScalar(query, parameters);
                decimal totalHoras = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                _logger.Info($"Se obtuvieron {totalHoras} horas trabajadas para el empleado {idEmpleado}.");
                return totalHoras;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las jornadas registradas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}
