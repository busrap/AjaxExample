using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxOrnek.Controllers
{
    public class UrunlerController : Controller
    {
        List<string> isimler = new List<string> { "Ankara", "İzmir", "İstanbul", "Kars", "Zonguldak", "Edirne", "Sivas", "Kayseri", "Ağrı", "Muğla", "Muş", "Antalya", "Eskişehir" };

        [HttpPost]
        public ActionResult UrunleriGetir(string ara)
        {
            System.Threading.Thread.Sleep(1000);
            return PartialView(isimler.Where(i => i.Contains(ara)).ToList());
        }

        [HttpPost]
        public ActionResult UrunleriGetirIleBaslayan(string ara)
        {
            System.Threading.Thread.Sleep(1000);
            return PartialView("UrunleriGetir", isimler.Where(i => i.StartsWith(ara)).ToList());
        }
    }
}