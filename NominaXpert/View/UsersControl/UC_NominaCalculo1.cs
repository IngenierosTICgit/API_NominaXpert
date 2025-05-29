using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaXpertCore.Business;
using NominaXpertCore.Controller;
using NominaXpertCore.Utilities;
using System.Configuration;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_NominaCalculo1 : UserControl
    {
        private readonly NominasController _nominasController; // Controlador de nómina
        private readonly RegistroJornadaController _jornadaController; // Controlador de empleados
        private readonly decimal _sueldoMinimo; // Variable para almacenar el sueldo mínimo


        public UC_NominaCalculo1()
        {
            InitializeComponent();
            _nominasController = new NominasController();
            _jornadaController = new RegistroJornadaController();
            // Obtener el sueldo mínimo usando ConfigHelp
            try
            {
                _sueldoMinimo = ConfigHelp.ObtenerSueldoMinimo();
            }
            catch (ConfigurationErrorsException ex)
            {
                // Mostrar mensaje al usuario o manejar el error
                MessageBox.Show(ex.Message);
            }
        }




        private void UC_NominaAlta_Load(object sender, EventArgs e)
        {
            // 1. Verificar que el usuario tenga permisos
            int idUsuario = 1;
            var usuarioAutorizado = _nominasController.VerificarPermisosUsuario(idUsuario);

            if (!usuarioAutorizado)
            {
                MessageBox.Show("Lo siento, no tienes permisos suficientes para generar nómina.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Bloqueamos el acceso a la vista si no tiene permisos
            }
        }

        public void InicializaVentanaCalculoRecibos()
        {
            ConfigurarPermisos();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1️ Validar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("El campo de matrícula no puede estar vacío.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️ Validar si la matrícula tiene el formato correcto
            if (!EmpleadosNegocio.EsMatriculaValido(txtMatricula.Text.Trim()))
            {
                MessageBox.Show("Matrícula inválida. Verifique el formato.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var controller = new EmpleadosController();
                var (nombre, sueldo, idEmpleado, estatus) = controller.BuscarEmpleadoPorMatricula(txtMatricula.Text.Trim());

                // Mostrar datos en la UI
                txtNombreEmpleado.Text = nombre;
                txtSueldoBase.Text = sueldo.ToString("C");
                txtIdEmpleado.Text = idEmpleado.ToString();
                txtEstatusEmpleado.Text = estatus.ToString();

                // Verificar si el sueldo es inferior al mínimo
                if (sueldo < _sueldoMinimo)
                {
                    var result = MessageBox.Show(
                        "Este usuario cuenta con sueldo inferior al mínimo. ¿Desea continuar?",
                        "Advertencia",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        // Limpiar los campos si el usuario decide no continuar
                        txtNombreEmpleado.Text = string.Empty;
                        txtSueldoBase.Text = string.Empty;
                        txtIdEmpleado.Text = string.Empty;
                        txtEstatusEmpleado.Text = string.Empty;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCalcularVerNomina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text)) // Si el campo de matrícula está vacío
            {
                MessageBox.Show("El campo de matrícula no puede estar vacío", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Validar las horas trabajadas
            decimal totalHoras;
            bool isValid = decimal.TryParse(txtDiasLaborados.Text, out totalHoras); // Intentar convertir el texto a decimal

            if (!isValid || totalHoras == 0)
            {
                MessageBox.Show("No se puede generar la nómina porque las horas trabajadas son 0 o no son válidas.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el empleado esté activo
            if (txtEstatusEmpleado.Text != "Activo")
            {
                MessageBox.Show("El empleado no está activo. No se puede generar la nómina.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Iniciar el proceso de inserción de la nómina
            this.Cursor = Cursors.WaitCursor;

            // Crear y mostrar un ProgressBar de carga
            ProgressBar progressBar = new ProgressBar();
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.Dock = DockStyle.Fill;
            this.Controls.Add(progressBar);
            progressBar.BringToFront();

            try
            {
                int idEmpleado = int.Parse(txtIdEmpleado.Text);
                DateTime fechaInicio = dtpFechaInicioNomina.Value;
                DateTime fechaFin = dtpFechaFinNomina.Value;

                // Para pruebas, el idUsuario puede ser nulo
                int? idUsuario = null;

                // Llamar al controlador para registrar la nómina y obtener la ID generada
                bool resultado = _nominasController.CrearNomina(idEmpleado, idUsuario ?? 1, fechaInicio, fechaFin);

                if (resultado)
                {
                    MessageBox.Show("La nómina se generó correctamente.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Obtener el ID de la nómina recién creada
                    int idNominaGenerada = _nominasController.ObtenerUltimaNominaGenerada(idEmpleado); // Aquí obtenemos la ID de la nómina

                    // Redirigir a otro UserControl o pantalla después de generar la nómina
                    Control parent = this.Parent;
                    if (parent != null)
                    {
                        parent.Controls.Remove(this);

                        UC_NominaPercepciones ucPercepciones = new UC_NominaPercepciones(idNominaGenerada);
                        ucPercepciones.Dock = DockStyle.Fill;

                        // Pasar la ID de la nómina a UC_NominaPercepciones
                        ucPercepciones.IdNomina = idNominaGenerada;

                        parent.Controls.Add(ucPercepciones);
                        parent.Controls.SetChildIndex(ucPercepciones, 0); // Ponerlo al frente
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al generar la nómina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                progressBar.Visible = false;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicioNomina_ValueChanged(object sender, EventArgs e)
        {
            ActualizarHorasLaboradas();
        }

        private void dtpFechaFinNomina_ValueChanged(object sender, EventArgs e)
        {
            ActualizarHorasLaboradas();
        }

        // Método para calcular y actualizar los días laborados en el TextBox
        private void ActualizarHorasLaboradas()
        {
            try
            {
                // 1. Verificar que el campo de matrícula no esté vacío
                if (string.IsNullOrWhiteSpace(txtMatricula.Text))
                {
                    MessageBox.Show("El campo de matrícula no puede estar vacío.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Obtener la matrícula
                string matricula = txtMatricula.Text.Trim();

                // 3. Verificar el formato de la matrícula
                if (!EmpleadosNegocio.EsMatriculaValido(matricula))
                {
                    MessageBox.Show("Matrícula inválida. Verifique el formato.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Buscar el ID del empleado utilizando la matrícula
                var controller = new EmpleadosController();
                var (nombre, sueldo, idEmpleado, estatus) = controller.BuscarEmpleadoPorMatricula(matricula);

                // 5. Consultar las horas trabajadas en el periodo seleccionado
                DateTime periodoInicio = dtpFechaInicioNomina.Value;
                DateTime periodoFin = dtpFechaFinNomina.Value;

                int idUsuario = 1; // Este ID debe ser del usuario actual (el que está logueado)

                // Llamar al controlador para consultar las horas trabajadas
                decimal totalHoras = _jornadaController.ConsultarTotalHorasTrabajadas(idEmpleado, periodoInicio, periodoFin, idUsuario);

                // Mostrar el total de horas trabajadas en el TextBox (txtDiasLaborados)
                txtDiasLaborados.Text = totalHoras.ToString("0"); // Mostrar como número entero

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar las horas trabajadas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnCalcularVerNomina_Click(object sender, EventArgs e)
        //{
        //    UC_NominaRecibo ucr = new UC_NominaRecibo();
        //    Utilities.Formas.ActivateButton(sender, Formas.RGBColors.ChangeColor);
        //    ucr.Show();
        //}

        private void ConfigurarPermisos()
        {
            var controller = new UsuariosController();
            btnCalculoNomina1.Enabled = controller.TienePermiso("NOM_ADD");
        }

        private void dtpFechaInicioNomina_ValueChanged_2(object sender, EventArgs e)
        {
            ActualizarHorasLaboradas();
        }

        private void dtpFechaFinNomina_ValueChanged_2(object sender, EventArgs e)
        {
            ActualizarHorasLaboradas();
        }
    }
}
