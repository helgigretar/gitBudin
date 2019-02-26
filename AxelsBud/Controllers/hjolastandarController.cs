using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using AxelsBud.Models;

namespace AxelsBud.Controllers
{
    public class hjolastandarController : Controller
    {
        // GET: hjolastandar
        public ActionResult hjolastandar()
        {
            var result = new hjolastandar()
            {

            };
            return View(result);
        }
    }
}