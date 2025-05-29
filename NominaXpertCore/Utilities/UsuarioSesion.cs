using NominaXpertCore.Model;

namespace NominaXpertCore.Utilities
{
    public static class UsuarioSesion
    {
        public static int UsuarioId { get; private set; }
        public static string Correo { get; private set; }
        public static string NombreUsuario { get; private set; }
        public static string Contrasena { get; private set; }
        public static string RolNombre { get; private set; }
        public static List<Permiso> Permisos { get; private set; }

        public static void ActualizarSesion(Usuario usuario)
        {
            UsuarioId = usuario.Id;
            Correo = usuario.Nombre_Usuario;
            NombreUsuario = usuario.Nombre_Usuario;
            Contrasena = usuario.Contrasena;
            RolNombre = usuario.Rol?.Nombre;
            Permisos = usuario.Rol?.Permisos ?? new List<Permiso>();
        }

        public static void CerrarSesion()
        {
            UsuarioId = 0;
            Correo = null;
            NombreUsuario = null;
            Contrasena = null;
            RolNombre = null;
            Permisos = null;
        }

        // Método estático para obtener el idUsuario del usuario autenticado
        public static int ObtenerIdUsuarioActual()
        {
            // Si el id del usuario no está establecido, significa que no hay usuario autenticado
            if (UsuarioSesion.UsuarioId == 0)
            {
                return -1; // Retorna -1 si no hay un usuario autenticado
            }

            // Si el usuario está autenticado, retorna su id
            return UsuarioSesion.UsuarioId;
        }
    }
}
