using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
   
    public class HomeController : Controller
    {
        project1Entities db = new project1Entities();
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult computers()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult software()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult information()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult prophile()
        {
           
            if (Session["id"] == null)
            {
                return RedirectToAction("login");
            }
            else
            {
                int id = Convert.ToInt32(Session["id"]);
                user_register s = db.user_register.Where(x => x.reg_id == id).SingleOrDefault();
                ViewBag.name = s.users_name;
                if (s.user_status ==0)
                {
                    ViewBag.msg = "Your Application Is on Proceed";

                }
                else if(s.user_status == 1)
                {
                    ViewBag.msg = "Your Account Has Been Approved";
                }
                else
                {
                    ViewBag.msg = "Your Application Is Rejected";
                }

                registerviewmodel svm = new registerviewmodel();
                svm.users_name = s.users_name;
                svm.user_f_name = s.user_f_name;
                svm.user_cnic = s.user_cnic;
                svm.user_email = s.user_email;
                svm.userdep_id = s.userdep_id;
                svm.userdep_id1 = s.userdep_id1;
                return View(svm);
            }
          

           
        }

        public ActionResult login()
        {
            //if (Session["id"] !=null)
            //{
            //    return RedirectToAction("prophile");

            //}
            
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult login(userlogin uvm)
        {
            user_register s = db.user_register.Where(x => x.user_cnic == uvm.user_cnic && x.user_email == uvm.user_email)
                .SingleOrDefault();
            if (s!=null)
            {
                Session["id"] = s.reg_id;
                return RedirectToAction("prophile");

            }
            else
            {
                ViewBag.msg = "No Record Found";
            }
            

            return View();
        }


        public ActionResult checkpanel()
        {
            ViewBag.total = db.user_register.Count(x => x.user_status == 0 || x.user_status == 1 || x.user_status == -1);
            ViewBag.approved = db.user_register.Count(x => x.user_status == 1);
            ViewBag.pending = db.user_register.Count(x => x.user_status == 0);
            ViewBag.rejected = db.user_register.Count(x => x.user_status == -1);


            
            return View();
        }

    
    }

  
}