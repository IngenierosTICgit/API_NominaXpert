using Microsoft.AspNetCore.Mvc;

namespace API_NominaXpert
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimpleTestController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok(new
            {
                message = "API funcionando correctamente",
                timestamp = DateTime.Now,
                status = "success"
            });
        }
    }
}