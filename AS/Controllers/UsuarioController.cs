using Alpaca_Smith.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpaca_Smith.Controllers
{
    public class UsuarioController : Controller
    {
        
        [HttpPost]
        public ActionResult Login (string email, string password)
        {
            using (Alpaca_SmithContext db = new Alpaca_SmithContext())
            {
                Usuarios usuario =
                    db.Usuarios.FirstOrDefault(u => u.Mail == email && u.Password == password);
                if(usuario != null)
                {
                    Session["UsuarioLogueado"] = usuario;
                }
                else
                {
                    TempData["Error"] = "El usuario no existe o la contraseña es incorrecta";
                }
            }
                return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public string Prueba()
        {
            using (Alpaca_SmithContext db = new Models.Alpaca_SmithContext())
            {
                Usuarios nuevoUsuario = new Usuarios();
                nuevoUsuario.Mail = "nataliarochawilson@gmail.com";
                nuevoUsuario.Password = "123";
                nuevoUsuario.Nombre = "Natalia";
                nuevoUsuario.Apellido = "Rocha Wilson";
                nuevoUsuario.FechaDeNacimiento = DateTime.Now;
                nuevoUsuario.Telefono = "39720638";
                nuevoUsuario.Direccion = "MarceloT 2127";

                Usuarios nuevoUsuario2 = new Usuarios();
                nuevoUsuario2.Mail = "valen.belmonte@gmail.com";
                nuevoUsuario2.Password = "123";
                nuevoUsuario2.Nombre = "Valentin";
                nuevoUsuario2.Apellido = "Belmonte";
                nuevoUsuario2.FechaDeNacimiento = DateTime.Now;
                nuevoUsuario2.Telefono = "30821357";
                nuevoUsuario2.Direccion = "Quintana 50";

                db.Usuarios.Add(nuevoUsuario);
                db.Usuarios.Add(nuevoUsuario2);
                db.SaveChanges();
            }
            return "OK";
        }
    }
}