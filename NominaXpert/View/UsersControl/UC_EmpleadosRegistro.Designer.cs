namespace NominaXpertCore.View.UsersControl
{
    partial class UC_EmpleadosRegistro
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel17 = new Panel();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            panel2 = new Panel();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panel3 = new Panel();
            txtApPaterno = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txtApMaterno = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            DTPFechaNacimiento = new NominaXpertCore.Utilities.NominaDatePicker();
            label5 = new Label();
            panel6 = new Panel();
            cboGenero = new ComboBox();
            label6 = new Label();
            panel7 = new Panel();
            txtDireccion = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            txtRFC = new TextBox();
            label8 = new Label();
            panel9 = new Panel();
            txtCURP = new TextBox();
            label9 = new Label();
            panel10 = new Panel();
            txtTelefono = new TextBox();
            label10 = new Label();
            panel11 = new Panel();
            txtCorreo = new TextBox();
            label11 = new Label();
            panel12 = new Panel();
            cboDepartamento = new ComboBox();
            label12 = new Label();
            panel13 = new Panel();
            cboPuesto = new ComboBox();
            label13 = new Label();
            panel15 = new Panel();
            DTPFechaContratacion = new NominaXpertCore.Utilities.NominaDatePicker();
            label15 = new Label();
            panel14 = new Panel();
            txtSalario = new TextBox();
            label14 = new Label();
            panel16 = new Panel();
            label16 = new Label();
            cboEstatus = new ComboBox();
            btnRegistrarEmpleado = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel17.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(366, 35);
            label1.TabIndex = 0;
            label1.Text = "Registro de Nuevo Empleado";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 125);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(563, 53);
            label2.TabIndex = 3;
            label2.Text = "Ingresa los datos para registrar un nuevo empleado en el sistema.";
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
            tableLayoutPanel1.Size = new Size(1262, 588);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(48, 51, 59);
            flowLayoutPanel1.Controls.Add(panel17);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(panel12);
            flowLayoutPanel1.Controls.Add(panel13);
            flowLayoutPanel1.Controls.Add(panel15);
            flowLayoutPanel1.Controls.Add(panel14);
            flowLayoutPanel1.Controls.Add(panel16);
            flowLayoutPanel1.Controls.Add(btnRegistrarEmpleado);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(66, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1129, 582);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(48, 51, 59);
            panel17.Controls.Add(txtMatricula);
            panel17.Controls.Add(lblMatricula);
            panel17.Location = new Point(5, 3);
            panel17.Margin = new Padding(5, 3, 3, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(500, 60);
            panel17.TabIndex = 11;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.FromArgb(37, 41, 47);
            txtMatricula.Dock = DockStyle.Top;
            txtMatricula.ForeColor = Color.LightGray;
            txtMatricula.Location = new Point(0, 29);
            txtMatricula.MaxLength = 8;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(500, 27);
            txtMatricula.TabIndex = 3;
            txtMatricula.Text = "EJ: E-2019-54321";
            txtMatricula.Enter += textBox1_Enter;
            txtMatricula.Leave += textBox1_Leave;
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
            lblMatricula.Text = "Matrícula*";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 51, 59);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblNombre);
            panel2.Location = new Point(511, 3);
            panel2.Margin = new Padding(3, 3, 5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 60);
            panel2.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(37, 41, 47);
            txtNombre.Dock = DockStyle.Top;
            txtNombre.ForeColor = Color.LightGray;
            txtNombre.Location = new Point(0, 29);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(500, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "EJ: Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave_1;
            // 
            // lblNombre
            // 
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(0, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(500, 29);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre*";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 51, 59);
            panel3.Controls.Add(txtApPaterno);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(5, 69);
            panel3.Margin = new Padding(5, 3, 3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 60);
            panel3.TabIndex = 1;
            // 
            // txtApPaterno
            // 
            txtApPaterno.BackColor = Color.FromArgb(37, 41, 47);
            txtApPaterno.Dock = DockStyle.Top;
            txtApPaterno.ForeColor = Color.LightGray;
            txtApPaterno.Location = new Point(0, 29);
            txtApPaterno.MaxLength = 50;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(500, 27);
            txtApPaterno.TabIndex = 3;
            txtApPaterno.Text = "EJ: Apellido Paterno";
            txtApPaterno.Enter += txtApPaterno_Enter;
            txtApPaterno.Leave += txtApPaterno_Leave;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(500, 29);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno*";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(48, 51, 59);
            panel4.Controls.Add(txtApMaterno);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(511, 69);
            panel4.Margin = new Padding(3, 3, 5, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 60);
            panel4.TabIndex = 4;
            // 
            // txtApMaterno
            // 
            txtApMaterno.BackColor = Color.FromArgb(37, 41, 47);
            txtApMaterno.Dock = DockStyle.Top;
            txtApMaterno.ForeColor = Color.LightGray;
            txtApMaterno.Location = new Point(0, 29);
            txtApMaterno.MaxLength = 50;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(500, 27);
            txtApMaterno.TabIndex = 3;
            txtApMaterno.Text = "EJ: Apellido Materno";
            txtApMaterno.Enter += txtApMaterno_Enter;
            txtApMaterno.Leave += txtApMaterno_Leave;
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
            label4.Text = "Apellido Materno*";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(48, 51, 59);
            panel5.Controls.Add(DTPFechaNacimiento);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(5, 135);
            panel5.Margin = new Padding(5, 3, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(500, 60);
            panel5.TabIndex = 5;
            // 
            // DTPFechaNacimiento
            // 
            DTPFechaNacimiento.BorderColor = Color.FromArgb(12, 215, 253);
            DTPFechaNacimiento.BorderSize = 2;
            DTPFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPFechaNacimiento.Format = DateTimePickerFormat.Short;
            DTPFechaNacimiento.Location = new Point(0, 25);
            DTPFechaNacimiento.MinimumSize = new Size(0, 35);
            DTPFechaNacimiento.Name = "DTPFechaNacimiento";
            DTPFechaNacimiento.Size = new Size(147, 35);
            DTPFechaNacimiento.SkinColor = Color.FromArgb(48, 51, 59);
            DTPFechaNacimiento.TabIndex = 3;
            DTPFechaNacimiento.TextColor = Color.FromArgb(12, 215, 253);
            DTPFechaNacimiento.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            label5.Text = "Fecha de Nacimiento*";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(48, 51, 59);
            panel6.Controls.Add(cboGenero);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(511, 135);
            panel6.Margin = new Padding(3, 3, 5, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(500, 60);
            panel6.TabIndex = 6;
            // 
            // cboGenero
            // 
            cboGenero.BackColor = Color.FromArgb(37, 41, 47);
            cboGenero.FlatStyle = FlatStyle.Flat;
            cboGenero.ForeColor = Color.White;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(3, 32);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(192, 28);
            cboGenero.TabIndex = 3;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
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
            label6.Text = "Género*";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(48, 51, 59);
            panel7.Controls.Add(txtDireccion);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(5, 201);
            panel7.Margin = new Padding(5, 3, 3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(500, 60);
            panel7.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(37, 41, 47);
            txtDireccion.Dock = DockStyle.Top;
            txtDireccion.ForeColor = Color.LightGray;
            txtDireccion.Location = new Point(0, 29);
            txtDireccion.MaxLength = 100;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(500, 27);
            txtDireccion.TabIndex = 3;
            txtDireccion.Text = "EJ: Dirección completa";
            txtDireccion.Enter += txtDireccion_Enter;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(500, 29);
            label7.TabIndex = 2;
            label7.Text = "Dirección*";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(48, 51, 59);
            panel8.Controls.Add(txtRFC);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(511, 201);
            panel8.Margin = new Padding(3, 3, 5, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(500, 60);
            panel8.TabIndex = 8;
            // 
            // txtRFC
            // 
            txtRFC.BackColor = Color.FromArgb(37, 41, 47);
            txtRFC.Dock = DockStyle.Top;
            txtRFC.ForeColor = Color.DarkGray;
            txtRFC.Location = new Point(0, 29);
            txtRFC.MaxLength = 13;
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(500, 27);
            txtRFC.TabIndex = 3;
            txtRFC.Text = "RFC";
            txtRFC.Enter += txtRFC_Enter;
            txtRFC.Leave += txtRFC_Leave;
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
            label8.Text = "RFC*";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(48, 51, 59);
            panel9.Controls.Add(txtCURP);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(5, 267);
            panel9.Margin = new Padding(5, 3, 3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(500, 60);
            panel9.TabIndex = 8;
            // 
            // txtCURP
            // 
            txtCURP.BackColor = Color.FromArgb(37, 41, 47);
            txtCURP.Dock = DockStyle.Top;
            txtCURP.ForeColor = Color.DarkGray;
            txtCURP.Location = new Point(0, 29);
            txtCURP.MaxLength = 18;
            txtCURP.Name = "txtCURP";
            txtCURP.Size = new Size(500, 27);
            txtCURP.TabIndex = 3;
            txtCURP.Text = "CURP";
            txtCURP.Enter += txtCURP_Enter;
            txtCURP.Leave += txtCURP_Leave;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(500, 29);
            label9.TabIndex = 2;
            label9.Text = "CURP*";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(48, 51, 59);
            panel10.Controls.Add(txtTelefono);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(511, 267);
            panel10.Margin = new Padding(3, 3, 5, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(500, 60);
            panel10.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(37, 41, 47);
            txtTelefono.Dock = DockStyle.Top;
            txtTelefono.ForeColor = Color.DarkGray;
            txtTelefono.Location = new Point(0, 29);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(500, 27);
            txtTelefono.TabIndex = 3;
            txtTelefono.Text = "EJ: 7221845696";
            txtTelefono.Enter += txtTelefono_Enter;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(500, 29);
            label10.TabIndex = 2;
            label10.Text = "Teléfono";
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(48, 51, 59);
            panel11.Controls.Add(txtCorreo);
            panel11.Controls.Add(label11);
            panel11.Location = new Point(5, 333);
            panel11.Margin = new Padding(5, 3, 3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(500, 60);
            panel11.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(37, 41, 47);
            txtCorreo.Dock = DockStyle.Top;
            txtCorreo.ForeColor = Color.DarkGray;
            txtCorreo.Location = new Point(0, 29);
            txtCorreo.MaxLength = 320;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(500, 27);
            txtCorreo.TabIndex = 3;
            txtCorreo.Text = "EJ: correo@empresa.com";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(500, 29);
            label11.TabIndex = 2;
            label11.Text = "Correo Electrónico*";
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(48, 51, 59);
            panel12.Controls.Add(cboDepartamento);
            panel12.Controls.Add(label12);
            panel12.Location = new Point(511, 333);
            panel12.Margin = new Padding(3, 3, 5, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(500, 60);
            panel12.TabIndex = 8;
            // 
            // cboDepartamento
            // 
            cboDepartamento.BackColor = Color.FromArgb(37, 41, 47);
            cboDepartamento.Dock = DockStyle.Top;
            cboDepartamento.FlatStyle = FlatStyle.Flat;
            cboDepartamento.ForeColor = Color.White;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(0, 29);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(500, 28);
            cboDepartamento.TabIndex = 4;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(500, 29);
            label12.TabIndex = 2;
            label12.Text = "Departamento*";
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(48, 51, 59);
            panel13.Controls.Add(cboPuesto);
            panel13.Controls.Add(label13);
            panel13.Location = new Point(5, 399);
            panel13.Margin = new Padding(5, 3, 3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(500, 60);
            panel13.TabIndex = 8;
            // 
            // cboPuesto
            // 
            cboPuesto.BackColor = Color.FromArgb(37, 41, 47);
            cboPuesto.Dock = DockStyle.Top;
            cboPuesto.FlatStyle = FlatStyle.Flat;
            cboPuesto.ForeColor = Color.White;
            cboPuesto.FormattingEnabled = true;
            cboPuesto.Location = new Point(0, 29);
            cboPuesto.Name = "cboPuesto";
            cboPuesto.Size = new Size(500, 28);
            cboPuesto.TabIndex = 5;
            // 
            // label13
            // 
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(500, 29);
            label13.TabIndex = 2;
            label13.Text = "Puesto*";
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(48, 51, 59);
            panel15.Controls.Add(DTPFechaContratacion);
            panel15.Controls.Add(label15);
            panel15.Location = new Point(511, 399);
            panel15.Margin = new Padding(3, 3, 5, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(500, 60);
            panel15.TabIndex = 9;
            // 
            // DTPFechaContratacion
            // 
            DTPFechaContratacion.BorderColor = Color.FromArgb(12, 215, 253);
            DTPFechaContratacion.BorderSize = 2;
            DTPFechaContratacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPFechaContratacion.Format = DateTimePickerFormat.Short;
            DTPFechaContratacion.Location = new Point(3, 25);
            DTPFechaContratacion.MinimumSize = new Size(0, 35);
            DTPFechaContratacion.Name = "DTPFechaContratacion";
            DTPFechaContratacion.Size = new Size(147, 35);
            DTPFechaContratacion.SkinColor = Color.FromArgb(48, 51, 59);
            DTPFechaContratacion.TabIndex = 4;
            DTPFechaContratacion.TextColor = Color.FromArgb(12, 215, 253);
            // 
            // label15
            // 
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(500, 29);
            label15.TabIndex = 2;
            label15.Text = "Fecha de Contratación*";
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(48, 51, 59);
            panel14.Controls.Add(txtSalario);
            panel14.Controls.Add(label14);
            panel14.Location = new Point(5, 465);
            panel14.Margin = new Padding(5, 3, 3, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(500, 60);
            panel14.TabIndex = 9;
            // 
            // txtSalario
            // 
            txtSalario.BackColor = Color.FromArgb(37, 41, 47);
            txtSalario.Dock = DockStyle.Top;
            txtSalario.ForeColor = Color.DarkGray;
            txtSalario.Location = new Point(0, 29);
            txtSalario.MaxLength = 10;
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(500, 27);
            txtSalario.TabIndex = 3;
            txtSalario.Text = "EJ: 00.00";
            txtSalario.Enter += txtSalario_Enter;
            txtSalario.Leave += txtSalario_Leave;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(500, 29);
            label14.TabIndex = 2;
            label14.Text = "Salario*";
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(48, 51, 59);
            panel16.Controls.Add(label16);
            panel16.Controls.Add(cboEstatus);
            panel16.Location = new Point(511, 465);
            panel16.Margin = new Padding(3, 3, 5, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(500, 60);
            panel16.TabIndex = 9;
            // 
            // label16
            // 
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(500, 29);
            label16.TabIndex = 2;
            label16.Text = "Estatus";
            // 
            // cboEstatus
            // 
            cboEstatus.BackColor = Color.FromArgb(37, 41, 47);
            cboEstatus.FlatStyle = FlatStyle.Flat;
            cboEstatus.ForeColor = Color.White;
            cboEstatus.FormattingEnabled = true;
            cboEstatus.Location = new Point(3, 29);
            cboEstatus.Name = "cboEstatus";
            cboEstatus.Size = new Size(192, 28);
            cboEstatus.TabIndex = 4;
            // 
            // btnRegistrarEmpleado
            // 
            btnRegistrarEmpleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegistrarEmpleado.BackColor = Color.Black;
            btnRegistrarEmpleado.Cursor = Cursors.Hand;
            btnRegistrarEmpleado.FlatAppearance.BorderColor = Color.Lime;
            btnRegistrarEmpleado.FlatAppearance.BorderSize = 2;
            btnRegistrarEmpleado.FlatStyle = FlatStyle.Flat;
            btnRegistrarEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarEmpleado.ForeColor = Color.Azure;
            btnRegistrarEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegistrarEmpleado.IconColor = Color.Lime;
            btnRegistrarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarEmpleado.IconSize = 32;
            btnRegistrarEmpleado.Location = new Point(3, 531);
            btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            btnRegistrarEmpleado.Size = new Size(201, 40);
            btnRegistrarEmpleado.TabIndex = 10;
            btnRegistrarEmpleado.Text = "Registrar Empleado";
            btnRegistrarEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarEmpleado.UseVisualStyleBackColor = false;
            btnRegistrarEmpleado.Click += btnRegistrarEmpleado_Click;
            // 
            // UC_EmpleadosRegistro
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_EmpleadosRegistro";
            Size = new Size(1262, 755);
            Load += UC_EmpleadosRegistro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel16.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Panel panel9;
        private Label label9;
        private Panel panel10;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private Panel panel12;
        private Label label12;
        private Panel panel13;
        private Label label13;
        private Panel panel15;
        private Label label15;
        private Panel panel14;
        private Label label14;
        private Panel panel16;
        private Label label16;
        private TextBox txtApPaterno;
        private TextBox txtApMaterno;
        private TextBox txtDireccion;
        private TextBox txtRFC;
        private TextBox txtCURP;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtSalario;
        private ComboBox cboGenero;
        private ComboBox cboDepartamento;
        private ComboBox cboPuesto;
        private ComboBox cboEstatus;
        private FontAwesome.Sharp.IconButton btnRegistrarEmpleado;
        private Utilities.NominaDatePicker DTPFechaNacimiento;
        private Utilities.NominaDatePicker DTPFechaContratacion;
        private Panel panel17;
        private TextBox txtMatricula;
        private Label lblMatricula;
    }
}
