namespace NominaXpertCore.View.UsersControl
{
    partial class UC_EmpleadosListado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblTotaldeRegistros = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLimpiarFiltros = new Button();
            btnSearch = new Button();
            cboEstatus = new ComboBox();
            cboTipoContrato = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtSearchTable = new TextBox();
            iconPIcture = new FontAwesome.Sharp.IconPictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Id_Empleado = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            Puesto = new DataGridViewTextBoxColumn();
            Depto = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Contrato = new DataGridViewTextBoxColumn();
            Estatus = new DataGridViewTextBoxColumn();
            FechaNac = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            FechContratacion = new DataGridViewTextBoxColumn();
            RFC = new DataGridViewTextBoxColumn();
            CURP = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotaldeRegistros);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 112);
            panel1.TabIndex = 2;
            // 
            // lblTotaldeRegistros
            // 
            lblTotaldeRegistros.AutoSize = true;
            lblTotaldeRegistros.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotaldeRegistros.ForeColor = Color.FromArgb(12, 215, 253);
            lblTotaldeRegistros.Location = new Point(881, 63);
            lblTotaldeRegistros.Name = "lblTotaldeRegistros";
            lblTotaldeRegistros.Size = new Size(163, 23);
            lblTotaldeRegistros.TabIndex = 7;
            lblTotaldeRegistros.Text = "Total de Registros: ";
            lblTotaldeRegistros.Click += lblTotaldeRegistros_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(563, 46);
            label2.TabIndex = 3;
            label2.Text = "Visualiza, filtra y exporta la información de todos los empleados.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(282, 35);
            label1.TabIndex = 0;
            label1.Text = "Listado de Empleados";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 41, 47);
            panel2.Controls.Add(btnLimpiarFiltros);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(cboEstatus);
            panel2.Controls.Add(cboTipoContrato);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtSearchTable);
            panel2.Controls.Add(iconPIcture);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 92);
            panel2.TabIndex = 3;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Black;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Popup;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarFiltros.ForeColor = Color.White;
            btnLimpiarFiltros.Location = new Point(655, 57);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(133, 29);
            btnLimpiarFiltros.TabIndex = 7;
            btnLimpiarFiltros.Text = "Limpiar Filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(509, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboEstatus
            // 
            cboEstatus.BackColor = Color.FromArgb(37, 41, 47);
            cboEstatus.ForeColor = Color.White;
            cboEstatus.FormattingEnabled = true;
            cboEstatus.Location = new Point(1090, 17);
            cboEstatus.Name = "cboEstatus";
            cboEstatus.Size = new Size(126, 28);
            cboEstatus.TabIndex = 5;
            cboEstatus.SelectedIndexChanged += cboEstatus_SelectedIndexChanged;
            // 
            // cboTipoContrato
            // 
            cboTipoContrato.BackColor = Color.FromArgb(37, 41, 47);
            cboTipoContrato.ForeColor = Color.White;
            cboTipoContrato.FormattingEnabled = true;
            cboTipoContrato.Location = new Point(813, 16);
            cboTipoContrato.Name = "cboTipoContrato";
            cboTipoContrato.Size = new Size(188, 28);
            cboTipoContrato.TabIndex = 4;
            cboTipoContrato.SelectedIndexChanged += cboTipoContrato_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 215, 253);
            label4.Location = new Point(1020, 18);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "Estatus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(12, 215, 253);
            label3.Location = new Point(655, 18);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Contrato ";
            // 
            // txtSearchTable
            // 
            txtSearchTable.BackColor = Color.FromArgb(37, 41, 47);
            txtSearchTable.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTable.ForeColor = Color.LightGray;
            txtSearchTable.Location = new Point(67, 18);
            txtSearchTable.Name = "txtSearchTable";
            txtSearchTable.Size = new Size(423, 27);
            txtSearchTable.TabIndex = 1;
            txtSearchTable.Text = "Buscar empleados...";
            txtSearchTable.Enter += txtSearchTable_Enter;
            txtSearchTable.Leave += txtSearchTable_Leave;
            // 
            // iconPIcture
            // 
            iconPIcture.BackColor = Color.FromArgb(37, 41, 47);
            iconPIcture.ForeColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPIcture.IconColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPIcture.IconSize = 36;
            iconPIcture.Location = new Point(21, 9);
            iconPIcture.Name = "iconPIcture";
            iconPIcture.Size = new Size(40, 36);
            iconPIcture.TabIndex = 0;
            iconPIcture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 204);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 490);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Empleado, NombreEmpleado, Puesto, Depto, Sueldo, Contrato, Estatus, FechaNac, Correo, FechContratacion, RFC, CURP, Telefono, Direccion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkCyan;
            dataGridView1.Location = new Point(40, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1205, 484);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id_Empleado
            // 
            Id_Empleado.HeaderText = "ID";
            Id_Empleado.MinimumWidth = 6;
            Id_Empleado.Name = "Id_Empleado";
            Id_Empleado.ReadOnly = true;
            Id_Empleado.Width = 125;
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.HeaderText = "Nombre empleado";
            NombreEmpleado.MinimumWidth = 6;
            NombreEmpleado.Name = "NombreEmpleado";
            NombreEmpleado.ReadOnly = true;
            NombreEmpleado.Width = 125;
            // 
            // Puesto
            // 
            Puesto.HeaderText = "Puesto";
            Puesto.MinimumWidth = 6;
            Puesto.Name = "Puesto";
            Puesto.ReadOnly = true;
            Puesto.Width = 125;
            // 
            // Depto
            // 
            Depto.HeaderText = "Departamento";
            Depto.MinimumWidth = 6;
            Depto.Name = "Depto";
            Depto.ReadOnly = true;
            Depto.Width = 125;
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.MinimumWidth = 6;
            Sueldo.Name = "Sueldo";
            Sueldo.ReadOnly = true;
            Sueldo.Width = 125;
            // 
            // Contrato
            // 
            Contrato.HeaderText = "Contrato";
            Contrato.MinimumWidth = 6;
            Contrato.Name = "Contrato";
            Contrato.ReadOnly = true;
            Contrato.Width = 125;
            // 
            // Estatus
            // 
            Estatus.HeaderText = "Estatus";
            Estatus.MinimumWidth = 6;
            Estatus.Name = "Estatus";
            Estatus.ReadOnly = true;
            Estatus.Width = 125;
            // 
            // FechaNac
            // 
            FechaNac.HeaderText = "Fecha de Nacimiento";
            FechaNac.MinimumWidth = 6;
            FechaNac.Name = "FechaNac";
            FechaNac.ReadOnly = true;
            FechaNac.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo electrónico ";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 125;
            // 
            // FechContratacion
            // 
            FechContratacion.HeaderText = "Fecha de contratación";
            FechContratacion.MinimumWidth = 6;
            FechContratacion.Name = "FechContratacion";
            FechContratacion.ReadOnly = true;
            FechContratacion.Width = 125;
            // 
            // RFC
            // 
            RFC.HeaderText = "RFC";
            RFC.MinimumWidth = 6;
            RFC.Name = "RFC";
            RFC.ReadOnly = true;
            RFC.Width = 125;
            // 
            // CURP
            // 
            CURP.HeaderText = "CURP";
            CURP.MinimumWidth = 6;
            CURP.Name = "CURP";
            CURP.ReadOnly = true;
            CURP.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 125;
            // 
            // UC_EmpleadosListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_EmpleadosListado";
            Size = new Size(1262, 755);
            Load += UC_EmpleadosListado_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPIcture;
        private TextBox txtSearchTable;
        private ComboBox cboEstatus;
        private ComboBox cboTipoContrato;
        private Label label4;
        private Label label3;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Label lblTotaldeRegistros;
        private Button btnLimpiarFiltros;
        private DataGridViewTextBoxColumn Id_Empleado;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn Puesto;
        private DataGridViewTextBoxColumn Depto;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Contrato;
        private DataGridViewTextBoxColumn Estatus;
        private DataGridViewTextBoxColumn FechaNac;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn FechContratacion;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn CURP;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
    }
}
