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

namespace NominaXpertCore.View.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void horaFecha_Tick_1(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            InicializarDashboard();
            CargarEmpleadosActivosYInactivos();
            CargarNominasPagadasYPendientes();
            CargarCostoTotalMensual();  
        }

        public void InicializarDashboard()
        {

            lbltext1.Dock = DockStyle.Fill; // El label ocupará todo el espacio disponible
            lbltext1.TextAlign = ContentAlignment.MiddleLeft;
            lbltext1.Text = "Automatiza el cálculo y procesamiento de nóminas con precisión. Gestiona pagos, deducciones y beneficios de manera eficiente.";
            lbltext2.Dock = DockStyle.Fill;
            lbltext2.TextAlign = ContentAlignment.MiddleLeft;
            lbltext2.Text = "Administra la información de tus empleados, seguimiento de días trabajados, informes personales, auditoría y documentación en un solo lugar.";
            lbltext3.Dock = DockStyle.Fill;
            lbltext3.TextAlign = ContentAlignment.MiddleLeft;
            lbltext3.Text = "Genera informes detallados, analiza costos y obtén insights valiosos para la toma de decisiones estratégicas.";
        }

        private void CargarEmpleadosActivosYInactivos()
        {
            try
            {
                EmpleadosDataAccess empleadosDataAccess = new EmpleadosDataAccess();

                // Traemos TODOS los empleados (activos e inactivos)
                List<Empleado> todosLosEmpleados = empleadosDataAccess.ObtenerTodosLosEmpleados(false);

                // Contamos cuántos son activos e inactivos
                int empleadosActivos = todosLosEmpleados.Count(e => e.Estatus == true);
                int empleadosInactivos = todosLosEmpleados.Count(e => e.Estatus == false);

                // Mostrar los resultados en los Labels con el texto solicitado
                lblEmpleadosActivos.Text = $"ACTIVOS: {empleadosActivos}";
                lblEmpleadosInactivos.Text = $"INACTIVOS: {empleadosInactivos}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el número de empleados: " + ex.Message);
            }
        }

        private void CargarNominasPagadasYPendientes()
        {
            try
            {
                NominaDataAccess nominasDataAccess = new NominaDataAccess();

                // Llamamos al método que cuenta las nóminas por estado
                var (nominasPendientes, nominasPagas) = nominasDataAccess.ContarNominasPorEstado();

                // Mostrar los resultados en los Labels con el texto solicitado
                lblNominasPagadas.Text = $"PAGADAS: {nominasPagas}";
                lblNominasPendientes.Text = $"PENDIENTES: {nominasPendientes}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el número de nóminas: " + ex.Message);
            }


        }

        private void CargarCostoTotalMensual()
        {
            try
            {
                PagoDataAccess pagoDataAccess = new PagoDataAccess();
                // Llamamos al método que obtiene el costo total mensual
                decimal costoTotalMensual = pagoDataAccess.ContarMontoTotalMesActual();
                // Mostrar el resultado en el Label con el texto solicitado
                lblCostoTotalMensual.Text = $" {costoTotalMensual:C}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el costo total mensual: " + ex.Message);
            }



        }

    }
}
