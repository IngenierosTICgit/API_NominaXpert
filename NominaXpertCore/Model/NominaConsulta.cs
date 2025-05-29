using System;

namespace NominaXpertCore.Model
{
    public class NominaConsulta
    {
        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string EstadoPago { get; set; }
        public Empleado DatosEmpleado { get; set; }

        // Nuevas propiedades agregadas para el pago
        public decimal MontoTotal { get; set; }
        public string MontoLetras { get; set; }
      

        // Constructor predeterminado
        public NominaConsulta()
        {
            IdNomina = 0; // ID por defecto
            IdEmpleado = 0; // ID empleado por defecto
            FechaInicio = DateTime.Now.Date; // Fecha actual sin hora
            FechaFin = DateTime.Now.Date; // Fecha actual sin hora
            EstadoPago = "Pendiente"; // Estado inicial por defecto
            DatosEmpleado = null; // Relación no cargada inicialmente
            MontoTotal = 0; // Monto inicial
            MontoLetras = string.Empty; // Monto en letras vacío
        }

        // Constructor parcial (con datos clave sin relaciones)
        public NominaConsulta(int idNomina, int idEmpleado, DateTime fechaInicio, DateTime fechaFin, string estadoPago)
        {
            IdNomina = idNomina;
            IdEmpleado = idEmpleado;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoPago = estadoPago;
            DatosEmpleado = null; // Se puede asignar después
            MontoTotal = 0; // Monto inicial
            MontoLetras = string.Empty; // Monto en letras vacío
        }

        // Constructor completo (incluyendo el objeto Empleado relacionado)
        public NominaConsulta(int idNomina, int idEmpleado, DateTime fechaInicio, DateTime fechaFin, string estadoPago, Empleado datosEmpleado, decimal montoTotal, string montoLetras)
        {
            IdNomina = idNomina;
            IdEmpleado = idEmpleado;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoPago = estadoPago;
            DatosEmpleado = datosEmpleado; // Se pasa el empleado relacionado
            MontoTotal = montoTotal; // Se pasa el monto total
            MontoLetras = montoLetras; // Se pasa el monto en letras
        }

        public string NombreEmpleado => DatosEmpleado?.DatosPersonales?.NombreCompleto ?? "Sin Nombre";
        public string DepartamentoEmpleado => DatosEmpleado?.Departamento ?? "Sin Departamento";
        public string RfcEmpleado => DatosEmpleado?.DatosPersonales?.Rfc ?? "Sin RFC";
        public decimal SueldoBase => DatosEmpleado?.Sueldo ?? 0;
    }
}
