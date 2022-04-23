using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;

namespace AracSatis.Controllers
{
    public class RegisterController : Controller
    {
        AracSatisEntities db = new AracSatisEntities();

        [HttpGet]
        public ActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KayitOl(FormCollection f)
        {
            Tbl_Musteri ms = new Tbl_Musteri();
            ms.MusteriAD = f["firstName"].Trim();
            ms.MusteriSOYAD = f["lastName"].Trim();
            ms.MusteriTEL = f["number"].Trim();
            ms.MusteriMAIL = f["email"].Trim();
            ms.MusteriSIFRE = f["password"].Trim();
            ms.MusteriBAKIYE = 100;
            db.Tbl_Musteri.Add(ms);
            db.SaveChanges();

            return View();
        }
    }
}