using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using stockDosp.Models;

namespace stockDosp.Controllers
{
    public class CargoController : Controller
    {
        stockDospEntities1 entidad = new stockDospEntities1();
        // GET: Cargo
        public ActionResult Index()
        {
            var listadoCargos = entidad.cargo;
            return View(listadoCargos.ToList());
        }
        public ActionResult ListadoCargo()
        {

            var listadoCargos = entidad.cargo;
            return View(listadoCargos.ToList());

        }
        public ActionResult Personal(string cargo)
        {

            var personal = from p in entidad.usuario where p.cargo.nombre_cargo == cargo select p;
            return View(personal.ToList());

        }
        public ActionResult ListadoPersonal()
        {

            var personal = from p in entidad.usuario
                           join c in entidad.cargo
                           on p.id_cargo equals c.id_cargo
                           select new Usuarios
                           { 
                            id = p.id_usuario,
                            rut = p.rut_usuario,
                            nombre = p.nombre_usuario,
                            apellido = p.apellido_usuario,
                            telefono = p.telefono,
                            cargo = c.nombre_cargo
                           };

            return View(personal.ToList());






        }
    }
}