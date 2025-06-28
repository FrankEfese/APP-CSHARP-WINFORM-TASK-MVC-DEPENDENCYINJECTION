using Winform_Task_Mvc.Config;
using Winform_Task_Mvc.MenuPrincipal;


namespace Winform_Task_Mvc.Login
{
    public partial class Login_V : Form
    {

        public Login_V()
        {
            InitializeComponent();
        }


        // EVENTOS

        private async void btnInicio_Click(object sender, EventArgs e) // EVENTO PARA INICIAR SESION
        {

            try
            {

                string correoUsuario = txtCorreo.Text;
                string passUsuario = txtContraseña.Text;

                if (await AppConfig.InicioSesion(correoUsuario, passUsuario))
                {

                    MessageBox.Show("CREDENCIALES CORRECTAS", "INICIO DE SESION CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MenuPrincipal_V menuPrincipal = new MenuPrincipal_V();
                    menuPrincipal.FormClosed += (s, args) => this.Show();
                    this.Hide();
                    menuPrincipal.Show();

                }
                else MessageBox.Show("CREDENCIALES INCORRECTAS", "INICIO DE SESION INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("HAS INTRODUCIDO UN DATO ERRONEO", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
