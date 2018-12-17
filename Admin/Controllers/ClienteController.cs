using Admin.Context;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers
{
    public class ClienteController : Controller
    {
        private AdminContext con = new AdminContext();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(con.Cliente.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var cliente = con.Cliente.Find(id);
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    con.Cliente.Add(cliente);
                    con.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Create");
            }
            catch
            {
                return View(cliente);
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var cliente = con.Cliente.Find(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here

                if (ModelState.IsValid)
                {
                    con.Entry(cliente).State = EntityState.Modified;
                    con.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Cliente");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
