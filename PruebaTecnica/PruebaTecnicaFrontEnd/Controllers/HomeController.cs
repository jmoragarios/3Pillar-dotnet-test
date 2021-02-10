using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTecnicaFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        AutosServiceReference.AutosClient _autosService;

        public HomeController()
        {
            _autosService = new AutosServiceReference.AutosClient();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObtenerAutos()
        {
            try
            {
                AutosServiceReference.AutosClient service = new AutosServiceReference.AutosClient();
                var autos = _autosService.ObtenerAutos();

                return Json(autos);
            }
            catch (Exception)
            {
                return new HttpStatusCodeResult(500);
            }
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