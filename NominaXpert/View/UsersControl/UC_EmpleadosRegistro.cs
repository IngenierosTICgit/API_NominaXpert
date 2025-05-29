using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaXpertCore.Business;
using NominaXpertCore.Utilities;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_EmpleadosRegistro : UserControl
    {
        public UC_EmpleadosRegistro()
        {
            InitializeComponent();
        }

        private void UC_EmpleadosRegistro_Load(object sender, EventArgs e)
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

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            GuardarEmpleado();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "EJ: Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
            }
        }
        private void txtNombre_Leave_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "EJ: Nombre";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtApPaterno_Enter(object sender, EventArgs e)
        {
            if (txtApPaterno.Text == "EJ: Apellido Paterno")
            {
                txtApPaterno.Text = "";
                txtApPaterno.ForeColor = Color.White;
            }
        }

        private void txtApPaterno_Leave(object sender, EventArgs e)
        {
            if (txtApPaterno.Text == "")
            {
                txtApPaterno.Text = "EJ: Apellido Paterno";
                txtApPaterno.ForeColor = Color.LightGray;
            }
        }

        private void txtApMaterno_Enter(object sender, EventArgs e)
        {
            if (txtApMaterno.Text == "EJ: Apellido Materno")
            {
                txtApMaterno.Text = "";
                txtApMaterno.ForeColor = Color.White;
            }
        }

        private void txtApMaterno_Leave(object sender, EventArgs e)
        {
            if (txtApMaterno.Text == "")
            {
                txtApMaterno.Text = "EJ: Apellido Materno";
                txtApMaterno.ForeColor = Color.LightGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "EJ: Dirección completa")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.White;
            }
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "EJ: Dirección completa";
                txtDireccion.ForeColor = Color.LightGray;
            }
        }

        private void txtRFC_Enter(object sender, EventArgs e)
        {
            if (txtRFC.Text == "RFC")
            {
                txtRFC.Text = "";
                txtRFC.ForeColor = Color.White;
            }
        }

        private void txtRFC_Leave(object sender, EventArgs e)
        {
            if (txtRFC.Text == "")
            {
                txtRFC.Text = "RFC";
                txtRFC.ForeColor = Color.LightGray;
            }
        }

        private void txtCURP_Enter(object sender, EventArgs e)
        {
            if (txtCURP.Text == "CURP")
            {
                txtCURP.Text = "";
                txtCURP.ForeColor = Color.White;
            }
        }

        private void txtCURP_Leave(object sender, EventArgs e)
        {
            if (txtCURP.Text == "")
            {
                txtCURP.Text = "CURP";
                txtCURP.ForeColor = Color.LightGray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "EJ: 7221845696")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.White;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "EJ: 7221845696";
                txtTelefono.ForeColor = Color.LightGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "EJ: correo@empresa.com")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "EJ: correo@empresa.com";
                txtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void txtSalario_Enter(object sender, EventArgs e)
        {
            if (txtSalario.Text == "EJ: 00.00")
            {
                txtSalario.Text = "";
                txtSalario.ForeColor = Color.White;
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (txtSalario.Text == "")
            {
                txtSalario.Text = "EJ: 00.00";
                txtSalario.ForeColor = Color.LightGray;
            }
        }


        private bool GuardarEmpleado()
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
            if (txtMatricula.Text == "" || txtNombre.Text == "" ||
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
            if (!EmpleadosNegocio.EsMatriculaValido(txtMatricula.Text.Trim()))
            {
                MessageBox.Show("Matricula inválida.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "EJ: E-2019-54321")
            {
                txtMatricula.Text = "";
                txtMatricula.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtMatricula.Text == "")
            {
                txtMatricula.Text = "EJ: E-2019-54321";
                txtMatricula.ForeColor = Color.LightGray;
            }
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
