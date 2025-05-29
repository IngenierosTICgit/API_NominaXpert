using NominaXpertCore.Business;
using NominaXpertCore.Controller;
using NominaXpertCore.Model;
using NominaXpertCore.View.UsersControl;
using NominaXpertCore.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;

namespace NominaXpertCore.View.Forms
{
    public partial class frmReportes : Form
    {
        public int IdNomina { get; set; }

        private readonly NominasController _nominasController;


        public frmReportes()
        {
            InitializeComponent();
            ConfigurarPermisos();
            _nominasController = new NominasController();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            InicializaVentanaCalculoRecibos();
            // Cargar las nóminas automáticamente al abrir el formulario
            CargarNominasPorDefecto();
            // Inicializar el ComboBox de estados de pago
            InicializarComboEstadosPago();
        }
        public void InicializaVentanaCalculoRecibos()
        {
        }

        private void InicializarComboEstadosPago()
        {
            cboEstadoDePago.Items.Clear();
            cboEstadoDePago.Items.Add("Todos");
            cboEstadoDePago.Items.Add("Pendiente");
            cboEstadoDePago.Items.Add("Pagado");
            cboEstadoDePago.SelectedIndex = 0;
        }

        private void btnPDFReciboNomina_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado alguna fila en el DataGridView
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una nómina para generar el recibo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el IdNomina de la fila seleccionada
                int idNomina = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_Nomina"].Value);

