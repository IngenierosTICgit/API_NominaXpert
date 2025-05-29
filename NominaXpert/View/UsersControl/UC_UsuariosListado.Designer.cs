namespace NominaXpertCore.View.UsersControl
{
    partial class UC_UsuariosListado
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
            txtSearchUsuario = new TextBox();
            cbxEstatus = new ComboBox();
            lblRegistroUsuarios = new Label();
            btnRefrescar = new FontAwesome.Sharp.IconButton();
            dgvListadoUsuario = new DataGridView();
            btn_buscar = new Button();
            iconPIcture = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            ibtnBajaUsuario = new FontAwesome.Sharp.IconButton();
            lblTituloListado = new Label();
            label4 = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(txtSearchUsuario);
            panelContenedor.Controls.Add(cbxEstatus);
            panelContenedor.Controls.Add(lblRegistroUsuarios);
            panelContenedor.Controls.Add(btnRefrescar);
            panelContenedor.Controls.Add(dgvListadoUsuario);
            panelContenedor.Controls.Add(btn_buscar);
            panelContenedor.Controls.Add(iconPIcture);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Location = new Point(0, -1);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1262, 705);
            panelContenedor.TabIndex = 0;
            // 
            // txtSearchUsuario
            // 
            txtSearchUsuario.BackColor = Color.FromArgb(37, 41, 47);
            txtSearchUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtSearchUsuario.ForeColor = Color.LightGray;
            txtSearchUsuario.Location = new Point(177, 118);
            txtSearchUsuario.Name = "txtSearchUsuario";
            txtSearchUsuario.Size = new Size(556, 27);
            txtSearchUsuario.TabIndex = 98;
            txtSearchUsuario.Text = "Buscar usuarios";
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(998, 156);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(151, 28);
            cbxEstatus.TabIndex = 97;
            cbxEstatus.SelectedIndexChanged += cbxEstatus_SelectedIndexChanged;
            // 
            // lblRegistroUsuarios
            // 
            lblRegistroUsuarios.AutoSize = true;
            lblRegistroUsuarios.ForeColor = Color.FromArgb(12, 215, 253);
            lblRegistroUsuarios.Location = new Point(944, 125);
            lblRegistroUsuarios.Name = "lblRegistroUsuarios";
            lblRegistroUsuarios.Size = new Size(104, 20);
            lblRegistroUsuarios.TabIndex = 96;
            lblRegistroUsuarios.Text = "No. Registros: ";
            lblRegistroUsuarios.Click += lblRegistroUsuarios_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.FromArgb(37, 41, 47);
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefrescar.ForeColor = Color.FromArgb(12, 215, 253);
            btnRefrescar.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefrescar.IconColor = Color.FromArgb(12, 215, 253);
            btnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefrescar.IconSize = 24;
            btnRefrescar.Location = new Point(104, 156);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(125, 41);
            btnRefrescar.TabIndex = 95;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // dgvListadoUsuario
            // 
            dgvListadoUsuario.BackgroundColor = Color.FromArgb(37, 41, 47);
            dgvListadoUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoUsuario.Location = new Point(104, 203);
            dgvListadoUsuario.Name = "dgvListadoUsuario";
            dgvListadoUsuario.RowHeadersWidth = 51;
            dgvListadoUsuario.Size = new Size(1042, 400);
            dgvListadoUsuario.TabIndex = 16;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.Black;
            btn_buscar.FlatStyle = FlatStyle.Popup;
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Location = new Point(772, 121);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 15;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // iconPIcture
            // 
            iconPIcture.BackColor = Color.FromArgb(37, 41, 47);
            iconPIcture.ForeColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPIcture.IconColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPIcture.IconSize = 36;
            iconPIcture.Location = new Point(104, 112);
            iconPIcture.Name = "iconPIcture";
            iconPIcture.Size = new Size(40, 36);
            iconPIcture.TabIndex = 13;
            iconPIcture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 51, 59);
            panel1.Controls.Add(ibtnEditar);
            panel1.Controls.Add(ibtnBajaUsuario);
            panel1.Controls.Add(lblTituloListado);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 90);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // ibtnEditar
            // 
            ibtnEditar.BackColor = Color.FromArgb(37, 41, 47);
            ibtnEditar.FlatStyle = FlatStyle.Flat;
            ibtnEditar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnEditar.ForeColor = Color.FromArgb(12, 215, 253);
            ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            ibtnEditar.IconColor = Color.FromArgb(12, 215, 253);
            ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEditar.IconSize = 24;
            ibtnEditar.Location = new Point(1029, 36);
            ibtnEditar.Name = "ibtnEditar";
            ibtnEditar.Size = new Size(125, 41);
            ibtnEditar.TabIndex = 94;
            ibtnEditar.Text = "Editar";
            ibtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEditar.UseVisualStyleBackColor = false;
            ibtnEditar.Click += ibtnEditar_Click;
            // 
            // ibtnBajaUsuario
            // 
            ibtnBajaUsuario.BackColor = Color.FromArgb(37, 41, 47);
            ibtnBajaUsuario.FlatStyle = FlatStyle.Flat;
            ibtnBajaUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnBajaUsuario.ForeColor = Color.FromArgb(12, 215, 253);
            ibtnBajaUsuario.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            ibtnBajaUsuario.IconColor = Color.FromArgb(12, 215, 253);
            ibtnBajaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnBajaUsuario.IconSize = 24;
            ibtnBajaUsuario.Location = new Point(872, 36);
            ibtnBajaUsuario.Name = "ibtnBajaUsuario";
            ibtnBajaUsuario.Size = new Size(125, 41);
            ibtnBajaUsuario.TabIndex = 93;
            ibtnBajaUsuario.Text = "Baja";
            ibtnBajaUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnBajaUsuario.UseVisualStyleBackColor = false;
            ibtnBajaUsuario.Click += ibtnBajaUsuario_Click;
            // 
            // lblTituloListado
            // 
            lblTituloListado.AutoSize = true;
            lblTituloListado.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            lblTituloListado.ForeColor = Color.FromArgb(12, 215, 253);
            lblTituloListado.Location = new Point(40, 37);
            lblTituloListado.Name = "lblTituloListado";
            lblTituloListado.Size = new Size(253, 35);
            lblTituloListado.TabIndex = 9;
            lblTituloListado.Text = "Listado de Usuarios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 215, 253);
            label4.Location = new Point(911, 161);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 100;
            label4.Text = "Estatus";
            // 
            // UC_UsuariosListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(panelContenedor);
            Name = "UC_UsuariosListado";
            Size = new Size(1262, 705);
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panel1;
        private Label lblTituloListado;
        private FontAwesome.Sharp.IconButton ibtnBajaUsuario;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private DataGridView dgvListadoUsuario;
        private Button btn_buscar;
        private FontAwesome.Sharp.IconPictureBox iconPIcture;
        private FontAwesome.Sharp.IconButton btnRefrescar;
        private Label lblRegistroUsuarios;
        private ComboBox cbxEstatus;
        private TextBox txtSearchUsuario;
        private Label label4;
    }
}
