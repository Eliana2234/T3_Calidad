using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using T3ESOT.Models;
using T3ESOT.Repositorio;

namespace T3ESOT.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepo context;
        private readonly IClaimRepo claim;

        public AuthController(IAuthRepo context, IClaimRepo claim)
        {
            this.context = context;
            this.claim = claim;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = context.GetUser(username, password);

            if (user != null)
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Login");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                claim.SetHttpContext(HttpContext);
                claim.Login(claimsPrincipal);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Login", "Usuario o contraseña incorrectos.");
            return View("Login");
        }
        [HttpGet]
        public ActionResult Logout()
        {
            claim.SetHttpContext(HttpContext);
            claim.Logout();
            return View("Login");
        }
        
        [HttpGet]
        public ActionResult Registrar()
        {
            return View("Registrar");
        }

        [HttpPost]
        public ActionResult Registrar(User user, string passwordConf)
        {
            var username = context.GetUserUsername(user.Username);
            if (username != null)
                ModelState.AddModelError("PasswordConf", "Este usuario existe");
            if (user.Password != passwordConf)
                ModelState.AddModelError("PasswordConf", "Las contraseñas no coinciden");

            if (ModelState.IsValid)
            {
                context.SaveUser(user);
                return RedirectToAction("Login");
            }
            return View("Registrar", user);
        }
    }
}