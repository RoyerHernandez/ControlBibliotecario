using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net;
//using static WebServiceApiBiblioteca.Models.RegistroP;

namespace WebApplicationControlBiblioteca.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index() {            
            return View();
        }

        public ActionResult About()
        {
            string url = "https://webserviceapibiblioteca20190603090821.azurewebsites.net/api/Registro";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);

            return View(m);
        }

        public ActionResult Contact()
        {
            string url = "https://webserviceapibiblioteca20190603090821.azurewebsites.net/api/Registro";
            var json = new WebClient().DownloadString(url);
            dynamic l = JsonConvert.DeserializeObject(json);

            return View(l);
        }
    }
}