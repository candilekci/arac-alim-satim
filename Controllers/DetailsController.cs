using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;

namespace AracSatis.Controllers
{
    public class DetailsController : Controller
    {
        AracSatisEntities db = new AracSatisEntities();
        [Authorize]
        public ActionResult Index(int id)
        {
            ViewBag.id = id;
            var degerler = db.Tbl_Arac.Where(c => c.AracID == id).ToList();
            
            
            List<Tbl_Arac> list = new List<Tbl_Arac>();
            
            
            return View(degerler);
        }
    }
}