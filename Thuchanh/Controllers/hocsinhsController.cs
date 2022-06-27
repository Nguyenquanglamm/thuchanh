using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Thuchanh.Models;

namespace Thuchanh.Controllers
{
   [Authorize]
    public class hocsinhsController : Controller
    {
        private thuchanhDBcontext db = new thuchanhDBcontext();

        // GET: hocsinhs
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Hocsinhs.ToList());
        }

        // GET: hocsinhs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hocsinh hocsinh = db.Hocsinhs.Find(id);
            if (hocsinh == null)
            {
                return HttpNotFound();
            }
            return View(hocsinh);
        }

        // GET: hocsinhs/Create
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: hocsinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,address")] hocsinh hocsinh)
        {
            if (ModelState.IsValid)
            {
                db.Hocsinhs.Add(hocsinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hocsinh);
        }

        // GET: hocsinhs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hocsinh hocsinh = db.Hocsinhs.Find(id);
            if (hocsinh == null)
            {
                return HttpNotFound();
            }
            return View(hocsinh);
        }

        // POST: hocsinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,address")] hocsinh hocsinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hocsinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hocsinh);
        }

        // GET: hocsinhs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            hocsinh hocsinh = db.Hocsinhs.Find(id);
            if (hocsinh == null)
            {
                return HttpNotFound();
            }
            return View(hocsinh);
        }

        // POST: hocsinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            hocsinh hocsinh = db.Hocsinhs.Find(id);
            db.Hocsinhs.Remove(hocsinh);
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
