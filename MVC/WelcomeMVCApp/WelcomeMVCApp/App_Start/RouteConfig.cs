using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WelcomeMVCApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Welcome",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Welcome1",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome1", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Welcome2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome2", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Welcome3",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Welcome3", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "auth",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "auth", id = UrlParameter.Optional }
            );
        }
    }
}
