namespace Winform_Task_Mvc.MenuJugador
{
    partial class MenuJugador_V
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
            pnlPrincipal = new Panel();
            pnlTabla = new Panel();
            dgwDatos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            nacionalidad = new DataGridViewTextBoxColumn();
            nombreEquipo = new DataGridViewTextBoxColumn();
            lblNumTotalJugadores = new Label();
            lblTotalJugadores = new Label();
            pnlBuscador_Reinicio = new Panel();
            btnRecargar = new Button();
            txtBusquedaJugador = new TextBox();
            lblBuscador = new Label();
            pnlLblJugadores = new Panel();
            lblJugadores = new Label();
            pnlBotones = new Panel();
            tblBotones = new TableLayoutPanel();
            btnEliminarJugador = new Button();
            btnActualizarJugador = new Button();
            btnAgregarJugador = new Button();
            btnVerJugador = new Button();
            pnlLblOpciones = new Panel();
            lblOpciones = new Label();
            pnlPrincipal.SuspendLayout();
            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatos).BeginInit();
            pnlBuscador_Reinicio.SuspendLayout();
            pnlLblJugadores.SuspendLayout();
            pnlBotones.SuspendLayout();
            tblBotones.SuspendLayout();
            pnlLblOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.White;
            pnlPrincipal.Controls.Add(pnlTabla);
            pnlPrincipal.Controls.Add(pnlBuscador_Reinicio);
            pnlPrincipal.Controls.Add(pnlLblJugadores);
            pnlPrincipal.Controls.Add(pnlBotones);
            pnlPrincipal.Controls.Add(pnlLblOpciones);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(973, 565);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlTabla
            // 
            pnlTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTabla.Controls.Add(dgwDatos);
            pnlTabla.Controls.Add(lblNumTotalJugadores);
            pnlTabla.Controls.Add(lblTotalJugadores);
            pnlTabla.Location = new Point(0, 319);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(973, 246);
            pnlTabla.TabIndex = 6;
            // 
            // dgwDatos
            // 
            dgwDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDatos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, edad, nacionalidad, nombreEquipo });
            dgwDatos.Cursor = Cursors.Hand;
            dgwDatos.Location = new Point(12, 49);
            dgwDatos.MultiSelect = false;
            dgwDatos.Name = "dgwDatos";
            dgwDatos.ReadOnly = true;
            dgwDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDatos.Size = new Size(949, 185);
            dgwDatos.TabIndex = 4;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.FillWeight = 33.2641449F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombre.DefaultCellStyle = dataGridViewCellStyle2;
            nombre.FillWeight = 177.664978F;
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // edad
            // 
            edad.DataPropertyName = "edad";
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edad.DefaultCellStyle = dataGridViewCellStyle3;
            edad.FillWeight = 78.23812F;
            edad.HeaderText = "EDAD";
            edad.Name = "edad";
            edad.ReadOnly = true;
            // 
            // nacionalidad
            // 
            nacionalidad.DataPropertyName = "nacionalidad";
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nacionalidad.DefaultCellStyle = dataGridViewCellStyle4;
            nacionalidad.FillWeight = 160.185272F;
            nacionalidad.HeaderText = "NACIONALIDAD";
            nacionalidad.Name = "nacionalidad";
            nacionalidad.ReadOnly = true;
            // 
            // nombreEquipo
            // 
            nombreEquipo.DataPropertyName = "nombreEquipo";
            dataGridViewCellStyle5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreEquipo.DefaultCellStyle = dataGridViewCellStyle5;
            nombreEquipo.FillWeight = 164.187637F;
            nombreEquipo.HeaderText = "EQUIPO";
            nombreEquipo.Name = "nombreEquipo";
            nombreEquipo.ReadOnly = true;
            // 
            // lblNumTotalJugadores
            // 
            lblNumTotalJugadores.AutoSize = true;
            lblNumTotalJugadores.BackColor = Color.White;
            lblNumTotalJugadores.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTotalJugadores.ForeColor = Color.Black;
            lblNumTotalJugadores.Location = new Point(198, 14);
            lblNumTotalJugadores.Name = "lblNumTotalJugadores";
            lblNumTotalJugadores.Size = new Size(20, 23);
            lblNumTotalJugadores.TabIndex = 3;
            lblNumTotalJugadores.Text = "0";
            // 
            // lblTotalJugadores
            // 
            lblTotalJugadores.AutoSize = true;
            lblTotalJugadores.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalJugadores.Location = new Point(12, 14);
            lblTotalJugadores.Name = "lblTotalJugadores";
            lblTotalJugadores.Size = new Size(191, 23);
            lblTotalJugadores.TabIndex = 1;
            lblTotalJugadores.Text = "* Total de Jugadores :";
            // 
            // pnlBuscador_Reinicio
            // 
            pnlBuscador_Reinicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBuscador_Reinicio.Controls.Add(btnRecargar);
            pnlBuscador_Reinicio.Controls.Add(txtBusquedaJugador);
            pnlBuscador_Reinicio.Controls.Add(lblBuscador);
            pnlBuscador_Reinicio.Location = new Point(0, 222);
            pnlBuscador_Reinicio.Name = "pnlBuscador_Reinicio";
            pnlBuscador_Reinicio.Size = new Size(973, 91);
            pnlBuscador_Reinicio.TabIndex = 5;
            // 
            // btnRecargar
            // 
            btnRecargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRecargar.BackColor = Color.Black;
            btnRecargar.Cursor = Cursors.Hand;
            btnRecargar.FlatAppearance.BorderColor = Color.Black;
            btnRecargar.FlatAppearance.BorderSize = 3;
            btnRecargar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnRecargar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnRecargar.FlatStyle = FlatStyle.Flat;
            btnRecargar.Image = Properties.Resources.icono_recarga_app_c_;
            btnRecargar.Location = new Point(910, 29);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(51, 47);
            btnRecargar.TabIndex = 2;
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // txtBusquedaJugador
            // 
            txtBusquedaJugador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusquedaJugador.Cursor = Cursors.Hand;
            txtBusquedaJugador.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusquedaJugador.Location = new Point(12, 46);
            txtBusquedaJugador.Name = "txtBusquedaJugador";
            txtBusquedaJugador.PlaceholderText = "Introduce el nombre...";
            txtBusquedaJugador.Size = new Size(839, 30);
            txtBusquedaJugador.TabIndex = 1;
            txtBusquedaJugador.TextChanged += txtBusquedaJugador_TextChanged;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(12, 10);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(324, 23);
            lblBuscador.TabIndex = 0;
            lblBuscador.Text = "* Busqueda por nombre del Jugador :";
            // 
            // pnlLblJugadores
            // 
            pnlLblJugadores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblJugadores.BackColor = Color.Black;
            pnlLblJugadores.Controls.Add(lblJugadores);
            pnlLblJugadores.Location = new Point(0, 147);
            pnlLblJugadores.Name = "pnlLblJugadores";
            pnlLblJugadores.Size = new Size(973, 69);
            pnlLblJugadores.TabIndex = 4;
            // 
            // lblJugadores
            // 
            lblJugadores.Anchor = AnchorStyles.Top;
            lblJugadores.AutoSize = true;
            lblJugadores.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJugadores.ForeColor = Color.White;
            lblJugadores.Location = new Point(327, 15);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(353, 45);
            lblJugadores.TabIndex = 0;
            lblJugadores.Text = "--- JUGADORES ---";
            // 
            // pnlBotones
            // 
            pnlBotones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBotones.BackColor = Color.White;
            pnlBotones.Controls.Add(tblBotones);
            pnlBotones.Location = new Point(0, 75);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(973, 69);
            pnlBotones.TabIndex = 3;
            // 
            // tblBotones
            // 
            tblBotones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblBotones.BackColor = Color.White;
            tblBotones.ColumnCount = 4;
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.0315266F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.0315342F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9153156F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0216255F));
            tblBotones.Controls.Add(btnEliminarJugador, 3, 0);
            tblBotones.Controls.Add(btnActualizarJugador, 2, 0);
            tblBotones.Controls.Add(btnAgregarJugador, 1, 0);
            tblBotones.Controls.Add(btnVerJugador, 0, 0);
            tblBotones.Location = new Point(0, 0);
            tblBotones.Name = "tblBotones";
            tblBotones.RowCount = 1;
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotones.Size = new Size(973, 69);
            tblBotones.TabIndex = 2;
            // 
            // btnEliminarJugador
            // 
            btnEliminarJugador.BackColor = Color.Black;
            btnEliminarJugador.Cursor = Cursors.Hand;
            btnEliminarJugador.Dock = DockStyle.Top;
            btnEliminarJugador.FlatAppearance.BorderColor = Color.Black;
            btnEliminarJugador.FlatAppearance.BorderSize = 3;
            btnEliminarJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEliminarJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarJugador.FlatStyle = FlatStyle.Flat;
            btnEliminarJugador.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarJugador.ForeColor = Color.White;
            btnEliminarJugador.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarJugador.Location = new Point(737, 5);
            btnEliminarJugador.Margin = new Padding(10, 5, 10, 6);
            btnEliminarJugador.Name = "btnEliminarJugador";
            btnEliminarJugador.Size = new Size(226, 58);
            btnEliminarJugador.TabIndex = 9;
            btnEliminarJugador.Text = "ELIMINAR JUGADOR";
            btnEliminarJugador.UseVisualStyleBackColor = false;
            btnEliminarJugador.Click += btnEliminarJugador_Click;
            // 
            // btnActualizarJugador
            // 
            btnActualizarJugador.BackColor = Color.Black;
            btnActualizarJugador.Cursor = Cursors.Hand;
            btnActualizarJugador.Dock = DockStyle.Top;
            btnActualizarJugador.FlatAppearance.BorderColor = Color.Black;
            btnActualizarJugador.FlatAppearance.BorderSize = 3;
            btnActualizarJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnActualizarJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnActualizarJugador.FlatStyle = FlatStyle.Flat;
            btnActualizarJugador.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarJugador.ForeColor = Color.White;
            btnActualizarJugador.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarJugador.Location = new Point(472, 5);
            btnActualizarJugador.Margin = new Padding(6, 5, 0, 6);
            btnActualizarJugador.Name = "btnActualizarJugador";
            btnActualizarJugador.Size = new Size(255, 58);
            btnActualizarJugador.TabIndex = 8;
            btnActualizarJugador.Text = "ACTUALIZAR JUGADOR";
            btnActualizarJugador.UseVisualStyleBackColor = false;
            btnActualizarJugador.Click += btnActualizarJugador_Click;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.BackColor = Color.Black;
            btnAgregarJugador.Cursor = Cursors.Hand;
            btnAgregarJugador.Dock = DockStyle.Top;
            btnAgregarJugador.FlatAppearance.BorderColor = Color.Black;
            btnAgregarJugador.FlatAppearance.BorderSize = 3;
            btnAgregarJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnAgregarJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregarJugador.FlatStyle = FlatStyle.Flat;
            btnAgregarJugador.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarJugador.ForeColor = Color.White;
            btnAgregarJugador.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarJugador.Location = new Point(239, 5);
            btnAgregarJugador.Margin = new Padding(6, 5, 6, 6);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(221, 58);
            btnAgregarJugador.TabIndex = 7;
            btnAgregarJugador.Text = "AGREGAR JUGADOR";
            btnAgregarJugador.UseVisualStyleBackColor = false;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnVerJugador
            // 
            btnVerJugador.BackColor = Color.Black;
            btnVerJugador.Cursor = Cursors.Hand;
            btnVerJugador.Dock = DockStyle.Top;
            btnVerJugador.FlatAppearance.BorderColor = Color.Black;
            btnVerJugador.FlatAppearance.BorderSize = 3;
            btnVerJugador.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnVerJugador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVerJugador.FlatStyle = FlatStyle.Flat;
            btnVerJugador.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerJugador.ForeColor = Color.White;
            btnVerJugador.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerJugador.Location = new Point(10, 5);
            btnVerJugador.Margin = new Padding(10, 5, 6, 6);
            btnVerJugador.Name = "btnVerJugador";
            btnVerJugador.Size = new Size(217, 58);
            btnVerJugador.TabIndex = 6;
            btnVerJugador.Text = "VER JUGADOR";
            btnVerJugador.UseVisualStyleBackColor = false;
            btnVerJugador.Click += btnVerJugador_Click;
            // 
            // pnlLblOpciones
            // 
            pnlLblOpciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblOpciones.BackColor = Color.Black;
            pnlLblOpciones.Controls.Add(lblOpciones);
            pnlLblOpciones.Location = new Point(0, 0);
            pnlLblOpciones.Name = "pnlLblOpciones";
            pnlLblOpciones.Size = new Size(973, 69);
            pnlLblOpciones.TabIndex = 1;
            // 
            // lblOpciones
            // 
            lblOpciones.Anchor = AnchorStyles.Top;
            lblOpciones.AutoSize = true;
            lblOpciones.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpciones.ForeColor = Color.White;
            lblOpciones.Location = new Point(341, 9);
            lblOpciones.Name = "lblOpciones";
            lblOpciones.Size = new Size(323, 45);
            lblOpciones.TabIndex = 0;
            lblOpciones.Text = "--- OPCIONES ---";
            // 
            // MenuJugador_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 565);
            Controls.Add(pnlPrincipal);
            Name = "MenuJugador_V";
            Text = "JUGADOR";
            FormClosed += MenuJugador_V_FormClosed;
            Load += MenuJugador_V_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlTabla.ResumeLayout(false);
            pnlTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatos).EndInit();
            pnlBuscador_Reinicio.ResumeLayout(false);
            pnlBuscador_Reinicio.PerformLayout();
            pnlLblJugadores.ResumeLayout(false);
            pnlLblJugadores.PerformLayout();
            pnlBotones.ResumeLayout(false);
            tblBotones.ResumeLayout(false);
            pnlLblOpciones.ResumeLayout(false);
            pnlLblOpciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlLblOpciones;
        private Label lblOpciones;
        private Panel pnlBotones;
        private TableLayoutPanel tblBotones;
        private Button btnEliminarJugador;
        private Button btnActualizarJugador;
        private Button btnAgregarJugador;
        private Button btnVerJugador;
        private Panel pnlLblJugadores;
        private Label lblJugadores;
        private Panel pnlBuscador_Reinicio;
        private Label lblBuscador;
        private TextBox txtBusquedaJugador;
        private Button btnRecargar;
        private Panel pnlTabla;
        private Label lblTotalJugadores;
        private Label lblNumTotalJugadores;
        private DataGridView dgwDatos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn nacionalidad;
        private DataGridViewTextBoxColumn nombreEquipo;
    }
}