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
    public class varahlutirController : Controller
    {
        //Global variable
        private static string[] names = new string[100];
        private static string[] verd = new string[100];
        private static string[] mynd = new string[100];
        private static string[] lysing = new string[100];
        private static string[] ids = new string[100];
        private static int counter = 0;
        // GET: varahlutir
        public ActionResult bremsubunadur()
        {
            counter = 0;
            LoadJson("bremsubunadur");
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
        public ActionResult girskiptar()
        {
            counter = 0;
            LoadJson("girskiptar");
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
        public ActionResult kedjur_girhlifar()
        {
            counter = 0;
            LoadJson("kedjur_girhlifar");
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
        public ActionResult gjardir()
        {
            return View();
        } public ActionResult index()
        {
            counter = 0;
            LoadJson("bremsubunadur");
            LoadJson("girskiptar");
            LoadJson("kedjur_girhlifar");
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