using Winform_Task_Mvc.Controllers;
using Winform_Task_Mvc.Login;
using Winform_Task_Mvc.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Winform_Task_Mvc
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider;

        [STAThread]
        static void Main()
        {

            // CONFIGURACION DEL CONTENEDOR DE DEPENDENCIAS

            var services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();


            // INICIO DE APLICACION CON LA VENTANA LOGIN

            ApplicationConfiguration.Initialize();
            Application.Run(new Login_V());

        }


        private static void ConfigureServices(IServiceCollection services) // METODO PARA INYECTAR LAS DEPENDENCIAS
        {
            services.AddSingleton<EquipoController>();
            services.AddSingleton<EquipoModel>();

            services.AddSingleton<JugadorController>();
            services.AddSingleton<JugadorModel>();
        }
    }
    
}