namespace Winform_Task_Mvc.Login
{
    partial class Login_V
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
            pnlPrincipal = new Panel();
            btnInicio = new Button();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            pnlSeparador = new Panel();
            lblInicioSesion = new Label();
            pnlLogo = new Panel();
            imgLogo = new PictureBox();
            pnlPrincipal.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(btnInicio);
            pnlPrincipal.Controls.Add(lblContraseña);
            pnlPrincipal.Controls.Add(txtContraseña);
            pnlPrincipal.Controls.Add(lblCorreo);
            pnlPrincipal.Controls.Add(txtCorreo);
            pnlPrincipal.Controls.Add(pnlSeparador);
            pnlPrincipal.Controls.Add(lblInicioSesion);
            pnlPrincipal.Controls.Add(pnlLogo);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(487, 529);
            pnlPrincipal.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Black;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderColor = Color.Black;
            btnInicio.FlatAppearance.BorderSize = 3;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(12, 472);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(463, 42);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "INICIAR SESION";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(12, 421);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(137, 23);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "CONTRASEÑA :";
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(155, 421);
            txtContraseña.MaxLength = 30;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(320, 26);
            txtContraseña.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(12, 371);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(90, 23);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "CORREO :";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(108, 372);
            txtCorreo.MaxLength = 40;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(367, 26);
            txtCorreo.TabIndex = 3;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.Black;
            pnlSeparador.Location = new Point(12, 334);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(463, 5);
            pnlSeparador.TabIndex = 2;
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Bahnschrift", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicioSesion.Location = new Point(100, 291);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(281, 40);
            lblInicioSesion.TabIndex = 1;
            lblInicioSesion.Text = "INICIO DE SESION";
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.SeaGreen;
            pnlLogo.Controls.Add(imgLogo);
            pnlLogo.Font = new Font("Segoe UI", 9F);
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(487, 285);
            pnlLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.ErrorImage = null;
            imgLogo.Image = Properties.Resources.logo_login_app_c_;
            imgLogo.Location = new Point(79, 23);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(319, 259);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // Login_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 529);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MaximumSize = new Size(503, 568);
            MinimumSize = new Size(503, 568);
            Name = "Login_V";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLogo;
        private PictureBox imgLogo;
        private Label lblInicioSesion;
        private Panel pnlSeparador;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Button btnInicio;
        private Label lblContraseña;
        private TextBox txtContraseña;
    }
}