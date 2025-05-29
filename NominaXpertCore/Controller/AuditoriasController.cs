using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaXpertCore.Model;
using NLog;
using NominaXpertCore.Data;
using ControlEscolar.Utilities;

namespace NominaXpertCore.Controller
{
    public class AuditoriasController
    {
        private readonly AuditoriaDataAccess _auditoriaDataAccess;
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.AuditoriasController");

        public AuditoriasController()
        {
            // Inicialización de las clases de acceso a datos
            _auditoriaDataAccess = new AuditoriaDataAccess();
        }

        /// <summary>
        /// Obtiene todas las auditorías registradas.
        /// </summary>
        /// <returns>Lista de auditorías</returns>
        public List<Auditoria> ObtenerTodasLasAuditorias()
        {
            try
            {
                // Obtener todas las auditorías desde el acceso a datos
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerTodasLasAuditorias();
                _logger.Info($"Se obtuvieron {auditorias.Count} auditorías.");
                return auditorias;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener todas las auditorías.");
                throw;
            }
        }

        /// <summary>
        /// Obtiene las auditorías filtradas por idUsuario y acción.
        /// </summary>
        /// <param name="idUsuario">ID del usuario</param>
        /// <param name="accion">Acción realizada</param>
        /// <returns>Lista de auditorías filtradas</returns>
        public List<Auditoria> ObtenerAuditoriasPorFiltro(int idUsuario, string accion)
        {
            try
            {
                // Validar que al menos uno de los parámetros sea válido
                if (idUsuario <= 0 && string.IsNullOrWhiteSpace(accion))
                {
                    throw new ArgumentException("Al menos uno de los criterios de búsqueda (idUsuario o acción) debe ser válido.");
                }

                // Obtener auditorías filtradas desde el acceso a datos
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerAuditoriasPorFiltro(idUsuario, accion);

                _logger.Info($"Se obtuvieron {auditorias.Count} auditorías filtradas por idUsuario: {idUsuario} y/o acción: {accion}.");
                return auditorias;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las auditorías filtradas.");
                throw;
            }
        }

        public List<Auditoria> ObtenerAuditoriasPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                // Validar que las fechas sean correctas
                if (fechaInicio > fechaFin)
                {
                    throw new ArgumentException("La fecha de inicio no puede ser posterior a la fecha de fin.");
                }

                // Obtener auditorías filtradas por el rango de fechas
                List<Auditoria> auditorias = _auditoriaDataAccess.ObtenerAuditoriasPorFechas(fechaInicio, fechaFin);
                _logger.Info($"Se obtuvieron {auditorias.Count} auditorías entre {fechaInicio.ToShortDateString()} y {fechaFin.ToShortDateString()}.");
                return auditorias;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las auditorías filtradas por fechas.");
                throw;
            }
        }


    }
}
