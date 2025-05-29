namespace NominaXpertCore.View.Forms
{
    partial class frmCalculoRecibos
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
            btnEstatusNomina = new FontAwesome.Sharp.IconButton();
            btnCalculoNomina = new FontAwesome.Sharp.IconButton();
            panelContainer = new Panel();
            panelBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.FromArgb(48, 51, 59);
            panelBar.Controls.Add(btnEstatusNomina);
            panelBar.Controls.Add(btnCalculoNomina);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1244, 64);
            panelBar.TabIndex = 6;
            // 
            // btnEstatusNomina
            // 
            btnEstatusNomina.Cursor = Cursors.Hand;
            btnEstatusNomina.FlatAppearance.BorderSize = 0;
            btnEstatusNomina.FlatStyle = FlatStyle.Flat;
            btnEstatusNomina.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstatusNomina.ForeColor = Color.White;
            btnEstatusNomina.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            btnEstatusNomina.IconColor = Color.FromArgb(12, 215, 253);
            btnEstatusNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstatusNomina.IconSize = 32;
            btnEstatusNomina.Location = new Point(205, 3);
            btnEstatusNomina.Name = "btnEstatusNomina";
            btnEstatusNomina.Padding = new Padding(10, 0, 20, 0);
            btnEstatusNomina.Size = new Size(224, 61);
            btnEstatusNomina.TabIndex = 2;
            btnEstatusNomina.Text = "Estatus de Nóminas";
            btnEstatusNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnEstatusNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstatusNomina.UseVisualStyleBackColor = false;
            btnEstatusNomina.Click += btnEstatusNomina_Click;
            // 
            // btnCalculoNomina
            // 
            btnCalculoNomina.Cursor = Cursors.Hand;
            btnCalculoNomina.FlatAppearance.BorderSize = 0;
            btnCalculoNomina.FlatStyle = FlatStyle.Flat;
            btnCalculoNomina.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculoNomina.ForeColor = Color.White;
            btnCalculoNomina.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnCalculoNomina.IconColor = Color.FromArgb(12, 215, 253);
            btnCalculoNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculoNomina.IconSize = 32;
            btnCalculoNomina.Location = new Point(3, 3);
            btnCalculoNomina.Name = "btnCalculoNomina";
            btnCalculoNomina.Padding = new Padding(10, 0, 20, 0);
            btnCalculoNomina.Size = new Size(210, 61);
            btnCalculoNomina.TabIndex = 0;
            btnCalculoNomina.Text = "Cálculo Nómina";
            btnCalculoNomina.TextAlign = ContentAlignment.MiddleLeft;
            btnCalculoNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculoNomina.UseVisualStyleBackColor = false;
            btnCalculoNomina.Click += btnCalculoNomina_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 64);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1244, 594);
            panelContainer.TabIndex = 7;
            // 
            // frmCalculoRecibos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            ClientSize = new Size(1244, 658);
            Controls.Add(panelContainer);
            Controls.Add(panelBar);
            Name = "frmCalculoRecibos";
            Text = "Cálculos y Recibos";
            panelBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnCalculoNomina;
        private Panel panelContainer;
        private Panel panelBar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnEstatusNomina;
    }
}