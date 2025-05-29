using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaXpertCore.Model
{
    public class Empleado
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Matricula { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public decimal Sueldo { get; set; }
        public string TipoContrato { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool SalarioFijo { get; set; }
        public bool Estatus { get; set; }



        // Propiedad que almacena los datos personales del empleado
        public Persona DatosPersonales { get; set; }

        // Constructor para inicializar el objeto Empleado
        public Empleado(int id, int idPersona, string matricula, string puesto, string departamento, decimal sueldo, string tipoContrato,
                        DateTime fechaIngreso, DateTime? fechaBaja, bool salarioFijo, bool estatus, Persona datosPersonales)
        {
            Id = id;
            IdPersona = idPersona;
            Matricula = matricula;
            Puesto = puesto;
            Departamento = departamento;
            Sueldo = sueldo;
            TipoContrato = tipoContrato;
            FechaIngreso = fechaIngreso;
            FechaBaja = fechaBaja;
            SalarioFijo = salarioFijo;
            Estatus = estatus;
            DatosPersonales = datosPersonales; // Asignamos la persona a los datos personales
        }

        // Constructor predeterminado
        public Empleado()
        {
            IdPersona = 0;
            Matricula = string.Empty;
            Puesto = string.Empty;
            Departamento = string.Empty;
            Sueldo = 0.00m;
            TipoContrato = string.Empty;
            FechaIngreso = DateTime.Now;
            FechaBaja = null;
            SalarioFijo = true;  // Por defecto, salario fijo
            Estatus = true;  // Por defecto, empleado activo
        }

        // Constructor con campos obligatorios
        public Empleado(int idPersona, string matricula, string puesto, string departamento, decimal sueldo, string tipoContrato, DateTime fechaIngreso)
        {
            IdPersona = idPersona;
            Matricula = matricula;
            Puesto = puesto;
            Departamento = departamento;
            Sueldo = sueldo;
            TipoContrato = tipoContrato;
            FechaIngreso = fechaIngreso;
            FechaBaja = null;  // El empleado no tiene baja al inicio
            SalarioFijo = true;  // Por defecto, salario fijo
            Estatus = true;  // Por defecto, empleado activo
        }

        // Constructor con todos los campos
        public Empleado(int id, int idPersona, string matricula, string puesto, string departamento, decimal sueldo, string tipoContrato, DateTime fechaIngreso, DateTime? fechaBaja, bool salarioFijo, bool estatus)
        {
            Id = id;
            IdPersona = idPersona;
            Matricula = matricula;
            Puesto = puesto;
            Departamento = departamento;
            Sueldo = sueldo;
            TipoContrato = tipoContrato;
            FechaIngreso = fechaIngreso;
            FechaBaja = fechaBaja;
            SalarioFijo = salarioFijo;
            Estatus = estatus;
        }

    }
}