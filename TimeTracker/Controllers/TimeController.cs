using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTracker.Models;
using System.Data.SqlClient;

namespace TimeTracker.Controllers
{
    public class TimeController : Controller
    {
        private TimeModelsContext db = new TimeModelsContext();

        public ActionResult Index()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ew-db\\dev;Initial Catalog=TimeTracker;Integrated Security=True;User ID=UserName;Password=Password"))
            {
                SqlConnection.ClearPool(connection);
                connection.Open();
            }
            return View(db.Time.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            TimeModels timemodels = db.Time.Find(id);
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
                db.Time.Add(timemodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timemodels);
        }

        //
        // GET: /Time/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TimeModels timemodels = db.Time.Find(id);
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
            TimeModels timemodels = db.Time.Find(id);
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
            TimeModels timemodels = db.Time.Find(id);
            db.Time.Remove(timemodels);
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