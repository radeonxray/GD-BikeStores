using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GD_TheBikeStore.Controllers
{
    public class HomeController : Controller
    {

        private BikeStoresEntities _context;

        public HomeController() {

            _context = new BikeStoresEntities();
        
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}