namespace Winform_Task_Mvc.Objects
{
    public class Equipo
    {

        // ATRIBUTOS

        public int id { get; set; }

        public string nombre { get; set; }

        public string liga {  get; set; }


        // RELACION 1 A MUCHOS CON JUGADOR
        public List<Jugador>? jugadores { get; set; }


        // VARIABLE PARA OBTENER EL TOTAL DE JUGADORES
        public int? totalJugadores
        {
            get
            {
                return jugadores?.Count ?? 0;
            }
        }

    }
}
