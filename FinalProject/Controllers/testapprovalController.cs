using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class testapprovalController : Controller
    {
        project1Entities db = new project1Entities();
        // GET: testapproval
        public ActionResult usertestlogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult usertestlogin(testlogin uvm)
        {
            user_register s = db.user_register.Where(x => x.user_email == uvm.user_email &&
            x.user_cnic == uvm.user_cnic).SingleOrDefault();
            if (s.user_status == 1)
            {
                Session["user"] = s.users_name;
                return RedirectToAction("test", "Test");
            }
            else
            {
                ViewBag.msg = "Your are On Proceed Or Rejected Please Check Profile Go To Login Page";
               }
            return View();
        }
    }
}