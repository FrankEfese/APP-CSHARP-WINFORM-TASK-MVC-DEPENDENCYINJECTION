namespace Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.AgregarEquipo
{
    partial class AgregarEquipo_V
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
            pnlAgregarEquipo = new Panel();
            btnAgregarEquipo = new Button();
            txtLiga = new TextBox();
            txtNombre = new TextBox();
            lblLiga = new Label();
            lblNombre = new Label();
            pnlSeparador_1 = new Panel();
            pnlSeparador_2 = new Panel();
            pnlSeparador_4 = new Panel();
            pnlLblAgregarEquipo = new Panel();
            lblAgregarEquipo = new Label();
            pnlPrincipal.SuspendLayout();
            pnlAgregarEquipo.SuspendLayout();
            pnlLblAgregarEquipo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(pnlAgregarEquipo);
            pnlPrincipal.Controls.Add(pnlLblAgregarEquipo);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(800, 273);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlAgregarEquipo
            // 
            pnlAgregarEquipo.Controls.Add(btnAgregarEquipo);
            pnlAgregarEquipo.Controls.Add(txtLiga);
            pnlAgregarEquipo.Controls.Add(txtNombre);
            pnlAgregarEquipo.Controls.Add(lblLiga);
            pnlAgregarEquipo.Controls.Add(lblNombre);
            pnlAgregarEquipo.Controls.Add(pnlSeparador_1);
            pnlAgregarEquipo.Controls.Add(pnlSeparador_2);
            pnlAgregarEquipo.Controls.Add(pnlSeparador_4);
            pnlAgregarEquipo.Location = new Point(0, 78);
            pnlAgregarEquipo.Name = "pnlAgregarEquipo";
            pnlAgregarEquipo.Size = new Size(800, 195);
            pnlAgregarEquipo.TabIndex = 5;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.Black;
            btnAgregarEquipo.Cursor = Cursors.Hand;
            btnAgregarEquipo.FlatAppearance.BorderColor = Color.Black;
            btnAgregarEquipo.FlatAppearance.BorderSize = 3;
            btnAgregarEquipo.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnAgregarEquipo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregarEquipo.FlatStyle = FlatStyle.Flat;
            btnAgregarEquipo.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEquipo.ForeColor = Color.White;
            btnAgregarEquipo.Location = new Point(36, 128);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(729, 46);
            btnAgregarEquipo.TabIndex = 88;
            btnAgregarEquipo.Text = "AGREGAR EQUIPO";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // txtLiga
            // 
            txtLiga.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLiga.Location = new Point(118, 72);
            txtLiga.MaxLength = 40;
            txtLiga.Name = "txtLiga";
            txtLiga.Size = new Size(647, 26);
            txtLiga.TabIndex = 87;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(162, 31);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(603, 26);
            txtNombre.TabIndex = 86;
            // 
            // lblLiga
            // 
            lblLiga.Anchor = AnchorStyles.Top;
            lblLiga.AutoSize = true;
            lblLiga.BackColor = Color.Transparent;
            lblLiga.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLiga.ForeColor = Color.Black;
            lblLiga.Location = new Point(36, 69);
            lblLiga.Name = "lblLiga";
            lblLiga.Size = new Size(76, 29);
            lblLiga.TabIndex = 85;
            lblLiga.Text = "LIGA :";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(36, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 29);
            lblNombre.TabIndex = 84;
            lblNombre.Text = "NOMBRE :";
            // 
            // pnlSeparador_1
            // 
            pnlSeparador_1.BackColor = Color.Black;
            pnlSeparador_1.Location = new Point(36, 20);
            pnlSeparador_1.Name = "pnlSeparador_1";
            pnlSeparador_1.Size = new Size(729, 5);
            pnlSeparador_1.TabIndex = 83;
            // 
            // pnlSeparador_2
            // 
            pnlSeparador_2.BackColor = Color.Black;
            pnlSeparador_2.Location = new Point(36, 61);
            pnlSeparador_2.Name = "pnlSeparador_2";
            pnlSeparador_2.Size = new Size(729, 5);
            pnlSeparador_2.TabIndex = 82;
            // 
            // pnlSeparador_4
            // 
            pnlSeparador_4.BackColor = Color.Black;
            pnlSeparador_4.Location = new Point(36, 101);
            pnlSeparador_4.Name = "pnlSeparador_4";
            pnlSeparador_4.Size = new Size(729, 5);
            pnlSeparador_4.TabIndex = 81;
            // 
            // pnlLblAgregarEquipo
            // 
            pnlLblAgregarEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblAgregarEquipo.BackColor = Color.Black;
            pnlLblAgregarEquipo.Controls.Add(lblAgregarEquipo);
            pnlLblAgregarEquipo.Location = new Point(0, 0);
            pnlLblAgregarEquipo.Name = "pnlLblAgregarEquipo";
            pnlLblAgregarEquipo.Size = new Size(800, 82);
            pnlLblAgregarEquipo.TabIndex = 4;
            // 
            // lblAgregarEquipo
            // 
            lblAgregarEquipo.Anchor = AnchorStyles.Top;
            lblAgregarEquipo.AutoSize = true;
            lblAgregarEquipo.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarEquipo.ForeColor = Color.White;
            lblAgregarEquipo.Location = new Point(183, 20);
            lblAgregarEquipo.Name = "lblAgregarEquipo";
            lblAgregarEquipo.Size = new Size(449, 45);
            lblAgregarEquipo.TabIndex = 1;
            lblAgregarEquipo.Text = "--- AGREGAR EQUIPO ---";
            // 
            // AgregarEquipo_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 273);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MaximumSize = new Size(816, 312);
            MinimumSize = new Size(816, 312);
            Name = "AgregarEquipo_V";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AGREGAR EQUIPO";
            pnlPrincipal.ResumeLayout(false);
            pnlAgregarEquipo.ResumeLayout(false);
            pnlAgregarEquipo.PerformLayout();
            pnlLblAgregarEquipo.ResumeLayout(false);
            pnlLblAgregarEquipo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLblAgregarEquipo;
        private Label lblAgregarEquipo;
        private Panel pnlAgregarEquipo;
        private Button btnAgregarEquipo;
        private TextBox txtLiga;
        private TextBox txtNombre;
        private Label lblLiga;
        private Label lblNombre;
        private Panel pnlSeparador_1;
        private Panel pnlSeparador_2;
        private Panel pnlSeparador_4;
    }
}