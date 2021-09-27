/* Nos trae lo que hay en la carpeta Entity (ver Imports.razor) asi conectamos esa capa con el client */
/* System.Collection este para hacer uso de esa lista */
using Proypelis.Shared.Entity;
using System.Collections.Generic;

namespace Proypelis.Client.Services
{
    public interface IServiceMovie
    {
         /* creamos una propiedad que nos va a llamar un metodo qye va a ser GetMovie y nos va a devolver una lista  */
        /* esta es una lista de la interfaz */
        List<Movie> GetMovies();
    }
}
/* Esta interfaz nos puede hacer uso o conectar con una API(interfaz de Programacion de Aplicaciones ) */
/* Las interfaces son abstractas, NO implementan metodos ni funciones, para eso se necesita una clase */