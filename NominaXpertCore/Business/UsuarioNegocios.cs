using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaXpertCore.Utilities;

namespace NominaXpertCore.Business
{
    public class UsuarioNegocios
    {
        public static string Rol { get; set; }

        public static bool EsCorreoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo); //Llama a utilities
        }
        public static string ObtenerRol(string usuario, string contraseña)
        {
            // Lógica para autenticar al usuario y obtener su rol
            // Ejemplo:
            if (usuario == "admin@gmail.com" && contraseña == "admin123")
                return "Administrador";
            else if (usuario == "rh@gmail.com" && contraseña == "rh123")
                return "Rh";
            else if (usuario == "au@gmail.com" && contraseña == "au123")
                return "Auditor";
            else
                return null; // Si las credenciales son incorrectas
        }
    }
}
