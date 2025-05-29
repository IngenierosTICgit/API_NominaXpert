namespace NominaXpertCore.View.UsersControl
{
    partial class UC_NominaCalculo1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblDescripcionCN = new Label();
            lblCalculoNominas = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gBoxDatosEmpleado = new GroupBox();
            panel5 = new Panel();
            txtEstatusEmpleado = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtIdEmpleado = new TextBox();
            lblIDEmpleado = new Label();
            panel10 = new Panel();
            ipbMatricula = new FontAwesome.Sharp.IconPictureBox();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            panel4 = new Panel();
            txtNombreEmpleado = new TextBox();
            lblNombreCompleto = new Label();
            panel6 = new Panel();
            txtSueldoBase = new TextBox();
            lblSueldoBase = new Label();
            gBoxPrestacionesLey = new GroupBox();
            dtpFechaFinNomina = new Utilities.NominaDatePicker();
            dtpFechaInicioNomina = new Utilities.NominaDatePicker();
            label1 = new Label();
            panel3 = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            btnCalculoNomina1 = new FontAwesome.Sharp.IconButton();
            lblDatosObligatorios = new Label();
            panel7 = new Panel();
            txtDiasLaborados = new TextBox();
            lblDiasLaborados = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            gBoxDatosEmpleado.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbMatricula).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            gBoxPrestacionesLey.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescripcionCN);
            panel1.Controls.Add(lblCalculoNominas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 125);
            panel1.TabIndex = 0;
            // 
            // lblDescripcionCN
            // 
            lblDescripcionCN.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionCN.ForeColor = Color.White;
            lblDescripcionCN.Location = new Point(32, 73);
            lblDescripcionCN.Name = "lblDescripcionCN";
            lblDescripcionCN.Size = new Size(743, 32);
            lblDescripcionCN.TabIndex = 4;
            lblDescripcionCN.Text = "Genera el cálculo de la nómina del empleado y permite realizar el recibo de la misma.";
            // 
            // lblCalculoNominas
            // 
            lblCalculoNominas.AutoSize = true;
            lblCalculoNominas.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalculoNominas.ForeColor = Color.FromArgb(12, 215, 253);
            lblCalculoNominas.Location = new Point(32, 19);
            lblCalculoNominas.Name = "lblCalculoNominas";
            lblCalculoNominas.Size = new Size(253, 35);
            lblCalculoNominas.TabIndex = 1;
            lblCalculoNominas.Text = "Cálculo de Nóminas";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 566);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(37, 41, 47);
            flowLayoutPanel1.Controls.Add(gBoxDatosEmpleado);
            flowLayoutPanel1.Controls.Add(gBoxPrestacionesLey);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(66, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1129, 560);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // gBoxDatosEmpleado
            // 
            gBoxDatosEmpleado.Controls.Add(panel5);
            gBoxDatosEmpleado.Controls.Add(panel2);
            gBoxDatosEmpleado.Controls.Add(panel10);
            gBoxDatosEmpleado.Controls.Add(panel4);
            gBoxDatosEmpleado.Controls.Add(panel6);
            gBoxDatosEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxDatosEmpleado.ForeColor = Color.White;
            gBoxDatosEmpleado.Location = new Point(3, 3);
            gBoxDatosEmpleado.Name = "gBoxDatosEmpleado";
            gBoxDatosEmpleado.Size = new Size(1111, 149);
            gBoxDatosEmpleado.TabIndex = 10;
            gBoxDatosEmpleado.TabStop = false;
            gBoxDatosEmpleado.Text = "Datos de empleado";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 41, 47);
            panel5.Controls.Add(txtEstatusEmpleado);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(763, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(342, 43);
            panel5.TabIndex = 16;
            // 
            // txtEstatusEmpleado
            // 
            txtEstatusEmpleado.Location = new Point(115, 3);
            txtEstatusEmpleado.MaxLength = 20;
            txtEstatusEmpleado.Name = "txtEstatusEmpleado";
            txtEstatusEmpleado.ReadOnly = true;
            txtEstatusEmpleado.Size = new Size(189, 30);
            txtEstatusEmpleado.TabIndex = 5;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(342, 29);
            label2.TabIndex = 4;
            label2.Text = "Estatus*";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 41, 47);
            panel2.Controls.Add(txtIdEmpleado);
            panel2.Controls.Add(lblIDEmpleado);
            panel2.Location = new Point(386, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 43);
            panel2.TabIndex = 15;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(126, 3);
            txtIdEmpleado.MaxLength = 20;
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.ReadOnly = true;
            txtIdEmpleado.Size = new Size(178, 30);
            txtIdEmpleado.TabIndex = 5;
            // 
            // lblIDEmpleado
            // 
            lblIDEmpleado.Dock = DockStyle.Top;
            lblIDEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDEmpleado.ForeColor = Color.White;
            lblIDEmpleado.Location = new Point(0, 0);
            lblIDEmpleado.Name = "lblIDEmpleado";
            lblIDEmpleado.Size = new Size(371, 29);
            lblIDEmpleado.TabIndex = 4;
            lblIDEmpleado.Text = "ID empleado*";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(37, 41, 47);
            panel10.Controls.Add(ipbMatricula);
            panel10.Controls.Add(txtMatricula);
            panel10.Controls.Add(lblMatricula);
            panel10.Location = new Point(5, 48);
            panel10.Name = "panel10";
            panel10.Size = new Size(371, 43);
            panel10.TabIndex = 14;
            // 
            // ipbMatricula
            // 
            ipbMatricula.BackColor = Color.FromArgb(37, 41, 47);
            ipbMatricula.ForeColor = Color.LightBlue;
            ipbMatricula.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            ipbMatricula.IconColor = Color.LightBlue;
            ipbMatricula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbMatricula.IconSize = 40;
            ipbMatricula.Location = new Point(328, -1);
            ipbMatricula.Name = "ipbMatricula";
            ipbMatricula.Size = new Size(40, 40);
            ipbMatricula.TabIndex = 6;
            ipbMatricula.TabStop = false;
            toolTip1.SetToolTip(ipbMatricula, "Ejemplo: E-2019-54321");
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(126, 3);
            txtMatricula.MaxLength = 20;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(178, 30);
            txtMatricula.TabIndex = 5;
            // 
            // lblMatricula
            // 
            lblMatricula.Dock = DockStyle.Top;
            lblMatricula.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatricula.ForeColor = Color.White;
            lblMatricula.Location = new Point(0, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(371, 29);
            lblMatricula.TabIndex = 4;
            lblMatricula.Text = "Matrícula *";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtNombreEmpleado);
            panel4.Controls.Add(lblNombreCompleto);
            panel4.Location = new Point(5, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(752, 42);
            panel4.TabIndex = 10;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(205, 3);
            txtNombreEmpleado.MaxLength = 100;
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.ReadOnly = true;
            txtNombreEmpleado.Size = new Size(544, 30);
            txtNombreEmpleado.TabIndex = 4;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Dock = DockStyle.Top;
            lblNombreCompleto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCompleto.ForeColor = Color.White;
            lblNombreCompleto.Location = new Point(0, 0);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(752, 29);
            lblNombreCompleto.TabIndex = 3;
            lblNombreCompleto.Text = "Nombre del Empleado ";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSueldoBase);
            panel6.Controls.Add(lblSueldoBase);
            panel6.Location = new Point(763, 97);
            panel6.Name = "panel6";
            panel6.Size = new Size(346, 42);
            panel6.TabIndex = 12;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Location = new Point(115, 3);
            txtSueldoBase.MaxLength = 100;
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.ReadOnly = true;
            txtSueldoBase.Size = new Size(192, 30);
            txtSueldoBase.TabIndex = 4;
            txtSueldoBase.Text = "  $";
            // 
            // lblSueldoBase
            // 
            lblSueldoBase.Dock = DockStyle.Top;
            lblSueldoBase.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoBase.ForeColor = Color.White;
            lblSueldoBase.Location = new Point(0, 0);
            lblSueldoBase.Name = "lblSueldoBase";
            lblSueldoBase.Size = new Size(346, 29);
            lblSueldoBase.TabIndex = 3;
            lblSueldoBase.Text = "Sueldo base";
            // 
            // gBoxPrestacionesLey
            // 
            gBoxPrestacionesLey.Controls.Add(dtpFechaFinNomina);
            gBoxPrestacionesLey.Controls.Add(dtpFechaInicioNomina);
            gBoxPrestacionesLey.Controls.Add(label1);
            gBoxPrestacionesLey.Controls.Add(panel3);
            gBoxPrestacionesLey.Controls.Add(label6);
            gBoxPrestacionesLey.Controls.Add(btnCalculoNomina1);
            gBoxPrestacionesLey.Controls.Add(lblDatosObligatorios);
            gBoxPrestacionesLey.Controls.Add(panel7);
            gBoxPrestacionesLey.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxPrestacionesLey.ForeColor = Color.White;
            gBoxPrestacionesLey.Location = new Point(3, 158);
            gBoxPrestacionesLey.Name = "gBoxPrestacionesLey";
            gBoxPrestacionesLey.Size = new Size(1110, 325);
            gBoxPrestacionesLey.TabIndex = 9;
            gBoxPrestacionesLey.TabStop = false;
            gBoxPrestacionesLey.Text = "Selección de Período";
            // 
            // dtpFechaFinNomina
            // 
            dtpFechaFinNomina.BorderColor = Color.FromArgb(12, 215, 253);
            dtpFechaFinNomina.BorderSize = 2;
            dtpFechaFinNomina.Font = new Font("Segoe UI", 9.5F);
            dtpFechaFinNomina.Format = DateTimePickerFormat.Short;
            dtpFechaFinNomina.Location = new Point(512, 151);
            dtpFechaFinNomina.MinimumSize = new Size(0, 35);
            dtpFechaFinNomina.Name = "dtpFechaFinNomina";
            dtpFechaFinNomina.Size = new Size(318, 35);
            dtpFechaFinNomina.SkinColor = Color.FromArgb(48, 51, 59);
            dtpFechaFinNomina.TabIndex = 19;
            dtpFechaFinNomina.TextColor = Color.FromArgb(12, 215, 253);
            dtpFechaFinNomina.ValueChanged += dtpFechaFinNomina_ValueChanged_2;
            // 
            // dtpFechaInicioNomina
            // 
            dtpFechaInicioNomina.BorderColor = Color.FromArgb(12, 215, 253);
            dtpFechaInicioNomina.BorderSize = 2;
            dtpFechaInicioNomina.Font = new Font("Segoe UI", 9.5F);
            dtpFechaInicioNomina.Format = DateTimePickerFormat.Short;
            dtpFechaInicioNomina.Location = new Point(27, 151);
            dtpFechaInicioNomina.MinimumSize = new Size(0, 35);
            dtpFechaInicioNomina.Name = "dtpFechaInicioNomina";
            dtpFechaInicioNomina.Size = new Size(318, 35);
            dtpFechaInicioNomina.SkinColor = Color.FromArgb(48, 51, 59);
            dtpFechaInicioNomina.TabIndex = 18;
            dtpFechaInicioNomina.TextColor = Color.FromArgb(12, 215, 253);
            dtpFechaInicioNomina.ValueChanged += dtpFechaInicioNomina_ValueChanged_2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 100);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 17;
            label1.Text = "Fecha de inicio:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 41, 47);
            panel3.Controls.Add(btnBuscar);
            panel3.Location = new Point(733, 259);
            panel3.Name = "panel3";
            panel3.Size = new Size(145, 43);
            panel3.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.DeepSkyBlue;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 32;
            btnBuscar.Location = new Point(8, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 36);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(512, 100);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 16;
            label6.Text = "Fecha de fin:";
            // 
            // btnCalculoNomina1
            // 
            btnCalculoNomina1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCalculoNomina1.BackColor = Color.Black;
            btnCalculoNomina1.Cursor = Cursors.Hand;
            btnCalculoNomina1.FlatAppearance.BorderColor = Color.Lime;
            btnCalculoNomina1.FlatAppearance.BorderSize = 2;
            btnCalculoNomina1.FlatStyle = FlatStyle.Flat;
            btnCalculoNomina1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculoNomina1.ForeColor = Color.Azure;
            btnCalculoNomina1.IconChar = FontAwesome.Sharp.IconChar.CircleRight;
            btnCalculoNomina1.IconColor = Color.Lime;
            btnCalculoNomina1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalculoNomina1.IconSize = 32;
            btnCalculoNomina1.Location = new Point(922, 262);
            btnCalculoNomina1.Name = "btnCalculoNomina1";
            btnCalculoNomina1.Size = new Size(148, 40);
            btnCalculoNomina1.TabIndex = 11;
            btnCalculoNomina1.Text = "Siguente";
            btnCalculoNomina1.TextAlign = ContentAlignment.MiddleRight;
            btnCalculoNomina1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalculoNomina1.UseVisualStyleBackColor = false;
            btnCalculoNomina1.Click += btnCalcularVerNomina_Click;
            // 
            // lblDatosObligatorios
            // 
            lblDatosObligatorios.AutoSize = true;
            lblDatosObligatorios.ForeColor = Color.IndianRed;
            lblDatosObligatorios.Location = new Point(27, 63);
            lblDatosObligatorios.Name = "lblDatosObligatorios";
            lblDatosObligatorios.Size = new Size(171, 23);
            lblDatosObligatorios.TabIndex = 13;
            lblDatosObligatorios.Text = "Datos obligatorios *";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtDiasLaborados);
            panel7.Controls.Add(lblDiasLaborados);
            panel7.Location = new Point(27, 201);
            panel7.Name = "panel7";
            panel7.Size = new Size(318, 42);
            panel7.TabIndex = 13;
            // 
            // txtDiasLaborados
            // 
            txtDiasLaborados.Location = new Point(154, 0);
            txtDiasLaborados.MaxLength = 2;
            txtDiasLaborados.Name = "txtDiasLaborados";
            txtDiasLaborados.ReadOnly = true;
            txtDiasLaborados.Size = new Size(128, 30);
            txtDiasLaborados.TabIndex = 4;
            // 
            // lblDiasLaborados
            // 
            lblDiasLaborados.AutoSize = true;
            lblDiasLaborados.Dock = DockStyle.Top;
            lblDiasLaborados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiasLaborados.ForeColor = Color.White;
            lblDiasLaborados.Location = new Point(0, 0);
            lblDiasLaborados.Name = "lblDiasLaborados";
            lblDiasLaborados.Size = new Size(153, 23);
            lblDiasLaborados.TabIndex = 3;
            lblDiasLaborados.Text = "Horas Laboradas: ";
            // 
            // UC_NominaCalculo1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_NominaCalculo1";
            Size = new Size(1262, 705);
            Load += UC_NominaAlta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            gBoxDatosEmpleado.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbMatricula).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            gBoxPrestacionesLey.ResumeLayout(false);
            gBoxPrestacionesLey.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCalculoNomina;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCalculoNominas;
        private Label lblDescripcionCN;
        private GroupBox gBoxPrestacionesLey;
        private Label lblDatosObligatorios;
        private FontAwesome.Sharp.IconButton btnCalculoNomina1;
        private GroupBox gBoxDatosEmpleado;
        private Panel panel10;
        private TextBox textBox4;
        private Label lblMatricula;
        private Panel panel4;
        private TextBox txtNombreEmpleado;
        private Label lblNombreCompleto;
        private Panel panel6;
        private TextBox txtSueldoBase;
        private Label lblSueldoBase;
        private Panel panel7;
        private TextBox txtDiasLaborados;
        private Label lblDiasLaborados;
        private TextBox txtMatricula;
        private FontAwesome.Sharp.IconPictureBox ipbMatricula;
        private ToolTip toolTip1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Utilities.NominaDatePicker dtpFechaFinNomina;
        private Utilities.NominaDatePicker dtpFechaInicioNomina;
        private Label label1;
        private Label label6;
        private Panel panel2;
        private TextBox txtIdEmpleado;
        private Label lblIDEmpleado;
        private Panel panel5;
        private TextBox txtEstatusEmpleado;
        private Label label2;
    }
}
