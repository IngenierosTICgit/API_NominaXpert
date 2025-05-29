using NominaXpertCore.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Business
{
    public class PersonasNegocio
    {

        public static bool EsNombreValido(string nombre)
        {
            return Validaciones.EsNombreValido(nombre);
        }
        public static bool EsApellidoValido(string apellido)
        {
            return Validaciones.EsApellidoValido(apellido);
        }
        public static bool EsCorreoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo);
        }
        public static bool EsDireccionValida(string direccion)
        {
            return Validaciones.EsDireccionValida(direccion);
        }
        public static bool EsCURPValido(string curp)
        {
            return Validaciones.EsCURPValido(curp);
        }
        public static bool EsTelefonoValido(string direccion)
        {
            return Validaciones.EsDireccionValida(direccion);
        }
        public static bool EsRFCValido(string rfc)
        {
            return Validaciones.EsRFCValido(rfc);
        }
    }
}
