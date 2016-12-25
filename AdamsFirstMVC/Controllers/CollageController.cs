using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdamsFirstMVC.DAL;
using AdamsFirstMVC.Models;

namespace AdamsFirstMVC.Controllers
{
    public class CollageController : Controller
    {
        private MandMContext db = new MandMContext();

        // GET: Collage
        public ActionResult Index()
        {
            return View(db.Collages.ToList());
        }

        // GET: Collage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collage collage = db.Collages.Find(id);
            if (collage == null)
            {
                return HttpNotFound();
            }
            return View(collage);
        }

        // GET: Collage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Collage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,ImagePath")] Collage collage)
        {
            if (ModelState.IsValid)
            {
                db.Collages.Add(collage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collage);
        }

        // GET: Collage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collage collage = db.Collages.Find(id);
            if (collage == null)
            {
                return HttpNotFound();
            }
            return View(collage);
        }

        // POST: Collage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,ImagePath")] Collage collage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(collage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collage);
        }

        // GET: Collage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collage collage = db.Collages.Find(id);
            if (collage == null)
            {
                return HttpNotFound();
            }
            return View(collage);
        }

        // POST: Collage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Collage collage = db.Collages.Find(id);
            db.Collages.Remove(collage);
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
