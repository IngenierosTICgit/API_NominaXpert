namespace NominaXpertCore.View.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblContraseña = new Label();
            lblCorreo = new Label();
            btnCancelar = new Button();
            btnLogin = new Button();
            txtConstraseña = new TextBox();
            txtCorreo = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconEye = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconEye).BeginInit();
            SuspendLayout();
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.FromArgb(12, 215, 253);
            lblContraseña.Location = new Point(296, 275);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(119, 21);
            lblContraseña.TabIndex = 17;
            lblContraseña.Text = "Contraseña: ";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.ForeColor = Color.FromArgb(12, 215, 253);
            lblCorreo.Location = new Point(296, 214);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(72, 21);
            lblCorreo.TabIndex = 16;
            lblCorreo.Text = "Correo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(653, 21);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 30);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cerrar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(12, 215, 253);
            btnLogin.Location = new Point(364, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 34);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Acceder";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtConstraseña
            // 
            txtConstraseña.BackColor = Color.FromArgb(37, 41, 47);
            txtConstraseña.Cursor = Cursors.IBeam;
            txtConstraseña.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConstraseña.ForeColor = Color.FromArgb(12, 215, 253);
            txtConstraseña.Location = new Point(425, 275);
            txtConstraseña.Name = "txtConstraseña";
            txtConstraseña.PasswordChar = '*';
            txtConstraseña.Size = new Size(234, 28);
            txtConstraseña.TabIndex = 13;
            txtConstraseña.Text = "admin123";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(37, 41, 47);
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.FromArgb(12, 215, 253);
            txtCorreo.Location = new Point(425, 214);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(234, 28);
            txtCorreo.TabIndex = 12;
            txtCorreo.Text = "admin@nomina.com";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 430);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 285);
            label1.Name = "label1";
            label1.Size = new Size(222, 65);
            label1.TabIndex = 21;
            label1.Text = "Gestión de Nómina y Recursos Humanos";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Silver;
            lblLogin.Location = new Point(472, 56);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(134, 44);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "LOGIN";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(15, 15, 15);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 82;
            iconPictureBox1.Location = new Point(494, 112);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(91, 82);
            iconPictureBox1.TabIndex = 20;
            iconPictureBox1.TabStop = false;
            // 
            // iconEye
            // 
            iconEye.BackColor = Color.FromArgb(15, 15, 15);
            iconEye.Cursor = Cursors.Hand;
            iconEye.ForeColor = Color.Cyan;
            iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconEye.IconColor = Color.Cyan;
            iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEye.IconSize = 37;
            iconEye.Location = new Point(677, 266);
            iconEye.Name = "iconEye";
            iconEye.Size = new Size(38, 37);
            iconEye.TabIndex = 21;
            iconEye.TabStop = false;
            iconEye.Click += iconEye_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(780, 430);
            Controls.Add(iconEye);
            Controls.Add(iconPictureBox1);
            Controls.Add(lblLogin);
            Controls.Add(panel1);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogin);
            Controls.Add(txtConstraseña);
            Controls.Add(txtCorreo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblContraseña;
        private Label lblCorreo;
        private Button btnCancelar;
        private Button btnLogin;
        private TextBox txtConstraseña;
        private TextBox txtCorreo;
        private Panel panel1;
        private Label lblLogin;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconEye;
    }
}