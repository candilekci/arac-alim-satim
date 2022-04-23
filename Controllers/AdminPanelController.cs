using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AracSatis.Models.Entity;
using AracSatis.Blockchain;


namespace AracSatis.Controllers
{
    
    public class AdminPanelController : Controller
    {
        AracSatisEntities db = new AracSatisEntities();

        
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AracEkle()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AracEkle(Tbl_Arac a)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaad = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/WebSite/img/" + dosyaad;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                a.AracIMG = dosyaad;
            }
            db.Tbl_Arac.Add(a);
            db.SaveChanges();
            return View();
            
        }

       
        [HttpGet]
        public ActionResult Blockchain()
        {
            var blocks = db.Tbl_Blockchain.ToList();
            
                       
            return View(blocks);
        }
        
        [HttpPost]
        public ActionResult Blockchain(Tbl_Blockchain b)
        {

            



            return View();
        }

        
       
    }
}