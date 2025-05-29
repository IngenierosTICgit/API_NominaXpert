using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Rol
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estatus { get; set; }
        public List<Permiso> Permisos { get; set; } = new List<Permiso>();

        

        // Constructor con los campos necesarios
        public Rol()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }

        public Rol(int id, string codigo, string nombre, string descripcion, bool estatus, List<Permiso> permisos)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Estatus = estatus;
            Permisos = permisos;
        }
        
    }

}
