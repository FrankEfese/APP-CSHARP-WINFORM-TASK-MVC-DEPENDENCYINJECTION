using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Tools;


namespace Winform_Task_Mvc.MenuJugador.OpcionesJugador.AgregarJugador
{
    public partial class AgregarJugador_V : Form
    {

        // VARIABLE MENU JUGADOR

        private MenuJugador_V menuJugador { get; set; }


        // INYECCION DE DEPENDENCIA

        private readonly JugadorController _controladorJugador;


        public AgregarJugador_V(JugadorController controladorJugador, MenuJugador_V menuJugador) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorJugador = controladorJugador;

            this.menuJugador = menuJugador;
        }


        // EVENTOS

        private async void btnAgregarJugador_Click(object sender, EventArgs e) // EVENTO PARA AGREGAR A UN JUGADOR
        {

            try
            {

                if (Validaciones.ValidarJugador(this.txtNombre.Text, (int)this.spnEdad.Value, this.txtNacionalidad.Text, (int)this.spnAltura.Value, (int)this.spnPeso.Value))
                {

                    Jugador jugadorAgregado = new Jugador();
                    jugadorAgregado.nombre = this.txtNombre.Text;
                    jugadorAgregado.edad = (int)this.spnEdad.Value;
                    jugadorAgregado.nacionalidad = this.txtNacionalidad.Text;
                    jugadorAgregado.altura = (int)this.spnAltura.Value;
                    jugadorAgregado.peso = (int)this.spnPeso.Value;

                    int idJugador = await this._controladorJugador.AgregarJugador_C(jugadorAgregado);

                    jugadorAgregado.id = idJugador;

                    await this.menuJugador.ActualizarDatosVentanas(jugadorAgregado);

                    this.Close();

                }
                else MessageBox.Show("DATOS INTRODUCIDOS DE FORMA INCORRECTA", "AGREGAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL AGREGAR AL JUGADOR", "AGREGAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