                // Obtener la nómina seleccionada
                var nomina = _nominasController.BuscarNominaPorId(idNomina);
                if (nomina == null)
                {
                    MessageBox.Show("No se encontró la información de la nómina seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Guardar Recibo de Nómina",
                    FileName = $"ReciboNomina_{idNomina}_{DateTime.Now:yyyyMMdd}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog.FileName;

                    // Validar que el directorio exista
                    string directory = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directory))
                    {
                        MessageBox.Show("El directorio seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validar que tengamos permisos de escritura
                    try
                    {
                        using (FileStream fs = File.Create(path, 1, FileOptions.DeleteOnClose))
                        {
                            // Si llegamos aquí, tenemos permisos de escritura
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se tiene permiso para escribir en la ubicación seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (PdfWriter writer = new PdfWriter(path))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        // Configurar fuentes
                        PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                        PdfFont regularFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                        // Encabezado
                        Paragraph header = new Paragraph("NominaXpert")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFont(boldFont)
                            .SetFontSize(24)
                            .SetMarginTop(20);

                        Paragraph subHeader = new Paragraph("Recibo de Nómina")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFont(boldFont)
                            .SetFontSize(18)
                            .SetMarginBottom(20);

                        document.Add(header);
                        document.Add(subHeader);

                        // Tabla principal
                        Table mainTable = new Table(2).UseAllAvailableWidth();
                        mainTable.SetMarginTop(20);
                        mainTable.SetMarginBottom(20);

                        // Información del empleado
                        AddTableHeader(mainTable, "Datos del Empleado", boldFont);
                        AddTableRow(mainTable, "Nombre:", nomina.NombreEmpleado ?? "", regularFont);
                        AddTableRow(mainTable, "Departamento:", nomina.DepartamentoEmpleado ?? "", regularFont);
                        AddTableRow(mainTable, "RFC:", nomina.RfcEmpleado ?? "", regularFont);
                        AddTableRow(mainTable, "ID Empleado:", nomina.IdEmpleado.ToString(), regularFont);

                        // Información de la nómina
                        AddTableHeader(mainTable, "Datos de la Nómina", boldFont);
                        AddTableRow(mainTable, "Fecha Inicio:", nomina.FechaInicio.ToShortDateString(), regularFont);
                        AddTableRow(mainTable, "Fecha Fin:", nomina.FechaFin.ToShortDateString(), regularFont);
                        AddTableRow(mainTable, "Estado:", nomina.EstadoPago ?? "", regularFont);

                        // Información de percepciones y deducciones
                        var bonificacionController = new BonificacionController();
                        var deduccionController = new DeduccionController();
                        var percepciones = bonificacionController.ObtenerBonificacionesPorNomina(idNomina);
                        var deducciones = deduccionController.ObtenerDeduccionesPorNomina(idNomina);
                        decimal totalPercepciones = percepciones.Sum(p => p.Monto);
                        decimal totalDeducciones = deducciones.Sum(d => d.Monto);

                        // Información de percepciones
                        AddTableHeader(mainTable, "Percepciones", boldFont);
                        AddTableRow(mainTable, "Sueldo Base:", nomina.SueldoBase.ToString("C"), regularFont);
                        AddTableRow(mainTable, "Total Percepciones:", totalPercepciones.ToString("C"), regularFont);

                        // Información de deducciones
                        AddTableHeader(mainTable, "Deducciones", boldFont);
                        AddTableRow(mainTable, "Total Deducciones:", totalDeducciones.ToString("C"), regularFont);

                        // Información del total
                        AddTableHeader(mainTable, "Total Neto", boldFont);
                        AddTableRow(mainTable, "Monto Total:", nomina.MontoTotal.ToString("C"), regularFont);
                        AddTableRow(mainTable, "Monto en Letras:", nomina.MontoLetras ?? "", regularFont);

                        // Agregar la tabla al documento
                        document.Add(mainTable);

                        // Pie de página
                        Paragraph footer = new Paragraph($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFont(regularFont)
                            .SetFontSize(10)
                            .SetMarginTop(20);

                        document.Add(footer);
                    }

                    MessageBox.Show("El recibo de nómina ha sido generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTableHeader(Table table, string text, PdfFont font)
        {
            Cell cell = new Cell(1, 2)
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetFont(font)
                .SetPadding(5)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph(text ?? ""));
            table.AddCell(cell);
        }

        private void AddTableRow(Table table, string label, string value, PdfFont font)
        {
            Cell labelCell = new Cell()
                .SetFont(font)
                .SetPadding(5)
                .Add(new Paragraph(label ?? ""));

            Cell valueCell = new Cell()
                .SetFont(font)
                .SetPadding(5)
                .Add(new Paragraph(value ?? ""));

            table.AddCell(labelCell);
            table.AddCell(valueCell);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string matricula = txtMatricula.Text.Trim();

                // Validar si la matrícula tiene el formato correcto solo si se proporcionó una
                if (!string.IsNullOrWhiteSpace(matricula) && !EmpleadosNegocio.EsMatriculaValido(matricula))
                {
                    MessageBox.Show("Matrícula inválida. Verifique el formato.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener las nóminas filtradas por matrícula
                List<NominaConsulta> nominas = _nominasController.BuscarNominasPorMatriculaYFechas(
                    matricula,
                    DateTime.MinValue, // No filtrar por fecha de inicio
                    DateTime.MinValue  // No filtrar por fecha de fin
                );

                // Limpiar el DataGridView
                dataGridView1.Rows.Clear();

                // Llenar el DataGridView con los resultados
                if (nominas.Count > 0)
                {
                    foreach (var nomina in nominas)
                    {
                        dataGridView1.Rows.Add(
                            nomina.IdNomina,
                            nomina.IdEmpleado,
                            nomina.FechaInicio.ToShortDateString(),
                            nomina.FechaFin.ToShortDateString(),
                            nomina.EstadoPago,
                            nomina.MontoTotal,
                            nomina.MontoLetras
                        );
                    }

                    // Actualizar el total de registros
                    lblTotaldeRegistros.Text = $"Total de Registros: {dataGridView1.Rows.Count}";
                }
                else
                {
                    MessageBox.Show("No se encontraron nóminas para la matrícula especificada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar nóminas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconVerNomina_Click(object sender, EventArgs e)
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
                    saveFileDialog.FileName = "Reporte_Nominas_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
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
        private void ConfigurarPermisos()
        {
            var controller = new UsuariosController();
            btnDatalleNomina.Enabled = controller.TienePermiso("NOM_VIEW");
            btnExportarPDF.Enabled = controller.TienePermiso("EXP_DATS");
            btnEsportarExcel.Enabled = controller.TienePermiso("EXP_DATS");

        }
        private void btnDatalleNomina_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado alguna fila en el DataGridView
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una nómina para ver el detalle.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el IdNomina de la fila seleccionada
                int idNomina = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_Nomina"].Value);

                // Navegar a UC_NominaRecibo y pasar el IdNomina
                UC_NominaRecibo ucRecibo = new UC_NominaRecibo(idNomina); // Usamos el idNomina de la fila seleccionada
                ucRecibo.Dock = DockStyle.Fill; // Aseguramos que el UserControl ocupe todo el espacio disponible

                // Obtener el contenedor principal del UserControl actual
                Control parent = this.Parent;
                if (parent != null)
                {
                    // Remover el UserControl actual
                    parent.Controls.Remove(this);

                    // Agregar el nuevo UserControl al mismo contenedor
                    parent.Controls.Add(ucRecibo);
                    parent.Controls.SetChildIndex(ucRecibo, 0); // Ponerlo al frente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar de vista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarNominasPorDefecto()
        {
            try
            {
                // Llamar al controlador para obtener las nóminas
                NominasController nominaController = new NominasController();
                List<NominaConsulta> nominas = nominaController.DesplegarNominas();

                // Llenar el DataGridView con las nóminas
                if (nominas.Count > 0)
                {
                    // Limpiar cualquier dato previo
                    dataGridView1.Rows.Clear();

                    // Configurar el DataGridView para permitir scroll horizontal
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoResizeColumns();

                    // Llenar el DataGridView con los datos de las nóminas
                    foreach (var nomina in nominas)
                    {
                        dataGridView1.Rows.Add(
                            nomina.IdNomina,
                            nomina.IdEmpleado,
                            nomina.FechaInicio.ToShortDateString(),
                            nomina.FechaFin.ToShortDateString(),
                            nomina.EstadoPago,
                            nomina.EstadoPago == "Pendiente" ? "Nulo" : (object)nomina.MontoTotal,
                            nomina.EstadoPago == "Pendiente" ? "Nulo" : (object)nomina.MontoLetras
                        );
                    }

                    // Actualizar el texto del total de registros
                    lblTotaldeRegistros.Text = $"Total de Registros: {dataGridView1.Rows.Count}";
                }
                else
                {
                    MessageBox.Show("No se encontraron nóminas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las nóminas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEsportarExcel_Click(object sender, EventArgs e)
        {
            //No poner nada
        }

        private void btnFiltrarFechas_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener las fechas seleccionadas
                DateTime fechaInicio = DTPFechaInicioNomina.Value;
                DateTime fechaFin = DTPFechaFinNomina.Value;

                // Validar que la fecha de fin no sea anterior a la fecha de inicio
                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener las nóminas filtradas por fechas
                List<NominaConsulta> nominas = _nominasController.BuscarNominasPorFechas(fechaInicio, fechaFin);

                // Limpiar el DataGridView
                dataGridView1.Rows.Clear();

                // Llenar el DataGridView con los resultados
                if (nominas.Count > 0)
                {
                    foreach (var nomina in nominas)
                    {
                        dataGridView1.Rows.Add(
                            nomina.IdNomina,
                            nomina.IdEmpleado,
                            nomina.FechaInicio.ToShortDateString(),
                            nomina.FechaFin.ToShortDateString(),
                            nomina.EstadoPago,
                            nomina.MontoTotal,
                            nomina.MontoLetras
                        );
                    }

                    // Actualizar el total de registros
                    lblTotaldeRegistros.Text = $"Total de Registros: {dataGridView1.Rows.Count}";
                }
                else
                {
                    MessageBox.Show("No se encontraron nóminas en el rango de fechas especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar nóminas por fechas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntLimpiarfiltrosfechas_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar el campo de matrícula
                txtMatricula.Clear();

                // Establecer las fechas a valores por defecto (por ejemplo, el mes actual)
                DTPFechaInicioNomina.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DTPFechaFinNomina.Value = DateTime.Now;

                // Limpiar el DataGridView
                dataGridView1.Rows.Clear();

                // Recargar todas las nóminas (consulta general)
                CargarNominasPorDefecto();

                MessageBox.Show("Filtros limpiados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar los filtros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEstado_Click_1(object sender, EventArgs e)
        {
            try
            {
                string estadoSeleccionado = cboEstadoDePago.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(estadoSeleccionado))
                {
                    MessageBox.Show("Por favor, seleccione un estado de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener todas las nóminas
                List<NominaConsulta> nominas = _nominasController.DesplegarNominas();

                // Filtrar por estado si no es "Todos"
                if (estadoSeleccionado != "Todos")
                {
                    nominas = nominas.Where(n => n.EstadoPago == estadoSeleccionado).ToList();
                }

                // Limpiar el DataGridView
                dataGridView1.Rows.Clear();

                // Llenar el DataGridView con los resultados
                if (nominas.Count > 0)
                {
                    foreach (var nomina in nominas)
                    {
                        dataGridView1.Rows.Add(
                            nomina.IdNomina,
                            nomina.IdEmpleado,
                            nomina.FechaInicio.ToShortDateString(),
                            nomina.FechaFin.ToShortDateString(),
                            nomina.EstadoPago,
                            nomina.EstadoPago == "Pendiente" ? "Nulo" : (object)nomina.MontoTotal,
                            nomina.EstadoPago == "Pendiente" ? "Nulo" : (object)nomina.MontoLetras
                        );
                    }

                    // Actualizar el total de registros
                    lblTotaldeRegistros.Text = $"Total de Registros: {dataGridView1.Rows.Count}";
                }
                else
                {
                    MessageBox.Show("No se encontraron nóminas con el estado seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar nóminas por estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
