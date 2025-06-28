using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.ActualizarEquipo;
using Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.AgregarEquipo;
using Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.VerEquipo;
using Winform_Task_Mvc.Objects;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Data;


namespace Winform_Task_Mvc.MenuEquipo
{
    public partial class MenuEquipo_V : Form, INotifyPropertyChanged
    {


        // VARIABLES VENTANAS-OPCIONES

        public VerEquipo_V verEquipo = null;
        public AgregarEquipo_V agregarEquipo = null;
        public ActualizarEquipo_V actualizarEquipo = null;


        // INYECCION DE DEPENDENCIA

        private readonly EquipoController _controladorEquipo;


        public MenuEquipo_V(EquipoController controladorEquipo) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorEquipo = controladorEquipo;
        }


        // IMPLEMENTACION DE INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        // VARIABLES DATABINDING

        private BindingList<Equipo> _equipos = new BindingList<Equipo>();
        public BindingList<Equipo> Equipos
        {
            get => _equipos;
            set
            {
                if (_equipos != value)
                {
                    _equipos = value;
                    OnPropertyChanged(nameof(Equipos));
                }
            }
        }



        // EVENTOS

        private async void MenuEquipo_V_Load(object sender, EventArgs e) // EVENTO PARA CARGAR LOS DATOS DE INICIO Y VINCULAR EL DATABINDING
        {
            await CargarDatos();
        }


        private void MenuEquipo_V_FormClosed(object sender, FormClosedEventArgs e) // EVENTO PARA CERRAR LAS VENTANAS DE OPCIONES
        {

            if (this.verEquipo != null) this.verEquipo.Close();

            if (this.agregarEquipo != null) this.agregarEquipo.Close();

            if (this.actualizarEquipo != null) this.actualizarEquipo.Close();

        }


