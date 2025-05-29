namespace NominaXpertCore.View.Forms
{
    partial class frmDashboard
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
            components = new System.ComponentModel.Container();
            lblBienvenida = new Label();
            lblTexto1 = new Label();
            lblfecha = new Label();
            horaFecha = new System.Windows.Forms.Timer(components);
            icontime = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel10 = new Panel();
            lblEmpleadosInactivos = new Label();
            lblEmpleadosActivos = new Label();
            label4 = new Label();
            panel14 = new Panel();
            iconPn1 = new FontAwesome.Sharp.IconPictureBox();
            panel11 = new Panel();
            lblNominasPendientes = new Label();
            label9 = new Label();
            panel16 = new Panel();
            iconPn3 = new FontAwesome.Sharp.IconPictureBox();
            panel12 = new Panel();
            lblCostoTotalMensual = new Label();
            label7 = new Label();
            panel15 = new Panel();
            iconPn2 = new FontAwesome.Sharp.IconPictureBox();
            panel13 = new Panel();
            lblNominasPagadas = new Label();
            label11 = new Label();
            panel17 = new Panel();
            iconPn4 = new FontAwesome.Sharp.IconPictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel9 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            lbltext3 = new Label();
            panel8 = new Panel();
            label3 = new Label();
            iconReporte = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            lbltext2 = new Label();
            panel7 = new Panel();
            label2 = new Label();
            iconRH = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            lbltext1 = new Label();
            panel6 = new Panel();
            label1 = new Label();
            iconNomina = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)icontime).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPn1).BeginInit();
            panel11.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPn3).BeginInit();
            panel12.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPn2).BeginInit();
            panel13.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPn4).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconReporte).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRH).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconNomina).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(12, 215, 253);
            lblBienvenida.Location = new Point(12, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(453, 45);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido a NóminaXpert";
            // 
            // lblTexto1
            // 
            lblTexto1.AutoSize = true;
            lblTexto1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto1.ForeColor = Color.White;
            lblTexto1.Location = new Point(12, 74);
            lblTexto1.Name = "lblTexto1";
            lblTexto1.Size = new Size(592, 28);
            lblTexto1.TabIndex = 3;
            lblTexto1.Text = "Tu solución integral para la gestión de nómina y recursos humanos";
            // 
            // lblfecha
            // 
            lblfecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblfecha.AutoSize = true;
            lblfecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfecha.ForeColor = Color.PowderBlue;
            lblfecha.Location = new Point(1172, 106);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(59, 25);
            lblfecha.TabIndex = 4;
            lblfecha.Text = "label1";
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick_1;
            // 
            // icontime
            // 
            icontime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icontime.BackColor = Color.FromArgb(37, 41, 47);
            icontime.ForeColor = Color.PowderBlue;
            icontime.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            icontime.IconColor = Color.PowderBlue;
            icontime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icontime.IconSize = 29;
            icontime.Location = new Point(869, 106);
            icontime.Name = "icontime";
            icontime.Size = new Size(30, 29);
            icontime.TabIndex = 6;
            icontime.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(lblTexto1);
            panel1.Controls.Add(lblfecha);
            panel1.Controls.Add(icontime);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 156);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 156);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1244, 566);
            panel2.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.2516327F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.41503F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(panel10, 1, 0);
            tableLayoutPanel2.Controls.Add(panel11, 1, 1);
            tableLayoutPanel2.Controls.Add(panel12, 2, 0);
            tableLayoutPanel2.Controls.Add(panel13, 2, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(10, 277);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1224, 277);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(48, 51, 59);
            panel10.Controls.Add(lblEmpleadosInactivos);
            panel10.Controls.Add(lblEmpleadosActivos);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(panel14);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(207, 3);
            panel10.Margin = new Padding(3, 3, 10, 10);
            panel10.Name = "panel10";
            panel10.Size = new Size(394, 125);
            panel10.TabIndex = 0;
            // 
            // lblEmpleadosInactivos
            // 
            lblEmpleadosInactivos.AutoSize = true;
            lblEmpleadosInactivos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleadosInactivos.ForeColor = Color.White;
            lblEmpleadosInactivos.Location = new Point(204, 77);
            lblEmpleadosInactivos.Name = "lblEmpleadosInactivos";
            lblEmpleadosInactivos.Size = new Size(185, 31);
            lblEmpleadosInactivos.TabIndex = 3;
            lblEmpleadosInactivos.Text = "INACTIVOS: 000";
            // 
            // lblEmpleadosActivos
            // 
            lblEmpleadosActivos.AutoSize = true;
            lblEmpleadosActivos.Dock = DockStyle.Top;
            lblEmpleadosActivos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleadosActivos.ForeColor = Color.White;
            lblEmpleadosActivos.Location = new Point(0, 77);
            lblEmpleadosActivos.Name = "lblEmpleadosActivos";
            lblEmpleadosActivos.Size = new Size(160, 31);
            lblEmpleadosActivos.TabIndex = 2;
            lblEmpleadosActivos.Text = "ACTIVOS: 000";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(12, 215, 253);
            label4.Location = new Point(0, 45);
            label4.Name = "label4";
            label4.Size = new Size(394, 32);
            label4.TabIndex = 1;
            label4.Text = "Empleados Activos e Inactivos";
            // 
            // panel14
            // 
            panel14.Controls.Add(iconPn1);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(394, 45);
            panel14.TabIndex = 0;
            // 
            // iconPn1
            // 
            iconPn1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPn1.BackColor = Color.FromArgb(48, 51, 59);
            iconPn1.ForeColor = Color.FromArgb(12, 215, 253);
            iconPn1.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconPn1.IconColor = Color.FromArgb(12, 215, 253);
            iconPn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPn1.IconSize = 39;
            iconPn1.Location = new Point(341, 6);
            iconPn1.Name = "iconPn1";
            iconPn1.Size = new Size(39, 39);
            iconPn1.TabIndex = 2;
            iconPn1.TabStop = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(48, 51, 59);
            panel11.Controls.Add(lblNominasPendientes);
            panel11.Controls.Add(label9);
            panel11.Controls.Add(panel16);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(207, 141);
            panel11.Margin = new Padding(3, 3, 10, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(394, 133);
            panel11.TabIndex = 1;
            // 
            // lblNominasPendientes
            // 
            lblNominasPendientes.Dock = DockStyle.Top;
            lblNominasPendientes.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominasPendientes.ForeColor = Color.White;
            lblNominasPendientes.Location = new Point(0, 77);
            lblNominasPendientes.Name = "lblNominasPendientes";
            lblNominasPendientes.Size = new Size(394, 42);
            lblNominasPendientes.TabIndex = 5;
            lblNominasPendientes.Text = "000";
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(12, 215, 253);
            label9.Location = new Point(0, 45);
            label9.Name = "label9";
            label9.Size = new Size(394, 32);
            label9.TabIndex = 4;
            label9.Text = "Nóminas Pendientes ";
            // 
            // panel16
            // 
            panel16.Controls.Add(iconPn3);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(394, 45);
            panel16.TabIndex = 3;
            // 
            // iconPn3
            // 
            iconPn3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPn3.BackColor = Color.FromArgb(48, 51, 59);
            iconPn3.ForeColor = Color.FromArgb(12, 215, 253);
            iconPn3.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            iconPn3.IconColor = Color.FromArgb(12, 215, 253);
            iconPn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPn3.IconSize = 39;
            iconPn3.Location = new Point(341, 6);
            iconPn3.Name = "iconPn3";
            iconPn3.Size = new Size(39, 39);
            iconPn3.TabIndex = 2;
            iconPn3.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(48, 51, 59);
            panel12.Controls.Add(lblCostoTotalMensual);
            panel12.Controls.Add(label7);
            panel12.Controls.Add(panel15);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(614, 3);
            panel12.Margin = new Padding(3, 3, 3, 10);
            panel12.Name = "panel12";
            panel12.Size = new Size(403, 125);
            panel12.TabIndex = 2;
            // 
            // lblCostoTotalMensual
            // 
            lblCostoTotalMensual.Dock = DockStyle.Top;
            lblCostoTotalMensual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCostoTotalMensual.ForeColor = Color.White;
            lblCostoTotalMensual.Location = new Point(0, 77);
            lblCostoTotalMensual.Name = "lblCostoTotalMensual";
            lblCostoTotalMensual.Size = new Size(403, 42);
            lblCostoTotalMensual.TabIndex = 5;
            lblCostoTotalMensual.Text = "$000.00";
            // 
            // label7
            // 
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(12, 215, 253);
            label7.Location = new Point(0, 45);
            label7.Name = "label7";
            label7.Size = new Size(403, 32);
            label7.TabIndex = 4;
            label7.Text = "Costo Total Mensual";
            // 
            // panel15
            // 
            panel15.Controls.Add(iconPn2);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(403, 45);
            panel15.TabIndex = 3;
            // 
            // iconPn2
            // 
            iconPn2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPn2.BackColor = Color.FromArgb(48, 51, 59);
            iconPn2.ForeColor = Color.FromArgb(12, 215, 253);
            iconPn2.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconPn2.IconColor = Color.FromArgb(12, 215, 253);
            iconPn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPn2.IconSize = 39;
            iconPn2.Location = new Point(341, 6);
            iconPn2.Name = "iconPn2";
            iconPn2.Size = new Size(39, 39);
            iconPn2.TabIndex = 2;
            iconPn2.TabStop = false;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(48, 51, 59);
            panel13.Controls.Add(lblNominasPagadas);
            panel13.Controls.Add(label11);
            panel13.Controls.Add(panel17);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(614, 141);
            panel13.Name = "panel13";
            panel13.Size = new Size(403, 133);
            panel13.TabIndex = 3;
            // 
            // lblNominasPagadas
            // 
            lblNominasPagadas.Dock = DockStyle.Top;
            lblNominasPagadas.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNominasPagadas.ForeColor = Color.White;
            lblNominasPagadas.Location = new Point(0, 77);
            lblNominasPagadas.Name = "lblNominasPagadas";
            lblNominasPagadas.Size = new Size(403, 42);
            lblNominasPagadas.TabIndex = 5;
            lblNominasPagadas.Text = "000";
            // 
            // label11
            // 
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(12, 215, 253);
            label11.Location = new Point(0, 45);
            label11.Name = "label11";
            label11.Size = new Size(403, 32);
            label11.TabIndex = 4;
            label11.Text = "Nóminas Pagadas";
            // 
            // panel17
            // 
            panel17.Controls.Add(iconPn4);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(403, 45);
            panel17.TabIndex = 3;
            // 
            // iconPn4
            // 
            iconPn4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPn4.BackColor = Color.FromArgb(48, 51, 59);
            iconPn4.ForeColor = Color.FromArgb(12, 215, 253);
            iconPn4.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconPn4.IconColor = Color.FromArgb(12, 215, 253);
            iconPn4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPn4.IconSize = 39;
            iconPn4.Location = new Point(341, 6);
            iconPn4.Name = "iconPn4";
            iconPn4.Size = new Size(39, 39);
            iconPn4.TabIndex = 2;
            iconPn4.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(198, 125);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(10, 246);
            panel9.Name = "panel9";
            panel9.Size = new Size(1224, 31);
            panel9.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel5, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1224, 236);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(48, 51, 59);
            panel5.Controls.Add(lbltext3);
            panel5.Controls.Add(panel8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(819, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 230);
            panel5.TabIndex = 2;
            // 
            // lbltext3
            // 
            lbltext3.Dock = DockStyle.Fill;
            lbltext3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext3.ForeColor = Color.White;
            lbltext3.Location = new Point(0, 98);
            lbltext3.Name = "lbltext3";
            lbltext3.Size = new Size(402, 132);
            lbltext3.TabIndex = 2;
            lbltext3.Text = "Ejemplo texto";
            // 
            // panel8
            // 
            panel8.Controls.Add(label3);
            panel8.Controls.Add(iconReporte);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(402, 98);
            panel8.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(12, 215, 253);
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(284, 41);
            label3.TabIndex = 2;
            label3.Text = "Reportes y Análisis";
            // 
            // iconReporte
            // 
            iconReporte.BackColor = Color.FromArgb(48, 51, 59);
            iconReporte.ForeColor = Color.FromArgb(12, 215, 253);
            iconReporte.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            iconReporte.IconColor = Color.FromArgb(12, 215, 253);
            iconReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconReporte.IconSize = 55;
            iconReporte.Location = new Point(15, 14);
            iconReporte.Name = "iconReporte";
            iconReporte.Size = new Size(55, 55);
            iconReporte.TabIndex = 1;
            iconReporte.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(48, 51, 59);
            panel4.Controls.Add(lbltext2);
            panel4.Controls.Add(panel7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(411, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 230);
            panel4.TabIndex = 1;
            // 
            // lbltext2
            // 
            lbltext2.Dock = DockStyle.Fill;
            lbltext2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext2.ForeColor = Color.White;
            lbltext2.Location = new Point(0, 98);
            lbltext2.Name = "lbltext2";
            lbltext2.Size = new Size(402, 132);
            lbltext2.TabIndex = 2;
            lbltext2.Text = "Ejemplo texto";
            // 
            // panel7
            // 
            panel7.Controls.Add(label2);
            panel7.Controls.Add(iconRH);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(402, 98);
            panel7.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(12, 215, 253);
            label2.Location = new Point(0, 57);
            label2.Name = "label2";
            label2.Size = new Size(282, 41);
            label2.TabIndex = 2;
            label2.Text = "Recursos Humanos";
            // 
            // iconRH
            // 
            iconRH.BackColor = Color.FromArgb(48, 51, 59);
            iconRH.ForeColor = Color.FromArgb(12, 215, 253);
            iconRH.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconRH.IconColor = Color.FromArgb(12, 215, 253);
            iconRH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRH.IconSize = 55;
            iconRH.Location = new Point(15, 14);
            iconRH.Name = "iconRH";
            iconRH.Size = new Size(55, 55);
            iconRH.TabIndex = 1;
            iconRH.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(48, 51, 59);
            panel3.Controls.Add(lbltext1);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 230);
            panel3.TabIndex = 0;
            // 
            // lbltext1
            // 
            lbltext1.Dock = DockStyle.Fill;
            lbltext1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltext1.ForeColor = Color.White;
            lbltext1.Location = new Point(0, 98);
            lbltext1.Name = "lbltext1";
            lbltext1.Size = new Size(402, 132);
            lbltext1.TabIndex = 1;
            lbltext1.Text = "Ejemplo texto";
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Controls.Add(iconNomina);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(402, 98);
            panel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 215, 253);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 2;
            label1.Text = "Gestión de Nómina";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconNomina
            // 
            iconNomina.BackColor = Color.FromArgb(48, 51, 59);
            iconNomina.ForeColor = Color.FromArgb(12, 215, 253);
            iconNomina.IconChar = FontAwesome.Sharp.IconChar.Usd;
            iconNomina.IconColor = Color.FromArgb(12, 215, 253);
            iconNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconNomina.IconSize = 55;
            iconNomina.Location = new Point(15, 14);
            iconNomina.Name = "iconNomina";
            iconNomina.Size = new Size(55, 55);
            iconNomina.TabIndex = 1;
            iconNomina.TabStop = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            ClientSize = new Size(1244, 722);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDashboard";
            Text = "Dashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)icontime).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPn1).EndInit();
            panel11.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPn3).EndInit();
            panel12.ResumeLayout(false);
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPn2).EndInit();
            panel13.ResumeLayout(false);
            panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPn4).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconReporte).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconRH).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconNomina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBienvenida;
        private Label lblTexto1;
        private System.Windows.Forms.Timer horafecha;
        private Label lblfecha;
        private System.Windows.Forms.Timer horaFecha;
        private FontAwesome.Sharp.IconPictureBox icontime;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconNomina;
        private Panel panel6;
        private Label label1;
        private Label lbltext1;
        private Panel panel8;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconReporte;
        private Panel panel7;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconRH;
        private Label lbltext3;
        private Label lbltext2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Label lblEmpleadosActivos;
        private Label label4;
        private Panel panel14;
        private FontAwesome.Sharp.IconPictureBox iconPn1;
        private Label lblNominasPendientes;
        private Label label9;
        private Panel panel16;
        private FontAwesome.Sharp.IconPictureBox iconPn3;
        private Label lblCostoTotalMensual;
        private Label label7;
        private Panel panel15;
        private FontAwesome.Sharp.IconPictureBox iconPn2;
        private Label lblNominasPagadas;
        private Label label11;
        private Panel panel17;
        private FontAwesome.Sharp.IconPictureBox iconPn4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblEmpleadosInactivos;
    }
}