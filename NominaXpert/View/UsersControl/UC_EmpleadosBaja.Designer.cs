namespace NominaXpertCore.View.UsersControl
{
    partial class UC_EmpleadosBaja
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel6 = new Panel();
            lblChangeName = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            cboBaja = new ComboBox();
            label6 = new Label();
            panel8 = new Panel();
            txtDetalleBaja = new TextBox();
            label7 = new Label();
            btnProcesarBaja = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnSearch = new Button();
            txtSearchEmpleado = new TextBox();
            iconPIcture = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 308);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(48, 51, 59);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(btnProcesarBaja);
            flowLayoutPanel1.Controls.Add(btnEliminar);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(66, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1129, 302);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(48, 51, 59);
            panel6.Controls.Add(lblChangeName);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(5, 3);
            panel6.Margin = new Padding(5, 3, 3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(500, 60);
            panel6.TabIndex = 5;
            // 
            // lblChangeName
            // 
            lblChangeName.Dock = DockStyle.Top;
            lblChangeName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangeName.ForeColor = Color.Cyan;
            lblChangeName.Location = new Point(0, 29);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(500, 29);
            lblChangeName.TabIndex = 3;
            lblChangeName.Text = "--------";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(500, 29);
            label5.TabIndex = 2;
            label5.Text = "Nombre del Empleado: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 51, 59);
            panel3.Location = new Point(513, 3);
            panel3.Margin = new Padding(5, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 60);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(48, 51, 59);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(5, 69);
            panel4.Margin = new Padding(5, 3, 3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 60);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(500, 29);
            label4.TabIndex = 2;
            label4.Text = "Fecha de Baja";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(48, 51, 59);
            panel7.Controls.Add(cboBaja);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(511, 69);
            panel7.Margin = new Padding(3, 3, 5, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(500, 60);
            panel7.TabIndex = 6;
            // 
            // cboBaja
            // 
            cboBaja.BackColor = Color.FromArgb(37, 41, 47);
            cboBaja.FlatStyle = FlatStyle.Flat;
            cboBaja.ForeColor = Color.White;
            cboBaja.FormattingEnabled = true;
            cboBaja.Location = new Point(3, 32);
            cboBaja.Name = "cboBaja";
            cboBaja.Size = new Size(326, 28);
            cboBaja.TabIndex = 3;
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
            label6.Text = "Motivo de Baja";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(48, 51, 59);
            panel8.Controls.Add(txtDetalleBaja);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(5, 135);
            panel8.Margin = new Padding(5, 3, 3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1006, 85);
            panel8.TabIndex = 7;
            // 
            // txtDetalleBaja
            // 
            txtDetalleBaja.BackColor = Color.FromArgb(37, 41, 47);
            txtDetalleBaja.Dock = DockStyle.Top;
            txtDetalleBaja.ForeColor = Color.LightGray;
            txtDetalleBaja.Location = new Point(0, 23);
            txtDetalleBaja.MaxLength = 100;
            txtDetalleBaja.Name = "txtDetalleBaja";
            txtDetalleBaja.Size = new Size(1006, 27);
            txtDetalleBaja.TabIndex = 3;
            txtDetalleBaja.Text = "Detalles adicionales sobre la baja";
            txtDetalleBaja.Enter += txtDireccion_Enter;
            txtDetalleBaja.Leave += txtDireccion_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 2;
            label7.Text = "Notas Adicionales";
            // 
            // btnProcesarBaja
            // 
            btnProcesarBaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProcesarBaja.BackColor = Color.Black;
            btnProcesarBaja.Cursor = Cursors.Hand;
            btnProcesarBaja.FlatAppearance.BorderColor = Color.Red;
            btnProcesarBaja.FlatAppearance.BorderSize = 2;
            btnProcesarBaja.FlatStyle = FlatStyle.Flat;
            btnProcesarBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcesarBaja.ForeColor = Color.Red;
            btnProcesarBaja.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnProcesarBaja.IconColor = Color.Red;
            btnProcesarBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesarBaja.IconSize = 32;
            btnProcesarBaja.Location = new Point(3, 226);
            btnProcesarBaja.Margin = new Padding(3, 3, 200, 3);
            btnProcesarBaja.Name = "btnProcesarBaja";
            btnProcesarBaja.Size = new Size(201, 40);
            btnProcesarBaja.TabIndex = 10;
            btnProcesarBaja.Text = "Procesar Baja";
            btnProcesarBaja.TextAlign = ContentAlignment.MiddleRight;
            btnProcesarBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProcesarBaja.UseVisualStyleBackColor = false;
            btnProcesarBaja.Click += btnProcesarBaja_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnEliminar.IconColor = Color.Red;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 32;
            btnEliminar.Location = new Point(407, 226);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(294, 40);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Borrar definitivo al usuario";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 41, 47);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearchEmpleado);
            panel2.Controls.Add(iconPIcture);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 57);
            panel2.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(689, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchEmpleado
            // 
            txtSearchEmpleado.BackColor = Color.FromArgb(37, 41, 47);
            txtSearchEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtSearchEmpleado.ForeColor = Color.LightGray;
            txtSearchEmpleado.Location = new Point(67, 18);
            txtSearchEmpleado.Name = "txtSearchEmpleado";
            txtSearchEmpleado.Size = new Size(585, 27);
            txtSearchEmpleado.TabIndex = 1;
            txtSearchEmpleado.Text = "Buscar empleado";
            txtSearchEmpleado.Enter += txtSearchEmpleado_Enter;
            txtSearchEmpleado.Leave += txtSearchEmpleado_Leave;
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
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 107);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(681, 32);
            label2.TabIndex = 3;
            label2.Text = "Gestiona el proceso de baja de empleados y mantén un registro de auditoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "Baja de Empleados";
            // 
            // UC_EmpleadosBaja
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_EmpleadosBaja";
            Size = new Size(1262, 755);
            Load += UC_EmpleadosBaja_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel6;
        private Label label5;
        private Panel panel7;
        private ComboBox cboBaja;
        private Label label6;
        private Panel panel8;
        private TextBox txtDetalleBaja;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnProcesarBaja;
        private Panel panel2;
        private Button btnSearch;
        private TextBox txtSearchEmpleado;
        private FontAwesome.Sharp.IconPictureBox iconPIcture;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblChangeName;
        private Panel panel3;
        private Panel panel4;
        private Utilities.NominaDatePicker DTPFechaBaja;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}
