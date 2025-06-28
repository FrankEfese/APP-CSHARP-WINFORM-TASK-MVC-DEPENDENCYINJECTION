using Winform_Task_Mvc.Controllers;


namespace Winform_Task_Mvc.MenuJugador.OpcionesJugador.VerJugador
{
    public partial class VerJugador_V : Form
    {

        // VARIABLE ID-JUGADOR

        public int idJugador = -1;


        // INYECCION DE DEPENDENCIA

        private readonly JugadorController _controladorJugador;


        public VerJugador_V(JugadorController controladorJugador) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorJugador = controladorJugador;
        }



        // EVENTOS

        private async void VerJugador_V_Load(object sender, EventArgs e) // EVENTO PARA MOSTRAR LOS DATOS DEL JUGADOR DE INICIO
        {
            await CargarDatos();
        }


        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS DATOS DEL JUGADOR
        {

            try
            {

                var jugador = await this._controladorJugador.ObtenerUnJugador_C(this.idJugador);

                if(jugador != null)
                {

                    this.lblNombreJugador.Text = jugador.nombre;
                    this.lblEdadJugador.Text = jugador.edad.ToString();
                    this.lblNacionalidadJugador.Text = jugador.nacionalidad;
                    this.lblAlturaJugador.Text = jugador.altura.ToString();
                    this.lblPesoJugador.Text = jugador.peso.ToString();
                    this.lblEquipoJugador.Text = jugador.nombreEquipo;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS DEL JUGADOR", "VER JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
