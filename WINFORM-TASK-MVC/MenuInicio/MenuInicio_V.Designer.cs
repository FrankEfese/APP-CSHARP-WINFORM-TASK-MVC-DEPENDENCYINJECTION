namespace Winform_Task_Mvc.MenuInicio
{
    partial class MenuInicio_V
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
            pnlEstadisticas = new Panel();
            pnlTotalJugadoresParados = new Panel();
            lblNumTotalJugadoresParados = new Label();
            lblTotalJugadoresParados = new Label();
            pnlTotalJugadores = new Panel();
            lblNumTotalJugadores = new Label();
            lblTotalJugadores = new Label();
            pnlTotalEquipos = new Panel();
            lblNumTotalEquipos = new Label();
            lblTotalEquipos = new Label();
            pnlLblEstadisticas = new Panel();
            lblEstadisticas = new Label();
            pnlPrincipal.SuspendLayout();
            pnlEstadisticas.SuspendLayout();
            pnlTotalJugadoresParados.SuspendLayout();
            pnlTotalJugadores.SuspendLayout();
            pnlTotalEquipos.SuspendLayout();
            pnlLblEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pnlEstadisticas);
            pnlPrincipal.Controls.Add(pnlLblEstadisticas);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(973, 565);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlEstadisticas
            // 
            pnlEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEstadisticas.BackColor = Color.White;
            pnlEstadisticas.Controls.Add(pnlTotalJugadoresParados);
            pnlEstadisticas.Controls.Add(pnlTotalJugadores);
            pnlEstadisticas.Controls.Add(pnlTotalEquipos);
            pnlEstadisticas.Location = new Point(0, 90);
            pnlEstadisticas.Name = "pnlEstadisticas";
            pnlEstadisticas.Size = new Size(973, 475);
            pnlEstadisticas.TabIndex = 1;
            // 
            // pnlTotalJugadoresParados
            // 
            pnlTotalJugadoresParados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalJugadoresParados.BackColor = Color.Black;
            pnlTotalJugadoresParados.Controls.Add(lblNumTotalJugadoresParados);
            pnlTotalJugadoresParados.Controls.Add(lblTotalJugadoresParados);
            pnlTotalJugadoresParados.Location = new Point(67, 338);
            pnlTotalJugadoresParados.Name = "pnlTotalJugadoresParados";
            pnlTotalJugadoresParados.Size = new Size(843, 109);
            pnlTotalJugadoresParados.TabIndex = 2;
            // 
            // lblNumTotalJugadoresParados
            // 
            lblNumTotalJugadoresParados.Anchor = AnchorStyles.Top;
            lblNumTotalJugadoresParados.AutoSize = true;
            lblNumTotalJugadoresParados.BackColor = Color.Black;
            lblNumTotalJugadoresParados.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTotalJugadoresParados.ForeColor = Color.White;
            lblNumTotalJugadoresParados.Location = new Point(709, 32);
            lblNumTotalJugadoresParados.Name = "lblNumTotalJugadoresParados";
            lblNumTotalJugadoresParados.Size = new Size(40, 45);
            lblNumTotalJugadoresParados.TabIndex = 3;
            lblNumTotalJugadoresParados.Text = "0";
            // 
            // lblTotalJugadoresParados
            // 
            lblTotalJugadoresParados.Anchor = AnchorStyles.Top;
            lblTotalJugadoresParados.AutoSize = true;
            lblTotalJugadoresParados.BackColor = Color.Black;
            lblTotalJugadoresParados.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalJugadoresParados.ForeColor = Color.White;
            lblTotalJugadoresParados.Location = new Point(119, 32);
            lblTotalJugadoresParados.Name = "lblTotalJugadoresParados";
            lblTotalJugadoresParados.Size = new Size(584, 45);
            lblTotalJugadoresParados.TabIndex = 2;
            lblTotalJugadoresParados.Text = "TOTAL DE JUGADORES PARADOS :";
            // 
            // pnlTotalJugadores
            // 
            pnlTotalJugadores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalJugadores.BackColor = Color.Black;
            pnlTotalJugadores.Controls.Add(lblNumTotalJugadores);
            pnlTotalJugadores.Controls.Add(lblTotalJugadores);
            pnlTotalJugadores.Location = new Point(67, 184);
            pnlTotalJugadores.Name = "pnlTotalJugadores";
            pnlTotalJugadores.Size = new Size(843, 109);
            pnlTotalJugadores.TabIndex = 1;
            // 
            // lblNumTotalJugadores
            // 
            lblNumTotalJugadores.Anchor = AnchorStyles.Top;
            lblNumTotalJugadores.AutoSize = true;
            lblNumTotalJugadores.BackColor = Color.Black;
            lblNumTotalJugadores.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTotalJugadores.ForeColor = Color.White;
            lblNumTotalJugadores.Location = new Point(639, 33);
            lblNumTotalJugadores.Name = "lblNumTotalJugadores";
            lblNumTotalJugadores.Size = new Size(40, 45);
            lblNumTotalJugadores.TabIndex = 3;
            lblNumTotalJugadores.Text = "0";
            // 
            // lblTotalJugadores
            // 
            lblTotalJugadores.Anchor = AnchorStyles.Top;
            lblTotalJugadores.AutoSize = true;
            lblTotalJugadores.BackColor = Color.Black;
            lblTotalJugadores.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalJugadores.ForeColor = Color.White;
            lblTotalJugadores.Location = new Point(220, 33);
            lblTotalJugadores.Name = "lblTotalJugadores";
            lblTotalJugadores.Size = new Size(413, 45);
            lblTotalJugadores.TabIndex = 2;
            lblTotalJugadores.Text = "TOTAL DE JUGADORES :";
            // 
            // pnlTotalEquipos
            // 
            pnlTotalEquipos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalEquipos.BackColor = Color.Black;
            pnlTotalEquipos.Controls.Add(lblNumTotalEquipos);
            pnlTotalEquipos.Controls.Add(lblTotalEquipos);
            pnlTotalEquipos.Location = new Point(67, 27);
            pnlTotalEquipos.Name = "pnlTotalEquipos";
            pnlTotalEquipos.Size = new Size(843, 110);
            pnlTotalEquipos.TabIndex = 0;
            // 
            // lblNumTotalEquipos
            // 
            lblNumTotalEquipos.Anchor = AnchorStyles.Top;
            lblNumTotalEquipos.AutoSize = true;
            lblNumTotalEquipos.BackColor = Color.Black;
            lblNumTotalEquipos.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTotalEquipos.ForeColor = Color.White;
            lblNumTotalEquipos.Location = new Point(596, 34);
            lblNumTotalEquipos.Name = "lblNumTotalEquipos";
            lblNumTotalEquipos.Size = new Size(40, 45);
            lblNumTotalEquipos.TabIndex = 2;
            lblNumTotalEquipos.Text = "0";
            // 
            // lblTotalEquipos
            // 
            lblTotalEquipos.Anchor = AnchorStyles.Top;
            lblTotalEquipos.AutoSize = true;
            lblTotalEquipos.BackColor = Color.Black;
            lblTotalEquipos.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEquipos.ForeColor = Color.White;
            lblTotalEquipos.Location = new Point(233, 34);
            lblTotalEquipos.Name = "lblTotalEquipos";
            lblTotalEquipos.Size = new Size(357, 45);
            lblTotalEquipos.TabIndex = 1;
            lblTotalEquipos.Text = "TOTAL DE EQUIPOS :";
            // 
            // pnlLblEstadisticas
            // 
            pnlLblEstadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblEstadisticas.BackColor = Color.Black;
            pnlLblEstadisticas.Controls.Add(lblEstadisticas);
            pnlLblEstadisticas.Location = new Point(0, 0);
            pnlLblEstadisticas.Name = "pnlLblEstadisticas";
            pnlLblEstadisticas.Size = new Size(973, 95);
            pnlLblEstadisticas.TabIndex = 0;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.Anchor = AnchorStyles.Top;
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadisticas.ForeColor = Color.White;
            lblEstadisticas.Location = new Point(310, 23);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(388, 45);
            lblEstadisticas.TabIndex = 0;
            lblEstadisticas.Text = "--- ESTADISTICAS ---";
            // 
            // MenuInicio_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 565);
            Controls.Add(pnlPrincipal);
            Name = "MenuInicio_V";
            Text = "MENU INICIO";
            Load += MenuInicio_V_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlEstadisticas.ResumeLayout(false);
            pnlTotalJugadoresParados.ResumeLayout(false);
            pnlTotalJugadoresParados.PerformLayout();
            pnlTotalJugadores.ResumeLayout(false);
            pnlTotalJugadores.PerformLayout();
            pnlTotalEquipos.ResumeLayout(false);
            pnlTotalEquipos.PerformLayout();
            pnlLblEstadisticas.ResumeLayout(false);
            pnlLblEstadisticas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLblEstadisticas;
        private Label lblEstadisticas;
        private Panel pnlEstadisticas;
        private Panel pnlTotalEquipos;
        private Panel pnlTotalJugadoresParados;
        private Panel pnlTotalJugadores;
        private Label lblTotalJugadoresParados;
        private Label lblTotalJugadores;
        private Label lblTotalEquipos;
        private Label lblNumTotalEquipos;
        private Label lblNumTotalJugadoresParados;
        private Label lblNumTotalJugadores;
    }
}