using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.MenuEquipo;
using Winform_Task_Mvc.MenuInicio;
using Winform_Task_Mvc.MenuJugador;
using Microsoft.Extensions.DependencyInjection;


namespace Winform_Task_Mvc.MenuPrincipal
{
    public partial class MenuPrincipal_V : Form
    {

        // VARIABLES MENUS

        public MenuEquipo_V menuEquipo = null;

        public MenuJugador_V menuJugador = null;


        public MenuPrincipal_V()
        {
            InitializeComponent();
        }


        // EVENTOS

        private void MenuPrincipal_V_Load(object sender, EventArgs e) // EVENTO QUE CARGA EL MENU INICIO CUANDO SE CREA LA VENTANA PRINCIPAL
        {
            CargarMenuInicio();
        }


        private void MenuPrincipal_V_FormClosed(object sender, FormClosedEventArgs e) // EVENTO QUE CIERRA LAS VENTANAS DEL MENU DEL JUGADOR Y EQUIPO
        {
            if(this.menuEquipo != null ) this.menuEquipo.Close();
            
            if (this.menuJugador != null) this.menuJugador.Close();
        }


        private void btnInicio_Click(object sender, EventArgs e) // EVENTO PARA ENTRAR EN EL MENU INICIO
        {
            CargarMenuInicio();
        }


        private void btnEquipos_Click(object sender, EventArgs e) // EVENTO PARA ENTRAR EN EL MENU EQUIPO
        {
            CargarMenuEquipo();
        }


        private void btnJugadores_Click(object sender, EventArgs e) // EVENTO PARA ENTRAR EN EL MENU JUGADOR
        {
            CargarMenuJugador();
        }


        private void btnSalir_Click(object sender, EventArgs e) // EVENTO PARA SALIR DEL MENU PRINCIPAL
        {
            this.Close();
        }



        // METODOS


        public void CargarMenuInicio() // METODO PARA CARGAR EN EL CONTENER EL MENU INICIO
        {

            try
            {

                if (this.menuEquipo != null) this.menuEquipo.Close();

                if (this.menuJugador != null) this.menuJugador.Close();

                var controladorEquipo = Program.ServiceProvider.GetRequiredService<EquipoController>();
                var controladorJugador = Program.ServiceProvider.GetRequiredService<JugadorController>();

                this.pnlContenedor.Controls.Clear();

                MenuInicio_V menuInicio = new MenuInicio_V(controladorEquipo, controladorJugador);
                menuInicio.TopLevel = false;
                menuInicio.FormBorderStyle = FormBorderStyle.None;
                menuInicio.Dock = DockStyle.Fill;

                this.pnlContenedor.Controls.Add(menuInicio);
                this.pnlContenedor.Tag = menuInicio;

                menuInicio.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ABRIR EL MENU INICIO", "MENU PRINCIPAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void CargarMenuEquipo() // METODO PARA CARGAR EN EL CONTENER EL MENU EQUIPO
        {

            try
            {                               

                this.pnlContenedor.Controls.Clear();

                if (this.menuJugador != null) this.menuJugador.Close();

                if (this.menuEquipo == null || this.menuEquipo.IsDisposed)
                {
                    var controladorEquipo = Program.ServiceProvider.GetRequiredService<EquipoController>();
                    this.menuEquipo = new MenuEquipo_V(controladorEquipo);
                }

                this.menuEquipo.TopLevel = false;
                this.menuEquipo.FormBorderStyle = FormBorderStyle.None;
                this.menuEquipo.Dock = DockStyle.Fill;

                this.pnlContenedor.Controls.Add(this.menuEquipo);
                this.pnlContenedor.Tag = this.menuEquipo;

                this.menuEquipo.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ABRIR EL MENU EQUIPO", "MENU PRINCIPAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void CargarMenuJugador() // METODO PARA CARGAR EN EL CONTENER EL MENU JUGADOR
        {

            try
            {

                this.pnlContenedor.Controls.Clear();

                if (this.menuEquipo != null) this.menuEquipo.Close();

                if (this.menuJugador == null || this.menuJugador.IsDisposed)
                {
                    var controladorJugador = Program.ServiceProvider.GetRequiredService<JugadorController>();
                    this.menuJugador = new MenuJugador_V(controladorJugador);
                }

                this.menuJugador.TopLevel = false;
                this.menuJugador.FormBorderStyle = FormBorderStyle.None;
                this.menuJugador.Dock = DockStyle.Fill;

                this.pnlContenedor.Controls.Add(this.menuJugador);
                this.pnlContenedor.Tag = this.menuJugador;

                this.menuJugador.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("SE HA PRODUCIDO UN ERROR AL ABRIR EL MENU JUGADOR", "MENU PRINCIPAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
