﻿using System.Web.Mvc;
using System.Web.Routing;

namespace NetC.JuniorDeveloperExam.Web
{
    public class RouteConfig
    {
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        //}

        public static void RegisterRoutes(RouteCollection routes)
        {
            // Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Blog", action = "BlogPost", id = UrlParameter.Optional }
            );

            // Add this code to handle non-existing urls
            routes.MapRoute(
                name: "404-PageNotFound",
                // This will handle any non-existing urls
                url: "{*url}",
                // "Shared" is the name of your error controller, and "Error" is the action/page
                // that handles all your custom errors
                defaults: new { controller = "Shared", action = "Error" }
            );
        }
    }
}
