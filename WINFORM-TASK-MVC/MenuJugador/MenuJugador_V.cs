using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.MenuJugador.OpcionesJugador.ActualizarJugador;
using Winform_Task_Mvc.MenuJugador.OpcionesJugador.AgregarJugador;
using Winform_Task_Mvc.MenuJugador.OpcionesJugador.VerJugador;
using Winform_Task_Mvc.Objects;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Data;


namespace Winform_Task_Mvc.MenuJugador
{
    public partial class MenuJugador_V : Form, INotifyPropertyChanged
    {


        // VARIABLES VENTANAS-OPCIONES

        public VerJugador_V verJugador = null;
        public AgregarJugador_V agregarJugador = null;
        public ActualizarJugador_V actualizarJugador = null;


        // INYECCION DE DEPENDENCIA

        private readonly JugadorController _controladorJugador;


        public MenuJugador_V(JugadorController controladorJugador) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorJugador = controladorJugador;
        }


        // IMPLEMENTACION DE INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        // VARIABLES DATABINDING

        private BindingList<Jugador> _jugadores = new BindingList<Jugador>();
        public BindingList<Jugador> Jugadores
        {
            get => _jugadores;
            set
            {
                if (_jugadores != value)
                {
                    _jugadores = value;
                    OnPropertyChanged(nameof(Jugadores));
                }
            }
        }


        // EVENTOS

        private async void MenuJugador_V_Load(object sender, EventArgs e) // EVENTO PARA CARGAR LOS DATOS DE INICIO Y VINCULAR EL DATABINDING
        {
            await CargarDatos();
        }


        private void MenuJugador_V_FormClosed(object sender, FormClosedEventArgs e) // EVENTO PARA CERRAR LAS VENTANAS DE OPCIONES
        {

            if (this.verJugador != null) this.verJugador.Close();

            if (this.agregarJugador != null) this.agregarJugador.Close();

            if (this.actualizarJugador != null) this.actualizarJugador.Close();

        }


