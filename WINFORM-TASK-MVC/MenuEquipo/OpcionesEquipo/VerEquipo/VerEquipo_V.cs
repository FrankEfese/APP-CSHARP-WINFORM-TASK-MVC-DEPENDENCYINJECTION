using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.Objects;
using System.ComponentModel;


namespace Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.VerEquipo
{
    public partial class VerEquipo_V : Form, INotifyPropertyChanged
    {

        // VARIABLE ID-EQUIPO

        public int idEquipo = -1;


        // VARIABLE MENU JUGADOR

        private MenuEquipo_V menuEquipo { get; set; }


        // INYECCION DE DEPENDENCIA

        private readonly EquipoController _controladorEquipo;
        private readonly JugadorController _controladorJugador;


        public VerEquipo_V(EquipoController controladorEquipo, JugadorController controladorJugador , MenuEquipo_V menuEquipo) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorEquipo = controladorEquipo;
            this._controladorJugador = controladorJugador;

            this.menuEquipo = menuEquipo;
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


        // VARIABLES DATABINDING

        private BindingList<Jugador> _jugadoresParados = new BindingList<Jugador>();
        public BindingList<Jugador> JugadoresParados
        {
            get => _jugadoresParados;
            set
            {
                if (_jugadoresParados != value)
                {
                    _jugadoresParados = value;
                    OnPropertyChanged(nameof(JugadoresParados));
                }
            }
        }


        // EVENTOS

        private async void VerEquipo_V_Load(object sender, EventArgs e) // EVENTO PARA MOSTRAR LOS DATOS DEL EQUIPO Y LOS JUGADORES DE INICIO
        {
            await CargarDatos();
        }


        private async void btnDespedirJugador_Click(object sender, EventArgs e) // EVENTO PARA DESPEDIR A UN JUGADOR DE LA PLANTILLA
        {

            try
            {

                if (this.dgwDatosPlantilla.SelectedRows.Count > 0)
                {

                    DialogResult alerta = MessageBox.Show("¿Estás seguro de que quieres despedir a este Jugador?", "DESPEDIR JUGADOR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (alerta == DialogResult.OK)
                    {

                        DataGridViewRow filaSeleccionada = this.dgwDatosPlantilla.SelectedRows[0];

                        int idJugador = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                        var despedido = await this._controladorJugador.DespedirJugador_C(idJugador, this.idEquipo);

                        if (despedido)
                        {

                            var jugador = this.Jugadores.FirstOrDefault(j => j.id == idJugador);

                            if (jugador != null)
                            {
                                this.Jugadores.Remove(jugador);

                                this.JugadoresParados.Add(jugador);
                            }

                            this.dgwDatosPlantilla.Refresh();

                            this.dgwDatosParados.Refresh();

                            this.lblJugadoresEquipo.Text = this.Jugadores.Count.ToString();

                            this.lblNumTotalJugadoresParados.Text = this.JugadoresParados.Count.ToString();

                            var equipo = await this._controladorEquipo.ObtenerUnEquipo_C(this.idEquipo);

                            if (equipo != null) await this.menuEquipo.ActualizarDatosVentanas(equipo);

                        }

                    }
                                        
                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "VER EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL DESPEDIR A UN JUGADOR DE LA PLANTILLA", "VER EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private async void btnFicharJugador_Click(object sender, EventArgs e) // EVENTO PARA INSCRIBIR A UN JUGADOR PARADO A LA PLANTILLA
        {

            try
            {

                if (this.dgwDatosParados.SelectedRows.Count > 0)
                {

                    DialogResult alerta = MessageBox.Show("¿Estás seguro de que quieres inscribir a este Jugador?", "FICHAR JUGADOR", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (alerta == DialogResult.OK)
                    {

                        DataGridViewRow filaSeleccionada = this.dgwDatosParados.SelectedRows[0];

                        int idJugador = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                        var fichado = await this._controladorJugador.InscribirJugador_C(idJugador, this.idEquipo);

                        if (fichado)
                        {

                            var jugador = this.JugadoresParados.FirstOrDefault(j => j.id == idJugador);

                            if (jugador != null)
                            {
                                this.Jugadores.Add(jugador);

                                this.JugadoresParados.Remove(jugador);
                            }

                            this.dgwDatosPlantilla.Refresh();

                            this.dgwDatosParados.Refresh();

                            this.lblJugadoresEquipo.Text = this.Jugadores.Count.ToString();

                            this.lblNumTotalJugadoresParados.Text = this.JugadoresParados.Count.ToString();

                            var equipo = await this._controladorEquipo.ObtenerUnEquipo_C(this.idEquipo);

                            if (equipo != null) await this.menuEquipo.ActualizarDatosVentanas(equipo);

                        }
                       
                    }                                     

                }
                else MessageBox.Show("DEBES SELECCIONAR UNA FILA", "VER EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL INSCRIBIR A UN JUGADOR A LA PLANTILLA", "VER EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS DATOS DEL EQUIPO Y LOS JUGADORES
        {

            try
            {
                var equipo = await this._controladorEquipo.ObtenerUnEquipo_C(this.idEquipo);

                if(equipo != null)
                {

                    this.lblNombreEquipo.Text = equipo.nombre;

                    this.lblLigaEquipo.Text = equipo.liga;

                    this.lblJugadoresEquipo.Text = equipo.totalJugadores.ToString();

                    if (equipo.jugadores != null)
                    {

                        this.dgwDatosPlantilla.AutoGenerateColumns = false;

                        this.Jugadores = new BindingList<Jugador>(equipo.jugadores);

                        this.dgwDatosPlantilla.DataSource = this.Jugadores;

                    }

                }

                var jugadoresParados = await this._controladorJugador.ObtenerJugadoresParados_C();

                if (jugadoresParados != null)
                {

                    this.dgwDatosParados.AutoGenerateColumns = false;

                    this.JugadoresParados = new BindingList<Jugador>(jugadoresParados);

                    this.dgwDatosParados.DataSource = this.JugadoresParados;

                    this.lblNumTotalJugadoresParados.Text = jugadoresParados.Count().ToString();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS DEL EQUIPO Y LOS JUGADORES EN LA VENTANA", "VER EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
