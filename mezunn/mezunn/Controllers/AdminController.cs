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
    
    public class AdminController : Controller
    {
        RegisterManager rm = new RegisterManager();
        
        public ActionResult Index()
        {
            return View();
        }
       
        [Authorize]
        public ActionResult MezunBilgileri()
        {
            var registerValue = rm.GetAllRegister();

            return View(registerValue);
        }
       
        public  ActionResult RegisterDelete(int id)
        {

            var registerValue= rm.getById(id);
            rm.DeleteRegister(registerValue);

            return RedirectToAction("MezunBilgileri");

        }
        [HttpGet]
        public ActionResult UpdateRegister(int id)
        {
            var registerValue = rm.getById(id);
          
            return View(registerValue);
        }
        [HttpPost]
        public ActionResult UpdateRegister(Register register)
        {
            rm.RegisterUpdate(register);
            return RedirectToAction("MezunBilgileri", "Admin");


           
        }
      


    }
}