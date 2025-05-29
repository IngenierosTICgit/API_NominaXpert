using System.Data;
using System.Windows.Forms;
using NominaXpertCore.Controller;
using NominaXpertCore.Data;
using NominaXpertCore.Model;
namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_UsuariosListado : UserControl
    {

        public UC_UsuariosListado()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarUsuarios(); // Llama al método al cargar el UserControl
            CargarEstatus();
        }

        private void CargarEstatus()
        {
            // Limpiar los valores previos si es necesario
            cbxEstatus.Items.Clear();

            // Agregar las opciones de estatus al ComboBox (Activo o Inactivo)
            cbxEstatus.Items.Add("Activo");
            cbxEstatus.Items.Add("Inactivo");
            cbxEstatus.SelectedValue = true;
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
            //revisa que se haya seleccionado una fila en DataGridView
            if (dgvListadoUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idUsuario = Convert.ToInt32(dgvListadoUsuario.SelectedRows[0].Cells["id"].Value);

            UC_UsuariosAlta ucEditar = new UC_UsuariosAlta();
            addUsersControl(ucEditar);
            ucEditar.ObtenerDetalleUsuario(idUsuario); 
        }

        private void ibtnBajaUsuario_Click(object sender, EventArgs e)
        {
            if (dgvListadoUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para dar de baja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idUsuario = Convert.ToInt32(dgvListadoUsuario.SelectedRows[0].Cells["id"].Value);
            string nombreUsuario = dgvListadoUsuario.SelectedRows[0].Cells["nombre_usuario"].Value.ToString();

            UC_UsuariosBaja ucBaja = new UC_UsuariosBaja(idUsuario, nombreUsuario);
            addUsersControl(ucBaja);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarUsuarios()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                UsuariosController usuariosController = new UsuariosController();

                // Obtener todos los usuarios
                List<Usuario> usuarios = usuariosController.ObtenerUsuarios();

                dgvListadoUsuario.DataSource = null;

                if (usuarios.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios registrados",
                                  "Información",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                    return;
                }

                // Crear DataTable con estructura completa
                DataTable dt = new DataTable();
                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("nombre_usuario", typeof(string));
                dt.Columns.Add("nombre_completo", typeof(string));
                dt.Columns.Add("correo", typeof(string));
                dt.Columns.Add("telefono", typeof(string));
                dt.Columns.Add("direccion", typeof(string));
                dt.Columns.Add("curp", typeof(string));
                dt.Columns.Add("rfc", typeof(string));
                dt.Columns.Add("fecha_nacimiento", typeof(DateTime));
                dt.Columns.Add("id_rol", typeof(int));
                dt.Columns.Add("nombre_rol", typeof(string)); // Columna para nombre del rol
                dt.Columns.Add("estatus", typeof(bool));
                dt.Columns.Add("contraseña", typeof(string));

                foreach (Usuario usuario in usuarios)
                {
                    dt.Rows.Add(
                        usuario.Id,
                        usuario.Nombre_Usuario,
                        usuario.DatosPersonales?.NombreCompleto ?? "N/A",
                        usuario.DatosPersonales?.Correo ?? "N/A",
                        usuario.DatosPersonales?.Telefono ?? "N/A",
                        usuario.DatosPersonales?.Direccion ?? "N/A",
                        usuario.DatosPersonales?.Curp ?? "N/A",
                        usuario.DatosPersonales?.Rfc ?? "N/A",
                        usuario.DatosPersonales?.FechaNacimiento ?? DateTime.MinValue,
                        usuario.IdRol,
                        usuario.Rol?.Nombre ?? "Desconocido", // Nombre del rol
                        usuario.Estatus,
                        "*******" // No mostrar contraseña real
                    );
                }

                dgvListadoUsuario.DataSource = dt;
                ConfigurarDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ConfigurarDataGridView()
        {
            if (dgvListadoUsuario.Columns.Count == 0) return;

            // Ajustes generales
            dgvListadoUsuario.AllowUserToAddRows = false;
            dgvListadoUsuario.AllowUserToDeleteRows = false;
            dgvListadoUsuario.ReadOnly = true;

            // Configurar columnas
            var columnas = new[] {
        new { Name = "id", Width = 50, Visible = false },
        new { Name = "nombre_usuario", Width = 120, Visible = true },
        new { Name = "nombre_completo", Width = 200, Visible = true },
        new { Name = "correo", Width = 180, Visible = true },
        new { Name = "telefono", Width = 100, Visible = true },
        new { Name = "direccion", Width = 150, Visible = true },
        new { Name = "curp", Width = 120, Visible = true },
        new { Name = "rfc", Width = 120, Visible = true },
        new { Name = "fecha_nacimiento", Width = 100, Visible = true },
        new { Name = "id_rol", Width = 70, Visible = false }, // Ocultamos el ID del rol
        new { Name = "nombre_rol", Width = 150, Visible = true }, // Mostramos el nombre
        new { Name = "estatus", Width = 80, Visible = true },
        new { Name = "contraseña", Width = 80, Visible = false }
    };

            foreach (var col in columnas)
            {
                if (dgvListadoUsuario.Columns.Contains(col.Name))
                {
                    dgvListadoUsuario.Columns[col.Name].Width = col.Width;
                    dgvListadoUsuario.Columns[col.Name].Visible = col.Visible;
                }
            }

            // Formato para fechas
            dgvListadoUsuario.Columns["fecha_nacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Estilo de cabeceras
            dgvListadoUsuario.EnableHeadersVisualStyles = false;
            dgvListadoUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvListadoUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvListadoUsuario.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Alternar colores de filas
            dgvListadoUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Selección completa de fila
            dgvListadoUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblRegistroUsuarios.Text = $"Total de Registros: {dgvListadoUsuario.Rows.Count}";

        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void lblRegistroUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
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

            UsuariosDataAccess usuariosDataAccess = new UsuariosDataAccess();
            List<Usuario> usuarios = usuariosDataAccess.ObtenerUsuariosFiltrados(estatusBool);

            MostrarUsuarios(usuarios);
        }

        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            dgvListadoUsuario.DataSource = null;

            // Crear un nuevo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("nombre_usuario", typeof(string));
            dt.Columns.Add("nombre_completo", typeof(string));
            dt.Columns.Add("correo", typeof(string));
            dt.Columns.Add("telefono", typeof(string));
            dt.Columns.Add("direccion", typeof(string));
            dt.Columns.Add("curp", typeof(string));
            dt.Columns.Add("rfc", typeof(string));
            dt.Columns.Add("fecha_nacimiento", typeof(DateTime));
            dt.Columns.Add("id_rol", typeof(int));
            dt.Columns.Add("nombre_rol", typeof(string));
            dt.Columns.Add("estatus", typeof(bool));
            dt.Columns.Add("contraseña", typeof(string));

            foreach (Usuario usuario in usuarios)
            {
                dt.Rows.Add(
                    usuario.Id,
                    usuario.Nombre_Usuario,
                    usuario.DatosPersonales?.NombreCompleto ?? "N/A",
                    usuario.DatosPersonales?.Correo ?? "N/A",
                    usuario.DatosPersonales?.Telefono ?? "N/A",
                    usuario.DatosPersonales?.Direccion ?? "N/A",
                    usuario.DatosPersonales?.Curp ?? "N/A",
                    usuario.DatosPersonales?.Rfc ?? "N/A",
                    usuario.DatosPersonales?.FechaNacimiento ?? DateTime.MinValue,
                    usuario.IdRol,
                    usuario.Rol?.Nombre ?? "Desconocido",
                    usuario.Estatus,
                    "*******"
                );
            }

            dgvListadoUsuario.DataSource = dt;
            ConfigurarDataGridView(); // Aplicar configuración de columnas
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchUsuario.Text.Trim();

            if (string.IsNullOrEmpty(searchText) || searchText == "Buscar Usuarios...")
            {
                MessageBox.Show("Por favor, ingrese un ID o Nombre de usuario para buscar.");
                return;
            }

            if (int.TryParse(searchText, out int idUsuario))
            {
                // Si se busca por ID
                BuscarUsuarioPorId(idUsuario);
            }
            else
            {
                // Si se busca por nombre
                BuscarUsuarioPorNombre(searchText);
            }
        }

        private void BuscarUsuarioPorId(int idUsuario)
        {
            UsuariosDataAccess usuarioDataAccess = new UsuariosDataAccess();
            List<Usuario> usuario = usuarioDataAccess.ObtenerTodosLosUsuarios();

            var usuariosEncontrados = usuario.Where(usr => usr.Id == idUsuario).ToList();

            if (usuariosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró el usuario con ese ID.");
            }
            else
            {
                MostrarUsuarios(usuariosEncontrados);
            }
        }

        private void BuscarUsuarioPorNombre(string nombreUsuario)
        {
            UsuariosDataAccess usuarioDataAccess = new UsuariosDataAccess();
            List<Usuario> usuario = usuarioDataAccess.ObtenerTodosLosUsuarios();

            var usuariosEncontrados = usuario
                .Where(usr => usr.DatosPersonales.NombreCompleto.Contains(nombreUsuario, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (usuariosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró el empleado con ese nombre.");
            }
            else
            {
                MostrarUsuarios(usuariosEncontrados);
            }
        }
    }
    
}




