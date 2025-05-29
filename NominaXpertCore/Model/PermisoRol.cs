using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class PermisoRol
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public int IdPermiso { get; set; }

        // Constructor predeterminado
        public PermisoRol()
        {
            IdRol = 0;
            IdPermiso = 0;
        }

        // Constructor con los campos necesarios
        public PermisoRol(int idRol, int idPermiso)
        {
            IdRol = idRol;
            IdPermiso = idPermiso;
        }

        // Constructor completo
        public PermisoRol(int id, int idRol, int idPermiso)
        {
            Id = id;
            IdRol = idRol;
            IdPermiso = idPermiso;
        }
    }


}
