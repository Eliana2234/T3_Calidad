using T3ESOT.Controllers;
using T3ESOT.Models;
using T3ESOT.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3ESOT.TEST
{
    [TestFixture]
    class AuthTest
    {
        [Test]
        public void LoginGet()
        {
            var controller = new AuthController(null, null);
            var view = controller.Login() as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }
        [Test]
        public void LoginPostGood()
        {
            var repo = new Mock<IAuthRepo>();
            repo.Setup(o => o.GetUser("User", "user")).Returns(new User());

            var claim = new Mock<IClaimRepo>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Login("User", "user") as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }

        [Test]
        public void LoginPostBad()
        {
            var repo = new Mock<IAuthRepo>();
            repo.Setup(o => o.GetUser("User", "user")).Returns(new User());

            var claim = new Mock<IClaimRepo>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Login(null, null) as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }

        [Test]
        public void Logout()
        {
            var claim = new Mock<IClaimRepo>();

            var controller = new AuthController(null, claim.Object);
            var view = controller.Logout() as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }

        [Test]
        public void RegisterGet()
        {
            var controller = new AuthController(null, null);
            var view = controller.Registrar() as ViewResult;

            Assert.AreEqual("Registrar", view.ViewName);
        }

        [Test]
        public void RegisterPostGood()
        {
            var repo = new Mock<IAuthRepo>();
            repo.Setup(o => o.GetUserUsername("hola")).Returns(new User());
            repo.Setup(o => o.SaveUser(new User()));
            var claim = new Mock<IClaimRepo>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Registrar(new User() { Password = "user" }, "user") as RedirectToActionResult;

            Assert.AreEqual("Login", view.ActionName);
        }

        [Test]
        public void RegisterPostBad()
        {
            var repo = new Mock<IAuthRepo>();
            repo.Setup(o => o.GetUserUsername("hola")).Returns(new User());

            var claim = new Mock<IClaimRepo>();

            var controller = new AuthController(repo.Object, claim.Object);
            var view = controller.Registrar(new User() { Password = "1223" }, "1234") as ViewResult;

            Assert.AreEqual("Registrar", view.ViewName);
        }
    }
}
