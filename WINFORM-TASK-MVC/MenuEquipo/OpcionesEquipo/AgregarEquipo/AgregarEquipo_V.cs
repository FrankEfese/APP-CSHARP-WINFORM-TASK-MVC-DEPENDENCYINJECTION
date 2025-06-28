using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Tools;


namespace Winform_Task_Mvc.MenuEquipo.OpcionesEquipo.AgregarEquipo
{
    public partial class AgregarEquipo_V : Form
    {

        // VARIABLE MENU JUGADOR

        private MenuEquipo_V menuEquipo { get; set; }


        // INYECCION DE DEPENDENCIA

        private readonly EquipoController _controladorEquipo;


        public AgregarEquipo_V(EquipoController controladorEquipo, MenuEquipo_V menuEquipo) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            InitializeComponent();

            this._controladorEquipo = controladorEquipo;
            this.menuEquipo = menuEquipo;
        }


        // EVENTOS

        private async void btnAgregarEquipo_Click(object sender, EventArgs e) // EVENTO PARA AGREGAR UN EQUIPO
        {

            try
            {

                if (Validaciones.ValidarEquipo(this.txtNombre.Text , this.txtLiga.Text))
                {

                    Equipo equipoAgregado = new Equipo();
                    equipoAgregado.nombre = this.txtNombre.Text;
                    equipoAgregado.liga = this.txtLiga.Text;

                    int idEquipo = await this._controladorEquipo.AgregarEquipo_C(equipoAgregado);

                    equipoAgregado.id = idEquipo;

                    await this.menuEquipo.ActualizarDatosVentanas(equipoAgregado);

                    this.Close();

                }
                else MessageBox.Show("DATOS INTRODUCIDOS DE FORMA INCORRECTA", "AGREGAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL AGREGAR EL EQUIPO", "AGREGAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
