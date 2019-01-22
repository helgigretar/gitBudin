using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AxelsBud
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            "Karlahjólin",
            "karlahjol",
            new { controller = "Hjol", action = "karlahjol" });
            routes.MapRoute(
            "Kvennahjólin",
            "kvennahjol",
            new { controller = "Hjol", action = "kvennaHjol" });
            routes.MapRoute(
            "Barnahjólin",
            "barnahjol",
            new { controller = "Hjol", action = "barnaHjol" });
            routes.MapRoute(
           "Kertastjakarnir",
           "kertastjakar",
           new { controller = "kertastjakar", action = "kertastjakar" });
            routes.MapRoute(
           "Sagan um axelsbúð",
           "umAxelsbud",
           new { controller = "sagan", action = "um" });
            routes.MapRoute(
            "aukahlutir bjölur",
            "bjollur",
            new { controller = "aukahlutir", action = "bjollur" });
            routes.MapRoute(
            "Vara ? nafn á vöru",
            "vorur",
            new { controller = "vorur", action = "vorur" });
            routes.MapRoute(
            "aukahlutir bretti",
            "bretti",
            new { controller = "aukahlutir", action = "bretti" });
            routes.MapRoute(
            "bögglaberar",
            "bogglaberar",
            new { controller = "aukahlutir", action = "bogglaberar" });
            routes.MapRoute(
            "Hraðamælar",
            "hradamaelar",
            new { controller = "aukahlutir", action = "hradamaelar" });
            routes.MapRoute(
            "Körfur",
            "korfur",
            new { controller = "aukahlutir", action = "korfur" });



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
