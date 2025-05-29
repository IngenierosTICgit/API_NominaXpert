using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FontAwesome.Sharp; // Librería para los iconos
using NominaXpertCore.Business;
using NominaXpertCore.Controller;

namespace NominaXpertCore.View
{
    public partial class MDI_Nomina : Form
    {

        //Fields - Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public MDI_Nomina()
        {

            InitializeComponent();
            //ConfigurarPermisos();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ConfigurarPermisos();
        }

        //Structs
        private struct RGBColors
        {

            public static Color changeColor = Color.FromArgb(12, 215, 253);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(59, 62, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
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

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }

        //Reset
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(12, 215, 253);
            lblTitleChildForm.Text = "Home";
        }

        //Events

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new Forms.frmDashboard());

        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new Forms.frmAdminEmpleados());

        }
        private void btnCalculo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new Forms.frmCalculoRecibos());
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new Forms.frmReportes());
        }
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new Forms.frmSeguridadUsuarios());
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new Forms.frmConfiguracion());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Remove transparent border in maximized state
        private void FormMDI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.changeColor);
            OpenChildForm(new ChildForms.frmReporteAuditorias());
        }

        private void ConfigurarPermisos()
        {
            var controller = new UsuariosController();
            btnEmpleado.Enabled = controller.TienePermiso("EMP_VIEW");
            btnCalculo.Enabled = controller.TienePermiso("NOM_EDIT");
            btnReporte.Enabled = controller.TienePermiso("NOM_HIST");
            btnSeguridad.Enabled = controller.TienePermiso("USR_VIEW");
            btnConfig.Enabled = controller.TienePermiso("CNF_SIST");
            if (controller.TienePermiso("AUDIT_VIEW")||controller.TienePermiso("AUDIT_AUTH"))
                btnAuditoria.Enabled = true;
            else 
                btnAuditoria.Enabled = false;
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar sesión",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cerrar formularios hijos abiertos
                foreach (Form child in this.MdiChildren)
                {
                    child.Close();
                }

                // Ocultar el MDI antes de volver al Login
                this.Hide();

                // Abrir el Login nuevamente
                View.Forms.Login loginForm = new View.Forms.Login();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    OpenChildForm(new Forms.frmDashboard());
                    this.Show();
                    ConfigurarPermisos();
                    Reset();
                    
                }
                else
                {
                    // Si el usuario cancela el login, cerrar la aplicación
                    Application.Exit();
                }
            }
        }
    }
}

        