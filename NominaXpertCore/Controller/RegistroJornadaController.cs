using ControlEscolar.Utilities;
using NominaXpertCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NominaXpertCore.Controller
{
    public class RegistroJornadaController
    {
        private readonly RegistroJornadaDataAccess _registroJornadaDataAccess;
        private readonly UsuariosDataAccess _usuariosDataAccess; // Para verificar permisos
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.RegistroJornadaController");

        public RegistroJornadaController()
        {
            _registroJornadaDataAccess = new RegistroJornadaDataAccess();
            _usuariosDataAccess = new UsuariosDataAccess(); // Para verificar permisos
        }

        /// <summary>
        /// Consulta el total de horas trabajadas para un empleado en un periodo específico.
        /// </summary>
        /// <param name="idEmpleado">ID del empleado</param>
        /// <param name="fechaInicio">Fecha de inicio del periodo</param>
        /// <param name="fechaFin">Fecha de fin del periodo</param>
        /// <param name="idUsuario">ID del usuario que está haciendo la consulta (para validar permisos)</param>
        /// <returns>Total de horas trabajadas</returns>
        public decimal ConsultarTotalHorasTrabajadas(int idEmpleado, DateTime fechaInicio, DateTime fechaFin, int idUsuario)
        {
            try
            {
                // Log de inicio del proceso de consulta
                _logger.Info($"Iniciando consulta de total de horas trabajadas para el empleado ID: {idEmpleado}, periodo: {fechaInicio.ToShortDateString()} - {fechaFin.ToShortDateString()}.");

                // Validar que el usuario tenga permisos para consultar
                bool usuarioAutorizado = _usuariosDataAccess.PermisoUsuarioGenerarNomina(idUsuario);
                if (!usuarioAutorizado)
                {
                    throw new Exception("El usuario no tiene permisos suficientes para realizar la consulta de días trabajados.");
                }

                // Log: Usuario autorizado
                _logger.Info($"Usuario ID: {idUsuario} autorizado para consultar las horas trabajadas.");

                // Consultar las horas trabajadas en el periodo
                decimal totalHoras = _registroJornadaDataAccess.ObtenerTotalHorasTrabajadas(idEmpleado, fechaInicio, fechaFin);

                // Log del resultado
                _logger.Info($"Total de horas trabajadas para el empleado ID: {idEmpleado} en el periodo {fechaInicio.ToShortDateString()} - {fechaFin.ToShortDateString()} es: {totalHoras} horas.");

                return totalHoras;
            }
            catch (Exception ex)
            {
                // Log de error
                _logger.Error(ex, "Error al consultar el total de horas trabajadas.");
                return 0;
            }
        }
    }
}
