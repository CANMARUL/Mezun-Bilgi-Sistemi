using BussinesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mezunn.Controllers
{
    public class RegisterHomePageController : Controller
    {
        RegisterManager registerManager = new RegisterManager();
        // GET: RegisterHomePage
        public ActionResult RegisterHomePage(Register register)
        {
            return View();
        }
    }
}