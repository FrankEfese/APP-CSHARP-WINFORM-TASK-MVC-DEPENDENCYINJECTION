using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Tools;


namespace Winform_Task_Mvc.Config
{
    public class AppConfig
    {

        // VARIABLES ESTATICAS 

        public static string jwtToken = "";

        public static UserCredentials user = new UserCredentials();


        // METODOS

        public static async Task<bool> InicioSesion(string correoUsuario , string passUsuario) // METODO PARA EL INICIO DE SESION DEL USUARIO
        {

            user.usuario = correoUsuario;
            user.password = passUsuario;

            if(await Utils.AutenticarYObtenerToken(user)) return true;
            else return false;

        }

    }
}
