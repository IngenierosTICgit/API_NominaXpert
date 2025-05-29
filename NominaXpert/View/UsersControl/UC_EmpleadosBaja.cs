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
    public partial class UC_EmpleadosBaja : UserControl
    {
        public UC_EmpleadosBaja()
        {
            InitializeComponent();
        }

        private void UC_EmpleadosBaja_Load(object sender, EventArgs e)
        {
            InicializaVentanaEmpleadoBaja();
        }


        public void InicializaVentanaEmpleadoBaja()
        {
            PoblaComboBaja();

        }

        private void PoblaComboBaja()
        {
            //Crear un diccionario de valores
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
            {
                { 1, "Renuncia Voluntaria" },
                { 0, "Despido" },
                { 2, "Jubilación" },
                { 3, "Fin de Contrato" },
                { 4, "Otro" }
            };
            //Asignar el diccionario al combo
            cboBaja.DataSource = new BindingSource(list_estatus, null);
            cboBaja.DisplayMember = "Value";
            cboBaja.ValueMember = "Key";

            cboBaja.SelectedValue = 1;
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDetalleBaja.Text == "Detalles adicionales sobre la baja")
            {
                txtDetalleBaja.Text = "";
                txtDetalleBaja.ForeColor = Color.White;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDetalleBaja.Text == "")
            {
                txtDetalleBaja.Text = "Detalles adicionales sobre la baja";
                txtDetalleBaja.ForeColor = Color.LightGray;
            }
        }

        private void txtSearchEmpleado_Enter(object sender, EventArgs e)
        {
            if (txtSearchEmpleado.Text == "Buscar empleado")
            {
                txtSearchEmpleado.Text = "";
                txtSearchEmpleado.ForeColor = Color.White;
            }
        }

        private void txtSearchEmpleado_Leave(object sender, EventArgs e)
        {
            if (txtSearchEmpleado.Text == "")
            {
                txtSearchEmpleado.Text = "Buscar empleado";
                txtSearchEmpleado.ForeColor = Color.LightGray;
            }
        }

        private void btnProcesarBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
