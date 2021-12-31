using ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class TraineeController : Controller
    {
        private TrainingContext db = new TrainingContext();
        public ActionResult Index()
        {
            var list = db.Trainees.ToList<Trainee>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Traineeid,Traineename,Phone,Local_address,Courseid,Coursetoeic,Accountid")] Trainee trainee)
        {
            if (ModelState.IsValid)
            {
                db.Trainees.Add(trainee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainee);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Trainee trainee = db.Trainees.Find(id);
            return View(trainee);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Trainee_ID,Trainee_name,Phone,Birth_day,Local_address,Course_ID,Course_toeic,Account_ID")] Trainee trainee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainee);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Trainee trainee = db.Trainees.Find(id);
            db.Trainees.Remove(trainee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
  