using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Tools;


namespace Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.ActualizarEquipo
{
    public partial class ActualizarEquipo_V : Form
    {

        // VARIABLE ID-EQUIPO

        public int idEquipo = -1;


        // VARIABLE MENU JUGADOR

        private MenuEquipo_V menuEquipo { get; set; }


        // INYECCION DE DEPENDENCIA

        private readonly EquipoController _controladorEquipo;


        public ActualizarEquipo_V(EquipoController controladorEquipo, MenuEquipo_V menuEquipo) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorEquipo = controladorEquipo;

            this.menuEquipo = menuEquipo;
        }


        // EVENTOS

        private async void ActualizarEquipo_V_Load(object sender, EventArgs e) // // EVENTO PARA MOSTRAR LOS DATOS DEL EQUIPO DE INICIO
        {
            await CargarDatos();
        }


        private async void btnActualizarEquipo_Click(object sender, EventArgs e) // EVENTO PARA ACTUALIZAR LOS DATOS DEL EQUIPO
        {

            try
            {

                if (Validaciones.ValidarEquipo(this.txtNombre.Text, this.txtLiga.Text))
                {

                    Equipo equipoActualizado = new Equipo();
                    equipoActualizado.id = this.idEquipo;
                    equipoActualizado.nombre = this.txtNombre.Text;
                    equipoActualizado.liga = this.txtLiga.Text;

                    var actualizado = await this._controladorEquipo.ActualizarEquipo_C(equipoActualizado);

                    if(actualizado) await this.menuEquipo.ActualizarDatosVentanas(equipoActualizado);

                    this.Close();

                }
                else MessageBox.Show("DATOS INTRODUCIDOS DE FORMA INCORRECTA", "ACTUALIZAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ACTUALIZAR LOS DATOS DEL EQUIPO", "ACTUALIZAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // METODOS

        public async Task CargarDatos() // METODO PARA CARGAR LOS DATOS DEL EQUIPO
        {

            try
            {

                var equipo = await this._controladorEquipo.ObtenerUnEquipo_C(this.idEquipo);

                if(equipo != null)
                {
                    this.txtNombre.Text = equipo.nombre;
                    this.txtLiga.Text = equipo.liga;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL CARGAR LOS DATOS DEL EQUIPO", "ACTUALIZAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
