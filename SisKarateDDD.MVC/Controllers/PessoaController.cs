using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SisKarateDDD.Domain.Entities;
using SisKarateDDD.Domain.Interfaces.Services;
using SisKarateDDD.Domain.Services;
using SisKarateDDD.Infra.Data.Repositories;
using SisKarateDDD.MVC.ViewModels;

namespace SisKarateDDD.MVC.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaService _pessoaService = new PessoaService(new PessoaRepository());

       // public PessoaController(IPessoaService pessoaService)
       // {
       //     _pessoaService = pessoaService;
       // //}

        //
        // GET: /Pessoa/
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaService.GetAll());
            return View(pessoaViewModel);
        }

        //
        // GET: /Pessoa/Details/5
        public ActionResult Details(int id)
        {
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(_pessoaService.GetById(id));
            return View(pessoaViewModel);
        }

        //
        // GET: /Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaService.Add(pessoaDomain);
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(_pessoaService.GetById(id));
            return View(pessoaViewModel);
        }

        //
        // POST: /Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaService.Update(pessoaDomain);
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(_pessoaService.GetById(id));
            return View(pessoaViewModel);
        }

        //
        // POST: /Pessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryTokenAttribute]
        public ActionResult Apagar(int id)
        {
                var tipoPessoa = _pessoaService.GetById(id);
                _pessoaService.Update(tipoPessoa);
                return RedirectToAction("Index");
        }
    }
}
