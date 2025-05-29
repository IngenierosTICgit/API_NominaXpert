using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace NominaXpertCore.Utilities
{
    public static class ExcelExporter
    {
        public static void ExportToExcel(DataGridView dataGridView, string fileName)
        {
            Excel.Application excel = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excel = new Excel.Application();
                workbook = excel.Workbooks.Add();
                worksheet = workbook.Worksheets[1];
                worksheet.Name = "Reporte";

                // Encabezados
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Columns[i].Visible)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                        Range headerCell = worksheet.Cells[1, i + 1];
                        headerCell.Font.Bold = true;
                        headerCell.Interior.Color = ColorTranslator.ToOle(Color.SteelBlue);
                        headerCell.Font.Color = ColorTranslator.ToOle(Color.White);
                    }
                }

                // Datos
                int row = 2;
                foreach (DataGridViewRow dataRow in dataGridView.Rows)
                {
                    int col = 1;
                    foreach (DataGridViewCell cell in dataRow.Cells)
                    {
                        if (dataGridView.Columns[cell.ColumnIndex].Visible)
                        {
                            worksheet.Cells[row, col] = cell.Value;
                            col++;
                        }
                    }
                    row++;
                }

                // Ajustar ancho de columnas
                worksheet.Columns.AutoFit();

                // Aplicar bordes y formato
                Range dataRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[row - 1, dataGridView.Columns.Count]];
                dataRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                dataRange.Borders.Weight = XlBorderWeight.xlThin;

                // Alternar colores de filas
                for (int i = 2; i <= row - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Range rowRange = worksheet.Range[worksheet.Cells[i, 1], worksheet.Cells[i, dataGridView.Columns.Count]];
                        rowRange.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                    }
                }

                // Guardar el archivo
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();

                MessageBox.Show("Exportación a Excel completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Liberar recursos COM
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excel != null)
                {
                    excel.Quit();
                    Marshal.ReleaseComObject(excel);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
