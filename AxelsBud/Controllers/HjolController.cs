using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            string root1 = AppDomain.CurrentDomain.BaseDirectory;
            String a = "C:/Users/helgi.gretar/Desktop/gitBudin/AxelsBud/text/json.json";
            a = root1 + "text/json.json";

            using (StreamReader r = new StreamReader(a))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                foreach (var item in items)
                {
                    Debug.WriteLine(item.Name);
                }

            }

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