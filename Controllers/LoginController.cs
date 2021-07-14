using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Turnos.Models;

namespace Turnos.Controllers
{
    public class LoginController : Controller
    {
        private readonly TurnosContext _context;

        public LoginController(TurnosContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                string passwordEncriptado = Encriptar(login.Password);

                var loginBD = _context.Login.Where(l => l.Usuario == login.Usuario && l.Password == passwordEncriptado).FirstOrDefault();

                if(loginBD != null)
                {
                    HttpContext.Session.SetString("usuario", loginBD.Usuario);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["errorLogin"] = "Los datos ingresados son incorrectos";
                    return View("Index");
                }
            }
            return View("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        public string Encriptar(string texto)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes =sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                var stringBuilder = new StringBuilder();

                for(var i=0; i<bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("X2"));
                }

                return stringBuilder.ToString();

            }

        }
    }
}
