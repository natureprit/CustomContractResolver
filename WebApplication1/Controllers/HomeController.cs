using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (StreamReader r = new StreamReader(@"C:\\Users\\Pritesh_Bhanage\\source\\repos\\WebApplication1\\WebApplication1\\Controllers\\file.json"))
            {
                string json = r.ReadToEnd();
                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new CustomContractResolver(),
                };
                Product item = JsonConvert.DeserializeObject<Product>(json, settings);
            }

            return View();
        }
    }
}
