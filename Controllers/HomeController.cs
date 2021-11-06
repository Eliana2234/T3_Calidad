using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using T3ESOT.Models;
using T3ESOT.Repositorio;

namespace T3ESOT.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeRepo context;
        private readonly IClaimRepo claim;

        public HomeController(IHomeRepo context, IClaimRepo claim)
        {
            this.context = context;
            this.claim = claim;
        }

        [HttpGet]
        public IActionResult Index(string search)
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            ViewBag.Etiquetitas = context.GetEtiquetaNotas();
            ViewBag.Usuarios = context.GetUsersC(LoggedUser().Id);
            var notas = context.GetNotas(LoggedUser().Id);
            if (!String.IsNullOrEmpty(search))
                notas = notas.Where(o => o.Titulo.Contains(search) || o.Cuerpo.Contains(search)).ToList();
            return View("Index", notas);
        }

        [HttpGet]
        public IActionResult Categoria(int idCategoria)
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            ViewBag.Etiquetitas = context.GetEtiquetaNotas();
            var etiqueta = context.GetEtiquetaNotasUser(LoggedUser().Id, idCategoria);
            ViewBag.Usuarios = context.GetUsersC(LoggedUser().Id);
            return View("Categoria", etiqueta);
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            ViewBag.Etiquetitas = context.GetEtiquetaNotas();
            var nota = context.GetNota(id);
            return View("Detalle", nota);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            return View("Create", new Nota());
        }
        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            nota.Fecha = DateTime.Now;
            List<EtiquetaNota> etic = new List<EtiquetaNota>();

            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta", "Seleccione por lo menos uno");

            nota.IdUser = LoggedUser().Id;

            if (ModelState.IsValid)
            {
                context.SaveNota(nota);
                foreach (var item in etiqueta)
                {
                    var etique = new EtiquetaNota
                    {
                        IdEtiqueta = item,
                        IdNota = nota.Id
                    };
                    etic.Add(etique);
                }
                context.SaveEtiquetaNota(etic);
                return RedirectToAction("Index");
            }
            ViewBag.Etiquetas = context.GetEtiquetas();
            return View("Create", nota);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            var nota = context.GetNota(id);
            return View("Edit", nota);
        }
        [HttpPost]
        public IActionResult Edit(Nota nota, int idE, List<int> etiqueta)
        {
            nota.Fecha = DateTime.Now;
            List<EtiquetaNota> etic = new List<EtiquetaNota>();

            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta", "Seleccione por lo menos uno");
            nota.IdUser = LoggedUser().Id;
            if (ModelState.IsValid)
            {
                context.EliminarEtiquetas(idE);
                context.ActualizeNota(nota);

                foreach (var item in etiqueta)
                {
                    var etique = new EtiquetaNota();
                    etique.IdEtiqueta = item;
                    etique.IdNota = nota.Id;
                    etic.Add(etique);
                }
                context.SaveEtiquetaNota(etic);
                return RedirectToAction("Index");
            }
            ViewBag.Etiquetas = context.GetEtiquetas();
            return View("Edit", nota);
        }

        [HttpGet]
        public void Eliminar(int id)
        {
            context.EliminarNota(id);
        }

        [HttpPost]
        public void Compartir(Compartido comparte)
        {
            var compartido = context.GetCompartido(comparte.IdNota, comparte.IdUser);
            if (compartido != null)
                ModelState.AddModelError("Compartido", "Ya se compartio la nota al usuario");
            if (ModelState.IsValid)
            {
                context.SaveCompartido(comparte);
            }
        }

        [HttpGet]
        public IActionResult Amigos()
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            ViewBag.Etiquetitas = context.GetEtiquetaNotas();
            var compartido = context.GetCompartidos(LoggedUser().Id);
            return View("Amigos", compartido);
        }

        protected User LoggedUser()
        {
            claim.SetHttpContext(HttpContext);
            var user = claim.GetLoggedUser();
            return user;
        }
    }
}
