using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;
using System.Web.Security;

namespace AracSatis.Controllers
{
    public class LoginController : Controller
    {
        AracSatisEntities db = new AracSatisEntities();
        [HttpGet]
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(Tbl_Musteri m)
        {
            var kullanici = db.Tbl_Musteri.FirstOrDefault(x => x.MusteriMAIL == m.MusteriMAIL && x.MusteriSIFRE == m.MusteriSIFRE);
            if(kullanici != null)
            {
                FormsAuthentication.SetAuthCookie(kullanici.MusteriMAIL, false);
                Session["ID"] = kullanici.MusteriID.ToString();
                Session["Ad"] = kullanici.MusteriAD.ToString();
                Session["Soyad"] = kullanici.MusteriSOYAD.ToString();
                Session["Bakiye"] = kullanici.MusteriBAKIYE.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
           
        }

        public ActionResult CIKIS()
        {
            Session["Ad"] = null;
            Session["Soyad"] = null;
            Session["Bakiye"] = null;
            RedirectToAction("Index", "Home");
            return View();
        }
    }
}