using BussinesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mezunn.Controllers
{
    public class IsIlanlariController : Controller
    {

        IsIlanlariManager ilm = new IsIlanlariManager();
       [HttpGet]
        public ActionResult IsIlanlari()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IsIlanlari(IsIlanlari isIlanlari)
        {
            ilm.GetAddIsIlanlari(isIlanlari);
            return View();
        }
        
        
        
    }
}