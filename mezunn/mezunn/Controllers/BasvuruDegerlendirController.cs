using BussinesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mezunn.Controllers
{
    public class BasvuruDegerlendirController : Controller
    {
        BasvuruYapanlarManager bm = new BasvuruYapanlarManager();
       
        [HttpGet]
        public ActionResult Basvuru(BasvuruYapanlar basvuruYapanlar)
        {
            var basvuruYapanlarrValue = bm.GetAllBasvuruYapanlar();

            return View(basvuruYapanlarrValue);
        }
        [HttpPost]
        public ActionResult Basvuru(Register register)
        {
            Session["BasvuranEmail"] = register.registerEmail;

            return RedirectToAction("NewHomePage","Home");
        }
    }
}