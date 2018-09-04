using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class viewController : Controller
    {
        private project1Entities db = new project1Entities();

        // GET: view
        public ActionResult Index()
        {
            var user_register = db.user_register.Include(u => u.department).Include(u => u.department1);
            return View(user_register.ToList());
        }

        // GET: view/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user_register user_register = db.user_register.Find(id);
            if (user_register == null)
            {
                return HttpNotFound();
            }
            return View(user_register);
        }

        // GET: view/Create
        public ActionResult Create()
        {
            ViewBag.userdep_id = new SelectList(db.departments, "dep_id", "dep_name");
            ViewBag.userdep_id1 = new SelectList(db.department1, "dep_id1", "dep_name1");
            return View();
        }

        // POST: view/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "reg_id,users_name,user_f_name,user_email,user_cnic,user_reg_date,user_phonenum,gender,user_address,user_status,user_hecPercentage,yearofpassingexam,userdep_id,userdep_id1")] user_register user_register)
        {
            if (ModelState.IsValid)
            {
                db.user_register.Add(user_register);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.userdep_id = new SelectList(db.departments, "dep_id", "dep_name", user_register.userdep_id);
            ViewBag.userdep_id1 = new SelectList(db.department1, "dep_id1", "dep_name1", user_register.userdep_id1);
            return View(user_register);
        }

        // GET: view/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user_register user_register = db.user_register.Find(id);
            if (user_register == null)
            {
                return HttpNotFound();
            }
            ViewBag.userdep_id = new SelectList(db.departments, "dep_id", "dep_name", user_register.userdep_id);
            ViewBag.userdep_id1 = new SelectList(db.department1, "dep_id1", "dep_name1", user_register.userdep_id1);
            return View(user_register);
        }

        // POST: view/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "reg_id,users_name,user_f_name,user_email,user_cnic,user_reg_date,user_phonenum,gender,user_address,user_status,user_hecPercentage,yearofpassingexam,userdep_id,userdep_id1")] user_register user_register)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_register).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.userdep_id = new SelectList(db.departments, "dep_id", "dep_name", user_register.userdep_id);
            ViewBag.userdep_id1 = new SelectList(db.department1, "dep_id1", "dep_name1", user_register.userdep_id1);
            return View(user_register);
        }

        // GET: view/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user_register user_register = db.user_register.Find(id);
            if (user_register == null)
            {
                return HttpNotFound();
            }
            return View(user_register);
        }

        // POST: view/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            user_register user_register = db.user_register.Find(id);
            db.user_register.Remove(user_register);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
