namespace NominaXpertCore.View.UsersControl
{
    partial class UC_NominaRecibo
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
            lblReciboNominas = new Label();
            btnPDFReciboNomina = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gBoxVPDatosEmp = new GroupBox();
            lblEstado = new Label();
            lblFechaFin = new Label();
            lblFechaInicio = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblIdEmpleado = new Label();
            lblSueldoBase = new Label();
            lblRFC = new Label();
            lblDepartamento = new Label();
            lblNombreEmpleado = new Label();
            label6 = new Label();
            lblTotalNetoletra = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gBoxVPCalculoNom = new GroupBox();
            lblSueldoPorHorasTrabajadas = new Label();
            label10 = new Label();
            cboMetodoPago = new ComboBox();
            lblMetodoPago = new Label();
            btnGenerarNómina = new FontAwesome.Sharp.IconButton();
            lblMontoLetras = new Label();
            lblTotalDeducciones = new Label();
            lblTotalNeto = new Label();
            lblTotalPercepciones = new Label();
            lblMontoletra = new Label();
            lblNetoPagadoletra = new Label();
            lblTotalDeduccionletra = new Label();
            lblTotalPercepcionletra = new Label();
            btnRegresar = new FontAwesome.Sharp.IconButton();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            gBoxVPDatosEmp.SuspendLayout();
            gBoxVPCalculoNom.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDescripcionCN);
            panel1.Controls.Add(lblReciboNominas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 109);
            panel1.TabIndex = 1;
            // 
            // lblDescripcionCN
            // 
            lblDescripcionCN.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcionCN.ForeColor = Color.White;
            lblDescripcionCN.Location = new Point(32, 73);
            lblDescripcionCN.Name = "lblDescripcionCN";
            lblDescripcionCN.Size = new Size(939, 32);
            lblDescripcionCN.TabIndex = 4;
            lblDescripcionCN.Text = "Genera la vista previa de un recibo de nómina del empleado al que se le ha realizado el cálculo de su nómina.\r\n";
            // 
            // lblReciboNominas
            // 
            lblReciboNominas.AutoSize = true;
            lblReciboNominas.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReciboNominas.ForeColor = Color.FromArgb(12, 215, 253);
            lblReciboNominas.Location = new Point(32, 19);
            lblReciboNominas.Name = "lblReciboNominas";
            lblReciboNominas.Size = new Size(315, 35);
            lblReciboNominas.TabIndex = 1;
            lblReciboNominas.Text = "Resumen y Confirmación";
            // 
            // btnPDFReciboNomina
            // 
            btnPDFReciboNomina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPDFReciboNomina.BackColor = Color.Black;
            btnPDFReciboNomina.Cursor = Cursors.Hand;
            btnPDFReciboNomina.FlatAppearance.BorderColor = Color.Red;
            btnPDFReciboNomina.FlatAppearance.BorderSize = 2;
            btnPDFReciboNomina.FlatStyle = FlatStyle.Flat;
            btnPDFReciboNomina.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDFReciboNomina.ForeColor = Color.Azure;
            btnPDFReciboNomina.IconChar = FontAwesome.Sharp.IconChar.SheetPlastic;
            btnPDFReciboNomina.IconColor = Color.Red;
            btnPDFReciboNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPDFReciboNomina.IconSize = 32;
            btnPDFReciboNomina.Location = new Point(689, 187);
            btnPDFReciboNomina.Name = "btnPDFReciboNomina";
            btnPDFReciboNomina.Size = new Size(176, 40);
            btnPDFReciboNomina.TabIndex = 11;
            btnPDFReciboNomina.Text = "Descargar PDF";
            btnPDFReciboNomina.TextAlign = ContentAlignment.MiddleRight;
            btnPDFReciboNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPDFReciboNomina.UseVisualStyleBackColor = false;
            btnPDFReciboNomina.Click += btnPDFReciboNomina_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 109);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 566);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(37, 41, 47);
            flowLayoutPanel1.Controls.Add(gBoxVPDatosEmp);
            flowLayoutPanel1.Controls.Add(gBoxVPCalculoNom);
            flowLayoutPanel1.Controls.Add(btnRegresar);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(28, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1205, 560);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // gBoxVPDatosEmp
            // 
            gBoxVPDatosEmp.Controls.Add(lblEstado);
            gBoxVPDatosEmp.Controls.Add(lblFechaFin);
            gBoxVPDatosEmp.Controls.Add(lblFechaInicio);
            gBoxVPDatosEmp.Controls.Add(label9);
            gBoxVPDatosEmp.Controls.Add(label8);
            gBoxVPDatosEmp.Controls.Add(label7);
            gBoxVPDatosEmp.Controls.Add(lblIdEmpleado);
            gBoxVPDatosEmp.Controls.Add(lblSueldoBase);
            gBoxVPDatosEmp.Controls.Add(lblRFC);
            gBoxVPDatosEmp.Controls.Add(lblDepartamento);
            gBoxVPDatosEmp.Controls.Add(lblNombreEmpleado);
            gBoxVPDatosEmp.Controls.Add(label6);
            gBoxVPDatosEmp.Controls.Add(lblTotalNetoletra);
            gBoxVPDatosEmp.Controls.Add(label5);
            gBoxVPDatosEmp.Controls.Add(label4);
            gBoxVPDatosEmp.Controls.Add(label3);
            gBoxVPDatosEmp.Controls.Add(label2);
            gBoxVPDatosEmp.Controls.Add(label1);
            gBoxVPDatosEmp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxVPDatosEmp.ForeColor = Color.White;
            gBoxVPDatosEmp.Location = new Point(3, 3);
            gBoxVPDatosEmp.Name = "gBoxVPDatosEmp";
            gBoxVPDatosEmp.Size = new Size(1202, 208);
            gBoxVPDatosEmp.TabIndex = 10;
            gBoxVPDatosEmp.TabStop = false;
            gBoxVPDatosEmp.Text = "Resumen General:";
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.GreenYellow;
            lblEstado.Location = new Point(776, 137);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(362, 20);
            lblEstado.TabIndex = 41;
            lblEstado.Text = "Pendiente a Pagar";
            // 
            // lblFechaFin
            // 
            lblFechaFin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaFin.ForeColor = Color.White;
            lblFechaFin.Location = new Point(776, 106);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(362, 20);
            lblFechaFin.TabIndex = 40;
            lblFechaFin.Text = "---";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInicio.ForeColor = Color.White;
            lblFechaInicio.Location = new Point(776, 76);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(362, 20);
            lblFechaInicio.TabIndex = 39;
            lblFechaInicio.Text = "---";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(629, 137);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 38;
            label9.Text = "Estado:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(629, 106);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 37;
            label8.Text = "Fecha Fin:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(629, 76);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 36;
            label7.Text = "Fecha Inicio:";
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdEmpleado.ForeColor = Color.White;
            lblIdEmpleado.Location = new Point(165, 167);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(362, 20);
            lblIdEmpleado.TabIndex = 35;
            lblIdEmpleado.Text = "---";
            // 
            // lblSueldoBase
            // 
            lblSueldoBase.AutoSize = true;
            lblSueldoBase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoBase.ForeColor = Color.White;
            lblSueldoBase.Location = new Point(776, 167);
            lblSueldoBase.Name = "lblSueldoBase";
            lblSueldoBase.Size = new Size(31, 20);
            lblSueldoBase.TabIndex = 23;
            lblSueldoBase.Text = ".00";
            // 
            // lblRFC
            // 
            lblRFC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRFC.ForeColor = Color.White;
            lblRFC.Location = new Point(165, 137);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(362, 20);
            lblRFC.TabIndex = 34;
            lblRFC.Text = "---";
            // 
            // lblDepartamento
            // 
            lblDepartamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartamento.ForeColor = Color.White;
            lblDepartamento.Location = new Point(165, 106);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(362, 20);
            lblDepartamento.TabIndex = 33;
            lblDepartamento.Text = "---";
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEmpleado.ForeColor = Color.White;
            lblNombreEmpleado.Location = new Point(165, 76);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(362, 20);
            lblNombreEmpleado.TabIndex = 32;
            lblNombreEmpleado.Text = "---";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 167);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 31;
            label6.Text = "ID empleado:";
            // 
            // lblTotalNetoletra
            // 
            lblTotalNetoletra.AutoSize = true;
            lblTotalNetoletra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNetoletra.ForeColor = Color.White;
            lblTotalNetoletra.Location = new Point(629, 167);
            lblTotalNetoletra.Name = "lblTotalNetoletra";
            lblTotalNetoletra.Size = new Size(93, 20);
            lblTotalNetoletra.TabIndex = 19;
            lblTotalNetoletra.Text = "Sueldo Base";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 137);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 30;
            label5.Text = "RFC:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 106);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 29;
            label4.Text = "Departamento:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 76);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 27;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(629, 37);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 28;
            label2.Text = "Período de Nómina";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 27;
            label1.Text = "Datos del Empleado ";
            // 
            // gBoxVPCalculoNom
            // 
            gBoxVPCalculoNom.Controls.Add(lblSueldoPorHorasTrabajadas);
            gBoxVPCalculoNom.Controls.Add(label10);
            gBoxVPCalculoNom.Controls.Add(cboMetodoPago);
            gBoxVPCalculoNom.Controls.Add(lblMetodoPago);
            gBoxVPCalculoNom.Controls.Add(btnGenerarNómina);
            gBoxVPCalculoNom.Controls.Add(btnPDFReciboNomina);
            gBoxVPCalculoNom.Controls.Add(lblMontoLetras);
            gBoxVPCalculoNom.Controls.Add(lblTotalDeducciones);
            gBoxVPCalculoNom.Controls.Add(lblTotalNeto);
            gBoxVPCalculoNom.Controls.Add(lblTotalPercepciones);
            gBoxVPCalculoNom.Controls.Add(lblMontoletra);
            gBoxVPCalculoNom.Controls.Add(lblNetoPagadoletra);
            gBoxVPCalculoNom.Controls.Add(lblTotalDeduccionletra);
            gBoxVPCalculoNom.Controls.Add(lblTotalPercepcionletra);
            gBoxVPCalculoNom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            gBoxVPCalculoNom.ForeColor = Color.White;
            gBoxVPCalculoNom.Location = new Point(3, 217);
            gBoxVPCalculoNom.Name = "gBoxVPCalculoNom";
            gBoxVPCalculoNom.RightToLeft = RightToLeft.No;
            gBoxVPCalculoNom.Size = new Size(1202, 252);
            gBoxVPCalculoNom.TabIndex = 9;
            gBoxVPCalculoNom.TabStop = false;
            gBoxVPCalculoNom.Text = "Vista previa de cálculos de Nómina";
            // 
            // lblSueldoPorHorasTrabajadas
            // 
            lblSueldoPorHorasTrabajadas.AutoSize = true;
            lblSueldoPorHorasTrabajadas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoPorHorasTrabajadas.ForeColor = Color.White;
            lblSueldoPorHorasTrabajadas.Location = new Point(259, 87);
            lblSueldoPorHorasTrabajadas.Name = "lblSueldoPorHorasTrabajadas";
            lblSueldoPorHorasTrabajadas.Size = new Size(31, 20);
            lblSueldoPorHorasTrabajadas.TabIndex = 43;
            lblSueldoPorHorasTrabajadas.Text = ".00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(31, 87);
            label10.Name = "label10";
            label10.Size = new Size(208, 20);
            label10.TabIndex = 42;
            label10.Text = "Sueldo por Horas Trabajadas";
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(776, 97);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(151, 31);
            cboMetodoPago.TabIndex = 29;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodoPago.ForeColor = Color.White;
            lblMetodoPago.Location = new Point(617, 102);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(132, 20);
            lblMetodoPago.TabIndex = 28;
            lblMetodoPago.Text = "Método de Pago: ";
            // 
            // btnGenerarNómina
            // 
            btnGenerarNómina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerarNómina.BackColor = Color.Black;
            btnGenerarNómina.Cursor = Cursors.Hand;
            btnGenerarNómina.FlatAppearance.BorderColor = Color.Cyan;
            btnGenerarNómina.FlatAppearance.BorderSize = 2;
            btnGenerarNómina.FlatStyle = FlatStyle.Flat;
            btnGenerarNómina.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarNómina.ForeColor = Color.Azure;
            btnGenerarNómina.IconChar = FontAwesome.Sharp.IconChar.Usd;
            btnGenerarNómina.IconColor = Color.Cyan;
            btnGenerarNómina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarNómina.IconSize = 32;
            btnGenerarNómina.Location = new Point(895, 187);
            btnGenerarNómina.Name = "btnGenerarNómina";
            btnGenerarNómina.Size = new Size(176, 40);
            btnGenerarNómina.TabIndex = 27;
            btnGenerarNómina.Text = "Generar Nómina";
            btnGenerarNómina.TextAlign = ContentAlignment.MiddleRight;
            btnGenerarNómina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerarNómina.UseVisualStyleBackColor = false;
            btnGenerarNómina.Click += btnGenerarNómina_Click;
            // 
            // lblMontoLetras
            // 
            lblMontoLetras.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoLetras.ForeColor = Color.White;
            lblMontoLetras.Location = new Point(31, 175);
            lblMontoLetras.Name = "lblMontoLetras";
            lblMontoLetras.Size = new Size(588, 20);
            lblMontoLetras.TabIndex = 26;
            lblMontoLetras.Text = "PESOS 0/100 M.N,";
            // 
            // lblTotalDeducciones
            // 
            lblTotalDeducciones.AutoSize = true;
            lblTotalDeducciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDeducciones.ForeColor = Color.White;
            lblTotalDeducciones.Location = new Point(475, 46);
            lblTotalDeducciones.Name = "lblTotalDeducciones";
            lblTotalDeducciones.Size = new Size(31, 20);
            lblTotalDeducciones.TabIndex = 25;
            lblTotalDeducciones.Text = ".00";
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNeto.ForeColor = Color.White;
            lblTotalNeto.Location = new Point(785, 46);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(31, 20);
            lblTotalNeto.TabIndex = 24;
            lblTotalNeto.Text = ".00";
            // 
            // lblTotalPercepciones
            // 
            lblTotalPercepciones.AutoSize = true;
            lblTotalPercepciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPercepciones.ForeColor = Color.White;
            lblTotalPercepciones.Location = new Point(199, 46);
            lblTotalPercepciones.Name = "lblTotalPercepciones";
            lblTotalPercepciones.Size = new Size(31, 20);
            lblTotalPercepciones.TabIndex = 22;
            lblTotalPercepciones.Text = ".00";
            // 
            // lblMontoletra
            // 
            lblMontoletra.AutoSize = true;
            lblMontoletra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoletra.ForeColor = Color.White;
            lblMontoletra.Location = new Point(31, 141);
            lblMontoletra.Name = "lblMontoletra";
            lblMontoletra.Size = new Size(128, 20);
            lblMontoletra.TabIndex = 21;
            lblMontoletra.Text = "Monto en Letras:";
            // 
            // lblNetoPagadoletra
            // 
            lblNetoPagadoletra.AutoSize = true;
            lblNetoPagadoletra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetoPagadoletra.ForeColor = Color.White;
            lblNetoPagadoletra.Location = new Point(617, 46);
            lblNetoPagadoletra.Name = "lblNetoPagadoletra";
            lblNetoPagadoletra.Size = new Size(87, 20);
            lblNetoPagadoletra.TabIndex = 20;
            lblNetoPagadoletra.Text = "Total NETO";
            // 
            // lblTotalDeduccionletra
            // 
            lblTotalDeduccionletra.AutoSize = true;
            lblTotalDeduccionletra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDeduccionletra.ForeColor = Color.White;
            lblTotalDeduccionletra.Location = new Point(294, 46);
            lblTotalDeduccionletra.Name = "lblTotalDeduccionletra";
            lblTotalDeduccionletra.Size = new Size(140, 20);
            lblTotalDeduccionletra.TabIndex = 18;
            lblTotalDeduccionletra.Text = "Total  Deducciones";
            // 
            // lblTotalPercepcionletra
            // 
            lblTotalPercepcionletra.AutoSize = true;
            lblTotalPercepcionletra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPercepcionletra.ForeColor = Color.White;
            lblTotalPercepcionletra.Location = new Point(31, 46);
            lblTotalPercepcionletra.Name = "lblTotalPercepcionletra";
            lblTotalPercepcionletra.Size = new Size(139, 20);
            lblTotalPercepcionletra.TabIndex = 17;
            lblTotalPercepcionletra.Text = "Total Percepciones";
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRegresar.BackColor = Color.Black;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatAppearance.BorderColor = Color.Red;
            btnRegresar.FlatAppearance.BorderSize = 2;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Azure;
            btnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnRegresar.IconColor = Color.Red;
            btnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegresar.IconSize = 32;
            btnRegresar.Location = new Point(3, 475);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(148, 40);
            btnRegresar.TabIndex = 15;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleRight;
            btnRegresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // UC_NominaRecibo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 41, 47);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_NominaRecibo";
            Size = new Size(1262, 705);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            gBoxVPDatosEmp.ResumeLayout(false);
            gBoxVPDatosEmp.PerformLayout();
            gBoxVPCalculoNom.ResumeLayout(false);
            gBoxVPCalculoNom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescripcionCN;
        private Label lblReciboNominas;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gBoxVPDatosEmp;
        private FontAwesome.Sharp.IconButton btnPDFReciboNomina;
        private GroupBox gBoxVPCalculoNom;
        private DataGridView dgvCalcNom;
        private DataGridView dgvCalcNom2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Percepcion;
        private Label lblNetoPagadoletra;
        private Label lblTotalNetoletra;
        private Label lblTotalDeduccionletra;
        private Label lblTotalPercepcionletra;
        private Label lblMontoletra;
        private Label lblTotalPercepciones;
        private Label lblMontoLetras;
        private Label lblTotalDeducciones;
        private Label lblTotalNeto;
        private Label lblSueldoBase;
        private ToolTip toolTip1;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblIdEmpleado;
        private Label lblRFC;
        private Label lblDepartamento;
        private Label lblNombreEmpleado;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblEstado;
        private Label lblFechaFin;
        private Label lblFechaInicio;
        private FontAwesome.Sharp.IconButton btnGenerarNómina;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private Label lblMetodoPago;
        private ComboBox cboMetodoPago;
        private Label lblHorasTrabajadas;
        private Label label10;
        private Label lblSueldoPorHorasTrabajadas;
    }
}
