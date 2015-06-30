using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SisKarateDDD.Application.Interface;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.MVC.ViewModels;

namespace SisKarateDDD.MVC.Controllers
{
    public class TipoPessoaController : Controller
    {
        private readonly ITipoPessoaAppService _tipoPessoaApp;

        public TipoPessoaController(ITipoPessoaAppService tipoPessoaApp)
        {
            _tipoPessoaApp = tipoPessoaApp;
        }

        //
        // GET: /TipoPessoa/
        public ActionResult Index()
        {
            var tipoPessoaViewModel = Mapper.Map<IEnumerable<TipoPessoa>, IEnumerable<TipoPessoaViewModel>>(_tipoPessoaApp.GetAll());
            return View(tipoPessoaViewModel);
        }

        //
        // GET: /TipoPessoa/Details/5
        public ActionResult Details(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            var tipoPessoaViewModel = Mapper.Map<TipoPessoa, TipoPessoaViewModel>(tipoPessoa);
            return View(tipoPessoaViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoPessoaViewModel tipoPessoa)
        {
            if (ModelState.IsValid)
            {
                var tipoPessoaDomain = Mapper.Map<TipoPessoaViewModel, TipoPessoa>(tipoPessoa);
                _tipoPessoaApp.Add(tipoPessoaDomain);
                return RedirectToAction("Index");
            }
            return View(tipoPessoa);
        }

        //
        // GET: /TipoPessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            var tipoPessoaViewModel = Mapper.Map<TipoPessoa, TipoPessoaViewModel>(tipoPessoa);
            return View(tipoPessoaViewModel);
        }

        //
        // POST: /TipoPessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoPessoaViewModel tipoPessoa)
        {
            if (ModelState.IsValid)
            {
                var tipoPessoaDomain = Mapper.Map<TipoPessoaViewModel, TipoPessoa>(tipoPessoa);
                _tipoPessoaApp.Update(tipoPessoaDomain);
                return RedirectToAction("Index");
            }
            return View(tipoPessoa);
        }

        //
        // GET: /TipoPessoa/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            var tipoPessoaViewModel = Mapper.Map<TipoPessoa, TipoPessoaViewModel>(tipoPessoa);
            return View(tipoPessoaViewModel);
        }

        //
        // POST: /TipoPessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryTokenAttribute]
        public ActionResult Apagar(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            _tipoPessoaApp.Remove(tipoPessoa);

            return RedirectToAction("Index");
        }
    }
}
