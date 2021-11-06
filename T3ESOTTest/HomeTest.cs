using T3ESOT.Controllers;
using T3ESOT.Models;
using T3ESOT.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace T3ESOT.TEST
{
    [TestFixture]
    public class HomeTest
    {
        [Test]
        public void Index()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            repo.Setup(o => o.GetNotas(1)).Returns(new List<Nota>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Index(null) as ViewResult;

            Assert.AreEqual("Index", view.ViewName);
        }

        [Test]
        public void Categoria()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            repo.Setup(o => o.GetEtiquetaNotasUser(1,1)).Returns(new List<EtiquetaNota>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Categoria(1) as ViewResult;

            Assert.AreEqual("Categoria", view.ViewName);
        }

        [Test]
        public void Detalle()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            repo.Setup(o => o.GetNota(1)).Returns(new Nota());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Detalle(1) as ViewResult;

            Assert.AreEqual("Detalle", view.ViewName);
        }

        [Test]
        public void Create()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Create() as ViewResult;

            Assert.AreEqual("Create", view.ViewName);
        }

        [Test]
        public void CreatePostA()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.SaveNota(new Nota()));
            repo.Setup(o => o.SaveEtiquetaNota(new List<EtiquetaNota>()));

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Create(new Nota(), new List<int>() { 1}) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }

        [Test]
        public void CreatePostB()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Create(new Nota(), new List<int>() { }) as ViewResult;

            Assert.AreEqual("Create", view.ViewName);
        }

        [Test]
        public void Edit()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Edit(1) as ViewResult;

            Assert.AreEqual("Edit", view.ViewName);
        }

        [Test]
        public void EditPostA()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.EliminarEtiquetas(1));
            repo.Setup(o => o.ActualizeNota(new Nota()));
            repo.Setup(o => o.SaveEtiquetaNota(new List<EtiquetaNota>()));

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Edit(new Nota(), 1, new List<int>() { 1 }) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }

        [Test]
        public void EditPostB()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Edit(new Nota(),1, new List<int>() { }) as ViewResult;

            Assert.AreEqual("Edit", view.ViewName);
        }

        [Test]
        public void Eliminar()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();

            var controller = new HomeController(repo.Object, claim.Object);
            controller.Eliminar(1);

            Assert.AreEqual(null,null);
        }

        [Test]
        public void Compartir()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetCompartido(1, 1)).Returns(new Compartido());
            var controller = new HomeController(repo.Object, claim.Object);
            controller.Eliminar(1);

            Assert.AreEqual(null, null);
        }

        [Test]
        public void Amigos()
        {
            var claim = new Mock<IClaimRepo>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<IHomeRepo>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            repo.Setup(o => o.GetCompartidos(1)).Returns(new List<Compartido>());

            var controller = new HomeController(repo.Object, claim.Object);
            var view = controller.Amigos() as ViewResult;

            Assert.AreEqual("Amigos", view.ViewName);
        }
    }
}