using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Auditoria
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }  // Referencia al usuario que realizó la acción
        public string Accion { get; set; }  // Ejemplo: "Alta", "Modificación", "Baja"
        public string DetalleAccion { get; set; }  // Descripción de la acción
        public DateTime Fecha { get; set; }
        public string IpAcceso { get; set; }
        public string NombreEquipo { get; set; }
        public TimeSpan Hora { get; set; }


        // Relación con Usuario (quien realizó la acción)
        public Usuario DatosUsuario { get; set; }

        public Auditoria() //Contructor por defecto
        {
            IdUsuario = 0;
            Accion = string.Empty;
            DetalleAccion = string.Empty;
            Fecha = DateTime.Now;
            IpAcceso = string.Empty;
            NombreEquipo = string.Empty;
        }

        // Constructor con campos obligatorios
        public Auditoria(int idUsuario, string accion, string detalleAccion)
        {
            IdUsuario = idUsuario;
            Accion = accion;
            DetalleAccion = detalleAccion;
            Fecha = DateTime.Now;
            IpAcceso = string.Empty; // Esto se puede completar dinámicamente más tarde
            NombreEquipo = string.Empty; // Lo mismo para el nombre del equipo
        }


        // Constructor completo
        public Auditoria(int id, int idUsuario, string accion, string detalleAccion, DateTime fecha, string ipAcceso, string nombreEquipo)
        {
            Id = id;
            IdUsuario = idUsuario;
            Accion = accion;
            DetalleAccion = detalleAccion;
            Fecha = fecha;
            IpAcceso = ipAcceso;
            NombreEquipo = nombreEquipo;
        }
    }

}
