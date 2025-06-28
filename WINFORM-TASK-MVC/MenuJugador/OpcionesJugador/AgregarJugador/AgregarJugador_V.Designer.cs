namespace Winform_Task_Mvc.MenuJugador.OpcionesJugador.AgregarJugador
{
    partial class AgregarJugador_V
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
            pnlAgregarJugador = new Panel();
            btnAgregarJugador = new Button();
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
            pnlLblAgregarJugador = new Panel();
            lblAgregarJugador = new Label();
            pnlPrincipal.SuspendLayout();
            pnlAgregarJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spnPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spnEdad).BeginInit();
            pnlLblAgregarJugador.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(pnlAgregarJugador);
            pnlPrincipal.Controls.Add(pnlLblAgregarJugador);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(800, 402);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlAgregarJugador
            // 
            pnlAgregarJugador.Controls.Add(btnAgregarJugador);
            pnlAgregarJugador.Controls.Add(spnPeso);
            pnlAgregarJugador.Controls.Add(spnAltura);
            pnlAgregarJugador.Controls.Add(spnEdad);
            pnlAgregarJugador.Controls.Add(txtNacionalidad);
            pnlAgregarJugador.Controls.Add(txtNombre);
            pnlAgregarJugador.Controls.Add(lblPeso);
            pnlAgregarJugador.Controls.Add(lblAltura);
            pnlAgregarJugador.Controls.Add(lblNacionalidad);
            pnlAgregarJugador.Controls.Add(lblEdad);
            pnlAgregarJugador.Controls.Add(lblNombre);
            pnlAgregarJugador.Controls.Add(pnlSeparador_1);
            pnlAgregarJugador.Controls.Add(pnlSeparador_2);
            pnlAgregarJugador.Controls.Add(pnlSeparador_3);
            pnlAgregarJugador.Controls.Add(pnlSeparador_4);
            pnlAgregarJugador.Controls.Add(pnlSeparador_5);
            pnlAgregarJugador.Controls.Add(pnlSeparador_6);
            pnlAgregarJugador.Location = new Point(0, 79);
            pnlAgregarJugador.Name = "pnlAgregarJugador";
            pnlAgregarJugador.Size = new Size(800, 323);
            pnlAgregarJugador.TabIndex = 2;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.BackColor = Color.Black;
            btnAgregarJugador.Cursor = Cursors.Hand;
            btnAgregarJugador.FlatAppearance.BorderColor = Color.Black;
            btnAgregarJugador.FlatAppearance.BorderSize = 3;
            btnAgregarJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnAgregarJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregarJugador.FlatStyle = FlatStyle.Flat;
            btnAgregarJugador.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarJugador.ForeColor = Color.White;
            btnAgregarJugador.Location = new Point(35, 256);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(729, 46);
            btnAgregarJugador.TabIndex = 46;
            btnAgregarJugador.Text = "AGREGAR JUGADOR";
            btnAgregarJugador.UseVisualStyleBackColor = false;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // spnPeso
            // 
            spnPeso.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spnPeso.Location = new Point(124, 204);
            spnPeso.Maximum = new decimal(new int[] { 179, 0, 0, 0 });
            spnPeso.Minimum = new decimal(new int[] { 31, 0, 0, 0 });
            spnPeso.Name = "spnPeso";
            spnPeso.Size = new Size(120, 27);
            spnPeso.TabIndex = 45;
            spnPeso.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // spnAltura
            // 
            spnAltura.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spnAltura.Location = new Point(153, 159);
            spnAltura.Maximum = new decimal(new int[] { 249, 0, 0, 0 });
            spnAltura.Minimum = new decimal(new int[] { 101, 0, 0, 0 });
            spnAltura.Name = "spnAltura";
            spnAltura.Size = new Size(120, 27);
            spnAltura.TabIndex = 44;
            spnAltura.Value = new decimal(new int[] { 101, 0, 0, 0 });
            // 
            // spnEdad
            // 
            spnEdad.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spnEdad.Location = new Point(124, 73);
            spnEdad.Maximum = new decimal(new int[] { 44, 0, 0, 0 });
            spnEdad.Minimum = new decimal(new int[] { 17, 0, 0, 0 });
            spnEdad.Name = "spnEdad";
            spnEdad.Size = new Size(120, 27);
            spnEdad.TabIndex = 43;
            spnEdad.Value = new decimal(new int[] { 17, 0, 0, 0 });
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNacionalidad.Location = new Point(235, 116);
            txtNacionalidad.MaxLength = 40;
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(529, 26);
            txtNacionalidad.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(161, 32);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(603, 26);
            txtNombre.TabIndex = 41;
            // 
            // lblPeso
            // 
            lblPeso.Anchor = AnchorStyles.Top;
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.ForeColor = Color.Black;
            lblPeso.Location = new Point(35, 202);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(83, 29);
            lblPeso.TabIndex = 40;
            lblPeso.Text = "PESO :";
            // 
            // lblAltura
            // 
            lblAltura.Anchor = AnchorStyles.Top;
            lblAltura.AutoSize = true;
            lblAltura.BackColor = Color.Transparent;
            lblAltura.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAltura.ForeColor = Color.Black;
            lblAltura.Location = new Point(35, 157);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(112, 29);
            lblAltura.TabIndex = 39;
            lblAltura.Text = "ALTURA :";
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.Anchor = AnchorStyles.Top;
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.BackColor = Color.Transparent;
            lblNacionalidad.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNacionalidad.ForeColor = Color.Black;
            lblNacionalidad.Location = new Point(35, 113);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(194, 29);
            lblNacionalidad.TabIndex = 38;
            lblNacionalidad.Text = "NACIONALIDAD :";
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Top;
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.ForeColor = Color.Black;
            lblEdad.Location = new Point(35, 70);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(85, 29);
            lblEdad.TabIndex = 37;
            lblEdad.Text = "EDAD :";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(35, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 29);
            lblNombre.TabIndex = 36;
            lblNombre.Text = "NOMBRE :";
            // 
            // pnlSeparador_1
            // 
            pnlSeparador_1.BackColor = Color.Black;
            pnlSeparador_1.Location = new Point(35, 21);
            pnlSeparador_1.Name = "pnlSeparador_1";
            pnlSeparador_1.Size = new Size(729, 5);
            pnlSeparador_1.TabIndex = 35;
            // 
            // pnlSeparador_2
            // 
            pnlSeparador_2.BackColor = Color.Black;
            pnlSeparador_2.Location = new Point(35, 62);
            pnlSeparador_2.Name = "pnlSeparador_2";
            pnlSeparador_2.Size = new Size(729, 5);
            pnlSeparador_2.TabIndex = 34;
            // 
            // pnlSeparador_3
            // 
            pnlSeparador_3.BackColor = Color.Black;
            pnlSeparador_3.Location = new Point(35, 103);
            pnlSeparador_3.Name = "pnlSeparador_3";
            pnlSeparador_3.Size = new Size(729, 5);
            pnlSeparador_3.TabIndex = 33;
            // 
            // pnlSeparador_4
            // 
            pnlSeparador_4.BackColor = Color.Black;
            pnlSeparador_4.Location = new Point(35, 145);
            pnlSeparador_4.Name = "pnlSeparador_4";
            pnlSeparador_4.Size = new Size(729, 5);
            pnlSeparador_4.TabIndex = 31;
            // 
            // pnlSeparador_5
            // 
            pnlSeparador_5.BackColor = Color.Black;
            pnlSeparador_5.Location = new Point(35, 189);
            pnlSeparador_5.Name = "pnlSeparador_5";
            pnlSeparador_5.Size = new Size(729, 5);
            pnlSeparador_5.TabIndex = 30;
            // 
            // pnlSeparador_6
            // 
            pnlSeparador_6.BackColor = Color.Black;
            pnlSeparador_6.Location = new Point(35, 234);
            pnlSeparador_6.Name = "pnlSeparador_6";
            pnlSeparador_6.Size = new Size(729, 5);
            pnlSeparador_6.TabIndex = 29;
            // 
            // pnlLblAgregarJugador
            // 
            pnlLblAgregarJugador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblAgregarJugador.BackColor = Color.Black;
            pnlLblAgregarJugador.Controls.Add(lblAgregarJugador);
            pnlLblAgregarJugador.Location = new Point(0, 0);
            pnlLblAgregarJugador.Name = "pnlLblAgregarJugador";
            pnlLblAgregarJugador.Size = new Size(800, 82);
            pnlLblAgregarJugador.TabIndex = 1;
            // 
            // lblAgregarJugador
            // 
            lblAgregarJugador.Anchor = AnchorStyles.Top;
            lblAgregarJugador.AutoSize = true;
            lblAgregarJugador.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarJugador.ForeColor = Color.White;
            lblAgregarJugador.Location = new Point(171, 19);
            lblAgregarJugador.Name = "lblAgregarJugador";
            lblAgregarJugador.Size = new Size(482, 45);
            lblAgregarJugador.TabIndex = 1;
            lblAgregarJugador.Text = "--- AGREGAR JUGADOR ---";
            // 
            // AgregarJugador_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MaximumSize = new Size(816, 441);
            MinimumSize = new Size(816, 441);
            Name = "AgregarJugador_V";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGAR JUGADOR";
            pnlPrincipal.ResumeLayout(false);
            pnlAgregarJugador.ResumeLayout(false);
            pnlAgregarJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spnPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)spnEdad).EndInit();
            pnlLblAgregarJugador.ResumeLayout(false);
            pnlLblAgregarJugador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLblAgregarJugador;
        private Label lblAgregarJugador;
        private Panel pnlAgregarJugador;
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
        private TextBox txtNacionalidad;
        private TextBox txtNombre;
        private NumericUpDown spnPeso;
        private NumericUpDown spnAltura;
        private NumericUpDown spnEdad;
        private Button btnAgregarJugador;
    }
}