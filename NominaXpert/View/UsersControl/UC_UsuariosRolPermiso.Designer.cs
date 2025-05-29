namespace NominaXpertCore.View.UsersControl
{
    partial class UC_UsuariosRolPermiso
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
            panel = new Panel();
            panelContenedor = new Panel();
            cbxEstatus = new ComboBox();
            btnRefrescar = new FontAwesome.Sharp.IconButton();
            lblRegistros = new Label();
            dtgRoles = new DataGridView();
            btnSearch = new Button();
            txtBuscarRol = new TextBox();
            iconPIcture = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            ibtnEditar = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label4 = new Label();
            panel.SuspendLayout();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(panelContenedor);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(1262, 705);
            panel.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(label4);
            panelContenedor.Controls.Add(cbxEstatus);
            panelContenedor.Controls.Add(btnRefrescar);
            panelContenedor.Controls.Add(lblRegistros);
            panelContenedor.Controls.Add(dtgRoles);
            panelContenedor.Controls.Add(btnSearch);
            panelContenedor.Controls.Add(txtBuscarRol);
            panelContenedor.Controls.Add(iconPIcture);
            panelContenedor.Controls.Add(panel2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1262, 705);
            panelContenedor.TabIndex = 0;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(982, 192);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(151, 28);
            cbxEstatus.TabIndex = 98;
            cbxEstatus.SelectedIndexChanged += cbxEstatus_SelectedIndexChanged;
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
            btnRefrescar.Location = new Point(90, 184);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(125, 41);
            btnRefrescar.TabIndex = 96;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(945, 159);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(104, 20);
            lblRegistros.TabIndex = 49;
            lblRegistros.Text = "No. Registros: ";
            // 
            // dtgRoles
            // 
            dtgRoles.BackgroundColor = Color.FromArgb(37, 41, 47);
            dtgRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRoles.Location = new Point(90, 231);
            dtgRoles.Name = "dtgRoles";
            dtgRoles.RowHeadersWidth = 51;
            dtgRoles.Size = new Size(1043, 425);
            dtgRoles.TabIndex = 48;
            dtgRoles.CellContentClick += dtgRoles_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(758, 151);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 47;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBuscarRol
            // 
            txtBuscarRol.BackColor = Color.FromArgb(37, 41, 47);
            txtBuscarRol.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarRol.ForeColor = Color.LightGray;
            txtBuscarRol.Location = new Point(136, 151);
            txtBuscarRol.Name = "txtBuscarRol";
            txtBuscarRol.Size = new Size(585, 27);
            txtBuscarRol.TabIndex = 46;
            txtBuscarRol.Text = "Buscar rol";
            // 
            // iconPIcture
            // 
            iconPIcture.BackColor = Color.FromArgb(37, 41, 47);
            iconPIcture.ForeColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPIcture.IconColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPIcture.IconSize = 36;
            iconPIcture.Location = new Point(90, 142);
            iconPIcture.Name = "iconPIcture";
            iconPIcture.Size = new Size(40, 36);
            iconPIcture.TabIndex = 45;
            iconPIcture.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 51, 59);
            panel2.Controls.Add(ibtnEditar);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 84);
            panel2.TabIndex = 44;
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
            ibtnEditar.Location = new Point(974, 27);
            ibtnEditar.Name = "ibtnEditar";
            ibtnEditar.Size = new Size(125, 41);
            ibtnEditar.TabIndex = 96;
            ibtnEditar.Text = "Editar";
            ibtnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEditar.UseVisualStyleBackColor = false;
            ibtnEditar.Click += ibtnEditar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(12, 245, 253);
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 35);
            label1.TabIndex = 0;
            label1.Text = "Roles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 215, 253);
            label4.Location = new Point(885, 193);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 99;
            label4.Text = "Estatus";
            // 
            // UC_UsuariosRolPermiso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(panel);
            ForeColor = Color.FromArgb(12, 215, 253);
            Name = "UC_UsuariosRolPermiso";
            Size = new Size(1262, 705);
            panel.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Panel panelContenedor;
        private DataGridView dtgRoles;
        private Button btnSearch;
        private TextBox txtBuscarRol;
        private FontAwesome.Sharp.IconPictureBox iconPIcture;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private Label label1;
        private Label lblRegistros;
        private FontAwesome.Sharp.IconButton btnRefrescar;
        private ComboBox cbxEstatus;
        private Label label4;
    }
}
