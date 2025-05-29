using NominaXpertCore.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NominaXpertCore.Model;
using NominaXpertCore.Utilities;

namespace NominaXpertCore.View.ChildForms
{
    public partial class frmReporteAuditorias : Form
    {

        private readonly AuditoriasController _auditoriasController;

        public frmReporteAuditorias()
        {
            InitializeComponent();
            _auditoriasController = new AuditoriasController();

        }

        private void fmReporteAuditorias_Load(object sender, EventArgs e)
        {
            CargarTiposDeAccion(); // Cargar todos los tipos de acción
            CargarAuditorias(); // Cargar todas las auditorías


        }

        private void CargarTiposDeAccion()
        {
            // Limpiar los valores previos si es necesario
            cboTipoAccion.Items.Clear();

            // Agregar los tipos de acción manualmente
            cboTipoAccion.Items.Add("alta nómina");
            cboTipoAccion.Items.Add("edición nómina");
            cboTipoAccion.Items.Add("alta bonificación");
            cboTipoAccion.Items.Add("baja bonificación");
            cboTipoAccion.Items.Add("edición bonificación");
            cboTipoAccion.Items.Add("alta deducción");
            cboTipoAccion.Items.Add("baja deducción");
            cboTipoAccion.Items.Add("edición deducción");
            // Agregar los nuevos tipos de acción para usuarios
            cboTipoAccion.Items.Add("alta usuario");
            cboTipoAccion.Items.Add("edición usuario");

            cboTipoAccion.SelectedIndex = -1; // Por defecto seleccionar el primer item
        }

        private void CargarAuditorias(int idUsuario = 0, string accion = "")
        {
            try
            {
                // Obtener todas las auditorías si no se pasa un filtro
                List<Auditoria> auditorias;
                if (idUsuario > 0 || !string.IsNullOrWhiteSpace(accion))
                {
                    auditorias = _auditoriasController.ObtenerAuditoriasPorFiltro(idUsuario, accion);
                }
                else
                {
                    auditorias = _auditoriasController.ObtenerTodasLasAuditorias();
                }

                // Mostrar los datos en la tabla
                dataGridView1.Rows.Clear();
                foreach (var auditoria in auditorias)
                {
                    // Si 'fecha' y 'hora' son parte de tu auditoría y necesitas combinar ambos campos
                    DateTime fechaCompleta = auditoria.Fecha.Add(auditoria.Hora); // Combina fecha + hora

                    dataGridView1.Rows.Add(
                        auditoria.Id,
                        auditoria.IdUsuario,
                        auditoria.Accion,
                        auditoria.DetalleAccion,
                        auditoria.Fecha.ToString("yyyy-MM-dd"),  // Muestra la fecha
                        auditoria.IpAcceso,
                        auditoria.NombreEquipo,
                        fechaCompleta.ToString("HH:mm:ss") // Muestra solo la hora combinada
                    );
                }

                // Actualizar el label con el total de registros
                label4.Text = $"Total de Registros: {dataGridView1.Rows.Count - 1}";

                // Ajustar las columnas automáticamente para que se ajusten al contenido
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Ajustar el tamaño de la columna Hora si es necesario para que no se sobrecargue visualmente
                dataGridView1.Columns["Hora"].Width = 120;

                // Asegurarse de que se muestre el scroll horizontal si es necesario
                dataGridView1.ScrollBars = ScrollBars.Both; // Asegura que se habilite el scroll horizontal y vertical

                // Si las columnas son muchas, asegúrate de que el scroll horizontal se pueda usar
                if (dataGridView1.ColumnCount > 0)
                {
                    dataGridView1.HorizontalScrollingOffset = 0; // Restablecer el desplazamiento horizontal al inicio
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las auditorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            // Limpiar los filtros
            txtSearchTable.Clear();
            cboTipoAccion.SelectedIndex = -1; // Dejar el ComboBox vacío

            // Recargar las auditorías sin filtros
            CargarAuditorias();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializar variables
                int idUsuario = 0;
                string tipoAccion = cboTipoAccion.SelectedItem?.ToString() ?? "";

                // Verificar explícitamente si el texto está completamente vacío después de eliminar espacios
                string idText = txtSearchTable.Text.Trim();

                // Enfoque diferente: si hay texto, intenta convertirlo. Si no hay texto, usa 0.
                if (idText.Length > 0)
                {
                    if (!int.TryParse(idText, out idUsuario))
                    {
                        MessageBox.Show("El ID de usuario debe ser un número válido.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSearchTable.Clear(); // Limpia el campo
                        txtSearchTable.Focus();
                        return;
                    }
                }

                // Realizar la búsqueda con los valores actuales
                CargarAuditorias(idUsuario, tipoAccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSearchTable_Enter(object sender, EventArgs e)
        {
            if (txtSearchTable.Text == "Buscar ID usuario...")
            {
                txtSearchTable.Text = "";
                txtSearchTable.ForeColor = Color.White;
            }
        }

        private void txtSearchTable_Leave(object sender, EventArgs e)
        {
            if (txtSearchTable.Text == "")
            {
                txtSearchTable.Text = "Buscar ID usuario...";
                txtSearchTable.ForeColor = Color.LightGray;
            }
        }

        private void btnEsportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Guardar archivo Excel";
                    saveFileDialog.FileName = "Reporte_Auditorias_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveFileDialog.OverwritePrompt = true;
                    saveFileDialog.ValidateNames = true;
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.DefaultExt = "xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Verificar si el directorio existe
                        string directory = Path.GetDirectoryName(saveFileDialog.FileName);
                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        // Verificar si el archivo está en uso
                        if (File.Exists(saveFileDialog.FileName))
                        {
                            try
                            {
                                using (FileStream fs = File.Open(saveFileDialog.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                                {
                                    fs.Close();
                                }
                            }
                            catch (IOException)
                            {
                                MessageBox.Show("El archivo está siendo utilizado por otro programa. Por favor, ciérrelo e intente nuevamente.", 
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        ExcelExporter.ExportToExcel(dataGridView1, saveFileDialog.FileName);
                        MessageBox.Show("Archivo Excel exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            // Obtener las fechas desde los DateTimePicker
            DateTime fechaInicio = DTPFechaInicio.Value.Date;
            DateTime fechaFin = DTPFechaFin.Value.Date;

            // Llamar al controlador para obtener las auditorías filtradas por fechas
            List<Auditoria> auditorias = _auditoriasController.ObtenerAuditoriasPorFechas(fechaInicio, fechaFin);

            // Mostrar las auditorías en la tabla
            MostrarAuditoriasEnTabla(auditorias);
        }


        private void MostrarAuditoriasEnTabla(List<Auditoria> auditorias)
        {
            // Limpiar las filas previas
            dataGridView1.Rows.Clear();

            // Añadir las auditorías a la tabla
            foreach (var auditoria in auditorias)
            {
                DateTime fechaCompleta = auditoria.Fecha.Add(auditoria.Hora); // Combina fecha + hora
                dataGridView1.Rows.Add(
                    auditoria.Id,
                    auditoria.IdUsuario,
                    auditoria.Accion,
                    auditoria.DetalleAccion,
                    auditoria.Fecha.ToString("yyyy-MM-dd"),
                    auditoria.IpAcceso,
                    auditoria.NombreEquipo,
                    fechaCompleta.ToString("HH:mm:ss")
                );
            }

            // Actualizar el total de registros
            label4.Text = $"Total de Registros: {dataGridView1.Rows.Count - 1}";

            // Ajustar columnas y habilitar desplazamiento si es necesario
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Columns["Hora"].Width = 120;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }
    }
}
