using NominaXpertCore.Data;
using NominaXpertCore.Model;
using System;
using NominaXpertCore.Utilities;

namespace NominaXpertCore.Controller
{
    public class EmpleadosController
    {
        private readonly EmpleadosDataAccess _empleadosData;

        public EmpleadosController()
        {
            _empleadosData = new EmpleadosDataAccess();
        }

        // Método para buscar empleado por matrícula
        public (string Nombre, decimal SueldoBase, int IdEmpleado, string Estatus) BuscarEmpleadoPorMatricula(string matricula)
        {
            try
            {
                // Validar formato de matrícula (usa tu método de Validaciones)
                if (!Validaciones.EsNoMatriculaValido(matricula))
                    throw new Exception("Formato de matrícula inválido.");

                // Llamamos al método que obtiene los datos del empleado y su estatus
                var (nombre, sueldo, idEmpleado, estatus) = _empleadosData.ObtenerNombreYSueldoPorMatricula(matricula);

                // Verificar si se encontró el empleado
                if (string.IsNullOrEmpty(nombre))
                    throw new Exception("Empleado no encontrado.");

                // Si el estatus es true, devolvemos "Activo", si es false devolvemos "Inactivo"
                string estatusEmpleado = estatus == "Activo" ? "Activo" : "Inactivo";

                // Retornamos el nombre, sueldo, idEmpleado y el estatus (Activo/Inactivo)
                return (nombre, sueldo, idEmpleado, estatusEmpleado);
            }
            catch (Exception ex)
            {
                // Loggear el error si es necesario
                throw new Exception($"Error al buscar empleado: {ex.Message}");
            }
        }
    }
}