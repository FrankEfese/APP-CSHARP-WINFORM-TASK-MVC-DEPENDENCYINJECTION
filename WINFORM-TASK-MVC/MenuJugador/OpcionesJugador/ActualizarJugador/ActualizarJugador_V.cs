using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Tools;


namespace Winform_Task_Mvc.MenuJugador.OpcionesJugador.ActualizarJugador
{
    public partial class ActualizarJugador_V : Form
    {

        // VARIABLE ID-JUGADOR

        public int idJugador = -1;


        // VARIABLE MENU JUGADOR

        private MenuJugador_V menuJugador { get; set; }


        // INYECCION DE DEPENDENCIA

        private readonly JugadorController _controladorJugador;


        public ActualizarJugador_V(JugadorController controladorJugador, MenuJugador_V menuJugador) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorJugador = controladorJugador;

            this.menuJugador = menuJugador;
        }



        // EVENTOS

        private async void ActualizarJugador_V_Load(object sender, EventArgs e) // EVENTO PARA MOSTRAR LOS DATOS DEL JUGADOR DE INICIO
        {
            await CargarDatos();
        }


        private async void btnActualizarJugador_Click(object sender, EventArgs e) // EVENTO PARA ACTUALIZAR LOS DATOS DEL JUGADOR
        {

            try
            {

                if(Validaciones.ValidarJugador(this.txtNombre.Text, (int)this.spnEdad.Value, this.txtNacionalidad.Text, (int)this.spnAltura.Value, (int)this.spnPeso.Value))
                {

                    Jugador jugadorActualizado = new Jugador();
                    jugadorActualizado.id = this.idJugador;
                    jugadorActualizado.nombre = this.txtNombre.Text;
                    jugadorActualizado.edad = (int)this.spnEdad.Value;
                    jugadorActualizado.nacionalidad = this.txtNacionalidad.Text;
                    jugadorActualizado.altura = (int)this.spnAltura.Value;
                    jugadorActualizado.peso = (int)this.spnPeso.Value;

                    var actualizado = await this._controladorJugador.ActualizarJugador_C(jugadorActualizado);

                    if(actualizado) await this.menuJugador.ActualizarDatosVentanas(jugadorActualizado);

                    this.Close();

                }
                else MessageBox.Show("DATOS INTRODUCIDOS DE FORMA INCORRECTA", "ACTUALIZAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ACTUALIZAR LOS DATOS DEL JUGADOR", "ACTUALIZAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS DATOS DEL JUGADOR
        {

            try
            {

                var jugador = await this._controladorJugador.ObtenerUnJugador_C(this.idJugador);

                if(jugador != null)
                {

                    this.txtNombre.Text = jugador.nombre;
                    this.spnEdad.Value = jugador.edad;
                    this.txtNacionalidad.Text = jugador.nacionalidad;
                    this.spnAltura.Value = jugador.altura;
                    this.spnPeso.Value = jugador.peso;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS DEL JUGADOR", "ACTUALIZAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
