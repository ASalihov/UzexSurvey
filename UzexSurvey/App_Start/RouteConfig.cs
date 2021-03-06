﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UzexSurvey
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Quiz", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "UzexSurvey.Controllers" }
            );
            /*
            routes.MapRoute(
                name: "test",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Question", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