        private void txtBusquedaJugador_TextChanged(object sender, EventArgs e) // EVENTO PARA FILTRAR POR NOMBRE DEL JUGADOR
        {

            try
            {

                string filtroJugador = this.txtBusquedaJugador.Text.ToLower();

                if (filtroJugador.Length > 0)
                {

                    var jugadoresFiltrados = this.Jugadores.Where(e => e.nombre.ToLower().Contains(filtroJugador)).ToList();

                    this.dgwDatos.DataSource = jugadoresFiltrados;

                    this.lblNumTotalJugadores.Text = jugadoresFiltrados.Count.ToString();

                }
                else
                {

                    this.dgwDatos.DataSource = this.Jugadores;

                    this.lblNumTotalJugadores.Text = this.Jugadores.Count.ToString();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL FILTRAR LOS DATOS", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnRecargar_Click(object sender, EventArgs e) // EVENTO PARA RECARGAR LOS DATOS
        {
            this.txtBusquedaJugador.Text = "";

            await CargarDatos();
        }


        private async void btnVerJugador_Click(object sender, EventArgs e) // EVENTO PARA VER LOS DATOS DE UN JUGADOR
        {

            try
            {

                if (this.dgwDatos.SelectedRows.Count > 0)
                {

                    DataGridViewRow filaSeleccionada = this.dgwDatos.SelectedRows[0];

                    int idJugador = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                    if (this.verJugador == null || this.verJugador.IsDisposed)
                    {

                        var controladorJugador = Program.ServiceProvider.GetRequiredService<JugadorController>();
                        this.verJugador = new VerJugador_V(controladorJugador);
                        this.verJugador.idJugador = idJugador;
                        this.verJugador.Show();

                    }
                    else
                    {

                        this.verJugador.idJugador = idJugador;
                        this.verJugador.Show();
                        this.verJugador.Focus();
                        await this.verJugador.CargarDatos();

                    }

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL MOSTRAR LA VENTANA DE VER JUGADOR", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnAgregarJugador_Click(object sender, EventArgs e) // EVENTO PARA AGREGAR A UN JUGADOR
        {

            try
            {

                if (this.agregarJugador == null || this.agregarJugador.IsDisposed)
                {

                    var controladorJugador = Program.ServiceProvider.GetRequiredService<JugadorController>();
                    this.agregarJugador = new AgregarJugador_V(controladorJugador, this);
                    this.agregarJugador.Show();

                }
                else
                {

                    this.agregarJugador.Show();
                    this.agregarJugador.Focus();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL MOSTRAR LA VENTANA DE AGREGAR JUGADOR", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnActualizarJugador_Click(object sender, EventArgs e) // EVENTO PARA ACTUALIZAR A UN JUGADOR
        {

            try
            {

                if (this.dgwDatos.SelectedRows.Count > 0)
                {

                    DataGridViewRow filaSeleccionada = this.dgwDatos.SelectedRows[0];

                    int idJugador = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                    if (this.actualizarJugador == null || this.actualizarJugador.IsDisposed)
                    {

                        var controladorJugador = Program.ServiceProvider.GetRequiredService<JugadorController>();
                        this.actualizarJugador = new ActualizarJugador_V(controladorJugador, this);
                        this.actualizarJugador.idJugador = idJugador;
                        this.actualizarJugador.Show();

                    }
                    else
                    {

                        this.actualizarJugador.idJugador = idJugador;
                        this.actualizarJugador.Show();
                        this.actualizarJugador.Focus();
                        await this.actualizarJugador.CargarDatos();

                    }

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL MOSTRAR LA VENTANA DE ACTUALIZAR DE JUGADOR", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnEliminarJugador_Click(object sender, EventArgs e) // EVENTO PARA ELIMINAR A UN JUGADOR
        {

            try
            {

                if (this.dgwDatos.SelectedRows.Count > 0)
                {

                    DialogResult alerta = MessageBox.Show("¿Estás seguro de que quieres eliminar al Jugador?", "ELIMINAR JUGADOR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (alerta == DialogResult.OK)
                    {

                        DataGridViewRow filaSeleccionada = this.dgwDatos.SelectedRows[0];

                        int idJugador = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                        int indiceFila = filaSeleccionada.Index;

                        var despedido = await this._controladorJugador.EliminarJugador_C(idJugador);

                        if (despedido)
                        {

                            this.Jugadores.RemoveAt(indiceFila);

                            this.lblNumTotalJugadores.Text = this.Jugadores.Count.ToString();

                            if (this.verJugador != null && this.verJugador.idJugador == idJugador) this.verJugador.Close();

                            if (this.actualizarJugador != null && this.actualizarJugador.idJugador == idJugador) this.actualizarJugador.Close();

                        }

                    }

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ELIMINAR AL JUGADOR", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS DATOS DE LOS JUGADORES
        {

            try
            {

                this.dgwDatos.AutoGenerateColumns = false;

                var jugadoresObtenidos = await this._controladorJugador.ObtenerJugadores_C();

                this.Jugadores = new BindingList<Jugador>(jugadoresObtenidos);

                this.lblNumTotalJugadores.Text = this.Jugadores.Count.ToString();

                this.dgwDatos.DataSource = this.Jugadores;

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS DE LOS JUGADORES EN LA VENTANA", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public async Task ActualizarDatosVentanas(Jugador jugadorActualizado) // METODO PARA ACTUALIZAR LOS DATOS DE LAS DISTINTAS VENTANAS DESPUES DE UNA ACTUALIZACION O INSERCCION DE UN JUGADOR
        {

            try
            {

                var jugador = this.Jugadores.FirstOrDefault(j => j.id == jugadorActualizado.id);

                if (jugador != null)
                {
                    jugador.nombre = jugadorActualizado.nombre;
                    jugador.edad = jugadorActualizado.edad;
                    jugador.nacionalidad = jugadorActualizado.nacionalidad;
                    jugador.altura = jugadorActualizado.altura;
                    jugador.peso = jugadorActualizado.peso;

                    if (this.verJugador != null && this.verJugador.idJugador == jugadorActualizado.id) await this.verJugador.CargarDatos();
                }
                else if (jugadorActualizado.id != -1)
                {
                    this.Jugadores.Add(jugadorActualizado);
                    this.lblNumTotalJugadores.Text = this.Jugadores.Count.ToString();

                } 

                this.dgwDatos.Refresh();

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ACTUALIZAR LOS DATOS DE LAS VENTANAS", "MENU JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
    }
}
