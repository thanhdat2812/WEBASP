using ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class TrainingStaffController : Controller
    {
        private TrainingContext db = new TrainingContext();
        public ActionResult Index()
        {
            var list = db.TrainingStaffs.ToList<TrainingStaff>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "TrainingStaffid,Trainingname,phonenumber,email,local_address,Accountid")] TrainingStaff trainingStaff)
        {
            if (ModelState.IsValid)
            {
                db.TrainingStaffs.Add(trainingStaff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainingStaff);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            TrainingStaff trainingStaff = db.TrainingStaffs.Find(id);
            return View(trainingStaff);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "TrainingStaffid,Trainingname,phonenumber,email,local_address,Accountid")] TrainingStaff trainingStaff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainingStaff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainingStaff);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            TrainingStaff trainingStaff = db.TrainingStaffs.Find(id);
            db.TrainingStaffs.Remove(trainingStaff);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
