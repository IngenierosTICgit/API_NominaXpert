using ControlEscolar.Utilities;
using NLog;
using NominaXpertCore.Data;
using NominaXpertCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Controller
{
    public class DetalleNominaController
    {
        private readonly DetalleNominaDataAccess _detalleNominaDataAccess;
        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.DetalleNominaControler");



        public DetalleNominaController()
        {
            _detalleNominaDataAccess = new DetalleNominaDataAccess(); // Inicializamos el acceso a datos
        }

        // Método para registrar un detalle de nómina
        public void RegistrarDetalleNomina(DetalleNomina detalleNomina)
        {
            try
            {
                // Llamamos al acceso a datos para registrar el detalle
                _detalleNominaDataAccess.RegistrarDetalleNomina(detalleNomina);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, lanzamos una excepción personalizada
                throw new ApplicationException("Error al registrar el detalle de la nómina.", ex);
            }
        
        }

        // Método para obtener los detalles de una nómina específica por su ID
        public List<DetalleNomina> ObtenerDetallesPorNomina(int idNomina)
        {
            try
            {
                // Llamamos al acceso a datos para obtener los detalles de la nómina
                _logger.Info($"DetallesNomina obtenidas para la nómina ID: {idNomina}.");
                return _detalleNominaDataAccess.ObtenerDetallesPorNomina(idNomina);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, lanzamos una excepción personalizada
                _logger.Error(ex, $"Error al obtener los DetallesNominaController para la nómina ID: {idNomina}.");
                throw new ApplicationException("Error al obtener los detalles de la nómina.", ex);
            }
        }
    }
}
