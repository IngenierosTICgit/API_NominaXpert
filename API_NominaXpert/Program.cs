using ControlEscolar.Data;
using NominaXpertCore.Controller;

var builder = WebApplication.CreateBuilder(args);

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