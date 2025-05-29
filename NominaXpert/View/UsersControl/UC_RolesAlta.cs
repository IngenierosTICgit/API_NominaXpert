using System.Data;
using NominaXpertCore.Controller;
using NominaXpertCore.Model;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_RolesAlta : UserControl
    {
        private bool _modoEdicion = false;
        private int _idRolEditar = 0;

        public UC_RolesAlta()
        {
            InitializeComponent();
            inicializa_UC_Roles_Alta();
        }

        private void inicializa_UC_Roles_Alta()
        {
            PoblaComboEstatus();
            PoblaPermisos();
        }


        private void PoblaPermisos()
        {
            RolesController controller = new RolesController();
            var permisos = controller.ObtenerPermisosDisponibles();

            checkedListBoxPermisos.Items.Clear();
            foreach (var permiso in permisos)
            {
                checkedListBoxPermisos.Items.Add(permiso, false);
            }
        }

        private void PoblaComboEstatus()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                //key , value
                {1, "Activo"},
                {0, "Baja"},
                {2, "Baja Temporal"}
            };
            cbxEstatus.DataSource = new BindingSource(list_estatus, null);
            cbxEstatus.DisplayMember = "Value"; //lo que se muestra
            cbxEstatus.ValueMember = "Key"; //lo que se guarda como seleccion
            cbxEstatus.SelectedValue = 1;
        }
        private void icbtnGuardar_Click_1(object sender, EventArgs e)
        {
            bool resultado = _modoEdicion ? ActualizarRol() : GuardarRol();

            if (resultado)
            {
                MessageBox.Show(
                    _modoEdicion ? "Rol actualizado correctamente." : "Rol guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        private bool GuardarRol()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Rol nuevoRol = new Rol
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombreRol.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Estatus = Convert.ToInt32(cbxEstatus.SelectedValue) == 1
            };

            foreach (var item in checkedListBoxPermisos.CheckedItems)
            {
                if (item is Permiso permiso)
                    nuevoRol.Permisos.Add(permiso);
            }

            RolesController controller = new RolesController();
            var (exito, mensaje) = controller.RegistrarRol(nuevoRol);

            MessageBox.Show(mensaje,
                exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            return exito;
        }

        private bool ActualizarRol()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Rol rolActualizado = new Rol
            {
                Id = _idRolEditar,
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombreRol.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Estatus = Convert.ToInt32(cbxEstatus.SelectedValue) == 1
            };

            foreach (var item in checkedListBoxPermisos.CheckedItems)
            {
                if (item is Permiso permiso)
                    rolActualizado.Permisos.Add(permiso);
            }

            RolesController controller = new RolesController();
            var (exito, mensaje) = controller.ActualizarRol(rolActualizado);

            MessageBox.Show(mensaje,
                exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            return exito;
        }



        private bool DatosVacios()
        {
            if (txtCodigo.Text == "" || txtDescripcion.Text == "" || txtNombreRol.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CargarRolParaEditar(Rol rol)
        {
            _modoEdicion = true;
            _idRolEditar = rol.Id;

            txtCodigo.Text = rol.Codigo;
            txtNombreRol.Text = rol.Nombre;
            txtDescripcion.Text = rol.Descripcion;
            cbxEstatus.SelectedValue = rol.Estatus ? 1 : 0;

            for (int i = 0; i < checkedListBoxPermisos.Items.Count; i++)
            {
                var permiso = (Permiso)checkedListBoxPermisos.Items[i];
                checkedListBoxPermisos.SetItemChecked(i, rol.Permisos.Any(p => p.Id == permiso.Id));
            }

            ibtnGuardar.Text = "Actualizar";
        }

        private void checkedListBoxPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

