using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RjWebsite.DAL;
using RjWebsite.Models;

namespace RjWebsite.Controllers
{
    public class RoommateController : Controller
    {
        private ChoreContext db = new ChoreContext();

        // GET: Roommate
        public ActionResult Index()
        {
            return View(db.Roommates.ToList());
        }

        // GET: Roommate/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roommate roommate = db.Roommates.Find(id);
            if (roommate == null)
            {
                return HttpNotFound();
            }
            return View(roommate);
        }

        // GET: Roommate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roommate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName")] Roommate roommate)
        {
            if (ModelState.IsValid)
            {
                db.Roommates.Add(roommate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roommate);
        }

        // GET: Roommate/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roommate roommate = db.Roommates.Find(id);
            if (roommate == null)
            {
                return HttpNotFound();
            }
            return View(roommate);
        }

        // POST: Roommate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName")] Roommate roommate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roommate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roommate);
        }

        // GET: Roommate/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Roommate roommate = db.Roommates.Find(id);
            if (roommate == null)
            {
                return HttpNotFound();
            }
            return View(roommate);
        }

        // POST: Roommate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Roommate roommate = db.Roommates.Find(id);
            db.Roommates.Remove(roommate);
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
