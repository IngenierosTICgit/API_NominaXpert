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

        /// <summary>
        /// Constructor del controlador API para nóminas
        /// </summary>
        /// <param name="nominasController">Instancia del controlador de nóminas</param>
        /// <param name="logger">Logger para el controlador API</param>
        public NominaXpertControllerAPI_test(NominasController nominasController, ILogger<NominaXpertControllerAPI_test> logger)
        {
            _nominasController = nominasController;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene el historial completo de nóminas con filtros opcionales por fechas y estado de pago
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del periodo a buscar (opcional)</param>
        /// <param name="fechaFin">Fecha de fin del periodo a buscar (opcional)</param>
        /// <param name="estadoPago">Estado de pago a filtrar: Pagado, Pendiente, Rechazado (opcional)</param>
        /// <returns>Lista de nóminas que cumplen con los criterios especificados</returns>
        [HttpGet("historial")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NominaConsulta>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetHistorialNominas(
            [FromQuery] DateTime? fechaInicio = null,
            [FromQuery] DateTime? fechaFin = null,
            [FromQuery] string? estadoPago = null)
        {
            try
            {
                _logger.LogInformation("Iniciando consulta de historial de nóminas con filtros: " +
                    $"FechaInicio={fechaInicio?.ToString("dd/MM/yyyy") ?? "N/A"}, " +
                    $"FechaFin={fechaFin?.ToString("dd/MM/yyyy") ?? "N/A"}, " +
                    $"EstadoPago={estadoPago ?? "N/A"}");

                // Validar que si se proporcionan ambas fechas, la fecha fin no sea anterior a la inicio
                if (fechaInicio.HasValue && fechaFin.HasValue && fechaFin < fechaInicio)
                {
                    _logger.LogWarning("Fechas inválidas: fecha fin anterior a fecha inicio");
                    return BadRequest("La fecha de fin no puede ser anterior a la fecha de inicio.");
                }

                // Validar estado de pago si se proporciona
                if (!string.IsNullOrEmpty(estadoPago))
                {
                    var estadosValidos = new[] { "Pagado", "Pendiente", "Rechazado" };
                    if (!estadosValidos.Contains(estadoPago, StringComparer.OrdinalIgnoreCase))
                    {
                        _logger.LogWarning($"Estado de pago inválido: {estadoPago}");
                        return BadRequest("El estado de pago debe ser: Pagado, Pendiente o Rechazado.");
                    }
                }

                List<NominaConsulta> nominas;

                // Determinar qué método usar según los filtros proporcionados
                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    // Si se proporcionan ambas fechas, usar el filtro por fechas
                    nominas = _nominasController.BuscarNominasPorFechas(fechaInicio.Value, fechaFin.Value);
                    _logger.LogInformation($"Nóminas obtenidas por rango de fechas: {nominas.Count}");
                }
                else
                {
                    // Si no se proporcionan fechas, obtener todas las nóminas
                    nominas = _nominasController.DesplegarNominas();
                    _logger.LogInformation($"Todas las nóminas obtenidas: {nominas.Count}");
                }

                // Aplicar filtro por estado de pago si se proporciona
                if (!string.IsNullOrEmpty(estadoPago))
                {
                    var nominasOriginales = nominas.Count;
                    nominas = nominas.Where(n =>
                        string.Equals(n.EstadoPago, estadoPago, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    _logger.LogInformation($"Nóminas filtradas por estado '{estadoPago}': {nominas.Count} de {nominasOriginales}");
                }

                // Preparar respuesta con información adicional
                var response = new
                {
                    TotalNominas = nominas.Count,
                    FiltrosAplicados = new
                    {
                        FechaInicio = fechaInicio?.ToString("dd/MM/yyyy"),
                        FechaFin = fechaFin?.ToString("dd/MM/yyyy"),
                        EstadoPago = estadoPago
                    },
                    Nominas = nominas.OrderByDescending(n => n.FechaInicio) // Ordenar por fecha más reciente
                };

                _logger.LogInformation($"Consulta exitosa: {nominas.Count} nóminas devueltas");
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el historial de nóminas");
                return StatusCode(500, "Error interno del servidor al procesar la solicitud");
            }
        }

        /// <summary>
        /// Obtiene nóminas específicamente con estado "Pagado" dentro de un rango de fechas
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del periodo a buscar</param>
        /// <param name="fechaFin">Fecha de fin del periodo a buscar</param>
        /// <returns>Lista de nóminas pagadas en el rango de fechas especificado</returns>
        [HttpGet("pagadas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NominaConsulta>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetNominasPagadas([FromQuery] DateTime fechaInicio, [FromQuery] DateTime fechaFin)
        {
            try
            {
                _logger.LogInformation($"Consultando nóminas pagadas entre {fechaInicio:dd/MM/yyyy} y {fechaFin:dd/MM/yyyy}");

                // Validar que la fecha de fin no sea anterior a la fecha de inicio
                if (fechaFin < fechaInicio)
                {
                    _logger.LogWarning("Fechas inválidas para consulta de nóminas pagadas");
                    return BadRequest("La fecha de fin no puede ser anterior a la fecha de inicio.");
                }

                // Obtener las nóminas filtradas por fechas
                var nominas = _nominasController.BuscarNominasPorFechas(fechaInicio, fechaFin);

                // Filtrar solo las nóminas con estado "Pagado"
                var nominasPagadas = nominas.Where(n =>
                    string.Equals(n.EstadoPago, "Pagado", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(n => n.FechaInicio)
                    .ToList();

                _logger.LogInformation($"Se encontraron {nominasPagadas.Count} nóminas pagadas entre {fechaInicio:dd/MM/yyyy} y {fechaFin:dd/MM/yyyy}");

                return Ok(nominasPagadas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener las nóminas pagadas");
                return StatusCode(500, "Error interno del servidor al procesar la solicitud");
            }
        }

        /// <summary>
        /// Obtiene nóminas con estado "Pendiente"
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del periodo a buscar (opcional)</param>
        /// <param name="fechaFin">Fecha de fin del periodo a buscar (opcional)</param>
        /// <returns>Lista de nóminas pendientes</returns>
        [HttpGet("pendientes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NominaConsulta>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetNominasPendientes([FromQuery] DateTime? fechaInicio = null, [FromQuery] DateTime? fechaFin = null)
        {
            try
            {
                _logger.LogInformation("Consultando nóminas pendientes");

                List<NominaConsulta> nominas;

                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    // Validar fechas
                    if (fechaFin < fechaInicio)
                    {
                        return BadRequest("La fecha de fin no puede ser anterior a la fecha de inicio.");
                    }
                    nominas = _nominasController.BuscarNominasPorFechas(fechaInicio.Value, fechaFin.Value);
                }
                else
                {
                    nominas = _nominasController.DesplegarNominas();
                }

                var nominasPendientes = nominas.Where(n =>
                    string.Equals(n.EstadoPago, "Pendiente", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(n => n.FechaInicio)
                    .ToList();

                _logger.LogInformation($"Se encontraron {nominasPendientes.Count} nóminas pendientes");

                return Ok(nominasPendientes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener las nóminas pendientes");
                return StatusCode(500, "Error interno del servidor al procesar la solicitud");
            }
        }

        /// <summary>
        /// Obtiene nóminas con estado "Rechazado"
        /// </summary>
        /// <param name="fechaInicio">Fecha de inicio del periodo a buscar (opcional)</param>
        /// <param name="fechaFin">Fecha de fin del periodo a buscar (opcional)</param>
        /// <returns>Lista de nóminas rechazadas</returns>
        [HttpGet("rechazadas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NominaConsulta>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetNominasRechazadas([FromQuery] DateTime? fechaInicio = null, [FromQuery] DateTime? fechaFin = null)
        {
            try
            {
                _logger.LogInformation("Consultando nóminas rechazadas");

                List<NominaConsulta> nominas;

                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    // Validar fechas
                    if (fechaFin < fechaInicio)
                    {
                        return BadRequest("La fecha de fin no puede ser anterior a la fecha de inicio.");
                    }
                    nominas = _nominasController.BuscarNominasPorFechas(fechaInicio.Value, fechaFin.Value);
                }
                else
                {
                    nominas = _nominasController.DesplegarNominas();
                }

                var nominasRechazadas = nominas.Where(n =>
                    string.Equals(n.EstadoPago, "Rechazado", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(n => n.FechaInicio)
                    .ToList();

                _logger.LogInformation($"Se encontraron {nominasRechazadas.Count} nóminas rechazadas");

                return Ok(nominasRechazadas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener las nóminas rechazadas");
                return StatusCode(500, "Error interno del servidor al procesar la solicitud");
            }
        }

        /// <summary>
        /// Obtiene una nómina específica por su ID
        /// </summary>
        /// <param name="id">ID de la nómina a buscar</param>
        /// <returns>Datos de la nómina encontrada</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NominaConsulta))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetNominaPorId(int id)
        {
            try
            {
                if (id <= 0)
                {
                    _logger.LogWarning($"ID de nómina inválido: {id}");
                    return BadRequest("El ID de la nómina debe ser mayor a 0.");
                }

                _logger.LogInformation($"Buscando nómina con ID: {id}");

                var nomina = _nominasController.BuscarNominaPorId(id);

                if (nomina == null)
                {
                    _logger.LogWarning($"No se encontró la nómina con ID: {id}");
                    return NotFound($"No se encontró la nómina con ID {id}.");
                }

                _logger.LogInformation($"Nómina encontrada con ID: {id}");
                return Ok(nomina);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error al buscar la nómina con ID: {id}");
                return StatusCode(500, "Error interno del servidor al procesar la solicitud");
            }
        }

        [HttpGet("health")]
        public IActionResult HealthCheck()
        {
            return Ok(new
            {
                status = "API funcionando",
                timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                message = "Conexión exitosa"
            });
        }

    }
}