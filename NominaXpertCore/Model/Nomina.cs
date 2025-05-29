using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Nomina
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        public int IdAuditoria { get; set; } // Relación con la auditoría
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string EstadoPago { get; set; }
        public DateTime CreadoAt { get; set; }


        // Relación con el Empleado
        public Empleado DatosEmpleado { get; set; }

        // Relación con Auditoría
        public Auditoria DatosAuditoria { get; set; }

        // Constructor predeterminado
        public Nomina()
        {
            IdEmpleado = 0; // Valor predeterminado para ID de empleado
            IdAuditoria = 0; // Valor predeterminado para ID de auditoría (se asignará después)
        
            FechaInicio = DateTime.Now.Date; // Inicializa la fecha de inicio con la fecha actual (sin hora)
            FechaFin = DateTime.Now.Date;    // Inicializa la fecha de fin con la fecha actual (sin hora)
        
            EstadoPago = "Pendiente"; // Estado inicial de la nómina
            CreadoAt = DateTime.Now;  // Fecha de creación con hora actual

            // Las relaciones (Empleado y Auditoría) se inicializan a null ya que son objetos complejos
            DatosEmpleado = null;  
            DatosAuditoria = null; 

        }

        // Constructor con parámetros
        public Nomina(int idEmpleado, DateTime fechaInicio, DateTime fechaFin)
        {
            IdEmpleado = idEmpleado;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoPago = "Pendiente"; // Inicialmente la nómina está pendiente
            CreadoAt = DateTime.Now;
        }

        // Constructor completo
        public Nomina(int id, int idEmpleado, int idAuditoria, DateTime fechaInicio, DateTime fechaFin, string estadoPago, DateTime creadoAt)
        {
            Id = id;
            IdEmpleado = idEmpleado;
            IdAuditoria = idAuditoria;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoPago = estadoPago;
            CreadoAt = creadoAt;
        }
    }


}
