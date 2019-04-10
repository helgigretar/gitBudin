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
        private static string [] imgSrc = new string[30];
        private static string [] linkshref = new string[30];
        private static string ids;
       
        // GET: vorur
        public ActionResult vorur()
        {
            
            names = null;
            verd = null;
            mynd = null;
            //Þarf að búa til fylki
            lysing = new string[30];
            imgSrc = new string[30];
            linkshref = new string[30];
            ids = null;
            //Náum í URI
            string tempUrl = HttpContext.Request.Url.AbsoluteUri.ToString();
            //Náum í vöruna
            string[] words = tempUrl.Split('?');
            //assignum vöruna breytu
            string vara = words[1];
            //if bjöllur hjá krökkum
            if(vara == "krakkar_1" || vara =="krakkar_2" || vara == "krakkar_3" || vara == "krakkar_4")
            {
                LoadJsonMultiple("krakkar", "krakkar_1",0);
                LoadJsonMultiple("krakkar", "krakkar_2",1);
                LoadJsonMultiple("krakkar", "krakkar_3",2);
                LoadJsonMultiple("krakkar", "krakkar_4",3);
                LoadJson("krakkar", vara);
                var res = new vorur()
                {
                    verd = verd,
                    audkenni = ids,
                    lysing = lysing,
                    mynd = mynd,
                    nafn = names,
                    imgs = imgSrc,
                    links = linkshref,
                    multipleLinks = true
                    

                };
                return View(res);
            }
            //if körfur hjá rökkum
            if(vara == "krakkar_6" | vara == "krakkar_7")
            {
                LoadJsonMultiple("krakkar", "krakkar_6", 0);
                LoadJsonMultiple("krakkar", "krakkar_7", 1);
                LoadJson("krakkar", vara);
                var res = new vorur()
                {
                    verd = verd,
                    audkenni = ids,
                    lysing = lysing,
                    mynd = mynd,
                    nafn = names,
                    imgs = imgSrc,
                    links = linkshref,
                    multipleLinks = true

                };
                return View(res);
            }
            //if hlaupahjól hjá krökkum
            if(vara == "krakkar_8" || vara == "krakkar_9" || vara == "krakkar_10" || vara == "krakkar_11" || vara == "krakkar_12" || vara == "krakkar_13" )
            {
                LoadJsonMultiple("krakkar", "krakkar_8", 0);
                LoadJsonMultiple("krakkar", "krakkar_9", 1);
                LoadJsonMultiple("krakkar", "krakkar_10", 2);
                LoadJsonMultiple("krakkar", "krakkar_11", 3);
                LoadJsonMultiple("krakkar", "krakkar_12", 4);
                LoadJsonMultiple("krakkar", "krakkar_13", 5);
                LoadJson("krakkar", vara);
                var res = new vorur()
                {
                    verd = verd,
                    audkenni = ids,
                    lysing = lysing,
                    mynd = mynd,
                    nafn = names,
                    imgs = imgSrc,
                    links = linkshref,
                    multipleLinks = true

                };
                return View(res);
            }

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
            LoadJson("girskiptar", vara);
            LoadJson("bremsubunadur", vara);
            LoadJson("kertastjakar", vara);
            LoadJson("hnakkar", vara);
            LoadJson("krakkar", vara);
           
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
        //Load Json for multiple imgs
        public void LoadJsonMultiple(string sub, string vara,int count)
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
                        imgSrc[count] = data.mynd;
                        linkshref[count] = data.ID;
                        break;
                    }

                }
            }
        }
    }

}