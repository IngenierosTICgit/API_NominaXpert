namespace NominaXpertCore.View.UsersControl
{
    partial class UC_NominaPercepciones
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
            panel1 = new Panel();
            txtIdNomina = new TextBox();
            label4 = new Label();
            lblDescripcionCN = new Label();
            lblHistorialNominas = new Label();
            panel2 = new Panel();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            cboTipo = new ComboBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            txtMonto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            DataGridViewPercepciones = new DataGridView();
            panel3 = new Panel();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            id = new DataGridViewTextBoxColumn();
            Id_nomina = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPercepciones).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtIdNomina);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblDescripcionCN);
            panel1.Controls.Add(lblHistorialNominas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 119);
            panel1.TabIndex = 2;
            // 
            // txtIdNomina
            // 
            txtIdNomina.Location = new Point(752, 70);
            txtIdNomina.Name = "txtIdNomina";
            txtIdNomina.ReadOnly = true;
            txtIdNomina.Size = new Size(115, 27);
            txtIdNomina.TabIndex = 22;
            txtIdNomina.TextChanged += txtIdNomina_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(662, 73);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 5;
            label4.Text = "ID Nomina:";
            // 
            // lblDescripcionCN
            // 
            lblDescripcionCN.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionCN.ForeColor = Color.White;
            lblDescripcionCN.Location = new Point(32, 73);
            lblDescripcionCN.Name = "lblDescripcionCN";
            lblDescripcionCN.Size = new Size(743, 32);
            lblDescripcionCN.TabIndex = 4;
            lblDescripcionCN.Text = "Permite modificar las percepciones de la nómina de un empleado";
            // 
            // lblHistorialNominas
            // 
            lblHistorialNominas.AutoSize = true;
            lblHistorialNominas.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialNominas.ForeColor = Color.FromArgb(12, 215, 253);
            lblHistorialNominas.Location = new Point(32, 26);
            lblHistorialNominas.Name = "lblHistorialNominas";
            lblHistorialNominas.Size = new Size(274, 35);
            lblHistorialNominas.TabIndex = 1;
            lblHistorialNominas.Text = "Lista de Percepciones";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(DataGridViewPercepciones);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 473);
            panel2.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Azure;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Red;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 32;
            btnEliminar.Location = new Point(229, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderColor = Color.Yellow;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Azure;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnModificar.IconColor = Color.Yellow;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 32;
            btnModificar.Location = new Point(32, 403);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 40);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(639, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 411);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Percepción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(47, 199);
            label3.Name = "label3";
            label3.Size = new Size(367, 20);
            label3.TabIndex = 21;
            label3.Text = "(Se permite números hasta con 2 decimales: 00.00)";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(126, 71);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(204, 28);
            cboTipo.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Black;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Cyan;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Azure;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.Cyan;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 32;
            btnLimpiar.Location = new Point(374, 348);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar celdas";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Cyan;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Azure;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Cyan;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 32;
            btnGuardar.Location = new Point(47, 348);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(148, 40);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(131, 146);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(199, 27);
            txtMonto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 149);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 71);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo: ";
            // 
            // DataGridViewPercepciones
            // 
            DataGridViewPercepciones.AllowUserToAddRows = false;
            DataGridViewPercepciones.AllowUserToDeleteRows = false;
            DataGridViewPercepciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPercepciones.Columns.AddRange(new DataGridViewColumn[] { id, Id_nomina, Tipo, Monto });
            DataGridViewPercepciones.Location = new Point(32, 32);
            DataGridViewPercepciones.Name = "DataGridViewPercepciones";
            DataGridViewPercepciones.ReadOnly = true;
            DataGridViewPercepciones.RowHeadersWidth = 51;
            DataGridViewPercepciones.Size = new Size(579, 345);
            DataGridViewPercepciones.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSiguiente);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 592);
            panel3.Name = "panel3";
            panel3.Size = new Size(1262, 76);
            panel3.TabIndex = 4;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiguiente.BackColor = Color.Black;
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderColor = Color.Lime;
            btnSiguiente.FlatAppearance.BorderSize = 2;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.Azure;
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.CircleRight;
            btnSiguiente.IconColor = Color.Lime;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 32;
            btnSiguiente.Location = new Point(1066, 17);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(148, 40);
            btnSiguiente.TabIndex = 12;
            btnSiguiente.Text = "Siguente";
            btnSiguiente.TextAlign = ContentAlignment.MiddleRight;
            btnSiguiente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // Id_nomina
            // 
            Id_nomina.HeaderText = "Id_nomina";
            Id_nomina.MinimumWidth = 6;
            Id_nomina.Name = "Id_nomina";
            Id_nomina.ReadOnly = true;
            Id_nomina.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 220;
            // 
            // Monto
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0.00";
            Monto.DefaultCellStyle = dataGridViewCellStyle1;
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            Monto.Width = 180;
            // 
            // UC_NominaPercepciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_NominaPercepciones";
            Size = new Size(1262, 691);
            Load += UC_NominaPercepciones_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPercepciones).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescripcionCN;
        private Label lblHistorialNominas;
        private Panel panel2;
        private Panel panel3;
        private DataGridView DataGridViewPercepciones;
        private GroupBox groupBox1;
        private TextBox txtMonto;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private ComboBox cboTipo;
        private Label label3;
        private TextBox txtIdNomina;
        private Label label4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Id_nomina;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Monto;
    }
}
