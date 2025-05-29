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
    class DetalleNominaDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.DetalleNominaDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        // Constructor (aquí inicializas la conexión de acceso a datos)
        public DetalleNominaDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();

                _logger.Info("Instancia de DetalleNominaDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar DetalleNominaDataAccess");
                throw;
            }
        }

        /// <summary>
        /// Funcion de clase DetalleNominaDataAccess
        /// </summary>
        /// 
        // Registrar Detalle de Nómina
        public void RegistrarDetalleNomina(DetalleNomina detalleNomina)
        {
            string query = @"
            INSERT INTO nomina.detalle_nomina (id_nomina, descripcion, monto, tipo)
            VALUES (@idNomina, @descripcion, @monto, @tipo)";

            try
            {
                if (string.IsNullOrWhiteSpace(detalleNomina.Tipo))
                {
                    detalleNomina.Tipo = "Ingreso";
                }
                // Verificar si los parámetros son válidos
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                _dbAccess.CreateParameter("@idNomina", detalleNomina.IdNomina),
                _dbAccess.CreateParameter("@descripcion", detalleNomina.Descripcion),
                _dbAccess.CreateParameter("@monto", detalleNomina.Monto),
                _dbAccess.CreateParameter("@tipo", detalleNomina.Tipo)
                };

                _dbAccess.Connect();
                _dbAccess.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al registrar el detalle de nómina.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Obtener los detalles de una nómina
        public List<DetalleNomina> ObtenerDetallesPorNomina(int idNomina)
        {
            List<DetalleNomina> detalles = new List<DetalleNomina>();
            string query = @"
            SELECT id, id_nomina, descripcion, monto, tipo
            FROM nomina.detalle_nomina
            WHERE id_nomina = @idNomina";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                foreach (DataRow row in resultado.Rows)
                {
                    DetalleNomina detalle = new DetalleNomina
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdNomina = Convert.ToInt32(row["id_nomina"]),
                        Descripcion = row["descripcion"].ToString(),
                        Monto = Convert.ToDecimal(row["monto"]),
                        Tipo = row["tipo"].ToString()
                    };
                    detalles.Add(detalle);
                }

                return detalles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener los detalles de la nómina.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
    }
}
