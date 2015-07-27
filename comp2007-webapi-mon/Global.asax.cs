using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//reference http 
using System.Web.Http;

namespace comp2007_webapi_mon
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //set our http routing
            comp2007_webapi_mon.App_Start.WebApiConfig.Register(GlobalConfiguration.Configuration);

            //remove xml as an output option in all browsers
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
