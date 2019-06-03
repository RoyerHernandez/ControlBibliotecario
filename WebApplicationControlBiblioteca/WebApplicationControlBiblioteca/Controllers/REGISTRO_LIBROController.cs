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
    public class REGISTRO_LIBROController : Controller
    {
        private ROYER_PRUEBASEntities db = new ROYER_PRUEBASEntities();

        // GET: REGISTRO_LIBRO
        public ActionResult Index()
        {
            var rEGISTRO_LIBRO = db.REGISTRO_LIBRO.Include(r => r.ESTUDIANTE).Include(r => r.LIBRO);
            return View(rEGISTRO_LIBRO.ToList());
        }

        // GET: REGISTRO_LIBRO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REGISTRO_LIBRO rEGISTRO_LIBRO = db.REGISTRO_LIBRO.Find(id);
            if (rEGISTRO_LIBRO == null)
            {
                return HttpNotFound();
            }
            return View(rEGISTRO_LIBRO);
        }

        // GET: REGISTRO_LIBRO/Create
        public ActionResult Create()
        {
            ViewBag.id_estudiante = new SelectList(db.ESTUDIANTE, "id_estudiante", "nombre_estudiante");
            ViewBag.id_libro = new SelectList(db.LIBRO, "id_libro", "nombre_libro");
            return View();
        }

        // POST: REGISTRO_LIBRO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_libro,id_estudiante,fecha_registro,fecha_entrega,multa,observaciones")] REGISTRO_LIBRO rEGISTRO_LIBRO)
        {
            if (ModelState.IsValid)
            {
                db.REGISTRO_LIBRO.Add(rEGISTRO_LIBRO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_estudiante = new SelectList(db.ESTUDIANTE, "id_estudiante", "nombre_estudiante", rEGISTRO_LIBRO.id_estudiante);
            ViewBag.id_libro = new SelectList(db.LIBRO, "id_libro", "nombre_libro", rEGISTRO_LIBRO.id_libro);
            return View(rEGISTRO_LIBRO);
        }

        // GET: REGISTRO_LIBRO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REGISTRO_LIBRO rEGISTRO_LIBRO = db.REGISTRO_LIBRO.Find(id);
            if (rEGISTRO_LIBRO == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_estudiante = new SelectList(db.ESTUDIANTE, "id_estudiante", "nombre_estudiante", rEGISTRO_LIBRO.id_estudiante);
            ViewBag.id_libro = new SelectList(db.LIBRO, "id_libro", "nombre_libro", rEGISTRO_LIBRO.id_libro);
            return View(rEGISTRO_LIBRO);
        }

        // POST: REGISTRO_LIBRO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_libro,id_estudiante,fecha_registro,fecha_entrega,multa,observaciones")] REGISTRO_LIBRO rEGISTRO_LIBRO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rEGISTRO_LIBRO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_estudiante = new SelectList(db.ESTUDIANTE, "id_estudiante", "nombre_estudiante", rEGISTRO_LIBRO.id_estudiante);
            ViewBag.id_libro = new SelectList(db.LIBRO, "id_libro", "nombre_libro", rEGISTRO_LIBRO.id_libro);
            return View(rEGISTRO_LIBRO);
        }

        // GET: REGISTRO_LIBRO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            REGISTRO_LIBRO rEGISTRO_LIBRO = db.REGISTRO_LIBRO.Find(id);
            if (rEGISTRO_LIBRO == null)
            {
                return HttpNotFound();
            }
            return View(rEGISTRO_LIBRO);
        }

        // POST: REGISTRO_LIBRO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            REGISTRO_LIBRO rEGISTRO_LIBRO = db.REGISTRO_LIBRO.Find(id);
            db.REGISTRO_LIBRO.Remove(rEGISTRO_LIBRO);
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
