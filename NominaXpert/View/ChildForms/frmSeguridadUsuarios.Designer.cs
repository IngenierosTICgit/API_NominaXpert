namespace NominaXpertCore.View.Forms
{
    partial class frmSeguridadUsuarios
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
            panelBar = new Panel();
            ibtnBajaRoles = new FontAwesome.Sharp.IconButton();
            ibtnAltaRol = new FontAwesome.Sharp.IconButton();
            btnRolesPermisosBar = new FontAwesome.Sharp.IconButton();
            btnAltaBar = new FontAwesome.Sharp.IconButton();
            btnListadoBar = new FontAwesome.Sharp.IconButton();
            panelContainer = new Panel();
            panelBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.Controls.Add(ibtnBajaRoles);
            panelBar.Controls.Add(ibtnAltaRol);
            panelBar.Controls.Add(btnRolesPermisosBar);
            panelBar.Controls.Add(btnAltaBar);
            panelBar.Controls.Add(btnListadoBar);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1262, 67);
            panelBar.TabIndex = 2;
            // 
            // ibtnBajaRoles
            // 
            ibtnBajaRoles.BackColor = Color.FromArgb(48, 51, 59);
            ibtnBajaRoles.Cursor = Cursors.Hand;
            ibtnBajaRoles.FlatAppearance.BorderSize = 0;
            ibtnBajaRoles.FlatStyle = FlatStyle.Flat;
            ibtnBajaRoles.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnBajaRoles.ForeColor = Color.White;
            ibtnBajaRoles.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            ibtnBajaRoles.IconColor = Color.FromArgb(12, 215, 253);
            ibtnBajaRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBajaRoles.IconSize = 32;
            ibtnBajaRoles.Location = new Point(784, 4);
            ibtnBajaRoles.Name = "ibtnBajaRoles";
            ibtnBajaRoles.Padding = new Padding(10, 0, 20, 0);
            ibtnBajaRoles.Size = new Size(159, 61);
            ibtnBajaRoles.TabIndex = 14;
            ibtnBajaRoles.Text = "Baja Roles";
            ibtnBajaRoles.TextAlign = ContentAlignment.MiddleLeft;
            ibtnBajaRoles.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnBajaRoles.UseVisualStyleBackColor = false;
            ibtnBajaRoles.Click += ibtnBajaRoles_Click;
            // 
            // ibtnAltaRol
            // 
            ibtnAltaRol.BackColor = Color.FromArgb(48, 51, 59);
            ibtnAltaRol.Cursor = Cursors.Hand;
            ibtnAltaRol.FlatAppearance.BorderSize = 0;
            ibtnAltaRol.FlatStyle = FlatStyle.Flat;
            ibtnAltaRol.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnAltaRol.ForeColor = Color.White;
            ibtnAltaRol.IconChar = FontAwesome.Sharp.IconChar.File;
            ibtnAltaRol.IconColor = Color.FromArgb(12, 215, 253);
            ibtnAltaRol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAltaRol.IconSize = 32;
            ibtnAltaRol.Location = new Point(618, 6);
            ibtnAltaRol.Name = "ibtnAltaRol";
            ibtnAltaRol.Padding = new Padding(10, 0, 20, 0);
            ibtnAltaRol.Size = new Size(160, 61);
            ibtnAltaRol.TabIndex = 12;
            ibtnAltaRol.Text = "Alta Roles";
            ibtnAltaRol.TextAlign = ContentAlignment.MiddleLeft;
            ibtnAltaRol.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnAltaRol.UseVisualStyleBackColor = false;
            ibtnAltaRol.Click += ibtnAltaRol_Click;
            // 
            // btnRolesPermisosBar
            // 
            btnRolesPermisosBar.BackColor = Color.FromArgb(48, 51, 59);
            btnRolesPermisosBar.Cursor = Cursors.Hand;
            btnRolesPermisosBar.FlatAppearance.BorderSize = 0;
            btnRolesPermisosBar.FlatStyle = FlatStyle.Flat;
            btnRolesPermisosBar.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRolesPermisosBar.ForeColor = Color.White;
            btnRolesPermisosBar.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            btnRolesPermisosBar.IconColor = Color.FromArgb(12, 215, 253);
            btnRolesPermisosBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRolesPermisosBar.IconSize = 32;
            btnRolesPermisosBar.Location = new Point(420, 3);
            btnRolesPermisosBar.Name = "btnRolesPermisosBar";
            btnRolesPermisosBar.Padding = new Padding(10, 0, 20, 0);
            btnRolesPermisosBar.Size = new Size(178, 61);
            btnRolesPermisosBar.TabIndex = 10;
            btnRolesPermisosBar.Text = "Listado Roles";
            btnRolesPermisosBar.TextAlign = ContentAlignment.MiddleLeft;
            btnRolesPermisosBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRolesPermisosBar.UseVisualStyleBackColor = false;
            btnRolesPermisosBar.Click += btnRolesPermisosBar_Click;
            // 
            // btnAltaBar
            // 
            btnAltaBar.BackColor = Color.FromArgb(48, 51, 59);
            btnAltaBar.Cursor = Cursors.Hand;
            btnAltaBar.FlatAppearance.BorderSize = 0;
            btnAltaBar.FlatStyle = FlatStyle.Flat;
            btnAltaBar.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAltaBar.ForeColor = Color.White;
            btnAltaBar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnAltaBar.IconColor = Color.FromArgb(12, 215, 253);
            btnAltaBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAltaBar.IconSize = 32;
            btnAltaBar.Location = new Point(-2, 4);
            btnAltaBar.Name = "btnAltaBar";
            btnAltaBar.Padding = new Padding(10, 0, 20, 0);
            btnAltaBar.Size = new Size(206, 61);
            btnAltaBar.TabIndex = 6;
            btnAltaBar.Text = "Alta Usuarios";
            btnAltaBar.TextAlign = ContentAlignment.MiddleLeft;
            btnAltaBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAltaBar.UseVisualStyleBackColor = false;
            btnAltaBar.Click += btnAltaBar_Click;
            // 
            // btnListadoBar
            // 
            btnListadoBar.BackColor = Color.FromArgb(48, 51, 59);
            btnListadoBar.Cursor = Cursors.Hand;
            btnListadoBar.FlatAppearance.BorderSize = 0;
            btnListadoBar.FlatStyle = FlatStyle.Flat;
            btnListadoBar.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListadoBar.ForeColor = Color.White;
            btnListadoBar.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            btnListadoBar.IconColor = Color.FromArgb(12, 215, 253);
            btnListadoBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoBar.IconSize = 32;
            btnListadoBar.Location = new Point(210, 4);
            btnListadoBar.Name = "btnListadoBar";
            btnListadoBar.Padding = new Padding(10, 0, 20, 0);
            btnListadoBar.Size = new Size(204, 61);
            btnListadoBar.TabIndex = 7;
            btnListadoBar.Text = "Listado Usuarios";
            btnListadoBar.TextAlign = ContentAlignment.MiddleLeft;
            btnListadoBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoBar.UseVisualStyleBackColor = false;
            btnListadoBar.Click += btnListadoBar_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(37, 41, 47);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 67);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1262, 702);
            panelContainer.TabIndex = 3;
            // 
            // frmSeguridadUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 52, 55);
            ClientSize = new Size(1262, 769);
            Controls.Add(panelContainer);
            Controls.Add(panelBar);
            Name = "frmSeguridadUsuarios";
            Text = "Seguridad y Usuarios";
            panelBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBar;
        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnRolesPermisosBar;
        private FontAwesome.Sharp.IconButton btnAltaBar;
        private FontAwesome.Sharp.IconButton btnListadoBar;
        private FontAwesome.Sharp.IconButton ibtnBajaRoles;
        private FontAwesome.Sharp.IconButton ibtnAltaRol;
    }
}