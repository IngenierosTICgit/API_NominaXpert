using Microsoft.AspNetCore.Mvc;
using NominaXpertCore.Controller;
using NominaXpertCore.Model;

namespace API_NominaXpert
{
    [ApiController]
    [Route("api/[controller]")]
    public class NominaXpertControllerAPI_test : ControllerBase
    {
        private readonly NominasController _nominasController;
        private readonly ILogger<NominaXpertControllerAPI_test> _logger;

        public NominaXpertControllerAPI_test(NominasController nominasController, ILogger<NominaXpertControllerAPI_test> logger)
        {
            _nominasController = nominasController;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene todas las nóminas con filtros opcionales
        /// </summary>
        /// <param name="estadoPago">Estado de pago: Pagado, Pendiente, Rechazado</param>
        /// <param name="fechaInicio">Fecha de inicio del periodo</param>
        /// <param name="fechaFin">Fecha de fin del periodo</param>
        /// <returns>Lista de nóminas</returns>
        [HttpGet("historial_nominas")]
        public IActionResult GetNominas(
            [FromQuery] string? estadoPago = null,
            [FromQuery] DateTime? fechaInicio = null,
            [FromQuery] DateTime? fechaFin = null)
        {
            try
            {
                // Validar fechas
                if (fechaInicio.HasValue && fechaFin.HasValue && fechaFin < fechaInicio)
                {
                    return BadRequest("La fecha de fin no puede ser anterior a la fecha de inicio.");
                }

                List<NominaConsulta> nominas;

                // Obtener nóminas
                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    nominas = _nominasController.BuscarNominasPorFechas(fechaInicio.Value, fechaFin.Value);
                }
                else
                {
                    nominas = _nominasController.DesplegarNominas();
                }

                // Filtrar por estado
                if (!string.IsNullOrEmpty(estadoPago))
                {
                    var estadosValidos = new[] { "Pagado", "Pendiente", "Rechazado" };
                    if (!estadosValidos.Contains(estadoPago, StringComparer.OrdinalIgnoreCase))
                    {
                        return BadRequest("El estado de pago debe ser: Pagado, Pendiente o Rechazado.");
                    }

                    nominas = nominas.Where(n =>
                        string.Equals(n.EstadoPago, estadoPago, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                return Ok(nominas.OrderByDescending(n => n.FechaInicio));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener las nóminas");
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}