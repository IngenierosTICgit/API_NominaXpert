namespace NominaXpertCore.View.Forms
{
    partial class frmConfiguracion
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            panel17 = new Panel();
            cboGenero = new ComboBox();
            label4 = new Label();
            lblMatricula = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel17.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 112);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(563, 46);
            label2.TabIndex = 3;
            label2.Text = "Administre la configuración del sistema y las preferencias.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(184, 35);
            label1.TabIndex = 0;
            label1.Text = "Configuración";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 51, 59);
            panel2.Controls.Add(btnGuardarCambios);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel17);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 354);
            panel2.TabIndex = 4;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarCambios.BackColor = Color.Black;
            btnGuardarCambios.Cursor = Cursors.Hand;
            btnGuardarCambios.FlatAppearance.BorderColor = Color.Cyan;
            btnGuardarCambios.FlatAppearance.BorderSize = 2;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.ForeColor = Color.Azure;
            btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarCambios.IconColor = Color.Cyan;
            btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarCambios.IconSize = 32;
            btnGuardarCambios.Location = new Point(581, 266);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(241, 40);
            btnGuardarCambios.TabIndex = 14;
            btnGuardarCambios.Text = "Guardar Configuración";
            btnGuardarCambios.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarCambios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(48, 51, 59);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(32, 207);
            panel4.Margin = new Padding(5, 3, 3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 99);
            panel4.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(37, 41, 47);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 61);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(339, 28);
            comboBox2.TabIndex = 5;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 29);
            label7.Name = "label7";
            label7.Size = new Size(500, 29);
            label7.TabIndex = 4;
            label7.Text = "Formato para mostrar la hora en el sistema.";
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(500, 29);
            label8.TabIndex = 2;
            label8.Text = "Formato de hora";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 51, 59);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(581, 87);
            panel3.Margin = new Padding(5, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 99);
            panel3.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(37, 41, 47);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 28);
            comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 29);
            label5.Name = "label5";
            label5.Size = new Size(500, 29);
            label5.TabIndex = 4;
            label5.Text = "Moneda predeterminada para valores monetarios.";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(500, 29);
            label6.TabIndex = 2;
            label6.Text = "Formato de moneda";
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(48, 51, 59);
            panel17.Controls.Add(cboGenero);
            panel17.Controls.Add(label4);
            panel17.Controls.Add(lblMatricula);
            panel17.Location = new Point(32, 87);
            panel17.Margin = new Padding(5, 3, 3, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(500, 99);
            panel17.TabIndex = 12;
            // 
            // cboGenero
            // 
            cboGenero.BackColor = Color.FromArgb(37, 41, 47);
            cboGenero.FlatStyle = FlatStyle.Flat;
            cboGenero.ForeColor = Color.White;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(12, 61);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(339, 28);
            cboGenero.TabIndex = 5;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 29);
            label4.Name = "label4";
            label4.Size = new Size(500, 29);
            label4.TabIndex = 4;
            label4.Text = "Formato para mostrar fechas en el sistema.";
            // 
            // lblMatricula
            // 
            lblMatricula.Dock = DockStyle.Top;
            lblMatricula.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatricula.ForeColor = Color.White;
            lblMatricula.Location = new Point(0, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(500, 29);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Formato de fecha";
            // 
            // label3
            // 
            label3.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 39);
            label3.Name = "label3";
            label3.Size = new Size(351, 28);
            label3.TabIndex = 4;
            label3.Text = "Permite definir parámetros del sistema.";
            // 
            // frmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            ClientSize = new Size(1262, 769);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmConfiguracion";
            Text = "frmConfiguracion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Panel panel17;
        private Label label4;
        private Label lblMatricula;
        private Panel panel4;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private ComboBox cboGenero;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
    }
}