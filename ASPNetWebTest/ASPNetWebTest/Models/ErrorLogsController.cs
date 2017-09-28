using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ASPNetWebTest.Models {
    public class ErrorLogsController : Controller {
        private ErrorLogContext db = new ErrorLogContext();

        // GET: ErrorLogs
        public ActionResult Index() {
            return View(db.errors.ToList());
        }

        // GET: ErrorLogs/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorLog errorLog = db.errors.Find(id);
            if (errorLog == null) {
                return HttpNotFound();
            }
            return View(errorLog);
        }

        // GET: ErrorLogs/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ErrorLogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,errorUserID,errorMsg,errorLoc")] ErrorLog errorLog) {
            if (ModelState.IsValid) {
                db.errors.Add(errorLog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(errorLog);
        }

        // GET: ErrorLogs/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorLog errorLog = db.errors.Find(id);
            if (errorLog == null) {
                return HttpNotFound();
            }
            return View(errorLog);
        }

        // POST: ErrorLogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,errorUserID,errorMsg,errorLoc")] ErrorLog errorLog) {
            if (ModelState.IsValid) {
                db.Entry(errorLog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(errorLog);
        }

        // GET: ErrorLogs/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorLog errorLog = db.errors.Find(id);
            if (errorLog == null) {
                return HttpNotFound();
            }
            return View(errorLog);
        }

        // POST: ErrorLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            ErrorLog errorLog = db.errors.Find(id);
            db.errors.Remove(errorLog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
