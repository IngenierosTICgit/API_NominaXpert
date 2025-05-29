using System.Data;
using System.Numerics;
using NominaXpertCore.Business;
using NominaXpertCore.Controller;
using NominaXpertCore.Model;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_UsuariosAlta : UserControl
    {
        private bool _modoEdicion = false;

        private int _idUsuarioEditar = 0;
        private int _idPersonaEditar = 0;


        private void EstablecerModoEdicion(bool edicion)
        {
            _modoEdicion = edicion;
            ibtnGuardar.Text = edicion ? "Actualizar" : "Guardar";
            //.Text = edicion ? "Editar Usuario" : "Nuevo Usuario";
            ibtnRegresar.Visible = true;
        }

        public UC_UsuariosAlta()
        {
            InitializeComponent();
            inicializa_UC_Usuarios_Alta();
        }
        private void inicializa_UC_Usuarios_Alta()
        {
            PoblaComboEstatus();
            PoblaComboRol();
            ConfigurarPermisos();
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void ConfigurarPermisos()
        {
            var controller = new UsuariosController();

            ibtnGuardar.Enabled = controller.TienePermiso("USR_ADD");
        }
        private void PoblaComboEstatus()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                //key , value
                {1, "Activo"},
                {0, "Baja"},
            };
            cbxEstatus.DataSource = new BindingSource(list_estatus, null);
            cbxEstatus.DisplayMember = "Value"; //lo que se muestra
            cbxEstatus.ValueMember = "Key"; //lo que se guarda como seleccion
            cbxEstatus.SelectedValue = 1;
        }



        private void PoblaComboRol()
        {
            try
            {
                var controller = new RolesController();
                var listaRoles = controller.ObtenerRolesParaCombo();

                // Configurar el ComboBox
                cbxRoles.DataSource = new BindingSource(listaRoles, null);
                cbxRoles.DisplayMember = "Value"; // Muestra el nombre del rol
                cbxRoles.ValueMember = "Key";     // Guarda el ID del rol

                // Seleccionar el primer valor por defecto si existe
                if (listaRoles.Any())
                {
                    cbxRoles.SelectedValue = listaRoles.Keys.First();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al cargar roles: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                // Lista por defecto
                var listaDefault = new Dictionary<int, string>
        {
            {1, "Administrador"},
            {2, "Operador"},
            {3, "Lector"},
            {4, "Seguridad"},
            {5, "Autorizador"}
        };

                cbxRoles.DataSource = new BindingSource(listaDefault, null);
            }
        }

        private bool DatosVacios()
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtNomUsuario.Text == ""
                || txtContraseña.Text == "" || txtCorreo.Text == "" || txtRfc.Text == "" || txtDireccion.Text == "" || txtRfc.Text == "" || txtCurp.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            if (_modoEdicion)
            {
                ConfigurarPermisos();
                ActualizarUsuario();
            } 
            else
                GuardarUsuario(); 
        }

        public void ObtenerDetalleUsuario(int idUsuario)
        {
            UsuariosController controller = new UsuariosController();
            Usuario usuario = controller.ObtenerDetalleUsuario(idUsuario);

            if (usuario != null)
            {
                _idUsuarioEditar = usuario.Id;
                _idPersonaEditar = usuario.DatosPersonales?.Id ?? 0; 

                txtNomUsuario.Text = usuario.Nombre_Usuario;
                txtContraseña.Text = usuario.Contrasena;
                txtNombre.Text = usuario.DatosPersonales?.NombreCompleto ?? "";
                txtCorreo.Text = usuario.DatosPersonales?.Correo ?? "";
                txtTelefono.Text = usuario.DatosPersonales?.Telefono ?? "";
                txtDireccion.Text = usuario.DatosPersonales?.Direccion ?? "";
                txtCurp.Text = usuario.DatosPersonales?.Curp ?? "";
                txtRfc.Text = usuario.DatosPersonales?.Rfc ?? "";
                dtpFechaNacimiento.Value = usuario.DatosPersonales?.FechaNacimiento ?? DateTime.Now;
                cbxEstatus.SelectedValue = usuario.Estatus ? 1 : 0;
                cbxRoles.SelectedValue = usuario.IdRol;

                EstablecerModoEdicion(true);
            }
        }


        private void GuardarUsuario()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor llene todos los campos", "Información del sistema",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DatosValidos())
            {
                return;
            }

            try
            {
                Persona persona = new Persona(
                    txtNombre.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCurp.Text.Trim())
                {
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Direccion = txtDireccion.Text.Trim(),
                    Rfc = txtRfc.Text.Trim()
                };

                Usuario usuario = new Usuario
                {
                    Nombre_Usuario = txtNomUsuario.Text.Trim(),
                    Contrasena = txtContraseña.Text.Trim(),
                    IdRol = (int)cbxRoles.SelectedValue,
                    Estatus = Convert.ToInt32(cbxEstatus.SelectedValue) == 1, // Conversión correcta
                    DatosPersonales = persona
                };

                UsuariosController usuariosController = new UsuariosController();
                var (idUsuario, mensaje) = usuariosController.RegistrarUsuario(usuario);

                if (idUsuario > 0)
                {
                    MessageBox.Show(mensaje, "Información del sistema",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(mensaje, "Información del sistema",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo completar el registro. Error: " + ex.Message,
                              "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool DatosValidos()
        {
            if (!PersonasNegocio.EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsCURPValido(txtCurp.Text.Trim()))
            {
                MessageBox.Show("CURP inválida.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!PersonasNegocio.EsRFCValido(txtRfc.Text.Trim()))
            {
                MessageBox.Show("RFC inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtRfc.Clear();
            txtNomUsuario.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCurp.Clear();
            txtDireccion.Clear();
            cbxEstatus.ResetText();
            cbxRoles.ResetText();
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18); // Valor por defecto
            cbxEstatus.SelectedValue = 1; // Activo por defecto
            ibtnRegresar.Visible = false;
        }
        private void ReiniciarFormulario()//Se usa cuando ya se actualice el usuario
        {
            txtNomUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCurp.Clear();
            txtRfc.Clear();
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
            cbxEstatus.SelectedIndex = 0;
            cbxRoles.SelectedIndex = 0;

            _modoEdicion = false;
            _idUsuarioEditar = 0;
            EstablecerModoEdicion(false);
            ibtnRegresar.Visible = false;
            _idPersonaEditar = 0;
        }
        private void ActualizarUsuario()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor llena todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona persona = new Persona
            {
                Id = _idPersonaEditar,
                NombreCompleto = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Curp = txtCurp.Text.Trim(),
                Rfc = txtRfc.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                FechaNacimiento = dtpFechaNacimiento.Value,
                Estatus = Convert.ToInt32(cbxEstatus.SelectedValue) == 1
            };

            Usuario usuario = new Usuario
            {
                Id = _idUsuarioEditar,
                Nombre_Usuario = txtNomUsuario.Text.Trim(),
                Contrasena = txtContraseña.Text.Trim(),
                IdRol = Convert.ToInt32(cbxRoles.SelectedValue),
                Estatus = Convert.ToInt32(cbxEstatus.SelectedValue) == 1,
                DatosPersonales = persona
            };

            UsuariosController controller = new UsuariosController();
            var (exito, mensaje) = controller.ActualizarUsuario(usuario);

            MessageBox.Show(mensaje, exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (exito)
                ReiniciarFormulario();
        }

    }
}













