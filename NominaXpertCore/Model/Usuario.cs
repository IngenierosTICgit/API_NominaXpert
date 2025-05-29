using System.Data;

namespace NominaXpertCore.Model
{
    public class Usuario
    {
        public Usuario(int idPersona, int id, string nombre_usuario, string contrasena, bool estatus, int idrol)
        {
            Id = id;
            IdPersona = idPersona;
            Nombre_Usuario = nombre_usuario;
            Contrasena = contrasena;
            Estatus = estatus;
            IdRol = idrol;
            Persona = new Persona(); // Inicializar la propiedad Persona
        }

        public Usuario()
        {
            Nombre_Usuario = string.Empty;
            Contrasena = string.Empty;
            IdRol = 1;
            Estatus = true; // Por defecto, los estudiantes se crean activos
            DatosPersonales = new Persona();
        }
        public int Id { get; set; }

        public int IdPersona { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool Estatus { get; set; }
        public int IdRol { get; set; }
        public Rol Rol { get; set; }
        public Persona Persona { get; set; } // Nueva propiedad para los datos personales

        /// <summary>
        /// Datos personales del estudiante (relación con Persona)
        /// </summary>
        public Persona DatosPersonales { get; set; }

    }
}