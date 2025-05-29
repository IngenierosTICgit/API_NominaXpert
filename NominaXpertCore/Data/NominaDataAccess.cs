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
        public class NominaDataAccess
        {
            // Logger para la clase
            private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.NominaDataAccess");

            // Instancia del acceso a datos de PostgreSQL
            private readonly PostgresSQLDataAccess _dbAccess;

            /// <summary>
            /// Constructor de la clase NominasDataAccess
            /// </summary>

            public NominaDataAccess()
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

        // Crear una nueva nómina
        public int RegistrarNomina(int idEmpleado, int idAuditoria, DateTime periodoInicio, DateTime periodoFin)
        {
            string estadoPago = "Pendiente";  // El estado inicial por defecto

            string query = @"
                INSERT INTO nomina.nomina (id_empleado, fecha_inicio, fecha_fin, estado_pago, creado_at)
                VALUES (@idEmpleado, @periodoInicio, @periodoFin, @estadoPago, @creadoAt)
                RETURNING id;";  // Usamos RETURNING para obtener la ID generada

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idEmpleado", idEmpleado),
            _dbAccess.CreateParameter("@periodoInicio", periodoInicio),
            _dbAccess.CreateParameter("@periodoFin", periodoFin),
            _dbAccess.CreateParameter("@estadoPago", estadoPago),
            _dbAccess.CreateParameter("@creadoAt", DateTime.Now)
                };

                _dbAccess.Connect();
                DataTable result = _dbAccess.ExecuteQuery_Reader(query, parameters);

                if (result.Rows.Count > 0)
                {
                    // Obtener la ID generada
                    int idNomina = Convert.ToInt32(result.Rows[0]["id"]);
                    _logger.Info($"Nómina registrada correctamente para el empleado {idEmpleado}, ID de la nómina: {idNomina}.");
                    return idNomina;  // Retornar la ID de la nómina recién creada
                }
                else
                {
                    throw new Exception("No se pudo obtener la ID de la nómina.");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al registrar la nómina.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        // Obtener todas las nóminas
        public List<Nomina> ObtenerTodasLasNominas()
        {
            List<Nomina> nominas = new List<Nomina>();

            string query = @"
                SELECT id, id_empleado, periodo_inicio, periodo_fin, estado_pago, creado_at
                FROM nomina.nomina
                ORDER BY id";

            try
            {
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    Nomina nomina = new Nomina
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdEmpleado = Convert.ToInt32(row["id_empleado"]),
                        FechaInicio = Convert.ToDateTime(row["periodo_inicio"]),
                        FechaFin = Convert.ToDateTime(row["periodo_fin"]),
                        EstadoPago = row["estado_pago"].ToString(),
                        CreadoAt = Convert.ToDateTime(row["creado_at"])
                    };
                    nominas.Add(nomina);
                }

                _logger.Info($"Se obtuvieron {nominas.Count} nóminas.");
                return nominas;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las nóminas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Actualizar una nómina existente
        public int ActualizarNomina(Nomina nomina)
        {
            string query = @"
                UPDATE nomina.nomina
                SET id_empleado = @idEmpleado,
                    periodo_inicio = @periodoInicio,
                    periodo_fin = @periodoFin,
                    estado_pago = @estadoPago
                WHERE id = @id";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@id", nomina.Id),
                    _dbAccess.CreateParameter("@idEmpleado", nomina.IdEmpleado),
                    _dbAccess.CreateParameter("@periodoInicio", nomina.FechaInicio),
                    _dbAccess.CreateParameter("@periodoFin", nomina.FechaFin),
                    _dbAccess.CreateParameter("@estadoPago", nomina.EstadoPago)
                };

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);
                _logger.Info($"Nómina con ID {nomina.Id} actualizada correctamente. Filas afectadas: {rowsAffected}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar la nómina con ID {nomina.Id}");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Eliminar (baja lógica) una nómina
        public int EliminarNomina(int idNomina)
        {
            string query = "UPDATE nomina.nomina SET estado_pago = 'Eliminada' WHERE id = @idNomina";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idNomina", idNomina)
                };

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parameters);
                return rowsAffected; // Retorna el número de filas afectadas
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al eliminar la nómina con ID {idNomina}");
                return 0; // En caso de error
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Método para obtener la última nómina generada para un empleado específico
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public int ObtenerUltimaNominaGenerada(int idEmpleado)
        {
            string query = @"
                SELECT id
                FROM nomina.nomina
                WHERE id_empleado = @idEmpleado
                ORDER BY fecha_creacion DESC
                LIMIT 1"; // Asegura la última nómina generada
            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idEmpleado", idEmpleado)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    return Convert.ToInt32(resultado.Rows[0]["id"]);
                }
                else
                {
                    return 0; // Retornar 0 si no se encuentra ninguna nómina
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la última nómina generada.");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


        /// <summary>
        /// Método para buscar una nómina por su ID
        /// </summary>
        /// <param name="idNomina"></param>
        /// <returns></returns>
        public NominaConsulta BuscarNominaPorId(int idNomina)
        {
            string query = @"
        SELECT n.id AS IdNomina, e.id AS IdEmpleado, p.nombre_completo AS NombreEmpleado, 
               e.departamento AS Departamento, e.sueldo AS SueldoBase, p.rfc AS RFCEmpleado, 
               n.estado_pago AS EstadoPago
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
        ///Actualizar solo el estado de pago de una nómina
        /// </summary>
        /// <param name="idNomina"></param>
        /// <param name="nuevoEstado"></param>
        /// <returns></returns>
        public int ActualizarEstadoPago(int idNomina, string nuevoEstado)
        {
            string query = @"
        UPDATE nomina.nomina
        SET estado_pago = @nuevoEstado
        WHERE id = @idNomina";

            try
            {
                if (idNomina <= 0)
                    throw new ArgumentException("ID de nómina inválido.");

                var parametros = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idNomina", idNomina),
            _dbAccess.CreateParameter("@nuevoEstado", nuevoEstado)
                };

                _dbAccess.Connect();
                int rowsAffected = _dbAccess.ExecuteNonQuery(query, parametros);

                _logger.Info($"Estado de la nómina ID {idNomina} actualizado a '{nuevoEstado}'. Filas afectadas: {rowsAffected}");
                return rowsAffected;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al actualizar el estado de pago de la nómina.");
                return 0;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        // Método para contar las nóminas con estado de pago "Pendiente" y "Pagado"
        public (int pendientes, int pagados) ContarNominasPorEstado()
        {
            string query = @"
                SELECT
                    COUNT(CASE WHEN estado_pago = 'Pendiente' THEN 1 END) AS Pendientes,
                    COUNT(CASE WHEN estado_pago = 'Pagado' THEN 1 END) AS Pagados
                FROM nomina.nomina";

            try
            {
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                int pendientes = 0;
                int pagados = 0;

                if (resultado.Rows.Count > 0)
                {
                    // Obtener los valores de los recuentos
                    pendientes = Convert.ToInt32(resultado.Rows[0]["Pendientes"]);
                    pagados = Convert.ToInt32(resultado.Rows[0]["Pagados"]);
                }

                _logger.Info($"Se encontraron {pendientes} nóminas pendientes y {pagados} nóminas pagadas.");
                return (pendientes, pagados);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al contar las nóminas por estado de pago.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public List<NominaConsulta> DesplegarNominas()
        {
            List<NominaConsulta> nominas = new List<NominaConsulta>();

            // Consulta SQL modificada para usar LEFT JOIN y mostrar todas las nóminas
            string query = @"
                            SELECT 
                                n.id AS IdNomina,
                                n.id_empleado AS IdEmpleado,
                                n.fecha_inicio AS FechaInicio,
                                n.fecha_fin AS FechaFin,
                                n.estado_pago AS EstadoPago,
                                pay.monto_total AS MontoTotal,
                                pay.monto_letras AS MontoLetras
                            FROM 
                                nomina.nomina n
                            LEFT JOIN 
                                nomina.empleados e ON e.id = n.id_empleado
                            LEFT JOIN 
                                nomina.pagos pay ON pay.id_nomina = n.id
                            ORDER BY 
                                n.id DESC";

            try
            {
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    NominaConsulta nomina = new NominaConsulta
                    {
                        IdNomina = Convert.ToInt32(row["IdNomina"]),
                        IdEmpleado = Convert.ToInt32(row["IdEmpleado"]),
                        FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(row["FechaFin"]),
                        EstadoPago = row["EstadoPago"].ToString(),
                        MontoTotal = row["MontoTotal"] == DBNull.Value ? 0 : Convert.ToDecimal(row["MontoTotal"]),
                        MontoLetras = row["MontoLetras"] == DBNull.Value ? null : row["MontoLetras"].ToString()
                    };

                    nominas.Add(nomina);
                }

                _logger.Info($"Se obtuvieron {nominas.Count} nóminas.");
                return nominas;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al desplegar las nóminas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public List<NominaConsulta> BuscarNominasPorMatriculaYFechas(string matricula, DateTime fechaInicio, DateTime fechaFin)
        {
            List<NominaConsulta> nominas = new List<NominaConsulta>();
            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

            // Consulta SQL base
            string query = @"
            SELECT 
                n.id AS IdNomina,
                n.id_empleado AS IdEmpleado,
                n.fecha_inicio AS FechaInicio,
                n.fecha_fin AS FechaFin,
                n.estado_pago AS EstadoPago,
                pay.monto_total AS MontoTotal,
                pay.monto_letras AS MontoLetras
            FROM 
                nomina.nomina n
            JOIN 
                nomina.empleados e ON e.id = n.id_empleado
            JOIN 
                nomina.pagos pay ON pay.id_nomina = n.id
            WHERE 1=1";

            // Agregar condiciones solo si se proporcionan los parámetros
            if (!string.IsNullOrWhiteSpace(matricula))
            {
                query += " AND e.matricula = @matricula";
                parameters.Add(_dbAccess.CreateParameter("@matricula", matricula));
            }

            if (fechaInicio != DateTime.MinValue)
            {
                query += " AND n.fecha_inicio >= @fechaInicio";
                parameters.Add(_dbAccess.CreateParameter("@fechaInicio", fechaInicio));
            }

            if (fechaFin != DateTime.MinValue)
            {
                query += " AND n.fecha_fin <= @fechaFin";
                parameters.Add(_dbAccess.CreateParameter("@fechaFin", fechaFin));
            }

            query += " ORDER BY n.id DESC";

            try
            {
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

                foreach (DataRow row in resultado.Rows)
                {
                    NominaConsulta nomina = new NominaConsulta
                    {
                        IdNomina = Convert.ToInt32(row["IdNomina"]),
                        IdEmpleado = Convert.ToInt32(row["IdEmpleado"]),
                        FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(row["FechaFin"]),
                        EstadoPago = row["EstadoPago"].ToString(),
                        MontoTotal = Convert.ToDecimal(row["MontoTotal"]),
                        MontoLetras = row["MontoLetras"].ToString()
                    };

                    nominas.Add(nomina);
                }

                _logger.Info($"Se encontraron {nominas.Count} nóminas con los filtros aplicados.");
                return nominas;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar nóminas por filtros.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public List<NominaConsulta> BuscarNominasPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<NominaConsulta> nominas = new List<NominaConsulta>();

            string query = @"
            SELECT 
                n.id AS IdNomina,
                n.id_empleado AS IdEmpleado,
                n.fecha_inicio AS FechaInicio,
                n.fecha_fin AS FechaFin,
                n.estado_pago AS EstadoPago,
                pay.monto_total AS MontoTotal,
                pay.monto_letras AS MontoLetras
            FROM 
                nomina.nomina n
            JOIN 
                nomina.empleados e ON e.id = n.id_empleado
            JOIN 
                nomina.pagos pay ON pay.id_nomina = n.id
            WHERE 
                n.fecha_inicio >= @fechaInicio
                AND n.fecha_fin <= @fechaFin
            ORDER BY 
                n.id DESC";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@fechaInicio", fechaInicio),
                    _dbAccess.CreateParameter("@fechaFin", fechaFin)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                foreach (DataRow row in resultado.Rows)
                {
                    NominaConsulta nomina = new NominaConsulta
                    {
                        IdNomina = Convert.ToInt32(row["IdNomina"]),
                        IdEmpleado = Convert.ToInt32(row["IdEmpleado"]),
                        FechaInicio = Convert.ToDateTime(row["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(row["FechaFin"]),
                        EstadoPago = row["EstadoPago"].ToString(),
                        MontoTotal = Convert.ToDecimal(row["MontoTotal"]),
                        MontoLetras = row["MontoLetras"].ToString()
                    };

                    nominas.Add(nomina);
                }

                _logger.Info($"Se encontraron {nominas.Count} nóminas en el rango de fechas especificado.");
                return nominas;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar nóminas por rango de fechas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}