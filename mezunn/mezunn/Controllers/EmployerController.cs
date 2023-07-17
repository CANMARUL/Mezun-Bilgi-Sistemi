using BussinesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mezunn.Controllers
{
    public class EmployerController : Controller
    {
        EmployerManager employer = new EmployerManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployerList()
        {
            var employerValues = employer.GetAllEmployer();
            return View(employerValues);
        }
    }
}