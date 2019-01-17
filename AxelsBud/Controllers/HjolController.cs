using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AxelsBud.Controllers
{
    public class HjolController : Controller
    {
        // GET: karlaHjol
        public ActionResult karlaHjol()
        {
            return View();
        }
        //GET: Kvennahjól
        public ActionResult kvennaHjol()
        {
            return View();
        }
        //GET:Barnahjól
        public ActionResult barnaHjol()
        {
            return View();
        }
    }
}