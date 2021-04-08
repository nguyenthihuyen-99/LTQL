using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_quanlythuvien.Models;

namespace LTQL_quanlythuvien.Controllers
{
    public class nghenghiepsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: nghenghieps
        public ActionResult Index()
        {
            return View(db.nghenghieps.ToList());
        }

        // GET: nghenghieps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nghenghiep nghenghiep = db.nghenghieps.Find(id);
            if (nghenghiep == null)
            {
                return HttpNotFound();
            }
            return View(nghenghiep);
        }

        // GET: nghenghieps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nghenghieps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CCCD,congty,hoten")] nghenghiep nghenghiep)
        {
            if (ModelState.IsValid)
            {
                db.nghenghieps.Add(nghenghiep);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nghenghiep);
        }

        // GET: nghenghieps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nghenghiep nghenghiep = db.nghenghieps.Find(id);
            if (nghenghiep == null)
            {
                return HttpNotFound();
            }
            return View(nghenghiep);
        }

        // POST: nghenghieps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CCCD,congty,hoten")] nghenghiep nghenghiep)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nghenghiep).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nghenghiep);
        }

        // GET: nghenghieps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nghenghiep nghenghiep = db.nghenghieps.Find(id);
            if (nghenghiep == null)
            {
                return HttpNotFound();
            }
            return View(nghenghiep);
        }

        // POST: nghenghieps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nghenghiep nghenghiep = db.nghenghieps.Find(id);
            db.nghenghieps.Remove(nghenghiep);
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
