using AxelsBud.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AxelsBud.Controllers
{
    public class hjolvorurController : Controller
    {
        //Global variable
        private static string names;
        private static string verd;
        private static string mynd;
        private static string[] lysing = new string[30];
        private static string[] imgSrc = new string[30];
        private static string[] linkshref = new string[30];
        private static string ids;
        // GET: hjolvorur
        public ActionResult hjolvorur()
        {
            //Náum í URI
            string tempUrl = HttpContext.Request.Url.AbsoluteUri.ToString();
            //Náum í vöruna
            string[] words = tempUrl.Split('?');
            //assignum vöruna breytu
            string vara = words[1];
            LoadJson("hjol", vara);
            var result = new vorur()
            {
                verd = verd,
                audkenni = ids,
                lysing = lysing,
                mynd = mynd,
                nafn = names,
                multipleLinks = false,
            };
            return View(result);
        }
        //Load Json
        public void LoadJson(string sub, string vara)
        {
            if (names != null) { return; }
            string path = HttpContext.Server.MapPath("~/App_Data/" + sub + ".json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                foreach (var data in items)
                {
                    if (data.ID == vara)
                    {
                        names = data.Name;
                        verd = data.verd;
                        mynd = data.mynd;
                        ids = data.ID;
                        string[] reviews = data.lysing.Split('$');
                        int counter = 0;
                        foreach (var item in reviews)
                        {
                            lysing[counter] = item.ToString();
                            counter++;
                        }
                    }

                }

            }
        }
    }
}