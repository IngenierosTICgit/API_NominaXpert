using System;
using System.Configuration;
using NLog;

namespace NominaXpertCore.Utilities
{
    public static class ConfigHelp
    {
        private static readonly Logger _logger = ControlEscolar.Utilities.LoggingManager.GetLogger("NominaXpert.Utilities.ConfigHelp");

        /// <summary>
        /// Obtiene el valor del sueldo mínimo desde App.config
        /// </summary>
        /// <returns>Sueldo mínimo configurado o valor por defecto</returns>
        public static decimal ObtenerSueldoMinimo()
        {
            try
            {
                string sueldoMinimoStr = ConfigurationManager.AppSettings["SueldoMinimo"];

                if (string.IsNullOrEmpty(sueldoMinimoStr))
                {
                    string mensaje = "El valor mínimo no ha sido asignado. Favor de comunicar al administrador.";
                    _logger.Error(mensaje);
                    throw new ConfigurationErrorsException(mensaje);
                }

                if (decimal.TryParse(sueldoMinimoStr, out decimal sueldoMinimo))
                {
                    return sueldoMinimo;
                }
                else
                {
                    string mensaje = $"El valor de sueldo mínimo en App.config no es un número válido: {sueldoMinimoStr}. Favor de comunicar al administrador.";
                    _logger.Error(mensaje);
                    throw new ConfigurationErrorsException(mensaje);
                }
            }
            catch (ConfigurationErrorsException)
            {
                // Re-lanzar las excepciones de configuración
                throw;
            }
            catch (Exception ex)
            {
                string mensaje = "Error al obtener el sueldo mínimo desde App.config. Favor de comunicar al administrador.";
                _logger.Error(ex, mensaje);
                throw new ConfigurationErrorsException(mensaje, ex);
            }
        }
    }
}