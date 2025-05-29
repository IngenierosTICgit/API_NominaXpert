namespace NominaXpertCore.View.ChildForms
{
    partial class frmReporteAuditorias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            btnLimpiarFiltros = new Button();
            btnSearch = new Button();
            cboTipoAccion = new ComboBox();
            label3 = new Label();
            txtSearchTable = new TextBox();
            iconPIcture = new FontAwesome.Sharp.IconPictureBox();
            gBoxMatricula = new GroupBox();
            btnFiltrarFechas = new Button();
            panel6 = new Panel();
            btnEsportarExcel = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            DTPFechaFin = new NominaXpertCore.Utilities.NominaDatePicker();
            DTPFechaInicio = new NominaXpertCore.Utilities.NominaDatePicker();
            gBoxHistorial = new GroupBox();
            dataGridView1 = new DataGridView();
            Id_Auditoria = new DataGridViewTextBoxColumn();
            Id_usuario = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewTextBoxColumn();
            detalle_accion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            DireccionIP = new DataGridViewTextBoxColumn();
            NombreEquipo = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).BeginInit();
            gBoxMatricula.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            gBoxHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 112);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(674, 46);
            label2.TabIndex = 3;
            label2.Text = "Visualiza, filtra y exporta las acciones de todos los usuarios de nuestro sistema.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(286, 35);
            label1.TabIndex = 0;
            label1.Text = "Historial de Auditorías";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 41, 47);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnLimpiarFiltros);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(cboTipoAccion);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtSearchTable);
            panel2.Controls.Add(iconPIcture);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 64);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(76, 19);
            label8.Name = "label8";
            label8.Size = new Size(106, 22);
            label8.TabIndex = 17;
            label8.Text = "ID usuario:";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Black;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Popup;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarFiltros.ForeColor = Color.White;
            btnLimpiarFiltros.Location = new Point(1030, 19);
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
            btnSearch.Location = new Point(899, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboTipoAccion
            // 
            cboTipoAccion.BackColor = Color.FromArgb(37, 41, 47);
            cboTipoAccion.ForeColor = Color.White;
            cboTipoAccion.FormattingEnabled = true;
            cboTipoAccion.Location = new Point(643, 17);
            cboTipoAccion.Name = "cboTipoAccion";
            cboTipoAccion.Size = new Size(188, 28);
            cboTipoAccion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(12, 215, 253);
            label3.Location = new Point(497, 19);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 2;
            label3.Text = "Tipo de acción";
            // 
            // txtSearchTable
            // 
            txtSearchTable.BackColor = Color.FromArgb(37, 41, 47);
            txtSearchTable.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTable.ForeColor = Color.LightGray;
            txtSearchTable.Location = new Point(179, 17);
            txtSearchTable.Name = "txtSearchTable";
            txtSearchTable.Size = new Size(285, 27);
            txtSearchTable.TabIndex = 1;
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
            // gBoxMatricula
            // 
            gBoxMatricula.Controls.Add(btnFiltrarFechas);
            gBoxMatricula.Controls.Add(panel6);
            gBoxMatricula.Controls.Add(label6);
            gBoxMatricula.Controls.Add(panel3);
            gBoxMatricula.Controls.Add(label5);
            gBoxMatricula.Controls.Add(DTPFechaFin);
            gBoxMatricula.Controls.Add(DTPFechaInicio);
            gBoxMatricula.Dock = DockStyle.Top;
            gBoxMatricula.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxMatricula.ForeColor = Color.White;
            gBoxMatricula.Location = new Point(0, 176);
            gBoxMatricula.Name = "gBoxMatricula";
            gBoxMatricula.Size = new Size(1262, 92);
            gBoxMatricula.TabIndex = 19;
            gBoxMatricula.TabStop = false;
            gBoxMatricula.Text = "Acciones de Auditorías Recuperados";
            // 
            // btnFiltrarFechas
            // 
            btnFiltrarFechas.BackColor = Color.Black;
            btnFiltrarFechas.FlatStyle = FlatStyle.Popup;
            btnFiltrarFechas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrarFechas.ForeColor = Color.White;
            btnFiltrarFechas.Location = new Point(389, 52);
            btnFiltrarFechas.Name = "btnFiltrarFechas";
            btnFiltrarFechas.Size = new Size(133, 29);
            btnFiltrarFechas.TabIndex = 17;
            btnFiltrarFechas.Text = "Filtrar fechas";
            btnFiltrarFechas.UseVisualStyleBackColor = false;
            btnFiltrarFechas.Click += btnFiltrarFechas_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnEsportarExcel);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(957, 13);
            panel6.Name = "panel6";
            panel6.Size = new Size(293, 73);
            panel6.TabIndex = 16;
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
            btnEsportarExcel.Location = new Point(3, 33);
            btnEsportarExcel.Name = "btnEsportarExcel";
            btnEsportarExcel.Size = new Size(290, 40);
            btnEsportarExcel.TabIndex = 11;
            btnEsportarExcel.Text = "Descargar Excel de búsquedad";
            btnEsportarExcel.TextAlign = ContentAlignment.MiddleRight;
            btnEsportarExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEsportarExcel.UseVisualStyleBackColor = false;
            btnEsportarExcel.Click += btnEsportarExcel_Click;
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
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Location = new Point(698, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 73);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 215, 253);
            label4.Location = new Point(19, 33);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 8;
            label4.Text = "Total de Registros: ";
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
            // DTPFechaFin
            // 
            DTPFechaFin.BorderColor = Color.FromArgb(12, 215, 253);
            DTPFechaFin.BorderSize = 2;
            DTPFechaFin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPFechaFin.Format = DateTimePickerFormat.Short;
            DTPFechaFin.Location = new Point(205, 51);
            DTPFechaFin.MinimumSize = new Size(0, 35);
            DTPFechaFin.Name = "DTPFechaFin";
            DTPFechaFin.Size = new Size(147, 35);
            DTPFechaFin.SkinColor = Color.FromArgb(48, 51, 59);
            DTPFechaFin.TabIndex = 13;
            DTPFechaFin.TextColor = Color.FromArgb(12, 215, 253);
            // 
            // DTPFechaInicio
            // 
            DTPFechaInicio.BorderColor = Color.FromArgb(12, 215, 253);
            DTPFechaInicio.BorderSize = 2;
            DTPFechaInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DTPFechaInicio.Format = DateTimePickerFormat.Short;
            DTPFechaInicio.Location = new Point(18, 51);
            DTPFechaInicio.MinimumSize = new Size(0, 35);
            DTPFechaInicio.Name = "DTPFechaInicio";
            DTPFechaInicio.Size = new Size(147, 35);
            DTPFechaInicio.SkinColor = Color.FromArgb(48, 51, 59);
            DTPFechaInicio.TabIndex = 12;
            DTPFechaInicio.TextColor = Color.FromArgb(12, 215, 253);
            // 
            // gBoxHistorial
            // 
            gBoxHistorial.Controls.Add(dataGridView1);
            gBoxHistorial.Dock = DockStyle.Top;
            gBoxHistorial.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxHistorial.ForeColor = SystemColors.ButtonHighlight;
            gBoxHistorial.Location = new Point(0, 268);
            gBoxHistorial.Name = "gBoxHistorial";
            gBoxHistorial.Size = new Size(1262, 452);
            gBoxHistorial.TabIndex = 20;
            gBoxHistorial.TabStop = false;
            gBoxHistorial.Text = "Historial de Auditorías";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Auditoria, Id_usuario, Accion, detalle_accion, Fecha, DireccionIP, NombreEquipo, Hora });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 45, 48);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkCyan;
            dataGridView1.Location = new Point(12, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(1226, 420);
            dataGridView1.TabIndex = 0;
            // 
            // Id_Auditoria
            // 
            Id_Auditoria.HeaderText = "No. de Auditoría";
            Id_Auditoria.MinimumWidth = 6;
            Id_Auditoria.Name = "Id_Auditoria";
            Id_Auditoria.ReadOnly = true;
            Id_Auditoria.Width = 147;
            // 
            // Id_usuario
            // 
            Id_usuario.HeaderText = "Id_usuario";
            Id_usuario.MinimumWidth = 6;
            Id_usuario.Name = "Id_usuario";
            Id_usuario.ReadOnly = true;
            Id_usuario.Width = 147;
            // 
            // Accion
            // 
            Accion.HeaderText = "Acción";
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            Accion.ReadOnly = true;
            Accion.Width = 147;
            // 
            // detalle_accion
            // 
            detalle_accion.HeaderText = "Detalle Acción";
            detalle_accion.MinimumWidth = 6;
            detalle_accion.Name = "detalle_accion";
            detalle_accion.ReadOnly = true;
            detalle_accion.Width = 147;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 146;
            // 
            // DireccionIP
            // 
            DireccionIP.HeaderText = "Dirección IP";
            DireccionIP.MinimumWidth = 6;
            DireccionIP.Name = "DireccionIP";
            DireccionIP.ReadOnly = true;
            DireccionIP.Width = 147;
            // 
            // NombreEquipo
            // 
            NombreEquipo.HeaderText = "Nombre de Equipo";
            NombreEquipo.MinimumWidth = 6;
            NombreEquipo.Name = "NombreEquipo";
            NombreEquipo.ReadOnly = true;
            NombreEquipo.Width = 147;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.MinimumWidth = 6;
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 147;
            // 
            // frmReporteAuditorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            ClientSize = new Size(1262, 769);
            Controls.Add(gBoxHistorial);
            Controls.Add(gBoxMatricula);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmReporteAuditorias";
            Text = "fmReporteAuditorias";
            Load += fmReporteAuditorias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPIcture).EndInit();
            gBoxMatricula.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gBoxHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnLimpiarFiltros;
        private Button btnSearch;
        private ComboBox cboTipoAccion;
        private Label label3;
        private TextBox txtSearchTable;
        private FontAwesome.Sharp.IconPictureBox iconPIcture;
        private GroupBox gBoxMatricula;
        private Label label6;
        private Panel panel3;
        private Label label4;
        private Label label5;
        private Utilities.NominaDatePicker DTPFechaFin;
        private Utilities.NominaDatePicker DTPFechaInicio;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnEsportarExcel;
        private Label label7;
        private GroupBox gBoxHistorial;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_Auditoria;
        private DataGridViewTextBoxColumn Id_usuario;
        private DataGridViewTextBoxColumn Accion;
        private DataGridViewTextBoxColumn detalle_accion;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn DireccionIP;
        private DataGridViewTextBoxColumn NombreEquipo;
        private DataGridViewTextBoxColumn Hora;
        private Label label8;
        private Button btnFiltrarFechas;
    }
}