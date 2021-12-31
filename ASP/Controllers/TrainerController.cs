using ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class TrainerController : Controller
    {
        private TrainingContext db = new TrainingContext();
        public ActionResult Index()
        {
            var list = db.Trainers.ToList<Trainer>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Trainerid,Topicid,Trainername,education,phone,email,local_address,Accountid")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Trainers.Add(trainer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainer);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Trainer trainer = db.Trainers.Find(id);
            return View(trainer);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Trainerid,Topicid,Trainername,education,phone,email,local_address,Accountid")] Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trainer);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Trainer trainer = db.Trainers.Find(id);
            db.Trainers.Remove(trainer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
    