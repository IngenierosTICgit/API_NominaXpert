using ControlEscolar.Data;
using NominaXpertCore.Controller;
using ControlEscolar.Utilities; // Para LoggingManager

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
// === INICIALIZAR LOGGING ANTES QUE NADA ===
try
{
    // Configurar NLog para el entorno de producción
    var config = new NLog.Config.LoggingConfiguration();

    var consoleTarget = new NLog.Targets.ConsoleTarget("console")
    {
        Layout = "${longdate} ${level:uppercase=true} ${logger} ${message} ${exception:format=tostring}"
    };

    config.AddTarget(consoleTarget);
    config.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, consoleTarget);
    NLog.LogManager.Configuration = config;
=======
// DEBUG: Verificar la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine($"=== CONNECTION STRING DEBUG ===");
Console.WriteLine($"Connection String obtenida: {(string.IsNullOrEmpty(connectionString) ? "NULL/VACIA" : "ENCONTRADA")}");
Console.WriteLine($"Longitud: {connectionString?.Length ?? 0}");

if (string.IsNullOrEmpty(connectionString))
{
    Console.WriteLine("ERROR CRÍTICO: No se encontró cadena de conexión");
    throw new InvalidOperationException("No se encontró cadena de conexión");
}

// Establecer la cadena de conexión ANTES de registrar servicios
PostgresSQLDataAccess.ConnectionString = connectionString;
Console.WriteLine("Cadena de conexión establecida en PostgresSQLDataAccess");
>>>>>>> 7cb25e574f2b08088b8bbf0a72b6e898de023394

    Console.WriteLine("=== NLOG CONFIGURADO CORRECTAMENTE ===");
}
catch (Exception ex)
{
    Console.WriteLine($"Error configurando NLog: {ex.Message}");
    throw; // Si no podemos configurar el logging, mejor fallar rápido
}

// === CONFIGURAR CONNECTION STRING ===
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine($"Connection String: {(string.IsNullOrEmpty(connectionString) ? "NULL" : "ENCONTRADA")}");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("No se encontró cadena de conexión");
}

PostgresSQLDataAccess.ConnectionString = connectionString;

// === SERVICIOS ===
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<NominasController>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

Console.WriteLine("=== APLICACIÓN INICIADA ===");
app.Run();