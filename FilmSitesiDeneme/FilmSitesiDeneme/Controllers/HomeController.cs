using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSitesiDeneme.Models;
using PagedList.Mvc;
using PagedList;
namespace FilmSitesiDeneme.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        //public ActionResult Index(int sayfa = 1)
        //{
        //    var degerler = db.Filmler.ToList().ToPagedList(sayfa, 15);
        //    return View(degerler);
        //}
        public ActionResult Index(String p , int sayfa = 1)
        {
            var degerler = from d in db.Filmler select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Film_AD.Contains(p));
            }
            return View(degerler.ToList().ToPagedList(sayfa, 15));
        }
        //public ActionResult Diziler(int sayfa1 = 1)
        //{
        //    var degerler = db.Diziler.ToList().ToPagedList(sayfa1, 15);
        //    return View(degerler);
        //}
        public ActionResult Diziler(String p, int sayfa = 1)
        {
            var degerler = from d in db.Diziler select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.Dizi_AD.Contains(p));
            }
            return View(degerler.ToList().ToPagedList(sayfa, 15));
        }
        public ActionResult AvengersYorum() //Shared
        {
            return View();
        }
        public ActionResult AvengersYorumListele() //PartialView
        {
            var degerler = db.AvengersYorum.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AvengersYorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AvengersYorumEkle(AvengersYorum y1) //Shared
        {
            db.AvengersYorum.Add(y1);
            db.SaveChanges();
            return RedirectToAction("AvengersYorum");
        }

        public ActionResult Avengers2Yorum()
        {
            return View();
        }
        public ActionResult Avengers2YorumListele()
        {
            var degerler = db.Avengers2Yorum.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Avengers2YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Avengers2YorumEkle(Avengers2Yorum y1)
        {
            db.Avengers2Yorum.Add(y1);
            db.SaveChanges();
            return RedirectToAction("Avengers2Yorum");
        }
        public ActionResult Avengers3Yorum()
        {
            return View();
        }
        public ActionResult Avengers3YorumListele()
        {
            var degerler = db.Avengers3Yorum.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Avengers3YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Avengers3YorumEkle(Avengers3Yorum y1)
        {
            db.Avengers3Yorum.Add(y1);
            db.SaveChanges();
            return RedirectToAction("Avengers3Yorum");
        }
        public ActionResult Avengers4Yorum()
        {
            return View();
        }
        public ActionResult Avengers4YorumListele()
        {
            var degerler = db.Avengers4Yorum.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Avengers4YorumEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Avengers4YorumEkle(Avengers4Yorum y1) //Shared
        {
            db.Avengers4Yorum.Add(y1);
            db.SaveChanges();
            return RedirectToAction("Avengers4Yorum");
        }

    }
}