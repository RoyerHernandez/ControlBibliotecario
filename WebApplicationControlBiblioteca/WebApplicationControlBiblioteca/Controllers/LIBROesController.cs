using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationControlBiblioteca.Models;

namespace WebApplicationControlBiblioteca.Controllers
{
    public class LIBROesController : Controller
    {
        private ROYER_PRUEBASEntities db = new ROYER_PRUEBASEntities();

        // GET: LIBROes
        public ActionResult Index()
        {
            return View(db.LIBRO.ToList());
        }

        // GET: LIBROes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBRO lIBRO = db.LIBRO.Find(id);
            if (lIBRO == null)
            {
                return HttpNotFound();
            }
            return View(lIBRO);
        }

        // GET: LIBROes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LIBROes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_libro,nombre_libro,autor,editorial,cantidad_disponible,fecha_publicacion")] LIBRO lIBRO)
        {
            if (ModelState.IsValid)
            {
                db.LIBRO.Add(lIBRO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lIBRO);
        }

        // GET: LIBROes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBRO lIBRO = db.LIBRO.Find(id);
            if (lIBRO == null)
            {
                return HttpNotFound();
            }
            return View(lIBRO);
        }

        // POST: LIBROes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_libro,nombre_libro,autor,editorial,cantidad_disponible,fecha_publicacion")] LIBRO lIBRO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lIBRO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lIBRO);
        }

        // GET: LIBROes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LIBRO lIBRO = db.LIBRO.Find(id);
            if (lIBRO == null)
            {
                return HttpNotFound();
            }
            return View(lIBRO);
        }

        // POST: LIBROes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LIBRO lIBRO = db.LIBRO.Find(id);
            db.LIBRO.Remove(lIBRO);
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
