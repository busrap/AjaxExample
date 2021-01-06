using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxOrnek.Controllers
{
    // AJAX: (Asynchronous Javascript and Xml) Sayfa yeniden yüklenmeden sunucudan bilgi alabilmeyi sağlayan bir programlama tekniğidir. Tüm sayfanın güncellenmesi yerine sadece istenilen yerlerin güncellenmesini sağlar...

    // NuGet'ten Microsoft.jQuery.Unobtrusive.Ajax isimli paketi install etmemiz gerekiyor!..

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
    }
}