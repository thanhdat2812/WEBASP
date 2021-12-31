using ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class CatController : Controller
    {
        private TrainingContext db = new TrainingContext();
        public ActionResult Index()
        {
            var list = db.Cats.ToList<Cat>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Catid,Catname,Description")] Cat cat)
        {
            if (ModelState.IsValid)
            {
                db.Cats.Add(cat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cat);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Cat cat= db.Cats.Find(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Catid,Catname,Description")] Cat cat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cat);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Cat cat = db.Cats.Find(id);
            db.Cats.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
