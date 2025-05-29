using NominaXpertCore.Controller;
using Microsoft.AspNetCore.Mvc;
using NominaXpertCore.Model;

namespace API_NominaXpert
{
    [ApiController]
    [Route("api/[controller]")]
    public class NominaXpertControllerAPI_test : ControllerBase
    {
        private readonly NominasController _nominasController;
        private readonly ILogger<NominaXpertControllerAPI_test> _logger;
        //Logger para el controlador, este log no se guarda en ningun archivo, se muestra en  consola

        public NominaXpertControllerAPI_test(NominasController nominasController, ILogger<NominaXpertControllerAPI_test> logger)
        {
            _nominasController = nominasController;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene las nóminas con estado "Pagado" dentro de un rango de fechas
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del periodo a buscar</param>
        /// <param name="fechaFin">Fecha de fin del periodo a buscar</param>
        /// <returns>Lista de nóminas pagadas en el rango de fechas especificado</returns>
        [HttpGet("nominas-pagadas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NominaConsulta>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetNominasPagadas([FromQuery] DateTime fechaInicio, [FromQuery] DateTime fechaFin)
        {
            try
            {
                // Validar que la fecha de fin no sea anterior a la fecha de inicio
                if (fechaFin < fechaInicio)
                {
                    return BadRequest("La fecha de fin no puede ser anterior a la fecha de inicio.");
                }

                // Obtener las nóminas filtradas por fechas
                var nominas = _nominasController.BuscarNominasPorFechas(fechaInicio, fechaFin);

                // Filtrar solo las nóminas con estado "Pagado"
                var nominasPagadas = nominas.Where(n => n.EstadoPago == "Pagado").ToList();

                // Log informativo
                _logger.LogInformation($"Se encontraron {nominasPagadas.Count} nóminas pagadas entre {fechaInicio:dd/MM/yyyy} y {fechaFin:dd/MM/yyyy}");

                return Ok(nominasPagadas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener las nóminas pagadas");
                return StatusCode(500, "Error interno del servidor al procesar la solicitud");
            }
        }
    }
}
