using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestFizzBuzzWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DirectOutput",
                url: "direct/{begin}/{end}",
                defaults:
                    new
                    {
                        controller = "Home",
                        action = "DirectOutput",
                        begin = UrlParameter.Optional,
                        end = UrlParameter.Optional
                    });

            routes.MapRoute(
                name: "Default",
                url: "{begin}/{end}",
                defaults: new { controller = "Home", action = "Index" , begin=UrlParameter.Optional, end = UrlParameter.Optional}
            );

        }
    }
}
