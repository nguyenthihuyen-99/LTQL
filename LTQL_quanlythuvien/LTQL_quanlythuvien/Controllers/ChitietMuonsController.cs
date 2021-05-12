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
    public class ChiTietMuonsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: ChiTietMuons
        public ActionResult Index()
        {
            var chitietMuons = db.ChitietMuons.Include(c => c.Muons);
            return View(chitietMuons.ToList());
        }

        // GET: ChiTietMuons/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietMuon chiTietMuon = db.ChitietMuons.Find(id);
            if (chiTietMuon == null)
            {
                return HttpNotFound();
            }
            return View(chiTietMuon);
        }

        // GET: ChiTietMuons/Create
        public ActionResult Create()
        {
            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia");
            return View();
        }

        // POST: ChiTietMuons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTmuon,Mamuon,Ngaytra,Songayquahan,Tienphat,Ghichu")] ChiTietMuon chiTietMuon)
        {
            if (ModelState.IsValid)
            {
                db.ChitietMuons.Add(chiTietMuon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia", chiTietMuon.Mamuon);
            return View(chiTietMuon);
        }

        // GET: ChiTietMuons/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietMuon chiTietMuon = db.ChitietMuons.Find(id);
            if (chiTietMuon == null)
            {
                return HttpNotFound();
            }
            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia", chiTietMuon.Mamuon);
            return View(chiTietMuon);
        }

        // POST: ChiTietMuons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTmuon,Mamuon,Ngaytra,Songayquahan,Tienphat,Ghichu")] ChiTietMuon chiTietMuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietMuon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia", chiTietMuon.Mamuon);
            return View(chiTietMuon);
        }

        // GET: ChiTietMuons/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietMuon chiTietMuon = db.ChitietMuons.Find(id);
            if (chiTietMuon == null)
            {
                return HttpNotFound();
            }
            return View(chiTietMuon);
        }

        // POST: ChiTietMuons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChiTietMuon chiTietMuon = db.ChitietMuons.Find(id);
            db.ChitietMuons.Remove(chiTietMuon);
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
