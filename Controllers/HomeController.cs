using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;
using System.IO;


namespace AracSatis.Controllers
{
    
    public class HomeController : Controller
    {

        AracSatisEntities db = new AracSatisEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Kategori.SqlQuery("SELECT * FROM Tbl_Kategori").ToList();
            return View(degerler);
        }
       


    }

}