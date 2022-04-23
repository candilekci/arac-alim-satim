using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;

namespace AracSatis.Controllers
{
    public class AracController : Controller
    {
        // GET: Arac
        AracSatisEntities db = new AracSatisEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Arac.SqlQuery("SELECT * FROM Tbl_Arac").ToList();
            return View(degerler);
        }

        


    }
}