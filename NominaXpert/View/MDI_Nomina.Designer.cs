namespace NominaXpertCore.View
{
    partial class MDI_Nomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Nomina));
            panelMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnAuditoria = new FontAwesome.Sharp.IconButton();
            btnConfig = new FontAwesome.Sharp.IconButton();
            btnSeguridad = new FontAwesome.Sharp.IconButton();
            btnReporte = new FontAwesome.Sharp.IconButton();
            btnCalculo = new FontAwesome.Sharp.IconButton();
            btnEmpleado = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            icontime = new FontAwesome.Sharp.IconPictureBox();
            lblfecha = new Label();
            lblhora = new Label();
            pictureBox1 = new PictureBox();
            horafecha = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icontime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(48, 51, 59);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnAuditoria);
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Controls.Add(btnSeguridad);
            panelMenu.Controls.Add(btnReporte);
            panelMenu.Controls.Add(btnCalculo);
            panelMenu.Controls.Add(btnEmpleado);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 903);
            panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(48, 51, 59);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.FromArgb(12, 215, 253);
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 32;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 20, 0);
            btnLogout.Size = new Size(220, 60);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.BackColor = Color.FromArgb(48, 51, 59);
            btnAuditoria.Cursor = Cursors.Hand;
            btnAuditoria.Dock = DockStyle.Top;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuditoria.ForeColor = Color.White;
            btnAuditoria.IconChar = FontAwesome.Sharp.IconChar.UsersViewfinder;
            btnAuditoria.IconColor = Color.FromArgb(12, 215, 253);
            btnAuditoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAuditoria.IconSize = 32;
            btnAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.Location = new Point(0, 500);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Padding = new Padding(10, 0, 20, 0);
            btnAuditoria.Size = new Size(220, 60);
            btnAuditoria.TabIndex = 7;
            btnAuditoria.Text = "Reportes de auditoría";
            btnAuditoria.TextAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAuditoria.UseVisualStyleBackColor = false;
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(48, 51, 59);
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfig.ForeColor = Color.White;
            btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnConfig.IconColor = Color.FromArgb(12, 215, 253);
            btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfig.IconSize = 32;
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(0, 440);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(10, 0, 20, 0);
            btnConfig.Size = new Size(220, 60);
            btnConfig.TabIndex = 6;
            btnConfig.Text = "Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSeguridad
            // 
            btnSeguridad.BackColor = Color.FromArgb(48, 51, 59);
            btnSeguridad.Cursor = Cursors.Hand;
            btnSeguridad.Dock = DockStyle.Top;
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeguridad.ForeColor = Color.White;
            btnSeguridad.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            btnSeguridad.IconColor = Color.FromArgb(12, 215, 253);
            btnSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeguridad.IconSize = 32;
            btnSeguridad.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeguridad.Location = new Point(0, 380);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Padding = new Padding(10, 0, 20, 0);
            btnSeguridad.Size = new Size(220, 60);
            btnSeguridad.TabIndex = 4;
            btnSeguridad.Text = "Seguridad y Usuarios";
            btnSeguridad.TextAlign = ContentAlignment.MiddleLeft;
            btnSeguridad.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSeguridad.UseVisualStyleBackColor = false;
            btnSeguridad.Click += btnSeguridad_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(48, 51, 59);
            btnReporte.Cursor = Cursors.Hand;
            btnReporte.Dock = DockStyle.Top;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporte.ForeColor = Color.White;
            btnReporte.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnReporte.IconColor = Color.FromArgb(12, 215, 253);
            btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporte.IconSize = 32;
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(0, 320);
            btnReporte.Name = "btnReporte";
            btnReporte.Padding = new Padding(10, 0, 20, 0);
            btnReporte.Size = new Size(220, 60);
            btnReporte.TabIndex = 3;
            btnReporte.Text = "Reportes";
            btnReporte.TextAlign = ContentAlignment.MiddleLeft;
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnCalculo
            // 
            btnCalculo.BackColor = Color.FromArgb(48, 51, 59);
            btnCalculo.Cursor = Cursors.Hand;
            btnCalculo.Dock = DockStyle.Top;
            btnCalculo.FlatAppearance.BorderSize = 0;
            btnCalculo.FlatStyle = FlatStyle.Flat;
            btnCalculo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculo.ForeColor = Color.White;
            btnCalculo.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            btnCalculo.IconColor = Color.FromArgb(12, 215, 253);
            btnCalculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculo.IconSize = 32;
            btnCalculo.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculo.Location = new Point(0, 260);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Padding = new Padding(10, 0, 20, 0);
            btnCalculo.Size = new Size(220, 60);
            btnCalculo.TabIndex = 2;
            btnCalculo.Text = "Cálculos y Recibos";
            btnCalculo.TextAlign = ContentAlignment.MiddleLeft;
            btnCalculo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculo.UseVisualStyleBackColor = false;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(48, 51, 59);
            btnEmpleado.Cursor = Cursors.Hand;
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleado.ForeColor = Color.White;
            btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            btnEmpleado.IconColor = Color.FromArgb(12, 215, 253);
            btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleado.IconSize = 32;
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(0, 200);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Padding = new Padding(10, 0, 20, 0);
            btnEmpleado.Size = new Size(220, 60);
            btnEmpleado.TabIndex = 1;
            btnEmpleado.Text = "Administración de Empleados";
            btnEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(48, 51, 59);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnDashboard.IconColor = Color.FromArgb(12, 215, 253);
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 32;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 20, 0);
            btnDashboard.Size = new Size(220, 60);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(48, 51, 59);
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10, 0, 20, 0);
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = Properties.Resources.NX_banner_logo;
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 112);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(24, 44, 65);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1262, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(24, 44, 65);
            btnMinimize.ForeColor = Color.Silver;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Silver;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 20;
            btnMinimize.Location = new Point(1152, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 20);
            btnMinimize.TabIndex = 4;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(24, 44, 65);
            btnMaximize.ForeColor = Color.Silver;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Silver;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 20;
            btnMaximize.Location = new Point(1190, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(22, 20);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(24, 44, 65);
            btnExit.ForeColor = Color.Silver;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnExit.IconColor = Color.Silver;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 20;
            btnExit.Location = new Point(1228, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(22, 20);
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(64, 33);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(51, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(24, 44, 65);
            iconCurrentChildForm.ForeColor = Color.FromArgb(12, 215, 253);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(12, 215, 253);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(18, 22);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(24, 44, 65);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1262, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(37, 41, 47);
            panelDesktop.Controls.Add(icontime);
            panelDesktop.Controls.Add(lblfecha);
            panelDesktop.Controls.Add(lblhora);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1262, 819);
            panelDesktop.TabIndex = 3;
            // 
            // icontime
            // 
            icontime.Anchor = AnchorStyles.None;
            icontime.BackColor = Color.FromArgb(37, 41, 47);
            icontime.ForeColor = Color.PowderBlue;
            icontime.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            icontime.IconColor = Color.PowderBlue;
            icontime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icontime.IconSize = 40;
            icontime.Location = new Point(440, 511);
            icontime.Name = "icontime";
            icontime.Size = new Size(40, 40);
            icontime.TabIndex = 5;
            icontime.TabStop = false;
            // 
            // lblfecha
            // 
            lblfecha.Anchor = AnchorStyles.None;
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfecha.ForeColor = Color.PowderBlue;
            lblfecha.Location = new Point(486, 510);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(97, 41);
            lblfecha.TabIndex = 3;
            lblfecha.Text = "label1";
            // 
            // lblhora
            // 
            lblhora.Anchor = AnchorStyles.None;
            lblhora.AutoSize = true;
            lblhora.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhora.ForeColor = Color.FromArgb(12, 215, 253);
            lblhora.Location = new Point(486, 410);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(194, 81);
            lblhora.TabIndex = 2;
            lblhora.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(486, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // MDI_Nomina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1482, 903);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MDI_Nomina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDI NOMINA";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icontime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnConfig;
        private FontAwesome.Sharp.IconButton btnSeguridad;
        private FontAwesome.Sharp.IconButton btnReporte;
        private FontAwesome.Sharp.IconButton btnCalculo;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private Label lblfecha;
        private Label lblhora;
        private System.Windows.Forms.Timer horafecha;
        private FontAwesome.Sharp.IconPictureBox icontime;
        private FontAwesome.Sharp.IconButton btnAuditoria;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}