using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mezunn.Controllers
{
    [AllowAnonymous]
    public class AdminLoginController : Controller
    {
        Context c = new Context();
       
      
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Register register)
        {
            var adminLoginVerification = c.Registers.FirstOrDefault(m => m.registerEmail == register.registerEmail && m.registerPassword
              == register.registerPassword && m.registerRoll == register.registerRoll);

            if (adminLoginVerification != null&& adminLoginVerification.registerRoll=="A" )
            {
                FormsAuthentication.SetAuthCookie(register.registerEmail, false);
                return RedirectToAction("MezunBilgileri", "Admin");
            }
            else
            {
                ViewBag.Mesaj="Lütfen bilgilerini doğru giriniz...";
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();  
            return RedirectToAction("MezunBilgileri","Admin");
        }

    }
}