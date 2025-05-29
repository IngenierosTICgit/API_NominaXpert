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
    class AuditoriaDataAccess
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Data.AuditoriaDataAccess");

        // Instancia del acceso a datos de PostgreSQL
        private readonly PostgresSQLDataAccess _dbAccess;

        public AuditoriaDataAccess()
        {
            try
            {
                // Obtiene la instancia única de PostgresSQLDataAccess (patrón Singleton)
                _dbAccess = PostgresSQLDataAccess.GetInstance();
                _logger.Info("Instancia de AuditoriaDataAccess creada correctamente.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar AuditoriaDataAccess");
                throw;
            }
        }


        /// <summary>
        /// Constructor de la clase AuditoriaDataAccess
        /// </summary>
        /// 
        // Registrar Auditoría
        public void RegistrarAuditoria(int idUsuario, string accion, string detalleAccion)
        {
            string query = @"
        INSERT INTO seguridad.auditorias (id_usuario, accion, detalle_accion, fecha, ip_acceso, nombre_equipo, hora)
        VALUES (@idUsuario, @accion, @detalleAccion, @fecha, @ipAcceso, @nombreEquipo, @hora)";

            try
            {

                // Obtener la IP local de la máquina (puedes ajustarlo para obtener la IP externa si lo deseas)
                string ipAcceso = GetLocalIPAddress();

                // Obtener el nombre del equipo
                string nombreEquipo = Environment.MachineName;
                

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@idUsuario", idUsuario),
                    _dbAccess.CreateParameter("@accion", accion),
                    _dbAccess.CreateParameter("@detalleAccion", detalleAccion),
                    _dbAccess.CreateParameter("@fecha",  DateTime.Now.Date),
                    _dbAccess.CreateParameter("@ipAcceso", ipAcceso),  // IP obtenida dinámicamente
                    _dbAccess.CreateParameter("@nombreEquipo", nombreEquipo), // Nombre del equipo obtenido dinámicamente
                    _dbAccess.CreateParameter("@hora", DateTime.Now) // Hora actual
                };

                // Conexión a la base de datos y ejecución de la consulta
                _dbAccess.Connect();
                _dbAccess.ExecuteNonQuery(query, parameters);

                _logger.Info($"Auditoría registrada: {accion} - {detalleAccion}");
            }
            catch (Exception ex)
            {
                // Si hay un error, lo registramos en el log
                _logger.Error(ex, "Error al registrar la auditoría.");
                throw;
            }
            finally
            {
                // Desconectamos de la base de datos
                _dbAccess.Disconnect();
            }
        }

        // Función para obtener la IP local de la máquina IPv4
        private string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            // Obtener la dirección IP local
            foreach (var host in System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList)
            {
                // Filtrar solo las direcciones IPv4
                if (host.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = host.ToString();
                    break; // Salir del bucle una vez que encontramos la primera dirección IPv4
                }
            }
            return localIP;
        }

        /// <summary>
        /// Método para obtener todas las auditorías
        /// </summary>
        /// <returns></returns>
        public List<Auditoria> ObtenerTodasLasAuditorias()
        {
            List<Auditoria> auditorias = new List<Auditoria>();

            string query = @"
        SELECT id, id_usuario, accion, detalle_accion, fecha, ip_acceso, nombre_equipo, hora
        FROM seguridad.auditorias
        ORDER BY fecha DESC, hora DESC";

            try
            {
                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    // Convertir la fecha (que es un DateTime)
                    DateTime fecha = Convert.ToDateTime(row["fecha"]);

                    // Convertir la hora (que es un TimeSpan)
                    TimeSpan hora = (TimeSpan)row["hora"]; // Asumimos que la columna hora es de tipo time sin zona horaria en PostgreSQL

                    // Crear el objeto Auditoria y asignar los valores
                    Auditoria auditoria = new Auditoria
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdUsuario = Convert.ToInt32(row["id_usuario"]),
                        Accion = row["accion"].ToString(),
                        DetalleAccion = row["detalle_accion"].ToString(),
                        Fecha = fecha,
                        IpAcceso = row["ip_acceso"].ToString(),
                        NombreEquipo = row["nombre_equipo"].ToString(),
                        Hora = hora // Aquí asignamos el TimeSpan
                    };

                    auditorias.Add(auditoria);
                }

                _logger.Info($"Se obtuvieron {auditorias.Count} auditorías.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener todas las auditorías.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }

            return auditorias;
        }
        /// <summary>
        /// Método para obtener auditorías filtradas por idUsuario y acción
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="accion"></param>
        /// <returns></returns>
        public List<Auditoria> ObtenerAuditoriasPorFiltro(int idUsuario, string accion)
        {
            List<Auditoria> auditorias = new List<Auditoria>();

            // Modificamos la consulta para usar condiciones OR basadas en los parámetros
            string query = @"
        SELECT id, id_usuario, accion, detalle_accion, fecha, ip_acceso, nombre_equipo, hora
        FROM seguridad.auditorias
        WHERE (id_usuario = @idUsuario OR @idUsuario = 0)
        AND (accion = @accion OR @accion = '')";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@idUsuario", idUsuario),
            _dbAccess.CreateParameter("@accion", accion)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                foreach (DataRow row in resultado.Rows)
                {
                    // Modificado para convertir correctamente 'hora' a TimeSpan
                    TimeSpan hora = (TimeSpan)row["hora"]; // Convertir directamente a TimeSpan
                    Auditoria auditoria = new Auditoria
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdUsuario = Convert.ToInt32(row["id_usuario"]),
                        Accion = row["accion"].ToString(),
                        DetalleAccion = row["detalle_accion"].ToString(),
                        Fecha = Convert.ToDateTime(row["fecha"]),  // Aquí no hay problema porque 'fecha' es de tipo DateTime
                        IpAcceso = row["ip_acceso"].ToString(),
                        NombreEquipo = row["nombre_equipo"].ToString(),
                        Hora = hora // Asignamos el TimeSpan correctamente
                    };
                    auditorias.Add(auditoria);
                }

                _logger.Info($"Se obtuvieron {auditorias.Count} auditorías filtradas por usuario {idUsuario} y/o acción '{accion}'.");
                return auditorias;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las auditorías filtradas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


        public List<Auditoria> ObtenerAuditoriasPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Auditoria> auditorias = new List<Auditoria>();

            string query = @"
            SELECT id, id_usuario, accion, detalle_accion, fecha, ip_acceso, nombre_equipo, hora
            FROM seguridad.auditorias
            WHERE fecha BETWEEN @fechaInicio AND @fechaFin";

            try
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
            _dbAccess.CreateParameter("@fechaInicio", fechaInicio.Date),
            _dbAccess.CreateParameter("@fechaFin", fechaFin.Date)
                };

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parameters);

                foreach (DataRow row in resultado.Rows)
                {
                    Auditoria auditoria = new Auditoria
                    {
                        Id = Convert.ToInt32(row["id"]),
                        IdUsuario = Convert.ToInt32(row["id_usuario"]),
                        Accion = row["accion"].ToString(),
                        DetalleAccion = row["detalle_accion"].ToString(),
                        Fecha = Convert.ToDateTime(row["fecha"]),
                        IpAcceso = row["ip_acceso"].ToString(),
                        NombreEquipo = row["nombre_equipo"].ToString(),
                        Hora = (TimeSpan)row["hora"]
                    };
                    auditorias.Add(auditoria);
                }

                _logger.Info($"Se obtuvieron {auditorias.Count} auditorías entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}.");
                return auditorias;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener auditorías por fechas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


    }
}