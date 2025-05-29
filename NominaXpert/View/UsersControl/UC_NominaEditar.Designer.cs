namespace NominaXpertCore.View.UsersControl
{
    partial class UC_NominaEditar
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
            lblHistorialNominas = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gBoxDatosEmpleado = new GroupBox();
            panel3 = new Panel();
            txtEstadoDePago = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtNoNomina = new TextBox();
            lblNoNomina = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            txtNombreEmpleado = new TextBox();
            lblNombreCompleto = new Label();
            gBoxEditarEstatus = new GroupBox();
            btnVisualizarNomina = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            panel18 = new Panel();
            btnActualizarCambios = new FontAwesome.Sharp.IconButton();
            lblDatosObligatorios = new Label();
            panel9 = new Panel();
            cBoxEstatusNomina = new ComboBox();
            lblEstatusNomina = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            gBoxDatosEmpleado.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            gBoxEditarEstatus.SuspendLayout();
            panel18.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescripcionCN);
            panel1.Controls.Add(lblHistorialNominas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 125);
            panel1.TabIndex = 1;
            // 
            // lblDescripcionCN
            // 
            lblDescripcionCN.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionCN.ForeColor = Color.White;
            lblDescripcionCN.Location = new Point(32, 73);
            lblDescripcionCN.Name = "lblDescripcionCN";
            lblDescripcionCN.Size = new Size(743, 32);
            lblDescripcionCN.TabIndex = 4;
            lblDescripcionCN.Text = "Permite modificar el estatus de la nómina de un empleado";
            // 
            // lblHistorialNominas
            // 
            lblHistorialNominas.AutoSize = true;
            lblHistorialNominas.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialNominas.ForeColor = Color.FromArgb(12, 215, 253);
            lblHistorialNominas.Location = new Point(32, 26);
            lblHistorialNominas.Name = "lblHistorialNominas";
            lblHistorialNominas.Size = new Size(251, 35);
            lblHistorialNominas.TabIndex = 1;
            lblHistorialNominas.Text = " Estatus de Nómina";
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(37, 41, 47);
            flowLayoutPanel1.Controls.Add(gBoxDatosEmpleado);
            flowLayoutPanel1.Controls.Add(gBoxEditarEstatus);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(66, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1129, 560);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // gBoxDatosEmpleado
            // 
            gBoxDatosEmpleado.Controls.Add(panel3);
            gBoxDatosEmpleado.Controls.Add(panel2);
            gBoxDatosEmpleado.Controls.Add(btnBuscar);
            gBoxDatosEmpleado.Controls.Add(panel4);
            gBoxDatosEmpleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxDatosEmpleado.ForeColor = Color.White;
            gBoxDatosEmpleado.Location = new Point(3, 3);
            gBoxDatosEmpleado.Name = "gBoxDatosEmpleado";
            gBoxDatosEmpleado.Size = new Size(1111, 167);
            gBoxDatosEmpleado.TabIndex = 10;
            gBoxDatosEmpleado.TabStop = false;
            gBoxDatosEmpleado.Text = "Datos de empleado";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtEstadoDePago);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(578, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 42);
            panel3.TabIndex = 11;
            // 
            // txtEstadoDePago
            // 
            txtEstadoDePago.Location = new Point(140, 3);
            txtEstadoDePago.MaxLength = 100;
            txtEstadoDePago.Name = "txtEstadoDePago";
            txtEstadoDePago.ReadOnly = true;
            txtEstadoDePago.Size = new Size(208, 30);
            txtEstadoDePago.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 29);
            label1.TabIndex = 3;
            label1.Text = "Estado de Pago";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNoNomina);
            panel2.Controls.Add(lblNoNomina);
            panel2.Location = new Point(23, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 43);
            panel2.TabIndex = 17;
            // 
            // txtNoNomina
            // 
            txtNoNomina.Location = new Point(158, 3);
            txtNoNomina.MaxLength = 20;
            txtNoNomina.Name = "txtNoNomina";
            txtNoNomina.Size = new Size(183, 30);
            txtNoNomina.TabIndex = 6;
            // 
            // lblNoNomina
            // 
            lblNoNomina.Dock = DockStyle.Top;
            lblNoNomina.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoNomina.ForeColor = Color.White;
            lblNoNomina.Location = new Point(0, 0);
            lblNoNomina.Name = "lblNoNomina";
            lblNoNomina.Size = new Size(347, 29);
            lblNoNomina.TabIndex = 3;
            lblNoNomina.Text = "No. de Nómina* ";
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.DeepSkyBlue;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 32;
            btnBuscar.Location = new Point(408, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 36);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtNombreEmpleado);
            panel4.Controls.Add(lblNombreCompleto);
            panel4.Location = new Point(23, 97);
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
            // gBoxEditarEstatus
            // 
            gBoxEditarEstatus.Controls.Add(btnVisualizarNomina);
            gBoxEditarEstatus.Controls.Add(btnModificar);
            gBoxEditarEstatus.Controls.Add(panel18);
            gBoxEditarEstatus.Controls.Add(lblDatosObligatorios);
            gBoxEditarEstatus.Controls.Add(panel9);
            gBoxEditarEstatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxEditarEstatus.ForeColor = Color.White;
            gBoxEditarEstatus.Location = new Point(3, 176);
            gBoxEditarEstatus.Name = "gBoxEditarEstatus";
            gBoxEditarEstatus.Size = new Size(1111, 325);
            gBoxEditarEstatus.TabIndex = 8;
            gBoxEditarEstatus.TabStop = false;
            gBoxEditarEstatus.Text = "Estatus de nómina";
            // 
            // btnVisualizarNomina
            // 
            btnVisualizarNomina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizarNomina.BackColor = Color.Black;
            btnVisualizarNomina.Cursor = Cursors.Hand;
            btnVisualizarNomina.FlatAppearance.BorderColor = Color.LightGreen;
            btnVisualizarNomina.FlatAppearance.BorderSize = 2;
            btnVisualizarNomina.FlatStyle = FlatStyle.Flat;
            btnVisualizarNomina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVisualizarNomina.ForeColor = Color.Azure;
            btnVisualizarNomina.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnVisualizarNomina.IconColor = Color.LightGreen;
            btnVisualizarNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVisualizarNomina.IconSize = 32;
            btnVisualizarNomina.Location = new Point(811, 47);
            btnVisualizarNomina.Name = "btnVisualizarNomina";
            btnVisualizarNomina.Size = new Size(219, 40);
            btnVisualizarNomina.TabIndex = 12;
            btnVisualizarNomina.Text = "Vista previa de Nómina";
            btnVisualizarNomina.TextAlign = ContentAlignment.MiddleRight;
            btnVisualizarNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizarNomina.UseVisualStyleBackColor = false;
            btnVisualizarNomina.Click += btnVisualizarNomina_Click;
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
            btnModificar.Location = new Point(392, 185);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(335, 40);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar Percepciones y Deducciones";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(37, 41, 47);
            panel18.Controls.Add(btnActualizarCambios);
            panel18.Location = new Point(23, 166);
            panel18.Name = "panel18";
            panel18.Size = new Size(269, 72);
            panel18.TabIndex = 14;
            // 
            // btnActualizarCambios
            // 
            btnActualizarCambios.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizarCambios.BackColor = Color.Black;
            btnActualizarCambios.Cursor = Cursors.Hand;
            btnActualizarCambios.FlatAppearance.BorderColor = Color.Cyan;
            btnActualizarCambios.FlatAppearance.BorderSize = 2;
            btnActualizarCambios.FlatStyle = FlatStyle.Flat;
            btnActualizarCambios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarCambios.ForeColor = Color.Azure;
            btnActualizarCambios.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnActualizarCambios.IconColor = Color.Cyan;
            btnActualizarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizarCambios.IconSize = 32;
            btnActualizarCambios.Location = new Point(18, 19);
            btnActualizarCambios.Name = "btnActualizarCambios";
            btnActualizarCambios.Size = new Size(243, 40);
            btnActualizarCambios.TabIndex = 11;
            btnActualizarCambios.Text = "Actualizar Estado de Pago";
            btnActualizarCambios.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarCambios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizarCambios.UseVisualStyleBackColor = false;
            btnActualizarCambios.Click += btnActualizarCambios_Click;
            // 
            // lblDatosObligatorios
            // 
            lblDatosObligatorios.AutoSize = true;
            lblDatosObligatorios.ForeColor = Color.IndianRed;
            lblDatosObligatorios.Location = new Point(420, 46);
            lblDatosObligatorios.Name = "lblDatosObligatorios";
            lblDatosObligatorios.Size = new Size(171, 23);
            lblDatosObligatorios.TabIndex = 13;
            lblDatosObligatorios.Text = "Datos obligatorios *";
            // 
            // panel9
            // 
            panel9.Controls.Add(cBoxEstatusNomina);
            panel9.Controls.Add(lblEstatusNomina);
            panel9.Location = new Point(23, 55);
            panel9.Name = "panel9";
            panel9.Size = new Size(347, 43);
            panel9.TabIndex = 16;
            // 
            // cBoxEstatusNomina
            // 
            cBoxEstatusNomina.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxEstatusNomina.FormattingEnabled = true;
            cBoxEstatusNomina.Location = new Point(158, 6);
            cBoxEstatusNomina.Name = "cBoxEstatusNomina";
            cBoxEstatusNomina.Size = new Size(183, 31);
            cBoxEstatusNomina.TabIndex = 4;
            // 
            // lblEstatusNomina
            // 
            lblEstatusNomina.Dock = DockStyle.Top;
            lblEstatusNomina.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstatusNomina.ForeColor = Color.White;
            lblEstatusNomina.Location = new Point(0, 0);
            lblEstatusNomina.Name = "lblEstatusNomina";
            lblEstatusNomina.Size = new Size(347, 29);
            lblEstatusNomina.TabIndex = 3;
            lblEstatusNomina.Text = "Estatus Nómina*";
            // 
            // UC_NominaEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "UC_NominaEditar";
            Size = new Size(1262, 705);
            Load += UC_NominaEditar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            gBoxDatosEmpleado.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            gBoxEditarEstatus.ResumeLayout(false);
            gBoxEditarEstatus.PerformLayout();
            panel18.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescripcionCN;
        private Label lblHistorialNominas;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gBoxDatosEmpleado;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Panel panel4;
        private TextBox textBox2;
        private Label lblNombreCompleto;
        private Panel panel9;
        private ComboBox cBoxEstatusNomina;
        private Label lblEstatusNomina;
        private GroupBox gBoxEditarEstatus;
        private Panel panel18;
        private FontAwesome.Sharp.IconButton btnActualizarCambios;
        private Label lblDatosObligatorios;
        private Panel panel2;
        private TextBox txtNoNomina;
        private Label lblNoNomina;
        private ToolTip toolTip1;
        private Panel panel3;
        private TextBox txtEstadoDePago;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnVisualizarNomina;
        private TextBox txtNombre;
        private TextBox txtNombreEmpleado;
    }
}
