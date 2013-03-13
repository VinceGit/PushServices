using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestGCM
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Device",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Device", action = "Index", regId = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Send",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Send", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}