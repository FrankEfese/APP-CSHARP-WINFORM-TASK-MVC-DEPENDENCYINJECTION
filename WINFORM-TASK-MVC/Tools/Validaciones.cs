namespace Winform_Task_Mvc.Tools
{
    public class Validaciones
    {

        // METODOS

        public static bool ValidarEquipo(string nombreEquipo , string nombreLiga) // METODO PARA VALIDAR LOS DATOS DE UN EQUIPO
        {
            if(nombreEquipo.Length > 0 && nombreLiga.Length > 0) return true;
            else return false;
        }


        public static bool ValidarJugador(string nombreJugador, int edadJugador, string nacionalidadJugador, int alturaJugador, int pesoJugador) // METODO PARA VALIDAR LOS DATOS DE UN JUGADOR
        {
            if (nombreJugador.Length > 0 && nacionalidadJugador.Length > 0 && (edadJugador > 16 && edadJugador < 45) &&
                (alturaJugador > 100 && alturaJugador < 250) && (pesoJugador > 30 && pesoJugador < 180)) return true;
            else return false;
        }

    }
}
