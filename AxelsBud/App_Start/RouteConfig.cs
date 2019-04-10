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
            "aukahlutir/bjollur",
            new { controller = "aukahlutir", action = "bjollur" });
            routes.MapRoute(
            "Vara ? nafn á vöru",
            "vorur",
            new { controller = "vorur", action = "vorur" });
            routes.MapRoute(
            "aukahlutir bretti",
            "aukahlutir/bretti",
            new { controller = "aukahlutir", action = "bretti" });
            routes.MapRoute(
            "bögglaberar",
            "aukahlutir/bogglaberar",
            new { controller = "aukahlutir", action = "bogglaberar" });
            routes.MapRoute(
            "Hraðamælar",
            "aukahlutir/hradamaelar",
            new { controller = "aukahlutir", action = "hradamaelar" });
            routes.MapRoute(
            "Körfur",
            "aukahlutir/korfur",
            new { controller = "aukahlutir", action = "korfur" });
            routes.MapRoute(
            "Ljós",
            "aukahlutir/ljos",
            new { controller = "aukahlutir", action = "ljos" });
            routes.MapRoute(
            "pedalar",
            "aukahlutir/pedalar",
            new { controller = "aukahlutir", action = "pedalar" });
            routes.MapRoute(
            "aukahlutir/pumpur",
            "pumpur",
            new { controller = "aukahlutir", action = "pumpur" });
            routes.MapRoute(
            "aukahlutir/standarar",
            "standarar",
            new { controller = "aukahlutir", action = "standarar" });
            routes.MapRoute(
            "Stýrisendar",
            "aukahlutir/styrisendar",
            new { controller = "aukahlutir", action = "styrisendar" });
            routes.MapRoute(
            "Vatnsfloskur og statíf",
            "aukahlutir/vatnsfloskur_statif",
            new { controller = "aukahlutir", action = "vatnsfloskur_statif" });
            routes.MapRoute(
            "hnakkar",
            "aukahlutir/hnakkar",
            new { controller = "aukahlutir", action = "hnakkar" });
            routes.MapRoute(
            "lasar",
            "aukahlutir/lasar",
            new { controller = "aukahlutir", action = "lasar" });
            routes.MapRoute(
            "hjolastandar",
            "hjolastandar",
            new { controller = "hjolastandar", action = "hjolastandar" });

            routes.MapRoute(
            "Krakkarnir",
            "krakkarnir",
            new { controller = "krakkarnir", action = "krakkar" });

            routes.MapRoute(
            "Viðgerðir",
            "vidgerd",
            new { controller = "vidgerd", action = "vidgerd" });

            routes.MapRoute(
            "heimildarmynd",
            "heimildarmynd",
            new { controller = "sagan", action = "heimildamynd" });

            routes.MapRoute(
            "opnunartimar",
            "opnunartimar",
            new { controller = "sagan", action = "opnunartimar" });

            routes.MapRoute(
            "varahlutir",
            "varahlutir",
            new { controller = "varahlutir", action = "index" });

            routes.MapRoute(
            "aukahlutir",
            "aukahlutir",
            new { controller = "aukahlutir", action = "index" });

            routes.MapRoute(
            "varahlutir_Bremsubunadur",
            "varahlutir/bremsubunadur",
            new { controller = "varahlutir", action = "bremsubunadur" });

            routes.MapRoute(
            "varahlutir_girskiptar",
            "varahlutir/girskiptingar",
            new { controller = "varahlutir", action = "girskiptar" });

            routes.MapRoute(
            "varahlutir_gjardir",
            "varahlutir/gjardir",
            new { controller = "varahlutir", action = "gjardir" });

            routes.MapRoute(
            "varahlutir_kedjur_girhlifar",
            "varahlutir/kedjur_girhlifar",
            new { controller = "varahlutir", action = "kedjur_girhlifar" });

            routes.MapRoute(
            "fullordinshjol",
            "fullordinshjol",
            new { controller = "Hjol", action = "fullordinshjol" });

            routes.MapRoute(
            "hjolvorur",
            "hjol",
            new { controller = "hjolvorur", action = "hjolvorur" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
