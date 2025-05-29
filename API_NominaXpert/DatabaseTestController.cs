using Microsoft.AspNetCore.Mvc;
using ControlEscolar.Data;

namespace API_NominaXpert
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabaseTestController : ControllerBase
    {
        [HttpGet("connection")]
        public IActionResult TestConnection()
        {
            try
            {
                var dbAccess = PostgresSQLDataAccess.GetInstance();
                var connected = dbAccess.Connect();

                if (connected)
                {
                    dbAccess.Disconnect();
                    return Ok(new
                    {
                        status = "success",
                        message = "Conexión a base de datos exitosa",
                        timestamp = DateTime.Now
                    });
                }
                else
                {
                    return StatusCode(500, new
                    {
                        status = "error",
                        message = "No se pudo conectar a la base de datos"
                    });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    status = "error",
                    message = ex.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }

        [HttpGet("simple-query")]
        public IActionResult TestSimpleQuery()
        {
            try
            {
                var dbAccess = PostgresSQLDataAccess.GetInstance();
                dbAccess.Connect();

                // Query súper simple para probar
                var result = dbAccess.ExecuteScalar("SELECT 1");

                dbAccess.Disconnect();

                return Ok(new
                {
                    status = "success",
                    message = "Query ejecutada correctamente",
                    result = result,
                    timestamp = DateTime.Now
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    status = "error",
                    message = ex.Message,
                    stackTrace = ex.StackTrace
                });
            }
        }
    }
}