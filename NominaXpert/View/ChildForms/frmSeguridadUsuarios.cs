using FontAwesome.Sharp;
using NominaXpertCore.Controller;
using NominaXpertCore.Utilities;
using NominaXpertCore.View.UsersControl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NominaXpertCore.View.Forms
{
    public partial class frmSeguridadUsuarios : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmSeguridadUsuarios()
        {
            InitializeComponent();
            CrearBordeBoton();
            CargarUserControlInicial();
            ConfigurarPermisos();
        }


        private void CrearBordeBoton()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(100, 3);
            leftBorderBtn.Visible = false;
            this.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(59, 62, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Size = new Size(currentBtn.Width, 3);
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y + currentBtn.Height);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(48, 51, 59);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(12, 215, 253);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void CargarUserControlInicial()
        {
            UC_UsuariosAlta uc = new UC_UsuariosAlta();
            addUsersControl(uc);
        }

        private void addUsersControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnAltaBar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(12, 215, 253));
            addUsersControl(new UC_UsuariosAlta());
        }

        private void btnListadoBar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(12, 215, 253));
            addUsersControl(new UC_UsuariosListado());
        }

        private void btnBajaBar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(12, 215, 253));
            addUsersControl(new UC_UsuariosBaja());
        }

        private void btnRolesPermisosBar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(12, 215, 253));
            addUsersControl(new UC_UsuariosRolPermiso());
        }

        private void ibtnAltaRol_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(12, 215, 253));
            addUsersControl(new UC_RolesAlta());
        }

        private void ibtnBajaRoles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(12, 215, 253));
            addUsersControl(new UC_RolesBaja());
        }
        private void frmSeguridadUsuarios_Load(object sender, EventArgs e)
        {

        }
        private void ConfigurarPermisos()
        {
            var controller = new UsuariosController();

            btnAltaBar.Enabled = controller.TienePermiso("USR_ADD");
            btnListadoBar.Enabled = controller.TienePermiso("USR_VIEW");
            btnRolesPermisosBar.Enabled = controller.TienePermiso("ROL_VIEW");
            ibtnAltaRol.Enabled = controller.TienePermiso("ROL_ADD");
            ibtnBajaRoles.Enabled = controller.TienePermiso("ROL_EDIT");
        }
    }
}
