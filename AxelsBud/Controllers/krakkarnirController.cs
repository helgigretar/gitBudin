﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using AxelsBud.Models;

namespace AxelsBud.Controllers
{

    public class krakkarnirController : Controller
    {
        //Global variable
        public static string[] names = new string[100];
        public static string[] verd = new string[100];
        public static string[] mynd = new string[100];
        public static string[] lysing = new string[100];
        public static string[] ids = new string[100];
        // GET: krakkarnir
        public ActionResult krakkar()
        {
           
            LoadJson("krakkar");
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