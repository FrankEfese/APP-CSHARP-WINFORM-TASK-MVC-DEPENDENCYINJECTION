using Winform_Task_Mvc.Controllers;


namespace Winform_Task_Mvc.MenuInicio
{
    public partial class MenuInicio_V : Form
    {

        // INYECCION DE DEPENDENCIAS

        private readonly EquipoController _controladorEquipo;
        private readonly JugadorController _controladorJugador;


        public MenuInicio_V(EquipoController controladorEquipo, JugadorController controladorJugador) // CONSTRUCTOR CON LAS DEPENDENCIAS
        {
            InitializeComponent();

            this._controladorEquipo = controladorEquipo;
            this._controladorJugador = controladorJugador;
        }


        // EVENTOS

        private async void MenuInicio_V_Load(object sender, EventArgs e) // EVENTO CARGAR LOS DATOS DE INICIO
        {
            await CargarDatos();
        }



        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS TODOS LOS DATOS
        {

            try
            {
                var totalEquipos = await this._controladorEquipo.ObtenerTotal_C();
                var totalJugadores = await this._controladorJugador.ObtenerTotal_C();
                var totalJugadoresParados = await this._controladorJugador.ObtenerTotalParados_C();

                this.lblNumTotalEquipos.Text = totalEquipos.ToString();
                this.lblNumTotalJugadores.Text = totalJugadores.ToString();
                this.lblNumTotalJugadoresParados.Text = totalJugadoresParados.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS EN LA VENTANA", "MENU INICIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
