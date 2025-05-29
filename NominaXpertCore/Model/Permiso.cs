using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Permiso
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estatus { get; set; }

        // Constructor predeterminado
        public Permiso()
        {
            Codigo = string.Empty;
            Descripcion = string.Empty;
            Estatus = true; // Por defecto, los permisos están activos
        }

        // Constructor con los campos necesarios
        public Permiso(string codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Estatus = true; // Por defecto, el permiso está activo
        }

        // Constructor completo
        public Permiso(int id, string codigo, string descripcion, bool estatus)
        {
            Id = id;
            Codigo = codigo;
            Descripcion = descripcion;
            Estatus = estatus;
        }

        public override string ToString()
        {
            return $"{Codigo} - {Descripcion}";
        }
    }


}
