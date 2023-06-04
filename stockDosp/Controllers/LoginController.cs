using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stockDosp.Models;

namespace stockDosp.Controllers
{
    public class LoginController : Controller
    {
        stockDospEntities1 pass = new stockDospEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Validar(string rut, string contraseña)
        {
            login us = pass.login.FirstOrDefault(d => d.rut_usuario == rut & d.clave == contraseña);
            if (us !=null )
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("NoHallado", "login");

            }
        }
        public ActionResult NoHallado()
        {
            ViewBag.Error = "No se encontró al usuario";
            return View();
        }
    }

}