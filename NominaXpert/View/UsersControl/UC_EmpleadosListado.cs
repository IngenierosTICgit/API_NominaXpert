using NominaXpertCore.Data;
using NominaXpertCore.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_EmpleadosListado : UserControl
    {
        public UC_EmpleadosListado()
        {
            InitializeComponent();
        }

        private void UC_EmpleadosListado_Load(object sender, EventArgs e)
        {


            CargarEmpleados(); // Cargar todos los empleados
            CargarTiposDeContrato();// Tipos de contrato
            CargarEstatus();// Estatus


        }

        public void InicializaVentanaEmpleadoListado()
        {

        }


        private void CargarTiposDeContrato()
        {
            // Limpiar los valores previos si es necesario
            cboTipoContrato.Items.Clear();

            // Agregar los tipos de contrato manualmente
            cboTipoContrato.Items.Add("Indeterminado");
            cboTipoContrato.Items.Add("Temporal");
            cboTipoContrato.Items.Add("Por obra");
            cboTipoContrato.Items.Add("Medio tiempo");
            cboTipoContrato.Items.Add("Honorarios");
            cboTipoContrato.Items.Add("Tiempo Completo");

        }

        private void CargarEstatus()
        {
            // Limpiar los valores previos si es necesario
            cboEstatus.Items.Clear();

            // Agregar las opciones de estatus al ComboBox (Activo o Inactivo)
            cboEstatus.Items.Add("Activo");
            cboEstatus.Items.Add("Inactivo");

        }

        private void txtSearchTable_Enter(object sender, EventArgs e)
        {
            if (txtSearchTable.Text == "Buscar empleados...")
            {
                txtSearchTable.Text = "";
                txtSearchTable.ForeColor = Color.White;
            }
        }

        private void txtSearchTable_Leave(object sender, EventArgs e)
        {
            if (txtSearchTable.Text == "")
            {
                txtSearchTable.Text = "Buscar empleados...";
                txtSearchTable.ForeColor = Color.LightGray;
            }
        }

        // Método para ejecutar la búsqueda de empleados al hacer click en el botón
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchTable.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "Buscar empleados...")
            {
                MessageBox.Show("Por favor, ingrese un ID o Nombre de empleado para buscar.");
                return;
            }

            if (int.TryParse(searchText, out int idEmpleado))
            {
                // Si se busca por ID
                BuscarEmpleadoPorId(idEmpleado);
            }
            else
            {
                // Si se busca por nombre
                BuscarEmpleadoPorNombre(searchText);
            }
        }



        private void FiltrarEmpleados()
        {
            string tipoContrato = cboTipoContrato.SelectedItem != null ? cboTipoContrato.SelectedItem.ToString() : "";
            string estatus = cboEstatus.SelectedItem != null ? cboEstatus.SelectedItem.ToString() : "";

            // Asegúrate de que haya un valor seleccionado en el combo, si no muestra un mensaje o toma un valor por defecto
            if (string.IsNullOrEmpty(tipoContrato) || string.IsNullOrEmpty(estatus))
            {
                MessageBox.Show("Por favor, seleccione un valor en ambos filtros.");
                return;
            }

            // Convertir el estatus a booleano
            bool estatusBool = estatus == "Activo";

            EmpleadosDataAccess empleadosDataAccess = new EmpleadosDataAccess();
            List<Empleado> empleados = empleadosDataAccess.ObtenerEmpleadosFiltrados(tipoContrato, estatusBool);

            // Mostrar los empleados filtrados
            MostrarEmpleados(empleados);
        }


        private void BuscarEmpleadoPorId(int idEmpleado)
        {
            EmpleadosDataAccess empleadosDataAccess = new EmpleadosDataAccess();
            List<Empleado> empleados = empleadosDataAccess.ObtenerTodosLosEmpleados();

            var empleadosEncontrados = empleados.Where(emp => emp.Id == idEmpleado).ToList();

            if (empleadosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró el empleado con ese ID.");
            }
            else
            {
                MostrarEmpleados(empleadosEncontrados);
            }
        }

        private void BuscarEmpleadoPorNombre(string nombreEmpleado)
        {
            EmpleadosDataAccess empleadosDataAccess = new EmpleadosDataAccess();
            List<Empleado> empleados = empleadosDataAccess.ObtenerTodosLosEmpleados();

            var empleadosEncontrados = empleados
                .Where(emp => emp.DatosPersonales.NombreCompleto.Contains(nombreEmpleado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (empleadosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró el empleado con ese nombre.");
            }
            else
            {
                MostrarEmpleados(empleadosEncontrados);
            }
        }

        private void MostrarEmpleados(List<Empleado> empleados)
        {
            ConfigurarDataGridView(); //evita que se editen datos 
            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();

            // Agregar los empleados al DataGridView
            foreach (Empleado empleado in empleados)
            {
                // Obtenemos los datos de la persona asociada al empleado
                string nombreEmpleado = empleado.DatosPersonales.NombreCompleto;
                string correo = empleado.DatosPersonales.Correo;
                string telefono = empleado.DatosPersonales.Telefono;
                string fechaNacimiento = empleado.DatosPersonales.FechaNacimiento?.ToString("dd/MM/yyyy") ?? "N/A";
                string rfc = empleado.DatosPersonales.Rfc;
                string curp = empleado.DatosPersonales.Curp;
                string direccion = empleado.DatosPersonales.Direccion;

                // Insertar los datos del empleado y la persona en el DataGridView
                dataGridView1.Rows.Add(
                    empleado.Id, // ID Empleado
                    nombreEmpleado, // Nombre
                    empleado.Puesto, // Puesto
                    empleado.Departamento, // Departamento
                    empleado.Sueldo, // Sueldo
                    empleado.TipoContrato, // Tipo de Contrato
                    empleado.Estatus ? "Activo" : "Inactivo", // Estatus
                    fechaNacimiento, // Fecha de Nacimiento
                    correo, // Correo
                    empleado.FechaIngreso.ToString("dd/MM/yyyy"), // Fecha de Contratación
                    rfc, // RFC
                    curp, // CURP
                    telefono, // Teléfono
                    direccion // Dirección
                );
            }

            // Mostrar el total real de filas
            lblTotaldeRegistros.Text = $"Total de Registros: {dataGridView1.Rows.Count - 1}";
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void CargarEmpleados()
        {
            EmpleadosDataAccess empleadosDataAccess = new EmpleadosDataAccess();
            List<Empleado> empleados = empleadosDataAccess.ObtenerTodosLosEmpleados(); // ← correcto

            MostrarEmpleados(empleados); // Usamos MostrarEmpleados ya preparado
        }

        private void cboTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void cboEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }



        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cboTipoContrato.SelectedIndex = -1;
            cboEstatus.SelectedIndex = -1;
            txtSearchTable.Text = "Buscar empleados...";
            txtSearchTable.ForeColor = Color.LightGray;
            CargarEmpleados(); // Recargar todos los empleados
        }

        private void lblTotaldeRegistros_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
