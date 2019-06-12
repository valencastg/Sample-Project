using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAuth.Models;

namespace MVCAuth.Controllers
{
    public class ContactGVCsController : Controller
    {
        private ContactGVCDcContext db = new ContactGVCDcContext();

        // GET: ContactGVCs
        public ActionResult Index()
        {
            return View(db.ContactGVC.ToList());
        }

        // GET: ContactGVCs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactGVC contactGVC = db.ContactGVC.Find(id);
            if (contactGVC == null)
            {
                return HttpNotFound();
            }
            return View(contactGVC);
        }

        // GET: ContactGVCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactGVCs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Phone,Email,Birthday")] ContactGVC contactGVC)
        {
            if (ModelState.IsValid)
            {
                db.ContactGVC.Add(contactGVC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactGVC);
        }

        // GET: ContactGVCs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactGVC contactGVC = db.ContactGVC.Find(id);
            if (contactGVC == null)
            {
                return HttpNotFound();
            }
            return View(contactGVC);
        }

        // POST: ContactGVCs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Phone,Email,Birthday")] ContactGVC contactGVC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactGVC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactGVC);
        }

        // GET: ContactGVCs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactGVC contactGVC = db.ContactGVC.Find(id);
            if (contactGVC == null)
            {
                return HttpNotFound();
            }
            return View(contactGVC);
        }

        // POST: ContactGVCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactGVC contactGVC = db.ContactGVC.Find(id);
            db.ContactGVC.Remove(contactGVC);
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
