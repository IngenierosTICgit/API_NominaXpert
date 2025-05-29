using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace ControlEscolar.Utilities
{
    public static class LoggingManager
    {
        private static bool _isConfigured = false;

        /// <summary>
        /// Configura NLog para el proyecto. Este método debe llamarse al inicio de la aplicación.
        /// </summary>
        public static void ConfigureLogging()
        {
            // Si ya está configurado, no hacer nada
            if (_isConfigured)
                return;

            try
            {
                // Crear configuración básica
                LoggingConfiguration config = new LoggingConfiguration();

                // Crear directorio de logs
                string logDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }

                // Target para todos los logs
                FileTarget logFileTarget = new FileTarget
                {
                    Name = "logfile",
                    FileName = Path.Combine(logDirectory, "app-${shortdate}.log"),
                    //Layout = "${longdate} | ${level:uppercase=true} | ${logger} | ${message} ${exception:format=ToString}"
                    Layout = "${longdate} | ${level:uppercase=true} | ${logger} | " +
             // Para mensajes TRACE, añadir información adicional
             "${when:when=level==LogLevel.Trace:inner=[DETALLE COMPLETO] }${when:when=level==LogLevel.Fatal:inner=[CRÍTICO] }" +
             "${message} " +
             // Formato diferente para la excepción según el nivel
             "${when:when=level==LogLevel.Trace:inner=${exception:format=ToString,StackTrace:maxInnerExceptionLevel=3}}" +
             "${when:when=level==LogLevel.Error:inner=${exception:format=ToString}}" +
             "${when:when=level==LogLevel.Fatal:inner=${exception:format=ToString,StackTrace,Data:maxInnerExceptionLevel=5}}" +
             "${when:when=level!=LogLevel.Trace:when=level!=LogLevel.Error:when=level!=LogLevel.Fatal:inner=${exception:format=ToString}}"
                };

                // Target para logs de base de datos
                FileTarget dbFileTarget = new FileTarget
                {
                    Name = "dbfile",
                    FileName = Path.Combine(logDirectory, "db-${shortdate}.log"),
                    Layout = "${longdate} | ${level:uppercase=true} | ${message} ${exception:format=ToString}"
                };

                // Reglas para enrutamiento de logs

                // Logs de base de datos van a su archivo específico
                config.AddRule(LogLevel.Trace, LogLevel.Fatal, dbFileTarget, "ControlEscolar.Data*");

                // Todos los demás logs van al archivo general
                config.AddRule(LogLevel.Trace, LogLevel.Fatal, logFileTarget);


                //Jerarquía de niveles de log en NLog
                //En NLog, los niveles de log de menor a mayor severidad son:

                //Trace(el más detallado)
                //Debug
                //Info
                //Warn
                //Error
                //Fatal(el más severo)


                // Aplicar la configuración
                LogManager.Configuration = config;

                _isConfigured = true;

                // Registrar que se ha configurado correctamente
                Logger logger = LogManager.GetLogger("LoggingManager");
                logger.Info("Sistema de logging configurado correctamente");
            }
            catch (Exception ex)
            {
                // Si falla la configuración, escribir a un archivo simple
                try
                {
                    string errorMsg = $"Error al configurar el sistema de logging: {ex.Message}";
                    string emergencyLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log_error.txt");
                    File.AppendAllText(emergencyLog, $"{DateTime.Now}: {errorMsg}\n{ex}\n\n");
                }
                catch
                {
                    // No podemos hacer mucho más si esto falla
                }
            }
        }

        /// <summary>
        /// Obtiene un logger con el nombre especificado
        /// </summary>
        /// <param name="loggerName">Nombre del logger</param>
        /// <returns>Una instancia de Logger</returns>
        public static Logger GetLogger(string loggerName)
        {
            if (!_isConfigured)
                ConfigureLogging();

            return LogManager.GetLogger(loggerName);
        }

        /// <summary>
        /// Obtiene un logger para la clase llamadora
        /// </summary>
        /// <returns>Una instancia de Logger</returns>
        public static Logger GetCurrentClassLogger()
        {
            if (!_isConfigured)
                ConfigureLogging();

            return LogManager.GetCurrentClassLogger();
        }
    }
}
