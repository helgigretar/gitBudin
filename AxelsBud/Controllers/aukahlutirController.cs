﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using AxelsBud.Models;

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
        // GET: auka_varahlutir
        public ActionResult bjollur()
        {
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
                int counter = 0;
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