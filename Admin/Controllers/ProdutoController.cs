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
    public class ProdutoController : Controller
    {
        private AdminContext con = new AdminContext();

        // GET: Produto
        public ActionResult Index()
        {
            return View(con.Produto.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = con.Produto.Find(id);
            return View(produto);
        }

        public ActionResult Back()
        {
            HomeController Home = new HomeController();
            return View(Home.Index());
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    con.Produto.Add(produto);
                    con.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var produto = con.Produto.Find(id);

            if(produto == null)
            {
                return HttpNotFound();
            }

            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    con.Entry(produto).State = EntityState.Modified;
                    con.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Produto");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
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
