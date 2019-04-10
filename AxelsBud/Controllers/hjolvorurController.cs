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
        private static string[] extraName = new string[30];
        private static string[] extraprice = new string[30];
        private static string[] extraLinks = new string[30];

        private static string ids;
        private static string groups;
        // GET: hjolvorur
        public ActionResult hjolvorur()
        {
            names = null;
            verd = null;
            mynd = null;
            groups = null;
            //Þarf að búa til fylki
            lysing = new string[30];
            extraName = new string[30];
            extraprice = new string[30];
            extraLinks = new string[30];
            ids = null;
            //Náum í URI
            string tempUrl = HttpContext.Request.Url.AbsoluteUri.ToString();
            //Náum í vöruna
            string[] words = tempUrl.Split('?');
            //assignum vöruna breytu
            string vara = "";
            try
            {
                vara = words[1];
            }
            catch
            {
                Response.Redirect("~/");
            }
            LoadJson("hjol", vara);
            LoadJsonMultiple(groups);
            var result = new vorur()
            {
                verd = verd,
                audkenni = ids,
                lysing = lysing,
                mynd = mynd,
                nafn = names,
                extraNames = extraName,
                extraPrices = extraprice,
                extraLinks = extraLinks,
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
                        groups = data.group;
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
        public void LoadJsonMultiple(string group)
        {
            string path = HttpContext.Server.MapPath("~/App_Data/" + "hjol" + ".json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                int count = 0;
                foreach (var data in items)
                {
                    if (data.group == group)
                    {
                        extraName[count] = data.Name;
                        extraprice[count] = data.verd;
                        extraLinks[count] = data.ID;
                        count++;
                    }

                }
            }
        }
    }
}