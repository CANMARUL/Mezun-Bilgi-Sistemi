using BussinesLayer.Concrete;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography; // Crypto.Hash için bu namespace'i ekleyin
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace mezunn.Controllers
{
    public class RegisterController : Controller
    {
        RegisterManager rm = new RegisterManager();

        [HttpGet]
        public ActionResult AddRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRegister(Register p)
        {
            if (!IsValidEmail(p.registerEmail))
            {
                ModelState.AddModelError("", "Geçersiz e-posta adresi");
                return View(p);
            }

            if (rm.IsUserExists(p.registerEmail))
            {
                ModelState.AddModelError("", "Bu e-posta zaten kullanılıyor");
                return View(p);
            }
            else
            {
                // Parolayı hashleyerek kaydet
                var password = HashPassword(p.registerPassword);

                rm.GetAddRegister(p);
                return RedirectToAction("HomePage", "Home");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }


        // Verilen bir metni SHA256 algoritmasını kullanarak hashleyin
        private string HashPassword(string text)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
