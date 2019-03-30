using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using AxelsBud.Models;
using System.Diagnostics;

namespace AxelsBud.Controllers
{
    public class aukahlutirController : Controller
    {
        //Global variable
        private static string[] names = new string[100];
        private static string[] verd = new string[100];
        private static string[] mynd = new string[100];
        private static string[] lysing = new string[100];
        private static string[] ids = new string[100];
        private static int counter = 0;
        // GET: auka_varahlutir
        public ActionResult index()
        {
            counter = 0;
            LoadJson("bjollur");
            LoadJson("bretti");
            LoadJson("bogglaberar");
            LoadJson("hradamaelar");
            LoadJson("korfur");
            LoadJson("ljos");
            LoadJson("pedalar");
            LoadJson("pumpur");
            LoadJson("standarar");
            LoadJson("vatnsfloskur_statif");
            LoadJson("styrisendar");
            LoadJson("lasar");            
            //Fjarlægði hnakkar
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids,
                maxer = counter,
            };
            return View(results);
        }
        public ActionResult bjollur()
        {
            counter = 0;
            LoadJson("bjollur");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids,
            };
            return View(results);
        }
        //Get: bretti
        public ActionResult bretti()
        {
            counter = 0;
            LoadJson("bretti");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //Get: bogglaberar
        public ActionResult bogglaberar()
        {
            counter = 0;
            LoadJson("bogglaberar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //Get: hradamaelar
        public ActionResult hradamaelar()
        {
            counter = 0;
            LoadJson("hradamaelar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: korfur
        public ActionResult korfur()
        {
            counter = 0;
            LoadJson("korfur");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: ljos
        public ActionResult ljos()
        {
            counter = 0;
            LoadJson("ljos");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: pedalar
        public ActionResult pedalar()
        {
            counter = 0;
            LoadJson("pedalar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: pumpur
        public ActionResult pumpur()
        {
            counter = 0;
            LoadJson("pumpur");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: standarar
        public ActionResult standarar()
        {
            counter = 0;
            LoadJson("standarar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: styrisendar
        public ActionResult styrisendar()
        {
            counter = 0;
            LoadJson("styrisendar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: vatnsfloskur_statif
        public ActionResult vatnsfloskur_statif()
        {
            counter = 0;
            LoadJson("vatnsfloskur_statif");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: hnakkar
        public ActionResult hnakkar()
        {
            counter = 0;
            LoadJson("hnakkar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
            };
            return View(results);
        }
        //GET: Lasar
        public ActionResult lasar()
        {
            counter = 0;
            LoadJson("lasar");
            var results = new bjollur()
            {
                lysingar = lysing,
                myndir = mynd,
                nofn = names,
                verdin = verd,
                audkenin = ids
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
                foreach (var data in items)
                {
                    names[counter] = data.Name;
                    verd[counter] = data.verd;
                    lysing[counter] = data.lysing;
                    mynd[counter] = data.mynd;
                    ids[counter] = data.ID;
                    counter = counter + 1;
                }

            }
        }
    }
}