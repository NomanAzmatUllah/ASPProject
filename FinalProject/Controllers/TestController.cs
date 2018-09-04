using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class TestController : Controller
    {
        project1Entities db = new project1Entities();

        // GET: Test

            //[Authorize]
        public ActionResult test()
        {
            if (Session["user"] != null)
            {
                ViewBag.msg = Session["user"];

            }
            return View();
        }

        public ActionResult testlogin()
        {
            return View();
        }

        
    }
}