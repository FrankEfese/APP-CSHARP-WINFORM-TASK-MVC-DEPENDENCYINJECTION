namespace Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.VerEquipo
{
    partial class VerEquipo_V
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlPrincipal = new Panel();
            pnlVerEquipo = new Panel();
            btnFicharJugador = new Button();
            btnDespedirJugador = new Button();
            lblNumTotalJugadoresParados = new Label();
            lblJugadoresParados = new Label();
            dgwDatosParados = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            lblJugadoresPlantilla = new Label();
            dgwDatosPlantilla = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            lblJugadoresEquipo = new Label();
            lblLigaEquipo = new Label();
            lblNombreEquipo = new Label();
            lblJugadores = new Label();
            lblLiga = new Label();
            lblNombre = new Label();
            pnlSeparador_1 = new Panel();
            pnlSeparador_2 = new Panel();
            pnlSeparador_3 = new Panel();
            pnlSeparador_4 = new Panel();
            pnlLblVerEquipo = new Panel();
            lblVerEquipo = new Label();
            pnlPrincipal.SuspendLayout();
            pnlVerEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatosParados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwDatosPlantilla).BeginInit();
            pnlLblVerEquipo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(pnlVerEquipo);
            pnlPrincipal.Controls.Add(pnlLblVerEquipo);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(973, 529);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlVerEquipo
            // 
            pnlVerEquipo.Controls.Add(btnFicharJugador);
            pnlVerEquipo.Controls.Add(btnDespedirJugador);
            pnlVerEquipo.Controls.Add(lblNumTotalJugadoresParados);
            pnlVerEquipo.Controls.Add(lblJugadoresParados);
            pnlVerEquipo.Controls.Add(dgwDatosParados);
            pnlVerEquipo.Controls.Add(lblJugadoresPlantilla);
            pnlVerEquipo.Controls.Add(dgwDatosPlantilla);
            pnlVerEquipo.Controls.Add(lblJugadoresEquipo);
            pnlVerEquipo.Controls.Add(lblLigaEquipo);
            pnlVerEquipo.Controls.Add(lblNombreEquipo);
            pnlVerEquipo.Controls.Add(lblJugadores);
            pnlVerEquipo.Controls.Add(lblLiga);
            pnlVerEquipo.Controls.Add(lblNombre);
            pnlVerEquipo.Controls.Add(pnlSeparador_1);
            pnlVerEquipo.Controls.Add(pnlSeparador_2);
            pnlVerEquipo.Controls.Add(pnlSeparador_3);
            pnlVerEquipo.Controls.Add(pnlSeparador_4);
            pnlVerEquipo.Location = new Point(0, 78);
            pnlVerEquipo.Name = "pnlVerEquipo";
            pnlVerEquipo.Size = new Size(973, 451);
            pnlVerEquipo.TabIndex = 6;
            // 
            // btnFicharJugador
            // 
            btnFicharJugador.BackColor = Color.Black;
            btnFicharJugador.Cursor = Cursors.Hand;
            btnFicharJugador.FlatAppearance.BorderColor = Color.Black;
            btnFicharJugador.FlatAppearance.BorderSize = 3;
            btnFicharJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnFicharJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFicharJugador.FlatStyle = FlatStyle.Flat;
            btnFicharJugador.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFicharJugador.ForeColor = Color.White;
            btnFicharJugador.Location = new Point(510, 386);
            btnFicharJugador.Name = "btnFicharJugador";
            btnFicharJugador.Size = new Size(422, 46);
            btnFicharJugador.TabIndex = 90;
            btnFicharJugador.Text = "FICHAR JUGADOR";
            btnFicharJugador.UseVisualStyleBackColor = false;
            btnFicharJugador.Click += btnFicharJugador_Click;
            // 
            // btnDespedirJugador
            // 
            btnDespedirJugador.BackColor = Color.Black;
            btnDespedirJugador.Cursor = Cursors.Hand;
            btnDespedirJugador.FlatAppearance.BorderColor = Color.Black;
            btnDespedirJugador.FlatAppearance.BorderSize = 3;
            btnDespedirJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnDespedirJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnDespedirJugador.FlatStyle = FlatStyle.Flat;
            btnDespedirJugador.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDespedirJugador.ForeColor = Color.White;
            btnDespedirJugador.Location = new Point(32, 386);
            btnDespedirJugador.Name = "btnDespedirJugador";
            btnDespedirJugador.Size = new Size(420, 46);
            btnDespedirJugador.TabIndex = 89;
            btnDespedirJugador.Text = "DESPEDIR JUGADOR";
            btnDespedirJugador.UseVisualStyleBackColor = false;
            btnDespedirJugador.Click += btnDespedirJugador_Click;
            // 
            // lblNumTotalJugadoresParados
            // 
            lblNumTotalJugadoresParados.AutoSize = true;
            lblNumTotalJugadoresParados.BackColor = Color.White;
            lblNumTotalJugadoresParados.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTotalJugadoresParados.ForeColor = Color.Black;
            lblNumTotalJugadoresParados.Location = new Point(712, 172);
            lblNumTotalJugadoresParados.Name = "lblNumTotalJugadoresParados";
            lblNumTotalJugadoresParados.Size = new Size(20, 23);
            lblNumTotalJugadoresParados.TabIndex = 40;
            lblNumTotalJugadoresParados.Text = "0";
            // 
            // lblJugadoresParados
            // 
            lblJugadoresParados.AutoSize = true;
            lblJugadoresParados.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJugadoresParados.Location = new Point(510, 172);
            lblJugadoresParados.Name = "lblJugadoresParados";
            lblJugadoresParados.Size = new Size(196, 23);
            lblJugadoresParados.TabIndex = 39;
            lblJugadoresParados.Text = "* Jugadores Parados :";
            // 
            // dgwDatosParados
            // 
            dgwDatosParados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwDatosParados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDatosParados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDatosParados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgwDatosParados.Cursor = Cursors.Hand;
            dgwDatosParados.Location = new Point(510, 198);
            dgwDatosParados.MultiSelect = false;
            dgwDatosParados.Name = "dgwDatosParados";
            dgwDatosParados.ReadOnly = true;
            dgwDatosParados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDatosParados.Size = new Size(422, 149);
            dgwDatosParados.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn1.FillWeight = 55.9891357F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn2.FillWeight = 198.325577F;
            dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "edad";
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn3.FillWeight = 45.68528F;
            dataGridViewTextBoxColumn3.HeaderText = "EDAD";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblJugadoresPlantilla
            // 
            lblJugadoresPlantilla.AutoSize = true;
            lblJugadoresPlantilla.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJugadoresPlantilla.Location = new Point(32, 172);
            lblJugadoresPlantilla.Name = "lblJugadoresPlantilla";
            lblJugadoresPlantilla.Size = new Size(224, 23);
            lblJugadoresPlantilla.TabIndex = 37;
            lblJugadoresPlantilla.Text = "* Jugadores en Plantilla :";
            // 
            // dgwDatosPlantilla
            // 
            dgwDatosPlantilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwDatosPlantilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDatosPlantilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDatosPlantilla.Columns.AddRange(new DataGridViewColumn[] { id, nombre, edad });
            dgwDatosPlantilla.Cursor = Cursors.Hand;
            dgwDatosPlantilla.Location = new Point(32, 198);
            dgwDatosPlantilla.MultiSelect = false;
            dgwDatosPlantilla.Name = "dgwDatosPlantilla";
            dgwDatosPlantilla.ReadOnly = true;
            dgwDatosPlantilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDatosPlantilla.Size = new Size(420, 149);
            dgwDatosPlantilla.TabIndex = 36;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.DefaultCellStyle = dataGridViewCellStyle4;
            id.FillWeight = 55.9891357F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombre.DefaultCellStyle = dataGridViewCellStyle5;
            nombre.FillWeight = 198.325577F;
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // edad
            // 
            edad.DataPropertyName = "edad";
            dataGridViewCellStyle6.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edad.DefaultCellStyle = dataGridViewCellStyle6;
            edad.FillWeight = 45.68528F;
            edad.HeaderText = "EDAD";
            edad.Name = "edad";
            edad.ReadOnly = true;
            // 
            // lblJugadoresEquipo
            // 
            lblJugadoresEquipo.Anchor = AnchorStyles.Top;
            lblJugadoresEquipo.AutoSize = true;
            lblJugadoresEquipo.BackColor = Color.Transparent;
            lblJugadoresEquipo.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJugadoresEquipo.ForeColor = Color.Black;
            lblJugadoresEquipo.Location = new Point(336, 111);
            lblJugadoresEquipo.Name = "lblJugadoresEquipo";
            lblJugadoresEquipo.Size = new Size(0, 29);
            lblJugadoresEquipo.TabIndex = 35;
            // 
            // lblLigaEquipo
            // 
            lblLigaEquipo.Anchor = AnchorStyles.Top;
            lblLigaEquipo.AutoSize = true;
            lblLigaEquipo.BackColor = Color.Transparent;
            lblLigaEquipo.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLigaEquipo.ForeColor = Color.Black;
            lblLigaEquipo.Location = new Point(123, 68);
            lblLigaEquipo.Name = "lblLigaEquipo";
            lblLigaEquipo.Size = new Size(0, 29);
            lblLigaEquipo.TabIndex = 34;
            // 
            // lblNombreEquipo
            // 
            lblNombreEquipo.Anchor = AnchorStyles.Top;
            lblNombreEquipo.AutoSize = true;
            lblNombreEquipo.BackColor = Color.Transparent;
            lblNombreEquipo.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreEquipo.ForeColor = Color.Black;
            lblNombreEquipo.Location = new Point(158, 27);
            lblNombreEquipo.Name = "lblNombreEquipo";
            lblNombreEquipo.Size = new Size(0, 29);
            lblNombreEquipo.TabIndex = 33;
            // 
            // lblJugadores
            // 
            lblJugadores.Anchor = AnchorStyles.Top;
            lblJugadores.AutoSize = true;
            lblJugadores.BackColor = Color.Transparent;
            lblJugadores.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJugadores.ForeColor = Color.Black;
            lblJugadores.Location = new Point(32, 111);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(298, 29);
            lblJugadores.TabIndex = 32;
            lblJugadores.Text = "NUMERO DE JUGADORES :";
            // 
            // lblLiga
            // 
            lblLiga.Anchor = AnchorStyles.Top;
            lblLiga.AutoSize = true;
            lblLiga.BackColor = Color.Transparent;
            lblLiga.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLiga.ForeColor = Color.Black;
            lblLiga.Location = new Point(32, 68);
            lblLiga.Name = "lblLiga";
            lblLiga.Size = new Size(76, 29);
            lblLiga.TabIndex = 31;
            lblLiga.Text = "LIGA :";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(32, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(120, 29);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "NOMBRE :";
            // 
            // pnlSeparador_1
            // 
            pnlSeparador_1.BackColor = Color.Black;
            pnlSeparador_1.Location = new Point(32, 19);
            pnlSeparador_1.Name = "pnlSeparador_1";
            pnlSeparador_1.Size = new Size(900, 5);
            pnlSeparador_1.TabIndex = 29;
            // 
            // pnlSeparador_2
            // 
            pnlSeparador_2.BackColor = Color.Black;
            pnlSeparador_2.Location = new Point(32, 60);
            pnlSeparador_2.Name = "pnlSeparador_2";
            pnlSeparador_2.Size = new Size(900, 5);
            pnlSeparador_2.TabIndex = 28;
            // 
            // pnlSeparador_3
            // 
            pnlSeparador_3.BackColor = Color.Black;
            pnlSeparador_3.Location = new Point(32, 101);
            pnlSeparador_3.Name = "pnlSeparador_3";
            pnlSeparador_3.Size = new Size(900, 5);
            pnlSeparador_3.TabIndex = 27;
            // 
            // pnlSeparador_4
            // 
            pnlSeparador_4.BackColor = Color.Black;
            pnlSeparador_4.Location = new Point(32, 143);
            pnlSeparador_4.Name = "pnlSeparador_4";
            pnlSeparador_4.Size = new Size(900, 5);
            pnlSeparador_4.TabIndex = 26;
            // 
            // pnlLblVerEquipo
            // 
            pnlLblVerEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblVerEquipo.BackColor = Color.Black;
            pnlLblVerEquipo.Controls.Add(lblVerEquipo);
            pnlLblVerEquipo.Location = new Point(0, 0);
            pnlLblVerEquipo.Name = "pnlLblVerEquipo";
            pnlLblVerEquipo.Size = new Size(973, 82);
            pnlLblVerEquipo.TabIndex = 5;
            // 
            // lblVerEquipo
            // 
            lblVerEquipo.Anchor = AnchorStyles.Top;
            lblVerEquipo.AutoSize = true;
            lblVerEquipo.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerEquipo.ForeColor = Color.White;
            lblVerEquipo.Location = new Point(314, 20);
            lblVerEquipo.Name = "lblVerEquipo";
            lblVerEquipo.Size = new Size(353, 45);
            lblVerEquipo.TabIndex = 1;
            lblVerEquipo.Text = "--- VER EQUIPO ---";
            // 
            // VerEquipo_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 529);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MaximumSize = new Size(989, 568);
            MinimumSize = new Size(989, 568);
            Name = "VerEquipo_V";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VER EQUIPO";
            Load += VerEquipo_V_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlVerEquipo.ResumeLayout(false);
            pnlVerEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatosParados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwDatosPlantilla).EndInit();
            pnlLblVerEquipo.ResumeLayout(false);
            pnlLblVerEquipo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLblVerEquipo;
        private Label lblVerEquipo;
        private Panel pnlVerEquipo;
        private Label lblJugadoresEquipo;
        private Label lblLigaEquipo;
        private Label lblNombreEquipo;
        private Label lblJugadores;
        private Label lblLiga;
        private Label lblNombre;
        private Panel pnlSeparador_1;
        private Panel pnlSeparador_2;
        private Panel pnlSeparador_3;
        private Panel pnlSeparador_4;
        private DataGridView dgwDatosPlantilla;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn edad;
        private Label lblJugadoresPlantilla;
        private Label lblJugadoresParados;
        private DataGridView dgwDatosParados;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblNumTotalJugadoresParados;
        private Button btnDespedirJugador;
        private Button btnFicharJugador;
    }
}