using Clinica.Context;
using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Clinica.Controllers
{
    public class PrestadoresController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Prestadores
        public ActionResult Index()
        {
            return View(context.Veterinarios.OrderBy(c => c.VeterinarioId));
        }

        // GET: Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Veterinario veterinario)
        {
            context.Veterinarios.Add(veterinario);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: Veterinario/Edit/5
        [HttpGet]
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinario veterinario = context.Veterinarios.Find(id);
            if (veterinario == null)
            {
                return HttpNotFound();
            }
            return View(veterinario);
        }

        // POST: Veterinario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Veterinario veterinario)
        {
            if (ModelState.IsValid)
            {
                context.Entry(veterinario).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(veterinario);
        }
        // GET: Veterinario/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinario veterinario = context.Veterinarios.Find(id);
            if (veterinario == null)
            {
                return HttpNotFound();
            }
            return View(veterinario);
        }
        //GET: Veterinario/Delete/5
        [HttpGet]
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veterinario veterinario = context.Veterinarios.Find(id);
            if (veterinario == null)
            {
                return HttpNotFound();
            }
            return View(veterinario);
        }
        //POST: Veterinario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Veterinario veterinario = context.Veterinarios.Find(id);
            context.Veterinarios.Remove(veterinario);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}