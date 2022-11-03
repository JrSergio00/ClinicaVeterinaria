using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.OleDb;
using System.Data.Entity;
using Clinica.Context;

namespace Clinica.Controllers
{
    public class ProcedimentosController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Procedimentos
        public ActionResult Index()
        {
            return View(context.Consultas.OrderBy(c => c.ConsultaId));
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
        public ActionResult Create(Consulta consulta)
        {
            context.Consultas.Add(consulta);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET: Consultas/Edit/5
        [HttpGet]
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = context.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        // POST: Consulta/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                context.Entry(consulta).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consulta);
        }

        // GET: Consulta/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = context.Consultas.Find(id);
            //Consulta consulta = (Consulta)context.Consultas.Where(f => f.ConsultaId == id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        //GET: Consulta/Delete/5
        [HttpGet]
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulta consulta = context.Consultas.Find(id);
            if (consulta == null)
            {
                return HttpNotFound();
            }
            return View(consulta);
        }

        //POST: Consulta/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Consulta consulta = context.Consultas.Find(id);
            context.Consultas.Remove(consulta);
            context.SaveChanges();
            //TempData["Message"] = "Consulta " + consulta.ConsultaId.ToUpper() + " foi removida";
            return RedirectToAction("Index");
        }
    }
}