namespace NominaXpertCore.View.UsersControl
{
    partial class UC_UsuariosAlta
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
            panelContenedor = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ibtnRegresar = new FontAwesome.Sharp.IconButton();
            txtTelefono = new TextBox();
            Nombre = new Label();
            lblTelefono = new Label();
            label10 = new Label();
            txtCurp = new TextBox();
            txtNombre = new TextBox();
            lblCurp = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            panel3 = new Panel();
            txtRfc = new TextBox();
            lblRFC = new Label();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            lblDireccion = new Label();
            ibtnGuardar = new FontAwesome.Sharp.IconButton();
            txtNomUsuario = new TextBox();
            txtContraseña = new TextBox();
            label6 = new Label();
            label9 = new Label();
            cbxEstatus = new ComboBox();
            label7 = new Label();
            lblRol = new Label();
            cbxRoles = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            panelContenedor.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(tableLayoutPanel1);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1262, 705);
            panelContenedor.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 590);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(ibtnRegresar);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(Nombre);
            panel2.Controls.Add(lblTelefono);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCurp);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(lblCurp);
            panel2.Controls.Add(dtpFechaNacimiento);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(lblCorreo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(129, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 584);
            panel2.TabIndex = 0;
            // 
            // ibtnRegresar
            // 
            ibtnRegresar.BackColor = Color.FromArgb(37, 41, 47);
            ibtnRegresar.FlatAppearance.BorderSize = 2;
            ibtnRegresar.FlatStyle = FlatStyle.Flat;
            ibtnRegresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ibtnRegresar.ForeColor = Color.FromArgb(12, 215, 253);
            ibtnRegresar.IconChar = FontAwesome.Sharp.IconChar.LongArrowLeft;
            ibtnRegresar.IconColor = Color.FromArgb(12, 215, 253);
            ibtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnRegresar.IconSize = 24;
            ibtnRegresar.Location = new Point(57, 442);
            ibtnRegresar.Name = "ibtnRegresar";
            ibtnRegresar.Size = new Size(125, 50);
            ibtnRegresar.TabIndex = 114;
            ibtnRegresar.Text = "Regresar";
            ibtnRegresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnRegresar.UseVisualStyleBackColor = false;
            ibtnRegresar.Visible = false;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(37, 41, 47);
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Century", 10F);
            txtTelefono.ForeColor = Color.FromArgb(12, 215, 253);
            txtTelefono.Location = new Point(227, 141);
            txtTelefono.MaxLength = 18;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 28);
            txtTelefono.TabIndex = 113;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            Nombre.ForeColor = Color.FromArgb(12, 215, 253);
            Nombre.Location = new Point(48, 53);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(168, 23);
            Nombre.TabIndex = 104;
            Nombre.Text = "Nombre Completo*";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(12, 215, 253);
            lblTelefono.Location = new Point(48, 146);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 23);
            lblTelefono.TabIndex = 112;
            lblTelefono.Text = "Télefono*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(12, 215, 253);
            label10.Location = new Point(48, 238);
            label10.Name = "label10";
            label10.Size = new Size(160, 23);
            label10.TabIndex = 105;
            label10.Text = "Fecha Nacimiento*";
            // 
            // txtCurp
            // 
            txtCurp.BackColor = Color.FromArgb(37, 41, 47);
            txtCurp.Cursor = Cursors.IBeam;
            txtCurp.Font = new Font("Century", 10F);
            txtCurp.ForeColor = Color.FromArgb(12, 215, 253);
            txtCurp.Location = new Point(227, 91);
            txtCurp.MaxLength = 18;
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(238, 28);
            txtCurp.TabIndex = 111;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(37, 41, 47);
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.FromArgb(12, 215, 253);
            txtNombre.Location = new Point(227, 49);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 26);
            txtNombre.TabIndex = 106;
            // 
            // lblCurp
            // 
            lblCurp.AutoSize = true;
            lblCurp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCurp.ForeColor = Color.FromArgb(12, 215, 253);
            lblCurp.Location = new Point(48, 96);
            lblCurp.Name = "lblCurp";
            lblCurp.Size = new Size(62, 23);
            lblCurp.TabIndex = 110;
            lblCurp.Text = "CURP*";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarForeColor = Color.FromArgb(12, 215, 253);
            dtpFechaNacimiento.CalendarMonthBackground = Color.FromArgb(24, 44, 65);
            dtpFechaNacimiento.CalendarTitleBackColor = Color.FromArgb(12, 215, 253);
            dtpFechaNacimiento.CalendarTitleForeColor = Color.FromArgb(12, 215, 253);
            dtpFechaNacimiento.CalendarTrailingForeColor = Color.FromArgb(12, 215, 253);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(227, 238);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(238, 27);
            dtpFechaNacimiento.TabIndex = 107;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(37, 41, 47);
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Century", 10F);
            txtCorreo.ForeColor = Color.FromArgb(12, 215, 253);
            txtCorreo.Location = new Point(227, 290);
            txtCorreo.MaxLength = 320;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 28);
            txtCorreo.TabIndex = 109;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(12, 215, 253);
            lblCorreo.Location = new Point(48, 294);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(72, 23);
            lblCorreo.TabIndex = 108;
            lblCorreo.Text = "Correo*";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtRfc);
            panel3.Controls.Add(lblRFC);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtDireccion);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblDireccion);
            panel3.Controls.Add(ibtnGuardar);
            panel3.Controls.Add(txtNomUsuario);
            panel3.Controls.Add(txtContraseña);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(cbxEstatus);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblRol);
            panel3.Controls.Add(cbxRoles);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(633, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 584);
            panel3.TabIndex = 1;
            // 
            // txtRfc
            // 
            txtRfc.BackColor = Color.FromArgb(37, 41, 47);
            txtRfc.Cursor = Cursors.IBeam;
            txtRfc.Font = new Font("Century", 10F);
            txtRfc.ForeColor = Color.FromArgb(12, 215, 253);
            txtRfc.Location = new Point(148, 36);
            txtRfc.MaxLength = 13;
            txtRfc.Name = "txtRfc";
            txtRfc.Size = new Size(239, 28);
            txtRfc.TabIndex = 120;
            // 
            // lblRFC
            // 
            lblRFC.AutoSize = true;
            lblRFC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRFC.ForeColor = Color.FromArgb(12, 215, 253);
            lblRFC.Location = new Point(1, 43);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(49, 23);
            lblRFC.TabIndex = 119;
            lblRFC.Text = "RFC*";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 102;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(37, 41, 47);
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Font = new Font("Century", 10F);
            txtDireccion.ForeColor = Color.FromArgb(12, 215, 253);
            txtDireccion.Location = new Point(148, 84);
            txtDireccion.MaxLength = 100;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(239, 28);
            txtDireccion.TabIndex = 118;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 103;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.FromArgb(12, 215, 253);
            lblDireccion.Location = new Point(1, 91);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(93, 23);
            lblDireccion.TabIndex = 117;
            lblDireccion.Text = "Dirección*";
            // 
            // ibtnGuardar
            // 
            ibtnGuardar.BackColor = Color.FromArgb(37, 41, 47);
            ibtnGuardar.FlatAppearance.BorderSize = 2;
            ibtnGuardar.FlatStyle = FlatStyle.Flat;
            ibtnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ibtnGuardar.ForeColor = Color.FromArgb(12, 215, 253);
            ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnGuardar.IconColor = Color.FromArgb(12, 215, 253);
            ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardar.IconSize = 24;
            ibtnGuardar.Location = new Point(262, 442);
            ibtnGuardar.Name = "ibtnGuardar";
            ibtnGuardar.Size = new Size(125, 50);
            ibtnGuardar.TabIndex = 95;
            ibtnGuardar.Text = "Guardar";
            ibtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardar.UseVisualStyleBackColor = false;
            ibtnGuardar.Click += ibtnGuardar_Click;
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.BackColor = Color.FromArgb(37, 41, 47);
            txtNomUsuario.Cursor = Cursors.IBeam;
            txtNomUsuario.Font = new Font("Century", 10F);
            txtNomUsuario.ForeColor = Color.FromArgb(12, 215, 253);
            txtNomUsuario.Location = new Point(148, 227);
            txtNomUsuario.MaxLength = 50;
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(239, 28);
            txtNomUsuario.TabIndex = 116;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(37, 41, 47);
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Font = new Font("Century", 10F);
            txtContraseña.ForeColor = Color.FromArgb(12, 215, 253);
            txtContraseña.Location = new Point(148, 274);
            txtContraseña.MaxLength = 100;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(239, 28);
            txtContraseña.TabIndex = 115;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(12, 215, 253);
            label6.Location = new Point(1, 133);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 108;
            label6.Text = "Estatus*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(12, 215, 253);
            label9.Location = new Point(1, 277);
            label9.Name = "label9";
            label9.Size = new Size(107, 23);
            label9.TabIndex = 114;
            label9.Text = "Contraseña*";
            // 
            // cbxEstatus
            // 
            cbxEstatus.BackColor = Color.FromArgb(37, 41, 47);
            cbxEstatus.Font = new Font("Century", 10F);
            cbxEstatus.ForeColor = Color.FromArgb(12, 215, 253);
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(148, 133);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(239, 29);
            cbxEstatus.TabIndex = 109;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(12, 215, 253);
            label7.Location = new Point(1, 234);
            label7.Name = "label7";
            label7.Size = new Size(149, 23);
            label7.TabIndex = 113;
            label7.Text = "Nombre Usuario*";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblRol.ForeColor = Color.FromArgb(12, 215, 253);
            lblRol.Location = new Point(1, 184);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(44, 23);
            lblRol.TabIndex = 110;
            lblRol.Text = "Rol*";
            // 
            // cbxRoles
            // 
            cbxRoles.BackColor = Color.FromArgb(37, 41, 47);
            cbxRoles.Font = new Font("Century", 10F);
            cbxRoles.ForeColor = Color.FromArgb(12, 215, 253);
            cbxRoles.FormattingEnabled = true;
            cbxRoles.Location = new Point(148, 181);
            cbxRoles.Name = "cbxRoles";
            cbxRoles.Size = new Size(239, 29);
            cbxRoles.TabIndex = 111;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 51, 59);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 67);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 51, 59);
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(380, 35);
            label1.TabIndex = 0;
            label1.Text = "Formulario de alta de usuarios";
            // 
            // UC_UsuariosAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(panelContenedor);
            ForeColor = Color.FromArgb(12, 215, 253);
            Name = "UC_UsuariosAlta";
            Size = new Size(1262, 705);
            panelContenedor.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnRegresar;
        private TextBox txtTelefono;
        private Label Nombre;
        private Label lblTelefono;
        private Label label10;
        private TextBox txtCurp;
        private TextBox txtNombre;
        private Label lblCurp;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Panel panel3;
        private TextBox txtRfc;
        private Label lblRFC;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private Label lblDireccion;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private TextBox txtNomUsuario;
        private TextBox txtContraseña;
        private Label label6;
        private Label label9;
        private ComboBox cbxEstatus;
        private Label label7;
        private Label lblRol;
        private ComboBox cbxRoles;
        private Panel panel1;
        private Label label1;
    }
}
