using NominaXpertCore.Controller;
using System.Data;
using NominaXpertCore.Utilities;
using NominaXpertCore.Model;
using NominaXpertCore.Data;
using static System.Net.Mime.MediaTypeNames;
namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_UsuariosRolPermiso : UserControl
    {
        public UC_UsuariosRolPermiso()
        {
            InitializeComponent();
            CargarRoles();
            PoblaComboEstatus();
        }


        private void dtgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PoblaComboEstatus()
        {
            // Limpiar los valores previos si es necesario
            cbxEstatus.Items.Clear();

            // Agregar las opciones de estatus al ComboBox (Activo o Inactivo)
            cbxEstatus.Items.Add("Activo");
            cbxEstatus.Items.Add("Inactivo");
            cbxEstatus.SelectedValue = true;
        }
        private void CargarRoles()
        {
            try
            {
                RolesController controller = new RolesController();
                var roles = controller.ObtenerTodosLosRoles();

                dtgRoles.DataSource = null;

                if (roles.Count == 0)
                {
                    MessageBox.Show("No se encontraron roles registrados.",
                                    "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("Estatus", typeof(string));
                dt.Columns.Add("Permisos", typeof(string));

                foreach (var rol in roles)
                {
                    dt.Rows.Add(
                        rol.Id,
                        rol.Nombre,
                        rol.Descripcion,
                        rol.Estatus ? "Activo" : "Inactivo",
                        string.Join(", ", rol.Permisos.Select(p => p.Descripcion))
                    );
                }

                dtgRoles.DataSource = dt;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarDataGridView()
        {
            if (dtgRoles.Columns.Count == 0) return;

            // Ajustes generales
            dtgRoles.AllowUserToAddRows = false;
            dtgRoles.AllowUserToDeleteRows = false;
            dtgRoles.ReadOnly = true;

            // Configurar columnas
            var columnas = new[] {
        new { Name = "id", Width = 50, Visible = false },
        new { Name = "Nombre", Width = 120, Visible = true },
        new { Name = "Descripcion", Width = 250, Visible = true },
        new { Name = "Estatus", Width = 100, Visible = true },
        new { Name = "Permisos", Width = 500, Visible = true }
    };

            foreach (var col in columnas)
            {
                if (dtgRoles.Columns.Contains(col.Name))
                {
                    dtgRoles.Columns[col.Name].Width = col.Width;
                    dtgRoles.Columns[col.Name].Visible = col.Visible;
                }
            }

            // Estilo de cabeceras
            dtgRoles.EnableHeadersVisualStyles = false;
            dtgRoles.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dtgRoles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgRoles.DefaultCellStyle.ForeColor = Color.Black;

            //dtgRoles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Alternar colores de filas
            dtgRoles.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección completa de fila
            dtgRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblRegistros.Text = $"Total de Registros: {dtgRoles.Rows.Count}";

        }

        private void addUsersControl(UserControl userControl)
        {
            // Limpiar el panel contenedor
            panelContenedor.Controls.Clear();
            // Configurar el control de usuario
            userControl.Dock = DockStyle.Fill;
            // Agregar el control de usuario al panel
            panelContenedor.Controls.Add(userControl);
        }
        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            if (dtgRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un rol para editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener el ID del rol desde la fila seleccionada
            int idRol = Convert.ToInt32(dtgRoles.SelectedRows[0].Cells["Id"].Value);

            // Obtener el rol completo (con permisos incluidos)
            RolesController controller = new RolesController();
            Rol rol = controller.ObtenerTodosLosRoles().FirstOrDefault(r => r.Id == idRol);

            if (rol != null)
            {
                // Crear el UserControl de edición
                UC_RolesAlta ucEditar = new UC_RolesAlta();

                // Mostrarlo en el contenedor
                addUsersControl(ucEditar);

                // Cargar los datos en el formulario
                ucEditar.CargarRolParaEditar(rol);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarRoles();
        }
        private void MostrarRolesFiltrados(List<Rol> roles)
        {
            try
            {
                if (roles.Count == 0)
                {
                    MessageBox.Show("No se encontraron roles registrados.",
                                    "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("Estatus", typeof(string));
                dt.Columns.Add("Permisos", typeof(string));

                foreach (var rol in roles)
                {
                    dt.Rows.Add(
                        rol.Id,
                        rol.Nombre,
                        rol.Descripcion,
                        rol.Estatus ? "Activo" : "Inactivo",
                        string.Join(", ", rol.Permisos.Select(p => p.Descripcion))
                    );
                }

                dtgRoles.DataSource = dt;
                ConfigurarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FiltrarUsuarios()
        {
            if (cbxEstatus.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un estatus para filtrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string estatusSeleccionado = cbxEstatus.SelectedItem.ToString();
            bool estatusBool = estatusSeleccionado == "Activo"; // Si es "Activo" = true, sino = false

            RolesDataAccess rolesDataAccess = new RolesDataAccess();
            List<Rol> roles = rolesDataAccess.ObtenerRolesFiltrados(estatusBool);

            MostrarRolesFiltrados(roles);

        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtBuscarRol.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "Buscar Rol...")
            {
                MessageBox.Show("Por favor, ingrese un ID o Nombre del rol para buscar.");
                return;
            }

            if (int.TryParse(searchText, out int idRol))
            {
                // Si se busca por ID
                BuscarRolPorId(idRol);
            }
            else
            {
                // Si se busca por nombre
                BuscarRolPorNombre(searchText);
            }
        }

        private void BuscarRolPorId(int idRol)
        {
            RolesDataAccess rolDataAccess = new RolesDataAccess();
            List<Rol> rol = rolDataAccess.ObtenerTodosLosRoles();

            var rolesEncontrados = rol.Where(rol => rol.Id == idRol).ToList();

            if (rolesEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró el rol con ese ID.");
            }
            else
            {
                MostrarRolesFiltrados(rolesEncontrados);
            }
        }

        private void BuscarRolPorNombre(string nombreRol)
        {
            RolesDataAccess rolesDataAccess = new RolesDataAccess();
            List<Rol> rol = rolesDataAccess.ObtenerTodosLosRoles();

            var rolesEncontrados = rol
                .Where(rol => rol.Nombre.Contains(nombreRol, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (rolesEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró el rol con ese nombre.");
            }
            else
            {
                MostrarRolesFiltrados(rolesEncontrados);
            }
        }
    }
}

