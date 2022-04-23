using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;

namespace AracSatis.Controllers
{
    public class KategoriController : Controller
    {
        AracSatisEntities db = new AracSatisEntities();
        public ActionResult Index(int id)
        {
            ViewBag.id = id;
            var kategori = db.Tbl_Arac.Where(c => c.Kategori == id).ToList();
            List<Tbl_Kategori> list = new List<Tbl_Kategori>();

            return View(kategori);
        }
    }
}