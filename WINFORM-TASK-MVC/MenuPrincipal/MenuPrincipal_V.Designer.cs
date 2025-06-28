namespace Winform_Task_Mvc.MenuPrincipal
{
    partial class MenuPrincipal_V
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
            imgLogo = new PictureBox();
            pnlContenedor = new Panel();
            pnlMenu = new Panel();
            btnSalir = new Button();
            btnJugadores = new Button();
            btnEquipos = new Button();
            btnInicio = new Button();
            pnlSeparador = new Panel();
            lblMenu = new Label();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.SeaGreen;
            pnlPrincipal.Controls.Add(imgLogo);
            pnlPrincipal.Controls.Add(pnlContenedor);
            pnlPrincipal.Controls.Add(pnlMenu);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1334, 711);
            pnlPrincipal.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logo_menu_app_c_;
            imgLogo.Location = new Point(31, 3);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(248, 211);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 3;
            imgLogo.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.BorderStyle = BorderStyle.Fixed3D;
            pnlContenedor.Location = new Point(316, 30);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(989, 651);
            pnlContenedor.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlMenu.BackColor = Color.White;
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnJugadores);
            pnlMenu.Controls.Add(btnEquipos);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlSeparador);
            pnlMenu.Controls.Add(lblMenu);
            pnlMenu.Location = new Point(31, 229);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(248, 452);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom;
            btnSalir.BackColor = Color.Black;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 3;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.icono_cerrar_app_c_;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(13, 385);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(215, 47);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnJugadores
            // 
            btnJugadores.BackColor = Color.Black;
            btnJugadores.Cursor = Cursors.Hand;
            btnJugadores.FlatAppearance.BorderColor = Color.Black;
            btnJugadores.FlatAppearance.BorderSize = 3;
            btnJugadores.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnJugadores.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnJugadores.FlatStyle = FlatStyle.Flat;
            btnJugadores.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugadores.ForeColor = Color.White;
            btnJugadores.Image = Properties.Resources.icono_jugador_app_c_;
            btnJugadores.ImageAlign = ContentAlignment.MiddleLeft;
            btnJugadores.Location = new Point(13, 222);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(215, 47);
            btnJugadores.TabIndex = 6;
            btnJugadores.Text = "JUGADORES";
            btnJugadores.UseVisualStyleBackColor = false;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.BackColor = Color.Black;
            btnEquipos.Cursor = Cursors.Hand;
            btnEquipos.FlatAppearance.BorderColor = Color.Black;
            btnEquipos.FlatAppearance.BorderSize = 3;
            btnEquipos.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEquipos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEquipos.FlatStyle = FlatStyle.Flat;
            btnEquipos.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipos.ForeColor = Color.White;
            btnEquipos.Image = Properties.Resources.icono_escudo_app_c_;
            btnEquipos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquipos.Location = new Point(13, 160);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(215, 47);
            btnEquipos.TabIndex = 5;
            btnEquipos.Text = "EQUIPOS";
            btnEquipos.UseVisualStyleBackColor = false;
            btnEquipos.Click += btnEquipos_Click;
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
            btnInicio.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = Properties.Resources.icono_casa_app_c_;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(13, 97);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(215, 47);
            btnInicio.TabIndex = 4;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.Black;
            pnlSeparador.Location = new Point(13, 68);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(215, 5);
            pnlSeparador.TabIndex = 3;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(67, 17);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(104, 39);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "MENU";
            // 
            // MenuPrincipal_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 711);
            Controls.Add(pnlPrincipal);
            MinimumSize = new Size(1350, 750);
            Name = "MenuPrincipal_V";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            FormClosed += MenuPrincipal_V_FormClosed;
            Load += MenuPrincipal_V_Load;
            pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlMenu;
        private Panel pnlContenedor;
        private PictureBox imgLogo;
        private Label lblMenu;
        private Panel pnlSeparador;
        private Button btnInicio;
        private Button btnSalir;
        private Button btnJugadores;
        private Button btnEquipos;
    }
}