using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using asp.net_mvc_proje2.Models;

namespace asp.net_mvc_proje2.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Amacimiz()
        {
            ViewBag.Message = "Your amacimiz page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(FormModel model)
        {

            TempData["Basarili"] = "Teşekürler en kısa zamanda tarafınıza dönüş yapılacaktır.";

            return RedirectToAction("Contact");
        }
    }
}