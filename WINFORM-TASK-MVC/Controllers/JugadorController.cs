using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Models;


namespace Winform_Task_Mvc.Controllers
{
    public class JugadorController
    {

        // INYECCION DE DEPENDENCIA

        private readonly JugadorModel _modeloJugador;

        public JugadorController(JugadorModel modeloJugador) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            this._modeloJugador = modeloJugador;
        }


        // METODOS


        public async Task<int> AgregarJugador_C(Jugador jugador) // METODO PARA AGREGAR UN JUGADOR (CONTROLADOR)
        {
            return await this._modeloJugador.AgregarJugador_M(jugador);
        }


        public async Task<bool> ActualizarJugador_C(Jugador jugador) // METODO PARA ACTUALIZAR UN JUGADOR (CONTROLADOR)
        {
            return await this._modeloJugador.ActualizarJugador_M(jugador);
        }


        public async Task<bool> InscribirJugador_C(int idJugador , int idEquipo) // METODO PARA INSCRIBIR UN JUGADOR PARADO A UN EQUIPO (CONTROLADOR)
        {
            return await this._modeloJugador.InscribirJugador_M(idJugador, idEquipo);
        }


        public async Task<bool> DespedirJugador_C(int idJugador, int idEquipo) // METODO PARA DESPEDIR UN JUGADOR DE UN EQUIPO (CONTROLADOR)
        {
            return await this._modeloJugador.DespedirJugador_M(idJugador, idEquipo);
        }


        public async Task<bool> EliminarJugador_C(int idJugador) // METODO PARA ELIMINAR UN JUGADOR (CONTROLADOR)
        {
            return await this._modeloJugador.EliminarJugador_M(idJugador);
        }


        public async Task<List<Jugador>> ObtenerJugadores_C() // METODO PARA OBTENER TODOS LOS JUGADORES (CONTROLADOR)
        {
            return await this._modeloJugador.ObtenerJugadores_M();
        }


        public async Task<List<Jugador>> ObtenerJugadoresParados_C() // METODO PARA OBTENER TODOS LOS JUGADORES PARADOS (CONTROLADOR)
        {
            return await this._modeloJugador.ObtenerJugadoresParados_M();
        }


        public async Task<Jugador> ObtenerUnJugador_C(int idJugador) // METODO PARA OBTNER UN JUGADOR (CONTROLADOR)
        {
            return await this._modeloJugador.ObtenerUnJugador_M(idJugador);
        }


        public async Task<int> ObtenerTotal_C() // METODO PARA OBTENER EL TOTAL DE JUGADORES (CONTROLADOR)
        {
            return await this._modeloJugador.ObtenerTotal_M();
        }


        public async Task<int> ObtenerTotalParados_C() // METODO PARA OBTENER EL TOTAL DE JUGADORES PARADOS (CONTROLADOR)
        {
            return await this._modeloJugador.ObtenerTotalParados_M();
        }

    }
}
