using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Outreach.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "IndexHtml",
                    url: "index.html",
                    defaults: new { controller = "Home", action = "Index" }
                );
            routes.MapRoute(
                    name: "AboutHtml",
                    url: "fireproof-movie.html",
                    defaults: new { controller = "Home", action = "About" }
                );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}