        private void txtBusquedaEquipo_TextChanged(object sender, EventArgs e) // EVENTO PARA FILTRAR POR NOMBRE DEL EQUIPO
        {

            try
            {

                string filtroEquipo = this.txtBusquedaEquipo.Text.ToLower();

                if (filtroEquipo.Length > 0)
                {

                    var equiposFiltrados = this.Equipos.Where(e => e.nombre.ToLower().Contains(filtroEquipo)).ToList();

                    this.dgwDatos.DataSource = equiposFiltrados;

                    this.lblNumTotalEquipos.Text = equiposFiltrados.Count.ToString();

                }
                else
                {

                    this.dgwDatos.DataSource = this.Equipos;

                    this.lblNumTotalEquipos.Text = this.Equipos.Count.ToString();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL FILTRAR LOS DATOS", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private async void btnRecargar_Click(object sender, EventArgs e) // EVENTO PARA RECARGAR LOS DATOS
        {
            this.txtBusquedaEquipo.Text = "";

            await CargarDatos();
        }


        private async void btnVerEquipo_Click(object sender, EventArgs e) // EVENTO PARA VER LOS DATOS DE UN EQUIPO
        {

            try
            {

                if (this.dgwDatos.SelectedRows.Count > 0)
                {

                    DataGridViewRow filaSeleccionada = this.dgwDatos.SelectedRows[0];

                    int idEquipo = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                    if (this.verEquipo == null || this.verEquipo.IsDisposed)
                    {

                        var controladorEquipo = Program.ServiceProvider.GetRequiredService<EquipoController>();
                        var controladorJugador = Program.ServiceProvider.GetRequiredService<JugadorController>();

                        this.verEquipo = new VerEquipo_V(controladorEquipo, controladorJugador, this);
                        this.verEquipo.idEquipo = idEquipo;
                        this.verEquipo.Show();

                    }
                    else
                    {

                        this.verEquipo.idEquipo = idEquipo;
                        this.verEquipo.Show();
                        this.verEquipo.Focus();
                        await this.verEquipo.CargarDatos();

                    }

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL MOSTRAR LA VENTANA DE VER JUGADOR", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnAgregarEquipo_Click(object sender, EventArgs e) // EVENTO PARA AGREGAR UN EQUIPO
        {

            try
            {

                if (this.agregarEquipo == null || this.agregarEquipo.IsDisposed)
                {

                    var controladorEquipo = Program.ServiceProvider.GetRequiredService<EquipoController>();
                    this.agregarEquipo = new AgregarEquipo_V(controladorEquipo, this);
                    this.agregarEquipo.Show();

                }
                else
                {

                    this.agregarEquipo.Show();
                    this.agregarEquipo.Focus();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL MOSTRAR LA VENTANA DE AGREGAR EQUIPO", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnActualizarEquipo_Click(object sender, EventArgs e) // EVENTO PARA ACTUALIZAR A UN EQUIPO
        {

            try
            {

                if (this.dgwDatos.SelectedRows.Count > 0)
                {

                    DataGridViewRow filaSeleccionada = this.dgwDatos.SelectedRows[0];

                    int idEquipo = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                    if (this.actualizarEquipo == null || this.actualizarEquipo.IsDisposed)
                    {

                        var controladorEquipo = Program.ServiceProvider.GetRequiredService<EquipoController>();
                        this.actualizarEquipo = new ActualizarEquipo_V(controladorEquipo, this);
                        this.actualizarEquipo.idEquipo = idEquipo;
                        this.actualizarEquipo.Show();

                    }
                    else
                    {

                        this.actualizarEquipo.idEquipo = idEquipo;
                        this.actualizarEquipo.Show();
                        this.actualizarEquipo.Focus();
                        await this.actualizarEquipo.CargarDatos();

                    }

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL MOSTRAR LA VENTANA DE ACTUALIZAR DE EQUIPO", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnEliminarEquipo_Click(object sender, EventArgs e) // EVENTO PARA ELIMINAR UN EQUIPO
        {

            try
            {

                if (this.dgwDatos.SelectedRows.Count > 0)
                {

                    DialogResult alerta = MessageBox.Show("¿Estás seguro de que quieres eliminar este Equipo?", "ELIMINAR EQUIPO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (alerta == DialogResult.OK)
                    {

                        DataGridViewRow filaSeleccionada = this.dgwDatos.SelectedRows[0];

                        int idEquipo = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
                        int indiceFila = filaSeleccionada.Index;

                        var eliminado = await this._controladorEquipo.EliminarEquipo_C(idEquipo);

                        if (eliminado)
                        {

                            this.Equipos.RemoveAt(indiceFila);

                            this.lblNumTotalEquipos.Text = this.Equipos.Count.ToString();

                            if (this.verEquipo != null && this.verEquipo.idEquipo == idEquipo) this.verEquipo.Close();

                            else if (this.verEquipo != null) await this.verEquipo.CargarDatos();

                            if (this.actualizarEquipo != null && this.actualizarEquipo.idEquipo == idEquipo) this.actualizarEquipo.Close();

                        }

                    }

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ELIMINAR EL EQUIPO", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS DATOS DE LOS EQUIPOS
        {

            try
            {

                this.dgwDatos.AutoGenerateColumns = false;

                var equiposObtenidos = await this._controladorEquipo.ObtenerEquipos_C();

                this.Equipos = new BindingList<Equipo>(equiposObtenidos);

                this.lblNumTotalEquipos.Text = this.Equipos.Count.ToString();

                this.dgwDatos.DataSource = this.Equipos;

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS DE LOS EQUIPOS EN LA VENTANA", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public async Task ActualizarDatosVentanas(Equipo equipoActualizado) // METODO PARA ACTUALIZAR LOS DATOS DE LAS DISTINTAS VENTANAS DESPUES DE UNA ACTUALIZACION O INSERCCION DE UN EQUIPO
        {

            try
            {

                var equipo = this.Equipos.FirstOrDefault(e => e.id == equipoActualizado.id);

                if (equipo != null)
                {
                    equipo.nombre = equipoActualizado.nombre;
                    equipo.liga = equipoActualizado.liga;

                    if (equipoActualizado.jugadores != null) equipo.jugadores = equipoActualizado.jugadores;

                    if (this.verEquipo != null && this.verEquipo.idEquipo == equipoActualizado.id) await this.verEquipo.CargarDatos();
                }
                else if (equipoActualizado.id != -1)
                {
                    this.Equipos.Add(equipoActualizado);
                    this.lblNumTotalEquipos.Text = this.Equipos.Count.ToString();

                }

                this.dgwDatos.Refresh();

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ACTUALIZAR LOS DATOS DE LAS VENTANAS", "MENU EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }


}

