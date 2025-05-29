using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaXpertCore.Controller;
using NominaXpertCore.Data;
using NominaXpertCore.Model;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_RolesBaja : UserControl
    {
        public UC_RolesBaja()
        {
            InitializeComponent();
            PoblaComboMotivo();
            PoblaComboRol();
            dtpFechaBaja.Value = DateTime.Now;
        }
        private int _idRol; // Este campo privado almacena el ID del rol que voy a dar de baja

        public UC_RolesBaja(int idRol, string nombreRol) : this() // Llama primero al constructor vacío
        {
            _idRol = idRol;

            if (cbxRoles.Items.Contains(nombreRol))
            {
                cbxRoles.SelectedItem = nombreRol;
            }
            else
            {
                cbxRoles.SelectedIndex = -1;
            }
        }

        private void PoblaComboMotivo()
        {
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                //key , value
                {1, "Motivo 1"},
                {0, "Motivo 2"},
                {2, "Motivo 3"}
            };
            cbxMotivoBaja.DataSource = new BindingSource(list_estatus, null);
            cbxMotivoBaja.DisplayMember = "Value"; //lo que se muestra
            cbxMotivoBaja.ValueMember = "Key"; //lo que se guarda como seleccion
            cbxMotivoBaja.SelectedValue = 1;
        }

        private void ibtnGuardar_Click(object sender, EventArgs e)
        {
            RolesController _rolesController = new RolesController();

            DialogResult resultado = MessageBox.Show(
                "¿Deseas dar de baja (baja lógica) o eliminar definitivamente el rol?\n\nSí = Baja lógica\nNo = Eliminación definitiva",
                "Confirmar acción",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            // Cancelar
            if (resultado == DialogResult.Cancel)
                return;

            // Baja lógica si presiona "Sí", eliminación si presiona "No"
            bool esBajaLogica = resultado == DialogResult.Yes;

            if (cbxRoles.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un rol antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var seleccion = (KeyValuePair<int, string>)cbxRoles.SelectedItem;
            int idSeleccionado = seleccion.Key;

            var (exito, mensaje) = _rolesController.DarDeBajaRol(idSeleccionado, esBajaLogica);
            if (!exito)
            {
                MessageBox.Show("No se puede eliminar este rol porque aún está asignado a usuarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show(mensaje, exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Error);
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

       

}
}
