using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisKarateDDD.MVC.Controllers
{
    public class TipoPessoaController : Controller
    {
        //
        // GET: /TipoPessoa/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /TipoPessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TipoPessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoPessoa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TipoPessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TipoPessoa/Delete/5
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
