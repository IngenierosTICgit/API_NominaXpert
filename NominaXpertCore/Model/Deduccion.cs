using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Deduccion
    {
        public int Id { get; set; }
        public int IdNomina { get; set; }
        public int IdTipo { get; set; }
        public decimal Monto { get; set; }

        // Constructor predeterminado
        public Deduccion()
        {
            IdNomina = 0;
            IdTipo = 0; 
            Monto = 0.00m;
        }

        // Constructor con parámetros
        public Deduccion(int idNomina, int idTipo, decimal monto)
        {
            IdNomina = idNomina;
            IdTipo = idTipo;
            Monto = monto;
        }

        // Constructor con todos los campos 
        public Deduccion(int id, int idNomina, int idTipo, decimal monto)
        {
            Id = id;
            IdNomina = idNomina;
            IdTipo = idTipo;
            Monto = monto;
        }
    }

}
