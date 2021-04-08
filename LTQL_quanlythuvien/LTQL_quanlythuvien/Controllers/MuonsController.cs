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
    public class MuonsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: Muons
        public ActionResult Index()
        {
            return View(db.Muons.ToList());
        }

        // GET: Muons/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muon muon = db.Muons.Find(id);
            if (muon == null)
            {
                return HttpNotFound();
            }
            return View(muon);
        }

        // GET: Muons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Muons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mamuon,Madocgia,Masach,MaNV,Ngaymuon,Hanphaitra,Ghichu")] Muon muon)
        {
            if (ModelState.IsValid)
            {
                db.Muons.Add(muon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(muon);
        }

        // GET: Muons/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muon muon = db.Muons.Find(id);
            if (muon == null)
            {
                return HttpNotFound();
            }
            return View(muon);
        }

        // POST: Muons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mamuon,Madocgia,Masach,MaNV,Ngaymuon,Hanphaitra,Ghichu")] Muon muon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(muon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(muon);
        }

        // GET: Muons/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muon muon = db.Muons.Find(id);
            if (muon == null)
            {
                return HttpNotFound();
            }
            return View(muon);
        }

        // POST: Muons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Muon muon = db.Muons.Find(id);
            db.Muons.Remove(muon);
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
