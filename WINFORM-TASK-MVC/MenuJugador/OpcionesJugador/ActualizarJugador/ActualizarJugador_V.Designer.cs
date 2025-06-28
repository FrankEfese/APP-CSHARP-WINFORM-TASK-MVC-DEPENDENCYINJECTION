namespace Winform_Task_Mvc.MenuJugador.OpcionesJugador.ActualizarJugador
{
    partial class ActualizarJugador_V
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
            pnlActualizarJugador = new Panel();
            btnActualizarJugador = new Button();
            spnPeso = new NumericUpDown();
            spnAltura = new NumericUpDown();
            spnEdad = new NumericUpDown();
            txtNacionalidad = new TextBox();
            txtNombre = new TextBox();
            lblPeso = new Label();
            lblAltura = new Label();
            lblNacionalidad = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            pnlSeparador_1 = new Panel();
            pnlSeparador_2 = new Panel();
            pnlSeparador_3 = new Panel();
            pnlSeparador_4 = new Panel();
            pnlSeparador_5 = new Panel();
            pnlSeparador_6 = new Panel();
            pnlLblActualizarJugador = new Panel();
            lblActualizarJugador = new Label();
            pnlPrincipal.SuspendLayout();
            pnlActualizarJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEdad).BeginInit();
            pnlLblActualizarJugador.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(pnlActualizarJugador);
            pnlPrincipal.Controls.Add(pnlLblActualizarJugador);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(800, 402);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlActualizarJugador
            // 
            pnlActualizarJugador.Controls.Add(btnActualizarJugador);
            pnlActualizarJugador.Controls.Add(spnPeso);
            pnlActualizarJugador.Controls.Add(spnAltura);
            pnlActualizarJugador.Controls.Add(spnEdad);
            pnlActualizarJugador.Controls.Add(txtNacionalidad);
            pnlActualizarJugador.Controls.Add(txtNombre);
            pnlActualizarJugador.Controls.Add(lblPeso);
            pnlActualizarJugador.Controls.Add(lblAltura);
            pnlActualizarJugador.Controls.Add(lblNacionalidad);
            pnlActualizarJugador.Controls.Add(lblEdad);
            pnlActualizarJugador.Controls.Add(lblNombre);
            pnlActualizarJugador.Controls.Add(pnlSeparador_1);
            pnlActualizarJugador.Controls.Add(pnlSeparador_2);
            pnlActualizarJugador.Controls.Add(pnlSeparador_3);
            pnlActualizarJugador.Controls.Add(pnlSeparador_4);
            pnlActualizarJugador.Controls.Add(pnlSeparador_5);
            pnlActualizarJugador.Controls.Add(pnlSeparador_6);
            pnlActualizarJugador.Location = new Point(0, 79);
            pnlActualizarJugador.Name = "pnlActualizarJugador";
            pnlActualizarJugador.Size = new Size(800, 323);
            pnlActualizarJugador.TabIndex = 3;
            // 
            // btnActualizarJugador
            // 
            btnActualizarJugador.BackColor = Color.Black;
            btnActualizarJugador.Cursor = Cursors.Hand;
            btnActualizarJugador.FlatAppearance.BorderColor = Color.Black;
            btnActualizarJugador.FlatAppearance.BorderSize = 3;
            btnActualizarJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnActualizarJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnActualizarJugador.FlatStyle = FlatStyle.Flat;
            btnActualizarJugador.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarJugador.ForeColor = Color.White;
            btnActualizarJugador.Location = new Point(36, 256);
            btnActualizarJugador.Name = "btnActualizarJugador";
            btnActualizarJugador.Size = new Size(729, 46);
            btnActualizarJugador.TabIndex = 63;
            btnActualizarJugador.Text = "ACTUALIZAR JUGADOR";
            btnActualizarJugador.UseVisualStyleBackColor = false;
            btnActualizarJugador.Click += btnActualizarJugador_Click;
            // 
            // spnPeso
            // 
            spnPeso.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spnPeso.Location = new Point(125, 204);
            spnPeso.Maximum = new decimal(new int[] { 179, 0, 0, 0 });
            spnPeso.Minimum = new decimal(new int[] { 31, 0, 0, 0 });
            spnPeso.Name = "spnPeso";
            spnPeso.Size = new Size(120, 27);
            spnPeso.TabIndex = 62;
            spnPeso.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // spnAltura
            // 
            spnAltura.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spnAltura.Location = new Point(154, 159);
            spnAltura.Maximum = new decimal(new int[] { 249, 0, 0, 0 });
            spnAltura.Minimum = new decimal(new int[] { 101, 0, 0, 0 });
            spnAltura.Name = "spnAltura";
            spnAltura.Size = new Size(120, 27);
            spnAltura.TabIndex = 61;
            spnAltura.Value = new decimal(new int[] { 101, 0, 0, 0 });
            // 
            // spnEdad
            // 
            spnEdad.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spnEdad.Location = new Point(125, 73);
            spnEdad.Maximum = new decimal(new int[] { 44, 0, 0, 0 });
            spnEdad.Minimum = new decimal(new int[] { 17, 0, 0, 0 });
            spnEdad.Name = "spnEdad";
            spnEdad.Size = new Size(120, 27);
            spnEdad.TabIndex = 60;
            spnEdad.Value = new decimal(new int[] { 17, 0, 0, 0 });
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNacionalidad.Location = new Point(236, 116);
            txtNacionalidad.MaxLength = 40;
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(529, 26);
            txtNacionalidad.TabIndex = 59;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(162, 32);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(603, 26);
            txtNombre.TabIndex = 58;
            // 
            // lblPeso
            // 
            lblPeso.Anchor = AnchorStyles.Top;
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.ForeColor = Color.Black;
            lblPeso.Location = new Point(36, 202);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(83, 29);
            lblPeso.TabIndex = 57;
            lblPeso.Text = "PESO :";
            // 
            // lblAltura
            // 
            lblAltura.Anchor = AnchorStyles.Top;
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltura.ForeColor = Color.Black;
            lblAltura.Location = new Point(36, 157);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(112, 29);
            lblAltura.TabIndex = 56;
            lblAltura.Text = "ALTURA :";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.Anchor = AnchorStyles.Top;
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.BackColor = Color.Transparent;
            lblNacionalidad.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNacionalidad.ForeColor = Color.Black;
            lblNacionalidad.Location = new Point(36, 113);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(194, 29);
            lblNacionalidad.TabIndex = 55;
            lblNacionalidad.Text = "NACIONALIDAD :";
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Top;
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.ForeColor = Color.Black;
            lblEdad.Location = new Point(36, 70);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(85, 29);
            lblEdad.TabIndex = 54;
            lblEdad.Text = "EDAD :";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(36, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 29);
            lblNombre.TabIndex = 53;
            lblNombre.Text = "NOMBRE :";
            // 
            // pnlSeparador_1
            // 
            pnlSeparador_1.BackColor = Color.Black;
            pnlSeparador_1.Location = new Point(36, 21);
            pnlSeparador_1.Name = "pnlSeparador_1";
            pnlSeparador_1.Size = new Size(729, 5);
            pnlSeparador_1.TabIndex = 52;
            // 
            // pnlSeparador_2
            // 
            pnlSeparador_2.BackColor = Color.Black;
            pnlSeparador_2.Location = new Point(36, 62);
            pnlSeparador_2.Name = "pnlSeparador_2";
            pnlSeparador_2.Size = new Size(729, 5);
            pnlSeparador_2.TabIndex = 51;
            // 
            // pnlSeparador_3
            // 
            pnlSeparador_3.BackColor = Color.Black;
            pnlSeparador_3.Location = new Point(36, 103);
            pnlSeparador_3.Name = "pnlSeparador_3";
            pnlSeparador_3.Size = new Size(729, 5);
            pnlSeparador_3.TabIndex = 50;
            // 
            // pnlSeparador_4
            // 
            pnlSeparador_4.BackColor = Color.Black;
            pnlSeparador_4.Location = new Point(36, 145);
            pnlSeparador_4.Name = "pnlSeparador_4";
            pnlSeparador_4.Size = new Size(729, 5);
            pnlSeparador_4.TabIndex = 49;
            // 
            // pnlSeparador_5
            // 
            pnlSeparador_5.BackColor = Color.Black;
            pnlSeparador_5.Location = new Point(36, 189);
            pnlSeparador_5.Name = "pnlSeparador_5";
            pnlSeparador_5.Size = new Size(729, 5);
            pnlSeparador_5.TabIndex = 48;
            // 
            // pnlSeparador_6
            // 
            pnlSeparador_6.BackColor = Color.Black;
            pnlSeparador_6.Location = new Point(36, 234);
            pnlSeparador_6.Name = "pnlSeparador_6";
            pnlSeparador_6.Size = new Size(729, 5);
            pnlSeparador_6.TabIndex = 47;
            // 
            // pnlLblActualizarJugador
            // 
            pnlLblActualizarJugador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblActualizarJugador.BackColor = Color.Black;
            pnlLblActualizarJugador.Controls.Add(lblActualizarJugador);
            pnlLblActualizarJugador.Location = new Point(0, 0);
            pnlLblActualizarJugador.Name = "pnlLblActualizarJugador";
            pnlLblActualizarJugador.Size = new Size(800, 82);
            pnlLblActualizarJugador.TabIndex = 2;
            // 
            // lblActualizarJugador
            // 
            lblActualizarJugador.Anchor = AnchorStyles.Top;
            lblActualizarJugador.AutoSize = true;
            lblActualizarJugador.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActualizarJugador.ForeColor = Color.White;
            lblActualizarJugador.Location = new Point(133, 19);
            lblActualizarJugador.Name = "lblActualizarJugador";
            lblActualizarJugador.Size = new Size(528, 45);
            lblActualizarJugador.TabIndex = 1;
            lblActualizarJugador.Text = "--- ACTUALIZAR JUGADOR ---";
            // 
            // ActualizarJugador_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MaximumSize = new Size(816, 441);
            MinimumSize = new Size(816, 441);
            Name = "ActualizarJugador_V";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACTUALIZAR JUGADOR";
            Load += ActualizarJugador_V_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlActualizarJugador.ResumeLayout(false);
            pnlActualizarJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnEdad).EndInit();
            pnlLblActualizarJugador.ResumeLayout(false);
            pnlLblActualizarJugador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLblActualizarJugador;
        private Label lblActualizarJugador;
        private Panel pnlActualizarJugador;
        private Button btnActualizarJugador;
        private NumericUpDown spnPeso;
        private NumericUpDown spnAltura;
        private NumericUpDown spnEdad;
        private TextBox txtNacionalidad;
        private TextBox txtNombre;
        private Label lblPeso;
        private Label lblAltura;
        private Label lblNacionalidad;
        private Label lblEdad;
        private Label lblNombre;
        private Panel pnlSeparador_1;
        private Panel pnlSeparador_2;
        private Panel pnlSeparador_3;
        private Panel pnlSeparador_4;
        private Panel pnlSeparador_5;
        private Panel pnlSeparador_6;
    }
}