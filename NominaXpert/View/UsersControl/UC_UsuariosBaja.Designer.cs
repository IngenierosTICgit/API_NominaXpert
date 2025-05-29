namespace NominaXpertCore.View.UsersControl
{
    partial class UC_UsuariosBaja
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
            panelContainer = new Panel();
            btnSearch = new Button();
            txtSearchEmpleado = new TextBox();
            iconPIcture = new FontAwesome.Sharp.IconPictureBox();
            dtpFechaBaja = new NominaXpertCore.Utilities.NominaDatePicker();
            ibtnCancelar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTituloBaja = new Label();
            ibtnGuardar = new FontAwesome.Sharp.IconButton();
            cbxMotivoBaja = new ComboBox();
            lblMotivoBaja = new Label();
            lblSeleccionUsuario = new Label();
            cbxUsuario = new ComboBox();
            label10 = new Label();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(btnSearch);
            panelContainer.Controls.Add(txtSearchEmpleado);
            panelContainer.Controls.Add(iconPIcture);
            panelContainer.Controls.Add(dtpFechaBaja);
            panelContainer.Controls.Add(ibtnCancelar);
            panelContainer.Controls.Add(panel1);
            panelContainer.Controls.Add(ibtnGuardar);
            panelContainer.Controls.Add(cbxMotivoBaja);
            panelContainer.Controls.Add(lblMotivoBaja);
            panelContainer.Controls.Add(lblSeleccionUsuario);
            panelContainer.Controls.Add(cbxUsuario);
            panelContainer.Controls.Add(label10);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1262, 705);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(727, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 96;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchEmpleado
            // 
            txtSearchEmpleado.BackColor = Color.FromArgb(37, 41, 47);
            txtSearchEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtSearchEmpleado.ForeColor = Color.LightGray;
            txtSearchEmpleado.Location = new Point(105, 113);
            txtSearchEmpleado.Name = "txtSearchEmpleado";
            txtSearchEmpleado.Size = new Size(585, 27);
            txtSearchEmpleado.TabIndex = 95;
            txtSearchEmpleado.Text = "Buscar usuario";
            // 
            // iconPIcture
            // 
            iconPIcture.BackColor = Color.FromArgb(37, 41, 47);
            iconPIcture.ForeColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPIcture.IconColor = Color.FromArgb(12, 215, 253);
            iconPIcture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPIcture.IconSize = 36;
            iconPIcture.Location = new Point(59, 104);
            iconPIcture.Name = "iconPIcture";
            iconPIcture.Size = new Size(40, 36);
            iconPIcture.TabIndex = 94;
            iconPIcture.TabStop = false;
            // 
            // dtpFechaBaja
            // 
            dtpFechaBaja.BorderColor = Color.FromArgb(12, 215, 253);
            dtpFechaBaja.BorderSize = 2;
            dtpFechaBaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaBaja.Format = DateTimePickerFormat.Short;
            dtpFechaBaja.Location = new Point(213, 409);
            dtpFechaBaja.MinimumSize = new Size(0, 35);
            dtpFechaBaja.Name = "dtpFechaBaja";
            dtpFechaBaja.Size = new Size(147, 35);
            dtpFechaBaja.SkinColor = Color.FromArgb(48, 51, 59);
            dtpFechaBaja.TabIndex = 93;
            dtpFechaBaja.TextColor = Color.FromArgb(12, 215, 253);
            dtpFechaBaja.Value = new DateTime(2025, 3, 12, 1, 10, 15, 0);
            // 
            // ibtnCancelar
            // 
            ibtnCancelar.BackColor = Color.FromArgb(37, 41, 47);
            ibtnCancelar.FlatStyle = FlatStyle.Flat;
            ibtnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnCancelar.ForeColor = Color.FromArgb(12, 215, 253);
            ibtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            ibtnCancelar.IconColor = Color.FromArgb(12, 215, 253);
            ibtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancelar.IconSize = 24;
            ibtnCancelar.Location = new Point(213, 582);
            ibtnCancelar.Name = "ibtnCancelar";
            ibtnCancelar.Size = new Size(125, 41);
            ibtnCancelar.TabIndex = 92;
            ibtnCancelar.Text = "Cancelar";
            ibtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCancelar.UseVisualStyleBackColor = false;
            ibtnCancelar.Click += ibtnCancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 51, 59);
            panel1.Controls.Add(lblTituloBaja);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 85);
            panel1.TabIndex = 82;
            // 
            // lblTituloBaja
            // 
            lblTituloBaja.AutoSize = true;
            lblTituloBaja.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            lblTituloBaja.ForeColor = Color.FromArgb(12, 215, 253);
            lblTituloBaja.Location = new Point(35, 31);
            lblTituloBaja.Name = "lblTituloBaja";
            lblTituloBaja.Size = new Size(214, 35);
            lblTituloBaja.TabIndex = 0;
            lblTituloBaja.Text = "Baja de Usuarios";
            // 
            // ibtnGuardar
            // 
            ibtnGuardar.BackColor = Color.FromArgb(37, 41, 47);
            ibtnGuardar.FlatStyle = FlatStyle.Flat;
            ibtnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ibtnGuardar.ForeColor = Color.FromArgb(12, 215, 253);
            ibtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnGuardar.IconColor = Color.FromArgb(12, 215, 253);
            ibtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardar.IconSize = 24;
            ibtnGuardar.Location = new Point(776, 582);
            ibtnGuardar.Name = "ibtnGuardar";
            ibtnGuardar.Size = new Size(125, 41);
            ibtnGuardar.TabIndex = 91;
            ibtnGuardar.Text = "Guardar";
            ibtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardar.UseVisualStyleBackColor = false;
            ibtnGuardar.Click += ibtnGuardar_Click_1;
            // 
            // cbxMotivoBaja
            // 
            cbxMotivoBaja.BackColor = Color.FromArgb(24, 44, 65);
            cbxMotivoBaja.Cursor = Cursors.Hand;
            cbxMotivoBaja.Font = new Font("Century", 10F);
            cbxMotivoBaja.ForeColor = Color.FromArgb(12, 215, 253);
            cbxMotivoBaja.FormattingEnabled = true;
            cbxMotivoBaja.Location = new Point(213, 291);
            cbxMotivoBaja.Name = "cbxMotivoBaja";
            cbxMotivoBaja.Size = new Size(688, 29);
            cbxMotivoBaja.TabIndex = 90;
            cbxMotivoBaja.SelectedIndexChanged += cbxMotivoBaja_SelectedIndexChanged;
            // 
            // lblMotivoBaja
            // 
            lblMotivoBaja.AutoSize = true;
            lblMotivoBaja.Font = new Font("Century", 10F);
            lblMotivoBaja.ForeColor = Color.FromArgb(12, 215, 253);
            lblMotivoBaja.Location = new Point(213, 267);
            lblMotivoBaja.Name = "lblMotivoBaja";
            lblMotivoBaja.Size = new Size(114, 21);
            lblMotivoBaja.TabIndex = 83;
            lblMotivoBaja.Text = "Motivo Baja*";
            // 
            // lblSeleccionUsuario
            // 
            lblSeleccionUsuario.AutoSize = true;
            lblSeleccionUsuario.Font = new Font("Century", 10F);
            lblSeleccionUsuario.ForeColor = Color.FromArgb(12, 215, 253);
            lblSeleccionUsuario.Location = new Point(213, 159);
            lblSeleccionUsuario.Name = "lblSeleccionUsuario";
            lblSeleccionUsuario.Size = new Size(178, 21);
            lblSeleccionUsuario.TabIndex = 84;
            lblSeleccionUsuario.Text = "Seleccionar Usuario*";
            // 
            // cbxUsuario
            // 
            cbxUsuario.BackColor = Color.FromArgb(24, 44, 65);
            cbxUsuario.Cursor = Cursors.Hand;
            cbxUsuario.Font = new Font("Century", 10F);
            cbxUsuario.ForeColor = Color.FromArgb(12, 215, 253);
            cbxUsuario.FormattingEnabled = true;
            cbxUsuario.Location = new Point(213, 183);
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new Size(688, 29);
            cbxUsuario.TabIndex = 88;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 10F);
            label10.ForeColor = Color.FromArgb(12, 215, 253);
            label10.Location = new Point(213, 385);
            label10.Name = "label10";
            label10.Size = new Size(106, 21);
            label10.TabIndex = 85;
            label10.Text = "Fecha Baja*";
            // 
            // UC_UsuariosBaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(panelContainer);
            Name = "UC_UsuariosBaja";
            Size = new Size(1262, 705);
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private FontAwesome.Sharp.IconButton ibtnCancelar;
        private Panel panel1;
        private Label lblTituloBaja;
        private FontAwesome.Sharp.IconButton ibtnGuardar;
        private ComboBox cbxMotivoBaja;
        private Label lblMotivoBaja;
        private Label lblSeleccionUsuario;
        private ComboBox cbxUsuario;
        private Label label10;
        private Utilities.NominaDatePicker dtpFechaBaja;
        private Button btnSearch;
        private TextBox txtSearchEmpleado;
        private FontAwesome.Sharp.IconPictureBox iconPIcture;
    }
}
