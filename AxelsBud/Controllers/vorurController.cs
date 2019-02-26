using Newtonsoft.Json;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using AxelsBud.Models;

namespace AxelsBud.Controllers
{
    public class vorurController : Controller
    {
        //Global variable
        private static string names;
        private static string verd;
        private static string mynd;
        private static string [] lysing= new string[30];
        private static string ids;
        // GET: vorur
        public ActionResult vorur()
        {
            names = null;
            verd = null;
            mynd = null;
            //Þarf að búa til fylki
            lysing = new string[30];
            ids = null;
            //Náum í URI
            string tempUrl = HttpContext.Request.Url.AbsoluteUri.ToString();
            //Náum í vöruna
            string[] words = tempUrl.Split('?');
            //assignum vöruna breytu
            string vara = words[1];
            LoadJson("bjollur", vara);
            LoadJson("bretti", vara);
            LoadJson("bogglaberar", vara);
            LoadJson("hradamaelar", vara);
            LoadJson("korfur", vara);
            LoadJson("ljos", vara);
            LoadJson("pedalar", vara);
            LoadJson("pumpur", vara);
            LoadJson("standarar", vara);
            LoadJson("styrisendar", vara);
            LoadJson("vatnsfloskur_statif", vara);
            LoadJson("lasar", vara);
            LoadJson("kertastjakar", vara);
            //LoadJson("hnakkar", vara);
            LoadJson("krakkar", vara);
            while (names== null)
            {

            }
            var result = new vorur()
            {
                verd = verd,
                audkenni = ids,
                lysing = lysing,
                mynd = mynd,
                nafn = names
                
            };
            return View(result);
        }
        //Load Json
        public void LoadJson(string sub,string vara)
        {
            if(names != null) { return; }
            string path = HttpContext.Server.MapPath("~/App_Data/" + sub + ".json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                foreach (var data in items)
                {
                    if(data.ID == vara)
                    {
                        names = data.Name;
                        verd = data.verd;
                        mynd = data.mynd;
                        ids = data.ID;
                        string[] reviews = data.lysing.Split('$');
                        int counter = 0;
                        foreach(var item in reviews)
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