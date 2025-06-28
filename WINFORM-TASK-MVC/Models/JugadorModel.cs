using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Config;
using Winform_Task_Mvc.Tools;
using Newtonsoft.Json;
using System.Net;
using System.Text;


namespace Winform_Task_Mvc.Models
{
    public class JugadorModel
    {

        static readonly HttpClient client = new HttpClient(); // VARIABLE ESTATICA PARA REALIZAR PETICIONES A LA API


        // METODOS


        public async Task<int> AgregarJugador_M(Jugador jugador) // METODO PARA AGREGAR UN JUGADOR (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                var json = JsonConvert.SerializeObject(jugador);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.PostAsync("https://localhost:7232/api/Jugador/post", data);

                if (response.IsSuccessStatusCode)
                {
                    int idJugador =  int.Parse(await response.Content.ReadAsStringAsync());
                    MessageBox.Show("JUGADOR AGREGADO DE FORMA EXITOSA", "AGREGAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return idJugador;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - YA EXISTE UN JUGADOR CON EL NOMBRE INTRODUCIDO", 
                                    "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }



        public async Task<bool> ActualizarJugador_M(Jugador jugador) // METODO PARA ACTUALIZAR UN JUGADOR (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                var json = JsonConvert.SerializeObject(jugador);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.PutAsync($"https://localhost:7232/api/Jugador/put/{jugador.id}", data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("JUGADOR ACTUALIZADO DE FORMA EXITOSA", "ACTUALIZAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if (response.StatusCode == HttpStatusCode.Conflict)
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - YA EXISTE UN JUGADOR CON EL NOMBRE INTRODUCIDO",
                                    "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE JUGADOR INCORRECTO",
                                    "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        public async Task<bool> InscribirJugador_M(int idJugador , int idEquipo) // METODO PARA INSCRIBIR UN JUGADOR PARADO A UN EQUIPO (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                var json = JsonConvert.SerializeObject(idEquipo);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.PutAsync($"https://localhost:7232/api/Jugador/put/signing/{idJugador}", data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("JUGADOR INSCRITO DE FORMA EXITOSA", "INSCRIBIR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE JUGADOR INCORRECTO",
                                    "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        public async Task<bool> DespedirJugador_M(int idJugador , int idEquipo) // METODO PARA DESPEDIR UN JUGADOR DE UN EQUIPO (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                var json = JsonConvert.SerializeObject(idEquipo);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.PutAsync($"https://localhost:7232/api/Jugador/put/termination/{idJugador}", data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("JUGADOR DESPEDIDO DE FORMA EXITOSA", "DESPEDIR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE JUGADOR INCORRECTO", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        public async Task<bool> EliminarJugador_M(int idJugador) // METODO PARA ELIMINAR UN JUGADOR (MODELO)
        {

            try
            {

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7232/api/Jugador/{idJugador}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("JUGADOR ELIMINADO DE FORMA EXITOSA", "ELIMINAR JUGADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE JUGADOR INCORRECTO", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        public async Task<List<Jugador>> ObtenerJugadores_M() // METODO PARA OBTENER TODOS LOS JUGADORES (MODELO)
        {

            try
            {
                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7232/api/Jugador");

                if (response.IsSuccessStatusCode)
                {

                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jugadores = JsonConvert.DeserializeObject<List<Jugador>>(responseBody);
                    return jugadores;

                }
                else
                {
                    return new List<Jugador>();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Jugador>();
            }

        }



        public async Task<List<Jugador>> ObtenerJugadoresParados_M() // METODO PARA OBTENER TODOS LOS JUGADORES PARADOS (MODELO)
        {

            try
            {
                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7232/api/Jugador/terminates");

                if (response.IsSuccessStatusCode)
                {

                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jugadores = JsonConvert.DeserializeObject<List<Jugador>>(responseBody);
                    return jugadores;

                }
                else
                {
                    return new List<Jugador>();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Jugador>();
            }

        }



        public async Task<Jugador> ObtenerUnJugador_M(int idJugador) // METODO PARA OBTNER UN JUGADOR (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync($"https://localhost:7232/api/Jugador/{idJugador}");

                if (response.IsSuccessStatusCode)
                {

                    var responseBody = await response.Content.ReadAsStringAsync();
                    var jugador = JsonConvert.DeserializeObject<Jugador>(responseBody);
                    return jugador;

                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE JUGADOR INCORRECTO", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }



        public async Task<int> ObtenerTotal_M() // METODO PARA OBTENER EL TOTAL DE JUGADORES (MODELO)
        {

            try
            {
                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7232/api/Jugador/count");

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var total = JsonConvert.DeserializeObject<int>(responseBody);
                    return total;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }



        public async Task<int> ObtenerTotalParados_M() // METODO PARA OBTENER EL TOTAL DE JUGADORES PARADOS (MODELO)
        {

            try
            {
                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7232/api/Jugador/countTerminates");

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var total = JsonConvert.DeserializeObject<int>(responseBody);
                    return total;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

    }
}
