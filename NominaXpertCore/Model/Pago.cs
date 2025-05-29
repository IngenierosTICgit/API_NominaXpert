using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Pago
    {
        public int Id { get; set; }
        public int IdNomina { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoTotal { get; set; }
        public string MontoLetras { get; set; }
        public string MetodoPago { get; set; }
        public string Referencia { get; set; }

        // Constructor predeterminado
        public Pago()
        {
            // Se inicializan con valores predeterminados
            FechaPago = DateTime.Now;  // Se asigna la fecha actual por defecto
            MontoTotal = 0.00m;        // Por defecto, no hay monto
            MontoLetras = string.Empty; // Vacío, ya que será calculado
            MetodoPago = "Efectivo";    // Método de pago por defecto (podría ser "Transferencia", etc.)
            Referencia = string.Empty; // Vacío por defecto
        }

        // Constructor con parámetros
        public Pago(int idNomina, decimal montoTotal, string montoLetras, string metodoPago, string referencia)
        {
            IdNomina = idNomina;
            FechaPago = DateTime.Now;  // Se asigna la fecha actual por defecto
            MontoTotal = montoTotal;
            MontoLetras = montoLetras;
            MetodoPago = metodoPago;
            Referencia = referencia;
        }

        // Constructor con todos los campos
        public Pago(int id, int idNomina, DateTime fechaPago, decimal montoTotal, string montoLetras, string metodoPago, string referencia)
        {
            Id = id;
            IdNomina = idNomina;
            FechaPago = fechaPago;
            MontoTotal = montoTotal;
            MontoLetras = montoLetras;
            MetodoPago = metodoPago;
            Referencia = referencia;
        }

        // Método opcional para convertir monto a letras
        public static string ConvertirMontoALetras(decimal monto)
        {
            // Aquí podrías usar una librería o crear tu propia lógica para convertir el monto a letras
            return monto.ToString("C"); // Convierte el monto a formato de moneda, "$1,234.56"
        }
    }

}
