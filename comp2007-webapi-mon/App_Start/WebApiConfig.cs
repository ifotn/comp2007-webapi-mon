using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//reference the http library
using System.Web.Http;

namespace comp2007_webapi_mon.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "Courses",
                routeTemplate: "api/courses/{id}",
                defaults: new {controller = "courses", id = RouteParameter.Optional } );
        }
    }
}