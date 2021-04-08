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
    public class DocgiasController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: Docgias
        public ActionResult Index()
        {
            return View(db.Docgias.ToList());
        }

        // GET: Docgias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docgia docgia = db.Docgias.Find(id);
            if (docgia == null)
            {
                return HttpNotFound();
            }
            return View(docgia);
        }

        // GET: Docgias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Docgias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Madocgia,Tendocgia,Mamuon,Ngaysinh,Ghichu")] Docgia docgia)
        {
            if (ModelState.IsValid)
            {
                db.Docgias.Add(docgia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(docgia);
        }

        // GET: Docgias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docgia docgia = db.Docgias.Find(id);
            if (docgia == null)
            {
                return HttpNotFound();
            }
            return View(docgia);
        }

        // POST: Docgias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Madocgia,Tendocgia,Mamuon,Ngaysinh,Ghichu")] Docgia docgia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(docgia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(docgia);
        }

        // GET: Docgias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Docgia docgia = db.Docgias.Find(id);
            if (docgia == null)
            {
                return HttpNotFound();
            }
            return View(docgia);
        }

        // POST: Docgias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Docgia docgia = db.Docgias.Find(id);
            db.Docgias.Remove(docgia);
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
