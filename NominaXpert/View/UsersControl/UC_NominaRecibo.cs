using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NominaXpertCore.Controller;
using NominaXpertCore.Business;
using NominaXpertCore.Model;
using ControlEscolar.Utilities;
using NLog;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.Kernel.Exceptions;
using iText.IO.Font.Constants;
using NominaXpertCore.Utilities;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_NominaRecibo : UserControl
    {
        // Propiedad para almacenar el ID de la nómina
        public int IdNomina { get; set; }

        // Logger para la clase
        private static readonly Logger _logger = LoggingManager.GetLogger("NominaXpert.Controller.NominasController");

        // Controladores para las diferentes secciones
        private readonly NominasController _nominasController;
        private readonly BonificacionController _bonificacionController;
        private readonly DeduccionController _deduccionController;

        /// <summary>
        /// Constructor de la clase UC_NominaRecibo.
        /// </summary>
        /// <param name="idNomina"></param>
        public UC_NominaRecibo(int idNomina)
        {
            InitializeComponent();
            PoblaCombo();
            this.IdNomina = idNomina;

            _nominasController = new NominasController();
            _bonificacionController = new BonificacionController();
            _deduccionController = new DeduccionController();

            if (idNomina > 0)
                CargarRecibo();
            else
                MessageBox.Show("No se proporcionó una nómina válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PoblaCombo()
        {
            var metodosPago = new Dictionary<int, string>
    {
        { 1, "Transferencia" },
        { 2, "Efectivo" },
        { 3, "Cheque" }
    };

            cboMetodoPago.DataSource = new BindingSource(metodosPago, null);
            cboMetodoPago.DisplayMember = "Value";
            cboMetodoPago.ValueMember = "Key";
            cboMetodoPago.SelectedIndex = 0; // Por defecto Transferencia
        }

        /// <summary>
        /// Método para cargar los datos del recibo de nómina
        /// </summary>
        private void CargarRecibo()
        {
            try
            {
                // Obtener nómina
                var nomina = _nominasController.BuscarNominaPorId(IdNomina);

                if (nomina == null)
                {
                    MessageBox.Show("No se encontró la nómina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar datos de empleado
                lblNombreEmpleado.Text = nomina.NombreEmpleado;
                lblDepartamento.Text = nomina.DepartamentoEmpleado;
                lblRFC.Text = nomina.RfcEmpleado;
                lblIdEmpleado.Text = nomina.IdEmpleado.ToString();

                // Periodo de nómina
                lblFechaInicio.Text = nomina.FechaInicio.ToShortDateString();
                lblFechaFin.Text = nomina.FechaFin.ToShortDateString();
                lblEstado.Text = nomina.EstadoPago;

                // Obtener percepciones y deducciones
                var percepciones = _bonificacionController.ObtenerBonificacionesPorNomina(IdNomina);
                var deducciones = _deduccionController.ObtenerDeduccionesPorNomina(IdNomina);

                decimal totalPercepciones = percepciones.Sum(p => p.Monto);
                decimal totalDeducciones = deducciones.Sum(d => d.Monto);

                int idUsuario = 1; // ID fijo como en UC_NominaCalculo1

                // Después de obtener la nómina
                _logger.Info($"Fechas de nómina ID {IdNomina}: Inicio={nomina.FechaInicio.ToShortDateString()}, Fin={nomina.FechaFin.ToShortDateString()}");
                if (nomina.FechaInicio == nomina.FechaFin)
                {
                    _logger.Warn($"Fechas de inicio y fin son iguales: {nomina.FechaInicio.ToShortDateString()}. Esto puede causar que no se encuentren horas trabajadas.");
                }

                var jornadaController = new RegistroJornadaController();
                decimal horasTrabajadas = jornadaController.ConsultarTotalHorasTrabajadas(
                    nomina.IdEmpleado,
                    nomina.FechaInicio,
                    nomina.FechaFin,
                    idUsuario);

                // Log para depuración
                _logger.Info($"Horas trabajadas consultadas con idUsuario=1: {horasTrabajadas} para periodo {nomina.FechaInicio.ToShortDateString()} - {nomina.FechaFin.ToShortDateString()}");

                // Si no hay horas registradas, calcular basado en días laborables
                if (horasTrabajadas <= 0)
                {
                    int diasLaborables = CalcularDiasLaborables(nomina.FechaInicio, nomina.FechaFin);

                    // Si las fechas son iguales pero aún necesitamos calcular horas, asignar 8 horas (un día laboral)
                    if (diasLaborables <= 0)
                    {
                        horasTrabajadas = 8; // Un día laboral completo
                        _logger.Warn($"No hay días laborables en el periodo. Asignando 8 horas para un día de trabajo.");
                    }
                    else
                    {
                        horasTrabajadas = diasLaborables * 8;
                        _logger.Warn($"No se encontraron horas trabajadas para la nómina {IdNomina}. Calculando basado en {diasLaborables} días laborables: {horasTrabajadas} horas.");
                    }
                }

                // Calcular según la fórmula correcta
                decimal sueldoBase = nomina.SueldoBase;
                decimal sueldoPorDia = sueldoBase / 22m;
                decimal sueldoPorHora = sueldoPorDia / 8m;
                decimal sueldoPorHorasTrabajadas = sueldoPorHora * horasTrabajadas;

                // Cálculo del total neto
                decimal totalNeto = sueldoPorHorasTrabajadas + totalPercepciones - totalDeducciones;

                // Actualizar los controles de la interfaz
                lblTotalPercepciones.Text = totalPercepciones.ToString("C");
                lblTotalDeducciones.Text = totalDeducciones.ToString("C");
                lblSueldoBase.Text = sueldoBase.ToString("C");
                lblSueldoPorHorasTrabajadas.Text = sueldoPorHorasTrabajadas.ToString("C");
                lblTotalNeto.Text = totalNeto.ToString("C");

                // Imprimir valores para depuración
                _logger.Info($"Valores del cálculo: Sueldo Base={sueldoBase}, Horas={horasTrabajadas}, " +
                            $"Sueldo/Día={sueldoPorDia}, Sueldo/Hora={sueldoPorHora}, " +
                            $"Sueldo por Horas={sueldoPorHorasTrabajadas}, " +
                            $"Percepciones={totalPercepciones}, Deducciones={totalDeducciones}, " +
                            $"Total Neto={totalNeto}");

                // Monto en letras
                lblMontoLetras.Text = NominaNegocio.ConvertirNumeroALetras(totalNeto);

                // Validar estado de nómina
                if (nomina.EstadoPago == "Pagado")
                {
                    // Deshabilitar botones si ya está pagada
                    btnGenerarNómina.Visible = false;
                    btnRegresar.Visible = false;
                    lblMetodoPago.Visible = false;
                    cboMetodoPago.Visible = false;
                }
                else
                {
                    // Habilitar si no está pagada
                    btnGenerarNómina.Enabled = true;
                    btnRegresar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al cargar el recibo de nómina");
                MessageBox.Show($"Error al cargar el recibo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método auxiliar para calcular días laborables
        private int CalcularDiasLaborables(DateTime fechaInicio, DateTime fechaFin)
        {
            int diasLaborables = 0;
            for (DateTime fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasLaborables++;
                }
            }
            return diasLaborables;
        }
        /// <summary>
        /// Carga el recibo de nómina y lo muestra en el control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPDFReciboNomina_Click(object sender, EventArgs e)
        {
            PdfWriter writer = null;
            PdfDocument pdf = null;
            Document document = null;

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Guardar Recibo de Nómina",
                    FileName = $"ReciboNomina_{IdNomina}_{DateTime.Now:yyyyMMdd}.pdf"
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

                    writer = new PdfWriter(path);
                    pdf = new PdfDocument(writer);
                    document = new Document(pdf);

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
                    AddTableRow(mainTable, "Nombre:", lblNombreEmpleado.Text ?? "", regularFont);
                    AddTableRow(mainTable, "Departamento:", lblDepartamento.Text ?? "", regularFont);
                    AddTableRow(mainTable, "RFC:", lblRFC.Text ?? "", regularFont);
                    AddTableRow(mainTable, "ID Empleado:", lblIdEmpleado.Text ?? "", regularFont);

                    // Información de la nómina
                    AddTableHeader(mainTable, "Datos de la Nómina", boldFont);
                    AddTableRow(mainTable, "Fecha Inicio:", lblFechaInicio.Text ?? "", regularFont);
                    AddTableRow(mainTable, "Fecha Fin:", lblFechaFin.Text ?? "", regularFont);
                    AddTableRow(mainTable, "Estado:", lblEstado.Text ?? "", regularFont);

                    // Información de percepciones
                    AddTableHeader(mainTable, "Percepciones", boldFont);
                    AddTableRow(mainTable, "Sueldo Base:", lblSueldoBase.Text ?? "", regularFont);
                    AddTableRow(mainTable, "Sueldo por Horas:", lblSueldoPorHorasTrabajadas.Text ?? "", regularFont);
                    AddTableRow(mainTable, "Total Percepciones:", lblTotalPercepciones.Text ?? "", regularFont);

                    // Información de deducciones
                    AddTableHeader(mainTable, "Deducciones", boldFont);
                    AddTableRow(mainTable, "Total Deducciones:", lblTotalDeducciones.Text ?? "", regularFont);

                    // Información del total
                    AddTableHeader(mainTable, "Total Neto", boldFont);
                    AddTableRow(mainTable, "Monto Total:", lblTotalNeto.Text ?? "", regularFont);
                    AddTableRow(mainTable, "Monto en Letras:", lblMontoLetras.Text ?? "", regularFont);

                    // Agregar la tabla al documento
                    document.Add(mainTable);

                    // Pie de página
                    Paragraph footer = new Paragraph($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(regularFont)
                        .SetFontSize(10)
                        .SetMarginTop(20);

                    document.Add(footer);

                    // Cerrar el documento
                    document.Close();
                    document = null;
                    pdf.Close();
                    pdf = null;
                    writer.Close();
                    writer = null;

                    MessageBox.Show("El recibo de nómina ha sido generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al generar el PDF del recibo de nómina");
                MessageBox.Show($"Error al generar el PDF: {ex.Message}\n\nDetalles técnicos: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurar que todos los recursos se liberen correctamente
                if (document != null)
                {
                    try { document.Close(); } catch { }
                }
                if (pdf != null)
                {
                    try { pdf.Close(); } catch { }
                }
                if (writer != null)
                {
                    try { writer.Close(); } catch { }
                }
            }
        }

        private void AddTableHeader(Table table, string text, PdfFont font)
        {
            try
            {
                Cell cell = new Cell(1, 2)
                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                    .SetFont(font)
                    .SetPadding(5)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(text ?? ""));
                table.AddCell(cell);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al agregar encabezado de tabla: {text}");
                throw;
            }
        }

        private void AddTableRow(Table table, string label, string value, PdfFont font)
        {
            try
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
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al agregar fila de tabla: {label} - {value}");
                throw;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Crear un formulario de notificación temporal
            Form mensajeForm = new Form
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                Size = new System.Drawing.Size(350, 220),
                Text = "Información del sistema",
                ControlBox = false // Evita que se cierre manualmente
            };

            Label lblMensaje = new Label
            {
                Text = "Regresando a Deducciones...",
                AutoSize = false, //evita su crecimiento
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill //redimensiona al panel debajo
            };

            mensajeForm.Controls.Add(lblMensaje);
            mensajeForm.Show();

            // Configurar el temporizador para cerrar la ventana después de 2 segundos y cambiar de UC
            System.Timers.Timer timer = new System.Timers.Timer(2000);
            timer.Elapsed += (s, ev) =>
            {
                timer.Stop();
                mensajeForm.Invoke((MethodInvoker)delegate { mensajeForm.Close(); });

                // Ejecutar en el hilo principal
                this.Invoke((MethodInvoker)delegate //asistente solo ve y dile a chef y delega la tarea
                {
                    // Obtener el contenedor padre del UserControl actual
                    Control parent = this.Parent; //Quién es el padre?
                    if (parent != null)
                    {
                        // Remover el UserControl actual
                        parent.Controls.Remove(this);

                        // Crear una nueva instancia de UC_NominaRecibo
                        UC_NominaDeducciones ucRecibo = new UC_NominaDeducciones(this.IdNomina);
                        ucRecibo.Dock = DockStyle.Fill;

                        // Agregar el nuevo UserControl al mismo contenedor
                        parent.Controls.Add(ucRecibo);
                        parent.Controls.SetChildIndex(ucRecibo, 0); // Ponerlo al frente
                    }
                });
            };
            timer.Start();
        }

        private void btnGenerarNómina_Click(object sender, EventArgs e)
        {
            try
            {
                PagoController pagoController = new PagoController();

                // Validar que NO EXISTA PAGO ya para esta nómina
                if (pagoController.ExistePago(this.IdNomina))
                {
                    MessageBox.Show("Esta nómina ya fue pagada. No es posible generar otro pago.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Validar método de pago
                if (cboMetodoPago.SelectedItem == null || string.IsNullOrWhiteSpace(cboMetodoPago.Text))
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la nómina completa
                var nomina = _nominasController.BuscarNominaPorId(IdNomina);

                // Verificar si el sueldo base es menor al mínimo
                if (_nominasController.VerificarSueldoMenorMinimo(nomina.SueldoBase))
                {
                    decimal sueldoMinimo = _nominasController.ObtenerSueldoMinimo();
                    MessageBox.Show(
                        $"El sueldo base del empleado (${nomina.SueldoBase:N2}) es menor al sueldo mínimo establecido (${sueldoMinimo:N2}).\n\nNo es posible generar la nómina.",
                        "Error - Sueldo por debajo del mínimo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return; // No continuar con la generación de la nómina
                }

                // Verificar si el sueldo base es igual al mínimo (advertencia)
                if (_nominasController.VerificarSueldoIgualMinimo(nomina.SueldoBase))
                {
                    decimal sueldoMinimo = _nominasController.ObtenerSueldoMinimo();
                    DialogResult respuesta = MessageBox.Show(
                        $"El sueldo base del empleado (${nomina.SueldoBase:N2}) es exactamente igual al sueldo mínimo establecido.\n\n¿Desea continuar con la generación de la nómina?",
                        "Advertencia - Sueldo Mínimo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (respuesta == DialogResult.No)
                    {
                        return; // No continuar si el usuario elige no
                    }
                }


                // Consultar horas trabajadas usando el ID de usuario correcto
                int idUsuario = UsuarioSesion.UsuarioId;

                var jornadaController = new RegistroJornadaController();
                decimal horasTrabajadas = jornadaController.ConsultarTotalHorasTrabajadas(
                    nomina.IdEmpleado,
                    nomina.FechaInicio,
                    nomina.FechaFin,
                    idUsuario);

                // Si no hay horas registradas, usar un valor predeterminado
                if (horasTrabajadas <= 0)
                {
                    // Usamos 40 horas como valor por defecto (8 horas por 5 días)
                    horasTrabajadas = 40;
                    _logger.Warn($"No se encontraron horas trabajadas para la nómina {IdNomina}. Usando valor predeterminado de 40 horas.");
                }

                // Obtener percepciones y deducciones
                var percepciones = _bonificacionController.ObtenerBonificacionesPorNomina(IdNomina);
                var deducciones = _deduccionController.ObtenerDeduccionesPorNomina(IdNomina);
                decimal totalPercepciones = percepciones.Sum(p => p.Monto);
                decimal totalDeducciones = deducciones.Sum(d => d.Monto);

                // Calcular según la fórmula correcta
                decimal sueldoBase = nomina.SueldoBase;
                decimal sueldoPorDia = sueldoBase / 22m;
                decimal sueldoPorHora = sueldoPorDia / 8m;
                decimal sueldoPorHorasTrabajadas = sueldoPorHora * horasTrabajadas;

                // Nuevo cálculo del total neto
                decimal totalNeto = sueldoPorHorasTrabajadas + totalPercepciones - totalDeducciones;

                // Log para depuración
                _logger.Info($"Generación de pago: Sueldo Base={sueldoBase}, Horas={horasTrabajadas}, " +
                            $"Sueldo/Día={sueldoPorDia}, Sueldo/Hora={sueldoPorHora}, " +
                            $"Sueldo por Horas={sueldoPorHorasTrabajadas}, " +
                            $"Percepciones={totalPercepciones}, Deducciones={totalDeducciones}, " +
                            $"Total Neto={totalNeto}");

                // Crear objeto pago con el nuevo total calculado
                Pago nuevoPago = new Pago
                {
                    IdNomina = this.IdNomina,
                    FechaPago = DateTime.Now,
                    MontoTotal = totalNeto,
                    MontoLetras = NominaNegocio.ConvertirNumeroALetras(totalNeto),
                    MetodoPago = cboMetodoPago.Text,
                    Referencia = "Pago automático generado desde recibo de nómina"
                };

                // Registrar pago en la base de datos
                bool resultado = pagoController.RegistrarPago(nuevoPago);

                if (resultado)
                {
                    // Actualizar estado de nómina a "Pagado"
                    _logger.Info($"UC_NominaRecibo -> Se actualizará el estado de la nómina {this.IdNomina} a Pagado");

                    // Llamar al método con todos los parámetros
                    _nominasController.ActualizarEstadoPago(this.IdNomina, "Pagado", idUsuario);
                    _logger.Info($"UC_NominaRecibo -> Finalizó la actualización de la nómina {this.IdNomina} a Pagado");

                    // Refrescar la información visual del recibo para reflejar "Pagada"
                    CargarRecibo();

                    MessageBox.Show("El pago ha sido registrado correctamente. La nómina ha sido marcada como pagada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al generar la nómina");
                MessageBox.Show($"Error al generar la nómina: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}