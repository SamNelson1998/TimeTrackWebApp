using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTrack.Models;

namespace TimeTrack.Controllers
{
    public class TimeController : Controller
    {
        private TimeDBContext db = new TimeDBContext();

        //
        // GET: /Time/

        public ActionResult Index()
        {
            return View(db.TimeModels.ToList());
        }

        //
        // GET: /Time/Details/5

        public ActionResult Details(int id = 0)
        {
            TimeModels timemodels = db.TimeModels.Find(id);
            if (timemodels == null)
            {
                return HttpNotFound();
            }
            return View(timemodels);
        }

        //
        // GET: /Time/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Time/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TimeModels timemodels)
        {
            if (ModelState.IsValid)
            {
                db.TimeModels.Add(timemodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timemodels);
        }

        //
        // GET: /Time/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TimeModels timemodels = db.TimeModels.Find(id);
            if (timemodels == null)
            {
                return HttpNotFound();
            }
            return View(timemodels);
        }

        //
        // POST: /Time/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TimeModels timemodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timemodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timemodels);
        }

        //
        // GET: /Time/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TimeModels timemodels = db.TimeModels.Find(id);
            if (timemodels == null)
            {
                return HttpNotFound();
            }
            return View(timemodels);
        }

        //
        // POST: /Time/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeModels timemodels = db.TimeModels.Find(id);
            db.TimeModels.Remove(timemodels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}