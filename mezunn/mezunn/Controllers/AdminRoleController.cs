using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mezunn.Controllers
{
    
    public class AdminRoleController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public ActionResult AdminRoll()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminRoll(Register register)
        {
            var adminValue = c.Registers.FirstOrDefault(x => x.registerEmail == register.registerEmail &&
           x.registerPassword == register.registerPassword && x.registerRoll == register.registerRoll);

            if (adminValue != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Message = "Lütfen bilgilerinizi doğru giriniz";
                return View();
            }
        }
    }
}