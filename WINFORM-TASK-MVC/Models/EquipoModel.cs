using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Config;
using Winform_Task_Mvc.Tools;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Winform_Task_Mvc.Models
{
    public class EquipoModel
    {

        static readonly HttpClient client = new HttpClient(); // VARIABLE ESTATICA PARA REALIZAR PETICIONES A LA API


        // METODOS

        public async Task<int> AgregarEquipo_M(Equipo equipo) // METODO PARA AGREGAR UN EQUIPO (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                var json = JsonConvert.SerializeObject(equipo);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.PostAsync("https://localhost:7232/api/Equipo/post", data);

                if (response.IsSuccessStatusCode)
                {
                    int idEquipo = int.Parse(await response.Content.ReadAsStringAsync());
                    MessageBox.Show("EQUIPO AGREGADO DE FORMA EXITOSA", "AGREGAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return idEquipo;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - YA EXISTE UN EQUIPO CON EL NOMBRE INTRODUCIDO",
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



        public async Task<bool> ActualizarEquipo_M(Equipo equipo) // METODO PARA ACTUALIZAR UN EQUIPO (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                var json = JsonConvert.SerializeObject(equipo);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.PutAsync($"https://localhost:7232/api/Equipo/put/{equipo.id}", data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("EQUIPO ACTUALIZADO DE FORMA EXITOSA", "ACTUALIZAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if(response.StatusCode == HttpStatusCode.Conflict)
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - YA EXISTE UN EQUIPO CON EL NOMBRE INTRODUCIDO",
                                    "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE EQUIPO INCORRECTO",
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



        public async Task<bool> EliminarEquipo_M(int idEquipo) // METODO PARA ELIMINAR UN EQUIPO (MODELO)
        {

            try
            {

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7232/api/Equipo/{idEquipo}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("EQUIPO ELIMINADO DE FORMA EXITOSA", "ELIMINAR EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE EQUIPO INCORRECTO", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }



        public async Task<List<Equipo>> ObtenerEquipos_M() // METODO PARA OBTENER TODOS LOS EQUIPOS (MODELO)
        {

            try
            {
                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7232/api/Equipo");

                if (response.IsSuccessStatusCode)
                {

                    var responseBody = await response.Content.ReadAsStringAsync();
                    var equipos = JsonConvert.DeserializeObject<List<Equipo>>(responseBody);
                    return equipos;
                    
                }
                else
                {
                    return new List<Equipo>();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Equipo>();
            }

        }



        public async Task<Equipo> ObtenerUnEquipo_M(int idEquipo) // METODO PARA OBTNER UN EQUIPO (MODELO)
        {

            try
            {

                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync($"https://localhost:7232/api/Equipo/{idEquipo}");

                if (response.IsSuccessStatusCode)
                {

                    var responseBody = await response.Content.ReadAsStringAsync();
                    var equipo = JsonConvert.DeserializeObject<Equipo>(responseBody);
                    return equipo;

                }
                else
                {
                    MessageBox.Show($"({response.StatusCode.ToString().ToUpper()}) - ID DE EQUIPO INCORRECTO", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CONSULTAR CON EL SERVIDOR", "ERROR DE SERVIDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }



        public async Task<int> ObtenerTotal_M() // METODO PARA OBTENER EL TOTAL DE EQUIPOS (MODELO)
        {

            try
            {
                await Utils.ActualizarToken();

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppConfig.jwtToken);
                HttpResponseMessage response = await client.GetAsync("https://localhost:7232/api/Equipo/count");

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
