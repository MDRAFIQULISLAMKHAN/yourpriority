using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using yourpriority.Controllers;

namespace yourpriority
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            /*routes.MapMvcAttributeRoutes();*/
  
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /*routes.MapRoute("Default", "{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
         





        }
    }
}
