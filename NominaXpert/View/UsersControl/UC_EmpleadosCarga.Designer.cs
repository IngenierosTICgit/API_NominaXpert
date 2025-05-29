namespace NominaXpertCore.View.UsersControl
{
    partial class UC_EmpleadosCarga
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
            panelTexto = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel5 = new Panel();
            lbltext1 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            panel9 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel10 = new Panel();
            btnProcesarCSV = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            btnSubirArchivo = new Button();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            iconUpLoad = new FontAwesome.Sharp.IconPictureBox();
            panel7 = new Panel();
            panel8 = new Panel();
            OPFArchivo = new OpenFileDialog();
            panel1.SuspendLayout();
            panelTexto.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUpLoad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(350, 35);
            label1.TabIndex = 1;
            label1.Text = "Carga Masiva de Empleados";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 123);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(540, 50);
            label2.TabIndex = 2;
            label2.Text = "Importa múltiples empleados a la vez mediante un archivo CSV.";
            // 
            // panelTexto
            // 
            panelTexto.Controls.Add(tableLayoutPanel2);
            panelTexto.Controls.Add(tableLayoutPanel1);
            panelTexto.Dock = DockStyle.Fill;
            panelTexto.Location = new Point(0, 123);
            panelTexto.Name = "panelTexto";
            panelTexto.Size = new Size(1262, 646);
            panelTexto.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Controls.Add(panel9, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 325);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1262, 318);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbltext1);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(751, 312);
            panel5.TabIndex = 0;
            // 
            // lbltext1
            // 
            lbltext1.Dock = DockStyle.Fill;
            lbltext1.Font = new Font("Corbel", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext1.ForeColor = Color.White;
            lbltext1.Location = new Point(0, 118);
            lbltext1.Name = "lbltext1";
            lbltext1.Size = new Size(751, 194);
            lbltext1.TabIndex = 5;
            lbltext1.Text = "Ejemplo";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 80);
            label6.Name = "label6";
            label6.Size = new Size(751, 38);
            label6.TabIndex = 4;
            label6.Text = "El archivo CSV debe tener las siguientes columnas:";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(0, 37);
            label5.Name = "label5";
            label5.Size = new Size(751, 43);
            label5.TabIndex = 3;
            label5.Text = "Instrucciones";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(751, 37);
            panel6.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.AutoScroll = true;
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(760, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(499, 312);
            panel9.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel7, 0, 0);
            tableLayoutPanel1.Controls.Add(panel8, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 325);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 51, 59);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(255, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 319);
            panel2.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnProcesarCSV);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 238);
            panel10.Name = "panel10";
            panel10.Size = new Size(751, 81);
            panel10.TabIndex = 5;
            // 
            // btnProcesarCSV
            // 
            btnProcesarCSV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProcesarCSV.BackColor = Color.FromArgb(48, 51, 59);
            btnProcesarCSV.FlatAppearance.BorderColor = Color.Cyan;
            btnProcesarCSV.FlatAppearance.BorderSize = 2;
            btnProcesarCSV.FlatStyle = FlatStyle.Flat;
            btnProcesarCSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcesarCSV.ForeColor = Color.FromArgb(12, 215, 253);
            btnProcesarCSV.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnProcesarCSV.IconColor = Color.FromArgb(12, 215, 253);
            btnProcesarCSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProcesarCSV.IconSize = 32;
            btnProcesarCSV.Location = new Point(520, 29);
            btnProcesarCSV.Name = "btnProcesarCSV";
            btnProcesarCSV.Size = new Size(213, 40);
            btnProcesarCSV.TabIndex = 0;
            btnProcesarCSV.Text = "Procesar Importación";
            btnProcesarCSV.TextAlign = ContentAlignment.MiddleRight;
            btnProcesarCSV.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProcesarCSV.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSubirArchivo);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(751, 47);
            panel4.TabIndex = 4;
            // 
            // btnSubirArchivo
            // 
            btnSubirArchivo.Anchor = AnchorStyles.None;
            btnSubirArchivo.BackColor = Color.Black;
            btnSubirArchivo.Cursor = Cursors.Hand;
            btnSubirArchivo.FlatStyle = FlatStyle.Popup;
            btnSubirArchivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubirArchivo.ForeColor = Color.White;
            btnSubirArchivo.Location = new Point(278, 3);
            btnSubirArchivo.Name = "btnSubirArchivo";
            btnSubirArchivo.Size = new Size(179, 41);
            btnSubirArchivo.TabIndex = 0;
            btnSubirArchivo.Text = "Seleccionar Archivo";
            btnSubirArchivo.UseVisualStyleBackColor = false;
            btnSubirArchivo.Click += btnSubirArchivo_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 215, 253);
            label4.Location = new Point(0, 141);
            label4.Name = "label4";
            label4.Size = new Size(751, 50);
            label4.TabIndex = 3;
            label4.Text = "Favor de seleccionar la ruta del archivo correcta a importar ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 109);
            label3.Name = "label3";
            label3.Size = new Size(751, 32);
            label3.TabIndex = 2;
            label3.Text = "Sube tu Archivo CSV ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconUpLoad);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(751, 109);
            panel3.TabIndex = 1;
            // 
            // iconUpLoad
            // 
            iconUpLoad.Anchor = AnchorStyles.None;
            iconUpLoad.BackColor = Color.FromArgb(48, 51, 59);
            iconUpLoad.ForeColor = Color.FromArgb(12, 215, 253);
            iconUpLoad.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            iconUpLoad.IconColor = Color.FromArgb(12, 215, 253);
            iconUpLoad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUpLoad.IconSize = 61;
            iconUpLoad.Location = new Point(344, 22);
            iconUpLoad.Name = "iconUpLoad";
            iconUpLoad.Size = new Size(61, 63);
            iconUpLoad.TabIndex = 0;
            iconUpLoad.TabStop = false;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(246, 319);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(1012, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(247, 319);
            panel8.TabIndex = 2;
            // 
            // OPFArchivo
            // 
            OPFArchivo.FileName = "Carga masiva de Estudiantes";
            // 
            // UC_EmpleadosCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(panelTexto);
            Controls.Add(panel1);
            Name = "UC_EmpleadosCarga";
            Size = new Size(1262, 769);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTexto.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconUpLoad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panelTexto;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconUpLoad;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Button btnSubirArchivo;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label lbltext1;
        private Label label6;
        private Panel panel9;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private FontAwesome.Sharp.IconButton btnProcesarCSV;
        private OpenFileDialog OPFArchivo;
    }
}
