using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSitesiDeneme.Models;
namespace FilmSitesiDeneme.Controllers
{
    public class LoginController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Yönetici y1)
        {
        var bilgi = db.Yönetici.FirstOrDefault(x => x.Yönetici_AD == y1.Yönetici_AD && x.Yönetici_ŞİFRE == y1.Yönetici_ŞİFRE);
         if(bilgi != null)
         {
             return RedirectToAction("Filmler", "Admin");
         }
         else
         {
             return View();
         }
        }
    }
}