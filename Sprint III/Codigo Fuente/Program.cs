using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProyPelis.Client.Services;

namespace ProyPelis.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }
        /* metodo que nos permite config urar el sistema de inyeccion de dependencias */
        private static void ConfigureServices(IServiceCollection services){
            services.AddSingleton<IServiceMovie,ServiceMovie>();
        }
    }
}
/* Configura el sistema de inyección de dependencias para configurar un servicio IServiceMovie con una interfaz  */
/* La interfaz no se puede instanciar, pero la clase si. */
/* ACA SE LE DICE: VAMOS A IMPLEMENTAR UN SERVICIO */