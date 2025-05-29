using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class DetalleNomina
    {
        public int Id { get; set; }
        public int IdNomina { get; set; }
        public string Descripcion { get; set; }
        private string _tipo = "Ingreso";
        public string Tipo
        {
            get => string.IsNullOrWhiteSpace(_tipo) ? "Ingreso" : _tipo;
            set => _tipo = string.IsNullOrWhiteSpace(value) ? "Ingreso" : value;
        }
        public decimal Monto { get; set; }


        // Constructor predeterminado
        public DetalleNomina()
        {
            IdNomina = 0;
            Descripcion = string.Empty;
            Tipo = "Ingreso"; // Dejarlo vacío o usar un valor por defecto que puede ser asignado dinámicamente
            Monto = 0.00m;
        }

        // Constructor con parámetros
        public DetalleNomina(int idNomina, string descripcion, string tipo, decimal monto)
        {
            IdNomina = idNomina;
            Descripcion = descripcion;
            Tipo = tipo;
            Monto = monto;
        }

        // Constructor con todos los campos
        public DetalleNomina(int id, int idNomina, string descripcion, string tipo, decimal monto)
        {
            Id = id;
            IdNomina = idNomina;
            Descripcion = descripcion;
            Tipo = tipo;
            Monto = monto;
        }

    }


}
