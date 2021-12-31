using ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class CourseController : Controller
    {
        private TrainingContext db = new TrainingContext();
        public ActionResult Index()
        {
            var list = db.Courses.ToList<Course>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Courseid,Coursename,Coursetoeic,Description")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Course course = db.Courses.Find(id);
            return View(course);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Courseid,Coursename,Coursetoeic,Description")] Course course)
        {
            if (ModelState.IsValid)
            {
                db.Entry(course).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Course course = db.Courses.Find(id);
            db.Courses.Remove(course);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
