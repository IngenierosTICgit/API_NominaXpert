namespace NominaXpertCore.View.Forms
{
    partial class frmAdminEmpleados
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
            btnCargaBar = new FontAwesome.Sharp.IconButton();
            btnListadoBar = new FontAwesome.Sharp.IconButton();
            panelContainer = new Panel();
            panelBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.FromArgb(48, 51, 59);
            panelBar.Controls.Add(btnCargaBar);
            panelBar.Controls.Add(btnListadoBar);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1262, 64);
            panelBar.TabIndex = 2;
            // 
            // btnCargaBar
            // 
            btnCargaBar.Cursor = Cursors.Hand;
            btnCargaBar.FlatAppearance.BorderSize = 0;
            btnCargaBar.FlatStyle = FlatStyle.Flat;
            btnCargaBar.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargaBar.ForeColor = Color.White;
            btnCargaBar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnCargaBar.IconColor = Color.FromArgb(12, 215, 253);
            btnCargaBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCargaBar.IconSize = 32;
            btnCargaBar.Location = new Point(136, 3);
            btnCargaBar.Name = "btnCargaBar";
            btnCargaBar.Padding = new Padding(10, 0, 20, 0);
            btnCargaBar.Size = new Size(186, 61);
            btnCargaBar.TabIndex = 4;
            btnCargaBar.Text = "Carga Masiva";
            btnCargaBar.TextAlign = ContentAlignment.MiddleLeft;
            btnCargaBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCargaBar.UseVisualStyleBackColor = false;
            btnCargaBar.Click += btnCargaBar_Click;
            // 
            // btnListadoBar
            // 
            btnListadoBar.Cursor = Cursors.Hand;
            btnListadoBar.FlatAppearance.BorderSize = 0;
            btnListadoBar.FlatStyle = FlatStyle.Flat;
            btnListadoBar.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListadoBar.ForeColor = Color.White;
            btnListadoBar.IconChar = FontAwesome.Sharp.IconChar.UsersLine;
            btnListadoBar.IconColor = Color.FromArgb(12, 215, 253);
            btnListadoBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListadoBar.IconSize = 32;
            btnListadoBar.Location = new Point(3, 3);
            btnListadoBar.Name = "btnListadoBar";
            btnListadoBar.Padding = new Padding(10, 0, 20, 0);
            btnListadoBar.Size = new Size(141, 61);
            btnListadoBar.TabIndex = 1;
            btnListadoBar.Text = "Listado";
            btnListadoBar.TextAlign = ContentAlignment.MiddleLeft;
            btnListadoBar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListadoBar.UseVisualStyleBackColor = false;
            btnListadoBar.Click += btnListadoBar_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelContainer.Location = new Point(0, 64);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(10, 0, 20, 0);
            panelContainer.Size = new Size(1262, 705);
            panelContainer.TabIndex = 3;
            // 
            // frmAdminEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            ClientSize = new Size(1262, 769);
            Controls.Add(panelContainer);
            Controls.Add(panelBar);
            Name = "frmAdminEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de Empleados";
            panelBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBar;
        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnListadoBar;
        private FontAwesome.Sharp.IconButton btnCargaBar;
    }
}