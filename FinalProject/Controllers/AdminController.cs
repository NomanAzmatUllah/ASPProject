using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class AdminController : Controller
    {
        project1Entities db = new project1Entities();
        // GET: Admin
        public ActionResult signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult signup(adminviewmodel uvm)
        {
            admin_signup ad = new admin_signup();
            ad.admin_name = uvm.admin_name;
            ad.admin_email = uvm.admin_email;
            ad.admin_password = uvm.admin_password;
            ad.admin_c_password = uvm.admin_c_password;

            return View("login");
        }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(adminviewmodel uvm)
        {
            admin_signup ad = db.admin_signup.Where(z => z.admin_email == uvm.admin_email
            && z.admin_password == uvm.admin_password).SingleOrDefault();
            if (ad!=null)
            {
                Session["user"] = ad.admin_name;
                return RedirectToAction("Index","view");
            }
                return View();
        }
    }
}