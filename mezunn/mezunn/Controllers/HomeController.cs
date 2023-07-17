using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mezunn.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        IsIlanlariManager im = new IsIlanlariManager();
        BasvuruYapanlarManager bm = new BasvuruYapanlarManager();
       
        public object HomePage(Register register)
        {


            return View();
        }

        public ActionResult Hakkımzıda()
        {
            return View();
        }
        public ActionResult Özgeçmiş()
        {
            return View();

        }
        public ActionResult NewHomePage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewIsIlanları( )
        {
            var IsIlanıValues = im.GetAllIsIlanlari();

            return View(IsIlanıValues);
        }
        [HttpPost]
        public ActionResult NewIsIlanları(BasvuruYapanlar basvuruYapanlar)
        {

            bm.GetAddBasvuruYapanlar(basvuruYapanlar);
            return RedirectToAction("NewHomePage", "Home");

            
        }










    }
}



        
    