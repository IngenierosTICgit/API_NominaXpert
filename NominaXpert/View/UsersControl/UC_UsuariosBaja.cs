
using NominaXpertCore.Controller;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_UsuariosBaja : UserControl
    {
        private int _idUsuario;

        // Constructor sin parámetros (para inicialización básica)
        public UC_UsuariosBaja()
        {
            InitializeComponent();
            inicializa_UC_Usuarios_Alta();
        }

        // Constructor con parámetros (para uso específico)
        public UC_UsuariosBaja(int idUsuario, string nombreUsuario) : this()
        {
            _idUsuario = idUsuario;

            // Selecciona el usuario en el ComboBox (sin borrar los demás)
            if (cbxUsuario.Items.Contains(nombreUsuario))
            {
                cbxUsuario.SelectedItem = nombreUsuario;
            }
            else
            {
                cbxUsuario.SelectedIndex = -1; // Si no existe, no seleccionar nada
            }
        }

        private void inicializa_UC_Usuarios_Alta()
        {
            PoblarComboNombreUsuario();
            PoblaComboMotivo();
            dtpFechaBaja.Value = DateTime.Now;
        }
        private void PoblarComboNombreUsuario()
        {
            try
            {
                var controller = new UsuariosController();
                var nombresUsuarios = controller.ObtenerNombresUsuarios(soloActivos: true); // Solo usuarios activos

                cbxUsuario.DataSource = nombresUsuarios;
                cbxUsuario.SelectedIndex = -1; // Sin selección por defecto
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PoblaComboMotivo()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                //key , value
                {1, "Rotación de personal"},
                {0, "Problemas técnico"},
                {2, "Violación de políticas"},
                {3, "Solicitud del usuario"},
                {4, "Terminacón de contrato"}
            };
            cbxMotivoBaja.DataSource = new BindingSource(list_estatus, null);
            cbxMotivoBaja.DisplayMember = "Value"; //lo que se muestra
            cbxMotivoBaja.ValueMember = "Key"; //lo que se guarda como seleccion
            cbxMotivoBaja.SelectedValue = 1;
        }
        private void ibtnGuardar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Deseas dar de baja (baja lógica) o eliminar definitivamente al usuario?\n\nSí = Baja lógica\nNo = Baja definitiva",
                "Confirmar acción",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            // Cancelar
            if (resultado == DialogResult.Cancel)
                return;

            bool esBajaLogica = resultado == DialogResult.Yes; // Sí = baja lógica, No = baja definitiva

            if (RealizarBaja(esBajaLogica))
            {
                MessageBox.Show("Operación completada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private bool RealizarBaja(bool esBajaLogica)
        {
            UsuariosController controller = new UsuariosController();
            var (exito, mensaje) = controller.DarDeBajaUsuario(_idUsuario, cbxMotivoBaja.Text, esBajaLogica);

            MessageBox.Show(mensaje, exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            return exito;
        }

        private void addUsersControl(UserControl userControl)
        {
            // Limpiar el panel contenedor
            panelContainer.Controls.Clear();
            // Configurar el control de usuario
            userControl.Dock = DockStyle.Fill;
            // Agregar el control de usuario al panel
            panelContainer.Controls.Add(userControl);
        }
        //Si le doy en cancelar me regresa al usuario de control de listado de usuarios 
        private void ibtnCancelar_Click(object sender, EventArgs e)
        {
            UC_UsuariosListado uclistado = new UC_UsuariosListado();
            addUsersControl(uclistado);
        }
        public void CargarDatos(string usuarioSeleccionado)
        {
            // Aquí cargas los datos en los controles del UserControl
            cbxUsuario.SelectedValue = ObtenerClaveDeUsuario(usuarioSeleccionado);
        }

        private int ObtenerClaveDeUsuario(string usuarioSeleccionado)
        {
            // Obtener el BindingSource del ComboBox
            var bindingSource = (BindingSource)cbxUsuario.DataSource;

            // Obtener la lista de KeyValuePair desde el BindingSource
            var listaUsuarios = bindingSource.List as System.ComponentModel.BindingList<KeyValuePair<int, string>>;

            if (listaUsuarios != null)
            {
                // Buscar la clave correspondiente al nombre del usuario
                foreach (var item in listaUsuarios)
                {
                    if (item.Value == usuarioSeleccionado)
                        return item.Key; // Devuelve la clave asociada al valor
                }
            }
            return -1; // Valor por defecto si no se encuentra
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxMotivoBaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



