using ASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class AccountController : Controller
    {
        private TrainingContext db = new TrainingContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "Username, Password")] Account account)
        {
            TrainingContext db = new TrainingContext();
            Account acc = new Account();
            acc = db.Accounts.Where(p => p.Username == account.Username && p.Password == account.Password).FirstOrDefault();
            if (acc != null)
            {
                Session["UserName"] = acc.Username;
                Session["Status"] = acc.Status;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Index()
        {
            var list = db.Accounts.ToList<Account>();
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Accountid,Username,Password,Status")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Account account = db.Accounts.Find(id);
            return View(account);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Accountid,Username,Password,Status")] Account account)
        {
            if (ModelState.IsValid)
            {
                db.Entry(account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Account account = db.Accounts.Find(id);
            db.Accounts.Remove(account);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
