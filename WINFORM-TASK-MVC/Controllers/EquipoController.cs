using Winform_Task_Mvc.Objects;
using Winform_Task_Mvc.Models;

namespace Winform_Task_Mvc.Controllers
{
    public class EquipoController
    {

        // INYECCION DE DEPENDENCIA

        private readonly EquipoModel _modeloEquipo;

        public EquipoController(EquipoModel modeloEquipo) // CONSTRUCTOR CON LA DEPENDENCIA
        {
            this._modeloEquipo = modeloEquipo;
        }


        // METODOS

        public async Task<int> AgregarEquipo_C(Equipo equipo) // METODO PARA AGREGAR UN EQUIPO (CONTROLADOR)
        {
            return await this._modeloEquipo.AgregarEquipo_M(equipo);
        }


        public async Task<bool> ActualizarEquipo_C(Equipo equipo) // METODO PARA ACTUALIZAR UN EQUIPO (CONTROLADOR)
        {
            return await this._modeloEquipo.ActualizarEquipo_M(equipo);
        }


        public async Task<bool> EliminarEquipo_C(int idEquipo) // METODO PARA ELIMINAR UN EQUIPO (CONTROLADOR)
        {
            return await this._modeloEquipo.EliminarEquipo_M(idEquipo);
        }


        public async Task<List<Equipo>> ObtenerEquipos_C() // METODO PARA OBTENER TODOS LOS EQUIPOS (CONTROLADOR)
        {
            return await this._modeloEquipo.ObtenerEquipos_M();
        }


        public async Task<Equipo> ObtenerUnEquipo_C(int idEquipo) // METODO PARA OBTNER UN EQUIPO (CONTROLADOR)
        {
            return await this._modeloEquipo.ObtenerUnEquipo_M(idEquipo);
        }


        public async Task<int> ObtenerTotal_C() // METODO PARA OBTENER EL TOTAL DE EQUIPOS (CONTROLADOR)
        {
            return await this._modeloEquipo.ObtenerTotal_M();
        }

    }
}
