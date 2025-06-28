namespace Winform_Task_Mvc.Objects
{
    public class Jugador
    {

        // ATRIBUTOS

        public int id {  get; set; }

        public string nombre { get; set; }

        public int edad {  get; set; }

        public string nacionalidad { get; set; }

        public int altura { get; set; }

        public int peso { get; set; }

        // RELACION 1 A MUCHOS CON EQUIPO

        public int? idEquipo { get; set; }

        public Equipo? equipo { get; set; }


        // VARIABLE PARA OBTENER EL NOMBRE DEL EQUIPO
        public string? nombreEquipo
        {
            get
            {
                return equipo?.nombre ?? "*Sin Equipo*";
            }
        }


    }
}
