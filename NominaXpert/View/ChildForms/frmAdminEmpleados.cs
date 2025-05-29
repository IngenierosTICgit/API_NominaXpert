using NominaXpertCore.Controller;
using NominaXpertCore.Utilities;
using NominaXpertCore.View.UsersControl;

namespace NominaXpertCore.View.Forms
{
    public partial class frmAdminEmpleados : Form
    {
        public frmAdminEmpleados()
        {
            InitializeComponent();
            Formas.InitializePanel(panelBar); // Inicializa el borde izquierdo en el panel
            CargarUserControlInicial();
            ConfigurarPermisos();
        }        
        private void CargarUserControlInicial()
        {
            UC_EmpleadosListado uc = new UC_EmpleadosListado();
            addUsersControl(uc); // Usamos el mismo método que para los botones
        }
        private void addUsersControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        //private void btnRegistroBar_Click(object sender, EventArgs e)
        //{
        //    UC_EmpleadosRegistro uc = new UC_EmpleadosRegistro();
        //    Utilities.Formas.ActivateButton(sender, Formas.RGBColors.ChangeColor);
        //    addUsersControl(uc);
        //}

        private void btnListadoBar_Click(object sender, EventArgs e)
        {
            UC_EmpleadosListado uc = new UC_EmpleadosListado();
            Utilities.Formas.ActivateButton(sender, Formas.RGBColors.ChangeColor);
            addUsersControl(uc);
        }
        //private void btnEditBar_Click(object sender, EventArgs e)
        //{
        //    UC_EmpleadosEditar uc = new UC_EmpleadosEditar();
        //    Utilities.Formas.ActivateButton(sender, Formas.RGBColors.ChangeColor);
        //    addUsersControl(uc);
        //}

        //private void btnBajaBar_Click(object sender, EventArgs e)
        //{
        //    UC_EmpleadosBaja uc = new UC_EmpleadosBaja();
        //    Utilities.Formas.ActivateButton(sender, Formas.RGBColors.ChangeColor);
        //    addUsersControl(uc);
        //}

        private void btnCargaBar_Click(object sender, EventArgs e)
        {
            UC_EmpleadosCarga uc = new UC_EmpleadosCarga();
            Utilities.Formas.ActivateButton(sender, Formas.RGBColors.ChangeColor);
            addUsersControl(uc);
        }
        private void ConfigurarPermisos()
        {
            var controller = new UsuariosController();
            btnListadoBar.Enabled = controller.TienePermiso("EMP_VIEW");
            btnCargaBar.Enabled = controller.TienePermiso("CRG_MASV");
        }
    }
}
