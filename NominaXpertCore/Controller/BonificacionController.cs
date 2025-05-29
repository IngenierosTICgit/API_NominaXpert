using ControlEscolar.Utilities;
using NominaXpertCore.Data;
using NominaXpertCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;


namespace NominaXpertCore.Controller
{
    public class BonificacionController
    {
        private readonly BonificacionDataAccess _bonificacionDataAccess;
        private readonly AuditoriaDataAccess _auditoriaDataAccess; // Acceso a la auditoría

        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.PercepcionesController");

        public BonificacionController()
        {
            _bonificacionDataAccess = new BonificacionDataAccess(); // Inicializamos el acceso a datos
            _auditoriaDataAccess = new AuditoriaDataAccess();

        }

        // Método que obtiene las bonificaciones asociadas a una nómina específica
        public List<Bonificacion> ObtenerBonificacionesPorNomina(int idNomina)
        {
            try
            {
                // Llamamos al método de acceso a datos para obtener las bonificaciones
                _logger.Info($"Bonificaciones obtenidas para la nómina ID: {idNomina}.");
                return _bonificacionDataAccess.ObtenerBonificacionesPorNomina(idNomina);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                _logger.Error(ex, $"Error al obtener las bonificaciones para la nómina ID: {idNomina}.");
                throw new ApplicationException("Error al obtener las bonificaciones", ex);
            }
        }

        // Método para registrar una nueva bonificación
        public void RegistrarBonificacion(Bonificacion bonificacion, int idUsuario)
        {
            try
            {
                _bonificacionDataAccess.RegistrarBonificacion(bonificacion);

                // Registrar la auditoría de la acción de alta de bonificación
                string detalleAccion = $"Se registró una bonificación para la nómina ID {bonificacion.IdNomina}, tipo ID {bonificacion.IdTipo}, monto {bonificacion.Monto}.";
                _auditoriaDataAccess.RegistrarAuditoria(idUsuario, "alta bonificación", detalleAccion);

                _logger.Info($"Bonificación registrada correctamente: {bonificacion.IdNomina}, {bonificacion.IdTipo}, {bonificacion.Monto}.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al registrar la bonificación: {bonificacion.IdNomina}, {bonificacion.IdTipo}, {bonificacion.Monto}.");
                throw new ApplicationException("Error al registrar la bonificación", ex);

            }
        }

        // Método para actualizar una bonificación
        public int ActualizarBonificacion(Bonificacion bonificacion, int idUsuario)
        {
            try
            {
                _logger.Info($"Actualizando la bonificación ID: {bonificacion.Id}.");

                // Registrar la auditoría de la acción de actualización de bonificación
                string detalleAccion = $"Se actualizó la bonificación ID {bonificacion.Id} para la nómina ID {bonificacion.IdNomina}, tipo ID {bonificacion.IdTipo}, monto {bonificacion.Monto}.";
                _auditoriaDataAccess.RegistrarAuditoria(idUsuario, "edición bonificación", detalleAccion);

                return _bonificacionDataAccess.ActualizarBonificacion(bonificacion);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar la bonificación ID: {bonificacion.Id}.");
                throw new ApplicationException("Error al actualizar la bonificación", ex);
            }
        }

        // Método para eliminar una bonificación
        public int EliminarBonificacion(int idBonificacion, int idNomina, int idUsuario)
        {
            _logger.Info($"Iniciando la eliminación de la bonificación ID: {idBonificacion}");

            try
            {
                _logger.Info($"Eliminando la bonificación ID: {idBonificacion}");

                // Registrar la auditoría de la acción de eliminación de bonificación
                string detalleAccion = $"Se eliminó la bonificación ID {idBonificacion} de la nómina ID {idNomina}.";
                _auditoriaDataAccess.RegistrarAuditoria(idUsuario, "baja bonificación", detalleAccion);


                return _bonificacionDataAccess.EliminarBonificacion(idBonificacion,idNomina);
                
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al eliminar la bonificación ID: {idBonificacion}");
                throw new ApplicationException("Error al eliminar la bonificación", ex);
               
            }
        }
    }
}
