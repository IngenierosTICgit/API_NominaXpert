using NominaXpertCore.Business;
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
    public partial class UC_EmpleadosEditar : UserControl
    {
        public UC_EmpleadosEditar()
        {
            InitializeComponent();
        }

        private void UC_EmpleadosEditar_Load(object sender, EventArgs e)
        {
            InicializaVentanaEmpleadoRegistro();
        }
        public void InicializaVentanaEmpleadoRegistro()
        {
            PoblaComboEstatus();
            PoblaGenero();
        }

        private void PoblaComboEstatus()
        {
            //Crear un diccionario de valores
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                { 1, "Activo" },
                { 0, "Baja" },
                { 2, "Baja Temporal" }
            };
            //Asignar el diccionario al combo
            cboEstatus.DataSource = new BindingSource(list_estatus, null);
            cboEstatus.DisplayMember = "Value";
            cboEstatus.ValueMember = "Key";

            cboEstatus.SelectedValue = 1;
        }

        private void PoblaGenero()
        {
            //Crear un diccionario de valores
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                { 1, "Masculino" },
                { 2, "Femenino" }
            };
            //Asignar el diccionario al combo
            cboGenero.DataSource = new BindingSource(list_estatus, null);
            cboGenero.DisplayMember = "Value";
            cboGenero.ValueMember = "Key";

            cboEstatus.SelectedValue = 1;
        }

        private void txtSearchTable_Enter(object sender, EventArgs e)
        {
            if (txtSearchEmpleado.Text == "Buscar empleado")
            {
                txtSearchEmpleado.Text = "";
                txtSearchEmpleado.ForeColor = Color.White;
            }
        }

        private void txtSearchTable_Leave(object sender, EventArgs e)
        {
            if (txtSearchEmpleado.Text == "")
            {
                txtSearchEmpleado.Text = "Buscar empleado";
                txtSearchEmpleado.ForeColor = Color.LightGray;
            }
        }

        private bool GuardarCambiosEmpleado()
        { //primero verificamos si hay algo vaçío
            if (DatosVacios())
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidos())
            {
                return false;
            }
            return true;
        }
        private bool DatosVacios()
        {
            if (txtNombre.Text == "" ||
                txtApPaterno.Text == "" ||
                txtApMaterno.Text == "" ||
                txtCorreo.Text == "" ||
                txtCURP.Text == "" ||
                txtTelefono.Text == "" ||
                txtDireccion.Text == "" ||
                txtSalario.Text == "")
            {
                return true;
            }
            return false;
        }

        private bool DatosValidos()
        {
            if (!PersonasNegocio.EsNombreValido(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Nombre inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsApellidoValido(txtApPaterno.Text.Trim()))
            {
                MessageBox.Show("Apellido Paterno inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsApellidoValido(txtApMaterno.Text.Trim()))
            {
                MessageBox.Show("Apellido Materno inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsDireccionValida(txtDireccion.Text.Trim()))
            {
                MessageBox.Show("Direccion inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsCURPValido(txtCURP.Text.Trim()))
            {
                MessageBox.Show("CURP inválida.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsRFCValido(txtRFC.Text.Trim()))
            {
                MessageBox.Show("RFC inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!EmpleadosNegocio.EsSalarioValido(txtSalario.Text.Trim()))
            {
                MessageBox.Show("Salario inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            GuardarCambiosEmpleado();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
