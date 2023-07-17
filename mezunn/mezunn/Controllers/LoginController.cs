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
    public class LoginController : Controller
    {
        Context c = new Context();
        RegisterManager registerManager = new RegisterManager();
        [HttpGet]
        
        public ActionResult LoginVerification()
        {
            return View();
        }
        // GET: Login
        [HttpPost]
        
        public ActionResult LoginVerification(Register register )
        {
            Session["Kullanici"] = register.registerEmail;
            var loginVerification = c.Registers.FirstOrDefault(x => x.registerEmail == register.registerEmail &&
           x.registerPassword == register.registerPassword && x.registerRoll==register.registerRoll);

            if (loginVerification != null)
            {
                 
                
                return RedirectToAction( "NewHomePage", "Home");
               
            }
            else
            {
                ViewBag.Message = "Lütfen bilgilerinizi doğru giriniz";
                return View();

            }

            
        }
        public ActionResult HomePage()
        {
            return View();
        }
        
        
    }
}