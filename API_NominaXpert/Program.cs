using ControlEscolar.Data;
using NominaXpertCore.Controller;

var builder = WebApplication.CreateBuilder(args);

// DEBUG: Verificar la cadena de conexi�n
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine($"=== CONNECTION STRING DEBUG ===");
Console.WriteLine($"Connection String obtenida: {(string.IsNullOrEmpty(connectionString) ? "NULL/VACIA" : "ENCONTRADA")}");
Console.WriteLine($"Longitud: {connectionString?.Length ?? 0}");

if (string.IsNullOrEmpty(connectionString))
{
    Console.WriteLine("ERROR CR�TICO: No se encontr� cadena de conexi�n");
    throw new InvalidOperationException("No se encontr� cadena de conexi�n");
}

// Establecer la cadena de conexi�n ANTES de registrar servicios
PostgresSQLDataAccess.ConnectionString = connectionString;
Console.WriteLine("Cadena de conexi�n establecida en PostgresSQLDataAccess");

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

Console.WriteLine("=== APLICACI�N INICIADA ===");
app.Run();