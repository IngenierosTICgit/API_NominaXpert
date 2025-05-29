namespace NominaXpertCore.View.Forms
{
    partial class frmReportes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lblTotaldeRegistros = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            ipbMatricula = new FontAwesome.Sharp.IconPictureBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            panel4 = new Panel();
            btnExportarPDF = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            panel6 = new Panel();
            btnEsportarExcel = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            gBoxMatricula = new GroupBox();
            btnBuscarEstado = new Button();
            label3 = new Label();
            cboEstadoDePago = new ComboBox();
            bntLimpiarfiltrosfechas = new Button();
            btnFiltrarFechas = new Button();
            btnDatalleNomina = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label5 = new Label();
            DTPFechaFinNomina = new NominaXpertCore.Utilities.NominaDatePicker();
            DTPFechaInicioNomina = new NominaXpertCore.Utilities.NominaDatePicker();
            gBoxHistorial = new GroupBox();
            dataGridView1 = new DataGridView();
            Id_Nomina = new DataGridViewTextBoxColumn();
            Id_empleado = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Estado_Pago = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            MontoLetra = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            Selección = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipbMatricula).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            gBoxMatricula.SuspendLayout();
            gBoxHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 111);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(662, 53);
            label2.TabIndex = 5;
            label2.Text = "Ingresa datos especificos de búsquedad para encontrar tú nómina deseada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 35);
            label1.TabIndex = 4;
            label1.Text = "Historial de Nóminas Generadas";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotaldeRegistros);
            panel3.Location = new Point(692, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 73);
            panel3.TabIndex = 1;
            // 
            // lblTotaldeRegistros
            // 
            lblTotaldeRegistros.AutoSize = true;
            lblTotaldeRegistros.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotaldeRegistros.ForeColor = Color.FromArgb(12, 215, 253);
            lblTotaldeRegistros.Location = new Point(19, 33);
            lblTotaldeRegistros.Name = "lblTotaldeRegistros";
            lblTotaldeRegistros.Size = new Size(163, 23);
            lblTotaldeRegistros.TabIndex = 8;
            lblTotaldeRegistros.Text = "Total de Registros: ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1262, 96);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(ipbMatricula);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(lblMatricula);
            panel2.Controls.Add(txtMatricula);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 73);
            panel2.TabIndex = 0;
            // 
            // ipbMatricula
            // 
            ipbMatricula.BackColor = Color.FromArgb(37, 41, 47);
            ipbMatricula.ForeColor = Color.LightBlue;
            ipbMatricula.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            ipbMatricula.IconColor = Color.LightBlue;
            ipbMatricula.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipbMatricula.IconSize = 40;
            ipbMatricula.Location = new Point(300, 25);
            ipbMatricula.Name = "ipbMatricula";
            ipbMatricula.Size = new Size(40, 40);
            ipbMatricula.TabIndex = 25;
            ipbMatricula.TabStop = false;
            toolTip1.SetToolTip(ipbMatricula, "Ejemplo: E-2019-54321");
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.DeepSkyBlue;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 32;
            btnBuscar.Location = new Point(365, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 36);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblMatricula
            // 
            lblMatricula.Dock = DockStyle.Top;
            lblMatricula.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatricula.ForeColor = Color.White;
            lblMatricula.Location = new Point(0, 0);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(509, 29);
            lblMatricula.TabIndex = 5;
            lblMatricula.Text = "Matrícula*";
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.ForeColor = Color.Black;
            txtMatricula.Location = new Point(15, 32);
            txtMatricula.MaxLength = 20;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(263, 27);
            txtMatricula.TabIndex = 4;
            txtMatricula.TextChanged += txtMatricula_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnExportarPDF);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(518, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 79);
            panel4.TabIndex = 1;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.Black;
            btnExportarPDF.Cursor = Cursors.Hand;
            btnExportarPDF.FlatAppearance.BorderColor = Color.DeepPink;
            btnExportarPDF.FlatAppearance.BorderSize = 2;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.ForeColor = Color.Azure;
            btnExportarPDF.IconChar = FontAwesome.Sharp.IconChar.SheetPlastic;
            btnExportarPDF.IconColor = Color.MediumVioletRed;
            btnExportarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportarPDF.IconSize = 32;
            btnExportarPDF.Location = new Point(3, 33);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(213, 40);
            btnExportarPDF.TabIndex = 12;
            btnExportarPDF.Text = "Descargar PDF único";
            btnExportarPDF.TextAlign = ContentAlignment.MiddleRight;
            btnExportarPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnPDFReciboNomina_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(228, 29);
            label4.TabIndex = 3;
            label4.Text = "Exportar búsquedad";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnEsportarExcel);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(752, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(293, 79);
            panel6.TabIndex = 2;
            // 
            // btnEsportarExcel
            // 
            btnEsportarExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEsportarExcel.BackColor = Color.Black;
            btnEsportarExcel.Cursor = Cursors.Hand;
            btnEsportarExcel.FlatAppearance.BorderColor = Color.Lime;
            btnEsportarExcel.FlatAppearance.BorderSize = 2;
            btnEsportarExcel.FlatStyle = FlatStyle.Flat;
            btnEsportarExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEsportarExcel.ForeColor = Color.Azure;
            btnEsportarExcel.IconChar = FontAwesome.Sharp.IconChar.SheetPlastic;
            btnEsportarExcel.IconColor = Color.Lime;
            btnEsportarExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnEsportarExcel.IconSize = 32;
            btnEsportarExcel.Location = new Point(0, 32);
            btnEsportarExcel.Name = "btnEsportarExcel";
            btnEsportarExcel.Size = new Size(290, 40);
            btnEsportarExcel.TabIndex = 11;
            btnEsportarExcel.Text = "Descargar Excel de búsquedad";
            btnEsportarExcel.TextAlign = ContentAlignment.MiddleRight;
            btnEsportarExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEsportarExcel.UseVisualStyleBackColor = false;
            btnEsportarExcel.Click += iconVerNomina_Click;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(293, 29);
            label7.TabIndex = 3;
            label7.Text = "Exportar a Excel";
            // 
            // gBoxMatricula
            // 
            gBoxMatricula.Controls.Add(btnBuscarEstado);
            gBoxMatricula.Controls.Add(label3);
            gBoxMatricula.Controls.Add(cboEstadoDePago);
            gBoxMatricula.Controls.Add(bntLimpiarfiltrosfechas);
            gBoxMatricula.Controls.Add(btnFiltrarFechas);
            gBoxMatricula.Controls.Add(btnDatalleNomina);
            gBoxMatricula.Controls.Add(label6);
            gBoxMatricula.Controls.Add(label5);
            gBoxMatricula.Controls.Add(DTPFechaFinNomina);
            gBoxMatricula.Controls.Add(DTPFechaInicioNomina);
            gBoxMatricula.Dock = DockStyle.Top;
            gBoxMatricula.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxMatricula.ForeColor = Color.White;
            gBoxMatricula.Location = new Point(0, 207);
            gBoxMatricula.Name = "gBoxMatricula";
            gBoxMatricula.Size = new Size(1262, 92);
            gBoxMatricula.TabIndex = 18;
            gBoxMatricula.TabStop = false;
            gBoxMatricula.Text = "Recibos de Nómina Recuperados";
            // 
            // btnBuscarEstado
            // 
            btnBuscarEstado.BackColor = Color.Black;
            btnBuscarEstado.FlatStyle = FlatStyle.Popup;
            btnBuscarEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEstado.ForeColor = Color.White;
            btnBuscarEstado.Location = new Point(769, 21);
            btnBuscarEstado.Name = "btnBuscarEstado";
            btnBuscarEstado.Size = new Size(130, 29);
            btnBuscarEstado.TabIndex = 22;
            btnBuscarEstado.Text = "Buscar Estado";
            btnBuscarEstado.UseVisualStyleBackColor = false;
            btnBuscarEstado.Click += btnBuscarEstado_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(12, 215, 253);
            label3.Location = new Point(548, 21);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 21;
            label3.Text = "Estado de Pago";
            // 
            // cboEstadoDePago
            // 
            cboEstadoDePago.BackColor = Color.FromArgb(37, 41, 47);
            cboEstadoDePago.ForeColor = Color.White;
            cboEstadoDePago.FormattingEnabled = true;
            cboEstadoDePago.Location = new Point(548, 49);
            cboEstadoDePago.Name = "cboEstadoDePago";
            cboEstadoDePago.Size = new Size(188, 31);
            cboEstadoDePago.TabIndex = 20;
            // 
            // bntLimpiarfiltrosfechas
            // 
            bntLimpiarfiltrosfechas.BackColor = Color.Black;
            bntLimpiarfiltrosfechas.FlatStyle = FlatStyle.Popup;
            bntLimpiarfiltrosfechas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntLimpiarfiltrosfechas.ForeColor = Color.White;
            bntLimpiarfiltrosfechas.Location = new Point(769, 56);
            bntLimpiarfiltrosfechas.Name = "bntLimpiarfiltrosfechas";
            bntLimpiarfiltrosfechas.Size = new Size(130, 29);
            bntLimpiarfiltrosfechas.TabIndex = 19;
            bntLimpiarfiltrosfechas.Text = "Limpiar filtros";
            bntLimpiarfiltrosfechas.UseVisualStyleBackColor = false;
            bntLimpiarfiltrosfechas.Click += bntLimpiarfiltrosfechas_Click;
            // 
            // btnFiltrarFechas
            // 
            btnFiltrarFechas.BackColor = Color.Black;
            btnFiltrarFechas.FlatStyle = FlatStyle.Popup;
            btnFiltrarFechas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrarFechas.ForeColor = Color.White;
            btnFiltrarFechas.Location = new Point(379, 49);
            btnFiltrarFechas.Name = "btnFiltrarFechas";
            btnFiltrarFechas.Size = new Size(133, 29);
            btnFiltrarFechas.TabIndex = 18;
            btnFiltrarFechas.Text = "Filtrar fechas";
            btnFiltrarFechas.UseVisualStyleBackColor = false;
            btnFiltrarFechas.Click += btnFiltrarFechas_Click;
            // 
            // btnDatalleNomina
            // 
            btnDatalleNomina.BackColor = Color.Black;
            btnDatalleNomina.Cursor = Cursors.Hand;
            btnDatalleNomina.FlatAppearance.BorderColor = Color.Cyan;
            btnDatalleNomina.FlatAppearance.BorderSize = 2;
            btnDatalleNomina.FlatStyle = FlatStyle.Flat;
            btnDatalleNomina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatalleNomina.ForeColor = Color.Azure;
            btnDatalleNomina.IconChar = FontAwesome.Sharp.IconChar.SquareArrowUpRight;
            btnDatalleNomina.IconColor = Color.Cyan;
            btnDatalleNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDatalleNomina.IconSize = 32;
            btnDatalleNomina.Location = new Point(938, 38);
            btnDatalleNomina.Name = "btnDatalleNomina";
            btnDatalleNomina.Size = new Size(215, 40);
            btnDatalleNomina.TabIndex = 16;
            btnDatalleNomina.Text = "Ver detalle nómina";
            btnDatalleNomina.TextAlign = ContentAlignment.MiddleRight;
            btnDatalleNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDatalleNomina.UseVisualStyleBackColor = false;
            btnDatalleNomina.Click += btnDatalleNomina_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(205, 26);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 15;
            label6.Text = "Fecha de fin:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 26);
            label5.Name = "label5";
            label5.Size = new Size(134, 22);
            label5.TabIndex = 14;
            label5.Text = "Fecha de inicio:";
            // 
            // DTPFechaFinNomina
            // 
            DTPFechaFinNomina.BorderColor = Color.FromArgb(12, 215, 253);
            DTPFechaFinNomina.BorderSize = 2;
            DTPFechaFinNomina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPFechaFinNomina.Format = DateTimePickerFormat.Short;
            DTPFechaFinNomina.Location = new Point(205, 51);
            DTPFechaFinNomina.MinimumSize = new Size(0, 35);
            DTPFechaFinNomina.Name = "DTPFechaFinNomina";
            DTPFechaFinNomina.Size = new Size(147, 35);
            DTPFechaFinNomina.SkinColor = Color.FromArgb(48, 51, 59);
            DTPFechaFinNomina.TabIndex = 13;
            DTPFechaFinNomina.TextColor = Color.FromArgb(12, 215, 253);
            // 
            // DTPFechaInicioNomina
            // 
            DTPFechaInicioNomina.BorderColor = Color.FromArgb(12, 215, 253);
            DTPFechaInicioNomina.BorderSize = 2;
            DTPFechaInicioNomina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPFechaInicioNomina.Format = DateTimePickerFormat.Short;
            DTPFechaInicioNomina.Location = new Point(18, 51);
            DTPFechaInicioNomina.MinimumSize = new Size(0, 35);
            DTPFechaInicioNomina.Name = "DTPFechaInicioNomina";
            DTPFechaInicioNomina.Size = new Size(147, 35);
            DTPFechaInicioNomina.SkinColor = Color.FromArgb(48, 51, 59);
            DTPFechaInicioNomina.TabIndex = 12;
            DTPFechaInicioNomina.TextColor = Color.FromArgb(12, 215, 253);
            // 
            // gBoxHistorial
            // 
            gBoxHistorial.Controls.Add(dataGridView1);
            gBoxHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxHistorial.ForeColor = SystemColors.ButtonHighlight;
            gBoxHistorial.Location = new Point(3, 305);
            gBoxHistorial.Name = "gBoxHistorial";
            gBoxHistorial.Size = new Size(1259, 452);
            gBoxHistorial.TabIndex = 19;
            gBoxHistorial.TabStop = false;
            gBoxHistorial.Text = "Historial de Nóminas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Nomina, Id_empleado, FechaInicio, FechaFin, Estado_Pago, MontoTotal, MontoLetra });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkCyan;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1226, 420);
            dataGridView1.TabIndex = 0;
            // 
            // Id_Nomina
            // 
            Id_Nomina.HeaderText = "No. de Nómina";
            Id_Nomina.MinimumWidth = 6;
            Id_Nomina.Name = "Id_Nomina";
            Id_Nomina.ReadOnly = true;
            // 
            // Id_empleado
            // 
            Id_empleado.HeaderText = "Id_empleado";
            Id_empleado.MinimumWidth = 6;
            Id_empleado.Name = "Id_empleado";
            Id_empleado.ReadOnly = true;
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "Fecha de Inicio";
            FechaInicio.MinimumWidth = 6;
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            FechaFin.HeaderText = "Fecha de Fin";
            FechaFin.MinimumWidth = 6;
            FechaFin.Name = "FechaFin";
            FechaFin.ReadOnly = true;
            // 
            // Estado_Pago
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Estado_Pago.DefaultCellStyle = dataGridViewCellStyle2;
            Estado_Pago.HeaderText = "Estado de Pago";
            Estado_Pago.MinimumWidth = 6;
            Estado_Pago.Name = "Estado_Pago";
            Estado_Pago.ReadOnly = true;
            // 
            // MontoTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00";
            MontoTotal.DefaultCellStyle = dataGridViewCellStyle3;
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            // 
            // MontoLetra
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            MontoLetra.DefaultCellStyle = dataGridViewCellStyle4;
            MontoLetra.HeaderText = "Monto Letra";
            MontoLetra.MinimumWidth = 6;
            MontoLetra.Name = "MontoLetra";
            MontoLetra.ReadOnly = true;
            // 
            // Selección
            // 
            Selección.HeaderText = "Selección";
            Selección.MinimumWidth = 6;
            Selección.Name = "Selección";
            Selección.Width = 125;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            ClientSize = new Size(1262, 769);
            Controls.Add(gBoxHistorial);
            Controls.Add(gBoxMatricula);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "frmReportes";
            Text = "Reportes";
            Load += frmReportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipbMatricula).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            gBoxMatricula.ResumeLayout(false);
            gBoxMatricula.PerformLayout();
            gBoxHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnExportarPDF;
        private GroupBox gBoxMatricula;
        
        private Label label6;
        private Label label5;
        private Utilities.NominaDatePicker DTPFechaFinNomina;
        private Utilities.NominaDatePicker DTPFechaInicioNomina;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnEsportarExcel;
        private Label label7;
        private GroupBox gBoxHistorial;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconPictureBox ipbMatricula;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnDatalleNomina;
        private DataGridViewCheckBoxColumn Selección;
        private Label lblTotaldeRegistros;
        private DataGridViewTextBoxColumn Id_Nomina;
        private DataGridViewTextBoxColumn Id_empleado;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Estado_Pago;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn MontoLetra;
        private Button btnFiltrarFechas;
        private Button bntLimpiarfiltrosfechas;
        private ComboBox cboEstadoDePago;
        private Button btnBuscarEstado;
        private Label label3;
    }
}