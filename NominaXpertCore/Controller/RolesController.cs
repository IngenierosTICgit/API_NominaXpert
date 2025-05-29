using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NominaXpertCore.Data;
using NominaXpertCore.Model;

namespace NominaXpertCore.Controller
{
    public class RolesController
    {
        private readonly RolesDataAccess _rolesRepo = new();

        public (bool exito, string mensaje) RegistrarRol(Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                return (false, "El nombre del rol no puede estar vacío.");

            bool creado = _rolesRepo.AgregarRol(rol);
            return creado
                ? (true, "Rol registrado correctamente.")
                : (false, "Error al registrar el rol.");
        }

        public (bool exito, string mensaje) ActualizarRol(Rol rol)
        {
            if (rol.Id <= 0)
                return (false, "ID de rol inválido.");

            bool actualizado = _rolesRepo.ActualizarRol(rol);
            return actualizado
                ? (true, "Rol actualizado correctamente.")
                : (false, "Error al actualizar el rol.");
        }

        public List<Rol> ObtenerTodosLosRoles()
        {
            
            return _rolesRepo.ObtenerTodosLosRoles();
        }
        public Dictionary<int, string> ObtenerRolesParaCombo()
        {
            try
            {
                var roles = _rolesRepo.ObtenerTodosLosRoles();

                // Filtrar solo roles activos (si es necesario) y crear el Dictionary
                return roles
                    .Where(r => r.Estatus) // Solo roles activos
                    .OrderBy(r => r.Nombre) // Orden alfabético
                    .ToDictionary(r => r.Id, r => r.Nombre);
            }
            catch
            {
                // Lista por defecto en caso de error
                return new Dictionary<int, string>
        {
            {1, "Administrador"},
            {2, "Operador"},
            {3, "Lector"},
            {4, "Seguridad"},
            {5, "Autorizador"}
        };
            }
        }

        public List<Permiso> ObtenerPermisosDisponibles()
        {
            return _rolesRepo.ObtenerPermisosPorRol(0); // 0 para obtener todos
        }

        public (bool exito, string mensaje) DarDeBajaRol(int idRol, bool esBajaLogica)
        {
            if (idRol <= 0)
                return (false, "ID de rol inválido.");

            bool exito;
            if (esBajaLogica)
            {
                // Baja lógica
                exito = _rolesRepo.DarDeBajaRol(idRol);
            }
            else
            {
                // Eliminación definitiva
                exito = _rolesRepo.EliminarRolDefinitivo(idRol);
            }

            return exito
                ? (true, esBajaLogica ? "Rol dado de baja correctamente." : "Rol eliminado definitivamente.")
                : (false, "No se pudo completar la operación.");
        }




    }
}