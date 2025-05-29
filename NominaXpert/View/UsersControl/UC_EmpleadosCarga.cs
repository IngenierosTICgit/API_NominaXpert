using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaXpertCore.View.UsersControl
{
    public partial class UC_EmpleadosCarga : UserControl
    {
        public UC_EmpleadosCarga()
        {
            InitializeComponent();
            lbltext1.Text = string.Join(Environment.NewLine, new string[]
            {
                "1. nombre (obligatorio): Nombre completo del empleado",
                "2. email (obligatorio): Correo electrónico del empleado",
                "3. telefono: Número de teléfono",
                "4. posicion (obligatorio): Cargo o puesto",
                "5. departamento (obligatorio): Departamento",
                "6. fecha_inicio (obligatorio): Fecha de inicio (YYYY-MM-DD)",
                "7. salario: Salario base",
                "8. supervisor_id: ID del supervisor"
            });
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            OPFArchivo.Title = "Selecciona el archivo de Excel";
            OPFArchivo.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //Filtro de archivos
            OPFArchivo.FilterIndex = 1; //El primer filtro es el que se muestra por default
            OPFArchivo.RestoreDirectory = true; //Recuerda la ultima carpeta abierta

            if (OPFArchivo.ShowDialog() == DialogResult.OK)
            {
                string filePath = OPFArchivo.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".xls" || extension == ".xlsx")
                {
                    //Cargar el archivo
                    MessageBox.Show("El archivo " + filePath + " es válido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo seleccionado no es un archivo de Excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
