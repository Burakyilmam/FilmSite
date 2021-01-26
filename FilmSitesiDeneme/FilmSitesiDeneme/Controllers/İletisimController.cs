using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSitesiDeneme.Models;
namespace FilmSitesiDeneme.Controllers
{
    public class İletisimController : Controller
    {
        Model1 db = new Model1();
        public ActionResult İletisim()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Mesaj()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Mesaj(Mesaj m1)
        {
            db.Mesaj.Add(m1);
            db.SaveChanges();
            return RedirectToAction("Mesaj");
        }
    }
}