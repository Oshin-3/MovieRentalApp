using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieRentalApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //to enable Atrribute Routing
            routes.MapMvcAttributeRoutes();

            //custom route
            //routes.MapRoute(
            //    "MoviesByReleasedDate",
            //    "movies/released/{year}/{month}",
            //    new {controller = "Movie", action = "ByReleasedDate" },
            //    new {year = @"\d{4}", month = @"\d{2}"}
            //    );


            //default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
