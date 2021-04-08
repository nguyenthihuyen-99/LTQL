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
    public class ChitietMuonsController : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: ChitietMuons
        public ActionResult Index()
        {
            var chitietMuons = db.ChitietMuons.Include(c => c.Muons);
            return View(chitietMuons.ToList());
        }

        // GET: ChitietMuons/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChitietMuon chitietMuon = db.ChitietMuons.Find(id);
            if (chitietMuon == null)
            {
                return HttpNotFound();
            }
            return View(chitietMuon);
        }

        // GET: ChitietMuons/Create
        public ActionResult Create()
        {
            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia");
            return View();
        }

        // POST: ChitietMuons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCTmuon,Mamuon,Ngaytra,Songayquahan,Tienphat,Ghichu")] ChitietMuon chitietMuon)
        {
            if (ModelState.IsValid)
            {
                db.ChitietMuons.Add(chitietMuon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia", chitietMuon.Mamuon);
            return View(chitietMuon);
        }

        // GET: ChitietMuons/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChitietMuon chitietMuon = db.ChitietMuons.Find(id);
            if (chitietMuon == null)
            {
                return HttpNotFound();
            }
            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia", chitietMuon.Mamuon);
            return View(chitietMuon);
        }

        // POST: ChitietMuons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCTmuon,Mamuon,Ngaytra,Songayquahan,Tienphat,Ghichu")] ChitietMuon chitietMuon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chitietMuon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Mamuon = new SelectList(db.Muons, "Mamuon", "Madocgia", chitietMuon.Mamuon);
            return View(chitietMuon);
        }

        // GET: ChitietMuons/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChitietMuon chitietMuon = db.ChitietMuons.Find(id);
            if (chitietMuon == null)
            {
                return HttpNotFound();
            }
            return View(chitietMuon);
        }

        // POST: ChitietMuons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChitietMuon chitietMuon = db.ChitietMuons.Find(id);
            db.ChitietMuons.Remove(chitietMuon);
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
