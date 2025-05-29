using System;
using System.Data;
using ControlEscolar.Data;
using ControlEscolar.Utilities;
using NLog;
using NominaXpertCore.Model;
using Npgsql;

namespace NominaXpertCore.Data
{
    public class PagoDataAccess
    {
        // Logger usando el LoggingManager centralizado
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.PagoDataAccess");
        private readonly PostgresSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor de la clase PagoDataAccess.
        /// </summary>
        public PagoDataAccess()
        {
            try
            {
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                _logger.Info("Instancia de PagoDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar PagoDataAccess.");
                throw;
            }
        }

        /// <summary>
        /// Registra un nuevo pago en la base de datos.
        /// </summary>
        /// <param name="pago"></param>
        /// <returns></returns>
        public int RegistrarPago(Pago pago)
        {
            string query = @"
            INSERT INTO nomina.pagos (id_nomina, fecha_pago, monto_total, monto_letras, metodo_pago, referencia)
            VALUES (@idNomina, @fechaPago, @montoTotal, @montoLetras, @metodoPago, @referencia)";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@idNomina", pago.IdNomina),
                    _dbAccess.CreateParameter("@fechaPago", pago.FechaPago),
                    _dbAccess.CreateParameter("@montoTotal", pago.MontoTotal),
                    _dbAccess.CreateParameter("@montoLetras", pago.MontoLetras),
                    _dbAccess.CreateParameter("@metodoPago", pago.MetodoPago),
                    _dbAccess.CreateParameter("@referencia", pago.Referencia)
                };

                _dbAccess.Connect();
                int result = _dbAccess.ExecuteNonQuery(query, parameters);

                _logger.Info($"Pago registrado correctamente para la nómina {pago.IdNomina}.");
                return result;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al registrar el pago.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public bool ExistePagoParaNomina(int idNomina)
        {
            string query = "SELECT COUNT(*) FROM nomina.pagos WHERE id_nomina = @idNomina";

            try
            {
                _dbAccess.Connect();
                var parametro = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                DataTable dt = _dbAccess.ExecuteQuery_Reader(query, parametro);

                if (dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);
                    return count > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al verificar existencia de pago.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public decimal ContarMontoTotalMesActual()
        {
            string query = @"
        SELECT SUM(monto_total) AS MontoTotalMes
        FROM nomina.pagos
        WHERE EXTRACT(MONTH FROM fecha_pago) = EXTRACT(MONTH FROM CURRENT_DATE)
        AND EXTRACT(YEAR FROM fecha_pago) = EXTRACT(YEAR FROM CURRENT_DATE);";

            try
            {
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                decimal montoTotalMes = 0;

                if (resultado.Rows.Count > 0)
                {
                    montoTotalMes = Convert.ToDecimal(resultado.Rows[0]["MontoTotalMes"]);
                }

                _logger.Info($"El monto total de los pagos realizados en el mes actual es: {montoTotalMes}");
                return montoTotalMes;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al contar los montos totales del mes actual.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


    }
}
