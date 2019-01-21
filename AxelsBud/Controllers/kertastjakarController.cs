using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace AxelsBud.Controllers
{

    public class kertastjakarController : Controller
    {
        // GET: kertastjakar
        public ActionResult kertastjakar()
        {
         //   LoadJson("bjollur");
            return View();
        }
       
    }
    public class Item
    {
        public string Name;
        public string lysing;
        public string mynd;
        public string verd;
    }
}