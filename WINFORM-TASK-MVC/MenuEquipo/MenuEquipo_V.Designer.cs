namespace Winform_Task_Mvc.MenuEquipo
{
    partial class MenuEquipo_V
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlPrincipal = new Panel();
            pnlTabla = new Panel();
            dgwDatos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            liga = new DataGridViewTextBoxColumn();
            totalJugadores = new DataGridViewTextBoxColumn();
            lblNumTotalEquipos = new Label();
            lblTotalEquipos = new Label();
            pnlBuscador_Reinicio = new Panel();
            btnRecargar = new Button();
            txtBusquedaEquipo = new TextBox();
            lblBuscador = new Label();
            pnlLblEquipos = new Panel();
            lblEquipos = new Label();
            pnlBotones = new Panel();
            tblBotones = new TableLayoutPanel();
            btnEliminarEquipo = new Button();
            btnActualizarEquipo = new Button();
            btnAgregarEquipo = new Button();
            btnVerEquipo = new Button();
            pnlLblOpciones = new Panel();
            lblOpciones = new Label();
            pnlPrincipal.SuspendLayout();
            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatos).BeginInit();
            pnlBuscador_Reinicio.SuspendLayout();
            pnlLblEquipos.SuspendLayout();
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
            pnlPrincipal.Controls.Add(pnlLblEquipos);
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
            pnlTabla.Controls.Add(lblNumTotalEquipos);
            pnlTabla.Controls.Add(lblTotalEquipos);
            pnlTabla.Location = new Point(0, 319);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(973, 246);
            pnlTabla.TabIndex = 6;
            // 
            // dgwDatos
            // 
            dgwDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDatos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, liga, totalJugadores });
            dgwDatos.Cursor = Cursors.Hand;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgwDatos.DefaultCellStyle = dataGridViewCellStyle4;
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
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.DataPropertyName = "id";
            dataGridViewCellStyle1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.DataPropertyName = "nombre";
            dataGridViewCellStyle2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombre.DefaultCellStyle = dataGridViewCellStyle2;
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // liga
            // 
            liga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            liga.DataPropertyName = "liga";
            dataGridViewCellStyle3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            liga.DefaultCellStyle = dataGridViewCellStyle3;
            liga.HeaderText = "LIGA";
            liga.Name = "liga";
            liga.ReadOnly = true;
            // 
            // totalJugadores
            // 
            totalJugadores.DataPropertyName = "totalJugadores";
            totalJugadores.HeaderText = "TOTAL JUGADORES";
            totalJugadores.Name = "totalJugadores";
            totalJugadores.ReadOnly = true;
            // 
            // lblNumTotalEquipos
            // 
            lblNumTotalEquipos.AutoSize = true;
            lblNumTotalEquipos.BackColor = Color.White;
            lblNumTotalEquipos.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumTotalEquipos.ForeColor = Color.Black;
            lblNumTotalEquipos.Location = new Point(177, 14);
            lblNumTotalEquipos.Name = "lblNumTotalEquipos";
            lblNumTotalEquipos.Size = new Size(20, 23);
            lblNumTotalEquipos.TabIndex = 3;
            lblNumTotalEquipos.Text = "0";
            // 
            // lblTotalEquipos
            // 
            lblTotalEquipos.AutoSize = true;
            lblTotalEquipos.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEquipos.Location = new Point(12, 14);
            lblTotalEquipos.Name = "lblTotalEquipos";
            lblTotalEquipos.Size = new Size(169, 23);
            lblTotalEquipos.TabIndex = 1;
            lblTotalEquipos.Text = "* Total de Equipos :";
            // 
            // pnlBuscador_Reinicio
            // 
            pnlBuscador_Reinicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBuscador_Reinicio.Controls.Add(btnRecargar);
            pnlBuscador_Reinicio.Controls.Add(txtBusquedaEquipo);
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
            // txtBusquedaEquipo
            // 
            txtBusquedaEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusquedaEquipo.Cursor = Cursors.Hand;
            txtBusquedaEquipo.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusquedaEquipo.Location = new Point(12, 46);
            txtBusquedaEquipo.Name = "txtBusquedaEquipo";
            txtBusquedaEquipo.PlaceholderText = "Introduce el nombre...";
            txtBusquedaEquipo.Size = new Size(839, 30);
            txtBusquedaEquipo.TabIndex = 1;
            txtBusquedaEquipo.TextChanged += txtBusquedaEquipo_TextChanged;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscador.Location = new Point(12, 10);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(312, 23);
            lblBuscador.TabIndex = 0;
            lblBuscador.Text = "* Busqueda por nombre del Equipo :";
            // 
            // pnlLblEquipos
            // 
            pnlLblEquipos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblEquipos.BackColor = Color.Black;
            pnlLblEquipos.Controls.Add(lblEquipos);
            pnlLblEquipos.Location = new Point(0, 147);
            pnlLblEquipos.Name = "pnlLblEquipos";
            pnlLblEquipos.Size = new Size(973, 69);
            pnlLblEquipos.TabIndex = 4;
            // 
            // lblEquipos
            // 
            lblEquipos.Anchor = AnchorStyles.Top;
            lblEquipos.AutoSize = true;
            lblEquipos.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEquipos.ForeColor = Color.White;
            lblEquipos.Location = new Point(351, 14);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(297, 45);
            lblEquipos.TabIndex = 0;
            lblEquipos.Text = "--- EQUIPOS ---";
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
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBotones.Controls.Add(btnEliminarEquipo, 3, 0);
            tblBotones.Controls.Add(btnActualizarEquipo, 2, 0);
            tblBotones.Controls.Add(btnAgregarEquipo, 1, 0);
            tblBotones.Controls.Add(btnVerEquipo, 0, 0);
            tblBotones.Location = new Point(0, 0);
            tblBotones.Name = "tblBotones";
            tblBotones.RowCount = 1;
            tblBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBotones.Size = new Size(973, 69);
            tblBotones.TabIndex = 2;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.BackColor = Color.Black;
            btnEliminarEquipo.Cursor = Cursors.Hand;
            btnEliminarEquipo.Dock = DockStyle.Top;
            btnEliminarEquipo.FlatAppearance.BorderColor = Color.Black;
            btnEliminarEquipo.FlatAppearance.BorderSize = 3;
            btnEliminarEquipo.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnEliminarEquipo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarEquipo.FlatStyle = FlatStyle.Flat;
            btnEliminarEquipo.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarEquipo.ForeColor = Color.White;
            btnEliminarEquipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarEquipo.Location = new Point(735, 5);
            btnEliminarEquipo.Margin = new Padding(6, 5, 10, 6);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(228, 58);
            btnEliminarEquipo.TabIndex = 9;
            btnEliminarEquipo.Text = "ELIMINAR EQUIPO";
            btnEliminarEquipo.UseVisualStyleBackColor = false;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnActualizarEquipo
            // 
            btnActualizarEquipo.BackColor = Color.Black;
            btnActualizarEquipo.Cursor = Cursors.Hand;
            btnActualizarEquipo.Dock = DockStyle.Top;
            btnActualizarEquipo.FlatAppearance.BorderColor = Color.Black;
            btnActualizarEquipo.FlatAppearance.BorderSize = 3;
            btnActualizarEquipo.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnActualizarEquipo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnActualizarEquipo.FlatStyle = FlatStyle.Flat;
            btnActualizarEquipo.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarEquipo.ForeColor = Color.White;
            btnActualizarEquipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarEquipo.Location = new Point(492, 5);
            btnActualizarEquipo.Margin = new Padding(6, 5, 6, 6);
            btnActualizarEquipo.Name = "btnActualizarEquipo";
            btnActualizarEquipo.Size = new Size(231, 58);
            btnActualizarEquipo.TabIndex = 8;
            btnActualizarEquipo.Text = "ACTUALIZAR EQUIPO";
            btnActualizarEquipo.UseVisualStyleBackColor = false;
            btnActualizarEquipo.Click += btnActualizarEquipo_Click;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.BackColor = Color.Black;
            btnAgregarEquipo.Cursor = Cursors.Hand;
            btnAgregarEquipo.Dock = DockStyle.Top;
            btnAgregarEquipo.FlatAppearance.BorderColor = Color.Black;
            btnAgregarEquipo.FlatAppearance.BorderSize = 3;
            btnAgregarEquipo.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnAgregarEquipo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregarEquipo.FlatStyle = FlatStyle.Flat;
            btnAgregarEquipo.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEquipo.ForeColor = Color.White;
            btnAgregarEquipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarEquipo.Location = new Point(249, 5);
            btnAgregarEquipo.Margin = new Padding(6, 5, 6, 6);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(231, 58);
            btnAgregarEquipo.TabIndex = 7;
            btnAgregarEquipo.Text = "AGREGAR EQUIPO";
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnVerEquipo
            // 
            btnVerEquipo.BackColor = Color.Black;
            btnVerEquipo.Cursor = Cursors.Hand;
            btnVerEquipo.Dock = DockStyle.Top;
            btnVerEquipo.FlatAppearance.BorderColor = Color.Black;
            btnVerEquipo.FlatAppearance.BorderSize = 3;
            btnVerEquipo.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btnVerEquipo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVerEquipo.FlatStyle = FlatStyle.Flat;
            btnVerEquipo.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerEquipo.ForeColor = Color.White;
            btnVerEquipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerEquipo.Location = new Point(10, 5);
            btnVerEquipo.Margin = new Padding(10, 5, 6, 6);
            btnVerEquipo.Name = "btnVerEquipo";
            btnVerEquipo.Size = new Size(227, 58);
            btnVerEquipo.TabIndex = 6;
            btnVerEquipo.Text = "VER EQUIPO";
            btnVerEquipo.UseVisualStyleBackColor = false;
            btnVerEquipo.Click += btnVerEquipo_Click;
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
            // MenuEquipo_V
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 565);
            Controls.Add(pnlPrincipal);
            Name = "MenuEquipo_V";
            Text = "EQUIPO";
            FormClosed += MenuEquipo_V_FormClosed;
            Load += MenuEquipo_V_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlTabla.ResumeLayout(false);
            pnlTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwDatos).EndInit();
            pnlBuscador_Reinicio.ResumeLayout(false);
            pnlBuscador_Reinicio.PerformLayout();
            pnlLblEquipos.ResumeLayout(false);
            pnlLblEquipos.PerformLayout();
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
        private Button btnEliminarEquipo;
        private Button btnActualizarEquipo;
        private Button btnAgregarEquipo;
        private Button btnVerEquipo;
        private Panel pnlLblEquipos;
        private Label lblEquipos;
        private Panel pnlBuscador_Reinicio;
        private Label lblBuscador;
        private TextBox txtBusquedaEquipo;
        private Button btnRecargar;
        private Panel pnlTabla;
        private Label lblTotalEquipos;
        private Label lblNumTotalEquipos;
        private DataGridView dgwDatos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn liga;
        private DataGridViewTextBoxColumn totalJugadores;
    }
}