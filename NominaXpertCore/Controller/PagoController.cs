using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaXpertCore.Data;
using NominaXpertCore.Model;
using NLog;
using ControlEscolar.Utilities;

namespace NominaXpertCore.Controller
{
    public class PagoController
    {
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.PagoController");

        // Instancia de acceso a datos
        private readonly PagoDataAccess _pagoDataAccess;

        /// <summary>
        /// Constructor del PagoController
        /// </summary>
        public PagoController()
        {
            _pagoDataAccess = new PagoDataAccess();
        }

        /// <summary>
        /// Registra un pago en la base de datos.
        /// </summary>
        /// <param name="pago">Objeto Pago que contiene toda la información</param>
        /// <returns>True si se registró correctamente, False si ocurrió un error</returns>
        public bool RegistrarPago(Pago pago)
        {
            try
            {
                int filasAfectadas = _pagoDataAccess.RegistrarPago(pago);

                if (filasAfectadas > 0)
                {
                    _logger.Info($"Pago registrado exitosamente para la nómina ID {pago.IdNomina}.");
                    return true;
                }
                else
                {
                    _logger.Warn($"No se pudo registrar el pago para la nómina ID {pago.IdNomina}.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al registrar el pago para la nómina ID {pago.IdNomina}.");
                return false;
            }
        }

        
        public bool ExistePago(int idNomina)
        {
            try
            {

                bool existe = _pagoDataAccess.ExistePagoParaNomina(idNomina);

                if (existe)
                {
                    _logger.Info($"Ya existe un pago registrado para la nómina ID {idNomina}.");
                }
                else
                {
                    _logger.Info($"No existe un pago registrado para la nómina ID {idNomina}.");
                }

                return existe;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar existencia de pago para la nómina ID {idNomina}.");
                return false; // si hay error, regresa false para evitar bloqueos
            }
        }


    }
}
