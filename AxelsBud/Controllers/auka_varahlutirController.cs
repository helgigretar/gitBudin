using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using AxelsBud.Models;

namespace AxelsBud.Controllers
{
    public class auka_varahlutirController : Controller
    {
        //Global variable
        private static string[] names = new string[100];
        private static string[] verd = new string[100];
        private static string[] mynd = new string[100];
        private static string[] lysing = new string[100];
        // GET: auka_varahlutir
        public ActionResult bjollur()
        {
            LoadJson("bjollur");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd
            };
            return View(results);
        }
        //Load the Json
        public void LoadJson(string sub)
        {
            string path = HttpContext.Server.MapPath("~/App_Data/" + sub + ".json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                int counter = 0;
                foreach (var data in items)
                {
                    names[counter] = data.Name;
                    verd[counter] = data.verd;
                    lysing[counter] = data.lysing;
                    mynd[counter] = data.mynd;
                    counter = counter + 1;

                }

            }
        }
    }
}