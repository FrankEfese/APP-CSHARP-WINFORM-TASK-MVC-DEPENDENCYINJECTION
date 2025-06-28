using Newtonsoft.Json;
using System.Text;
using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Config;

namespace Winform_Task_Mvc.Tools
{
    public class Utils
    {

        static readonly HttpClient client = new HttpClient(); // VARIABLE ESTATICA PARA REALIZAR PETICIONES A LA API


        // METODOS

        public static async Task<bool> AutenticarYObtenerToken(UserCredentials usuario) // METODO PARA OBTENER EL JWT
        {

            try
            {

                var json = JsonConvert.SerializeObject(usuario);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://localhost:7232/api/Auth/authenticate", data);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonConvert.DeserializeObject<dynamic>(result);
                    AppConfig.jwtToken = tokenResponse.token;
                    return true;
                }

                return false;

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR" , "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        public static async Task ActualizarToken() // METODO PARA ACTUALIZAR EL JWT
        {

            try
            {

                var json = JsonConvert.SerializeObject(AppConfig.user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://localhost:7232/api/Auth/authenticate", data);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonConvert.DeserializeObject<dynamic>(result);
                    AppConfig.jwtToken = tokenResponse.token;
                }
                else MessageBox.Show("ERROR AL ACTUALIZAR EL TOKEN", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
