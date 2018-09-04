using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using System.Diagnostics;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class RegistrationController : Controller
    {
        project1Entities db = new project1Entities();
        // GET: Registration

        public ActionResult register()
        {
            List<department> list1 = db.departments.ToList();
            ViewBag.list = new SelectList(list1, "dep_id", "dep_name");

            List<department1> list2 = db.department1.ToList();
            ViewBag.list1 = new SelectList(list2, "dep_id1", "dep_name1");

            return View();
        }

        [HttpPost]
        public ActionResult register(registerviewmodel uvm)
        {

            List<department> list1 = db.departments.ToList();
            ViewBag.list = new SelectList(list1, "dep_id", "dep_name");

            List<department1> list2 = db.department1.ToList();
            ViewBag.list1 = new SelectList(list2, "dep_id1", "dep_name1");

            user_register us = new user_register();

            us.users_name = uvm.users_name;
            us.user_f_name = uvm.user_f_name;
            us.user_email = uvm.user_email;
            us.user_cnic = uvm.user_cnic;
            us.user_reg_date = uvm.user_reg_date;
            us.user_phonenum = uvm.user_phonenum;
            us.gender = uvm.gender;
            us.user_address = uvm.user_address;
            us.user_hecPercentage = uvm.user_hecPercentage;
            us.yearofpassingexam = uvm.yearofpassingexam;
            us.userdep_id = uvm.userdep_id;
            us.userdep_id1 = uvm.userdep_id1;
            us.dep_name = uvm.dep_name;
            us.dep_name1 = uvm.dep_name1;
            us.user_status = 0;
            db.user_register.Add(us);
            db.SaveChanges();
            Session["user"] = us.users_name;
            return RedirectToAction("optional");

        }

        public ActionResult optional()
        {
            return View();
        }


    }
}