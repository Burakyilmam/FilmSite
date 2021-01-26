using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSitesiDeneme.Models;
namespace FilmSitesiDeneme.Controllers
{
    public class AdminController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Filmler()
        {
            var degerler = db.Filmler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniFilm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniFilm(Filmler f1)
        {
            Model1 db = new Model1();
            db.Filmler.Add(f1);
            db.SaveChanges();
            return RedirectToAction("Filmler");
        }
        public ActionResult FilmSil(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.Filmler.Find(id);
            db3.Filmler.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Filmler");
        }

        [HttpGet]
        public ActionResult YeniDizi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDizi(Diziler d1)
        {
            Model1 db = new Model1();
            db.Diziler.Add(d1);
            db.SaveChanges();
            return RedirectToAction("Diziler");
        }
        public ActionResult DiziSil(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.Diziler.Find(id);
            db3.Diziler.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Diziler");
        }
        public ActionResult Diziler()
        {
            var degerler = db.Diziler.ToList();
            return View(degerler);
        }
        public ActionResult Mesajlar()
        {
            var degerler = db.Mesaj.ToList();
            return View(degerler);
        }
        public ActionResult İstekler()
        {
            return View();
        }
        public ActionResult Yorumlar()
        {
            ViewModel vm = new ViewModel();
            vm.AvengersYorums = db.AvengersYorum.ToList();
            vm.Avengers2Yorums = db.Avengers2Yorum.ToList();
            vm.Avengers3Yorums = db.Avengers3Yorum.ToList();
            vm.Avengers4Yorums = db.Avengers4Yorum.ToList();
            vm.Fast1Yorums = db.Fast1Yorum.ToList();
            vm.Fast2Yorums = db.Fast2Yorum.ToList();
            vm.Fast3Yorums = db.Fast3Yorum.ToList();
            vm.Fast4Yorums = db.Fast4Yorum.ToList();
            vm.Fast5Yorums = db.Fast5Yorum.ToList();
            vm.Fast6Yorums = db.Fast6Yorum.ToList();
            vm.Fast7Yorums = db.Fast7Yorum.ToList();
            vm.Fast8Yorums = db.Fast8Yorum.ToList();
            vm.Fast9Yorums = db.Fast9Yorum.ToList();
            vm.FastShawYorums = db.FastShawYorum.ToList();
            vm.BumblebeeYorums = db.BumblebeeYorum.ToList();
            return View(vm);
        }
        public ActionResult YorumSil(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.AvengersYorum.Find(id);
            db3.AvengersYorum.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public ActionResult YorumSil2(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.Avengers2Yorum.Find(id);
            db3.Avengers2Yorum.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public ActionResult YorumSil3(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.Avengers3Yorum.Find(id);
            db3.Avengers3Yorum.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public ActionResult YorumSil4(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.Avengers4Yorum.Find(id);
            db3.Avengers4Yorum.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Yorumlar");
        }
        public ActionResult MesajSil(int id)
        {
            Model1 db3 = new Model1();
            var f3 = db3.Mesaj.Find(id);
            db3.Mesaj.Remove(f3);
            db3.SaveChanges();
            return RedirectToAction("Mesajlar");
        }
    }
}
