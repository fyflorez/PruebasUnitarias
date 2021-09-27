using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplicationNetCSharp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{id1}",
                defaults: new { id = RouteParameter.Optional, Id1 = RouteParameter.Optional }
            );
        }
    }
}
