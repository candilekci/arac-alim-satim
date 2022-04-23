using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;

namespace AracSatis.Controllers
{
    public class SatisController : Controller
    {
        AracSatisEntities db = new AracSatisEntities();
        public ActionResult Index(int id)
        {

            var aracid = db.Tbl_Arac.Where(c => c.AracID == id).ToList();

            

            
            
            return View(aracid);
        }

        
    }
}