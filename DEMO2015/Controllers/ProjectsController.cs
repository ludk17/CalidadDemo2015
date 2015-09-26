using DEMO2015.Models;
using DEMO2015.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO2015.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        public PartialViewResult Index()
        {
            ViewBag.paises = new List<Pais>();
            return PartialView("Inicio");
        }

        [HttpGet]
        public PartialViewResult Item()
        {
            return PartialView("Item");
        }

        [HttpPost]
        public string Guardar(Persona o)
        {
            var r = new PersonaRepository();
            r.save(o);
            return String.Format("Id: {0}, Name: {1}, Lastname: {2}, age: {3}, sexo: {4}, comentarios: {5}, habilidades : {6}", 
                o.id, o.name, o.lastname, o.age, o.gender, o.comments, String.Join(", ", o.habilities));
        }

        [HttpPost]
        public ViewResult addPais(int pais_select)
        {
            ViewBag.paises = new List<Pais>{
                new Pais { name = "Perú", code = "+51"}
            };
            return View("Inicio");
        }

        [HttpGet]        
        public string Create()
        {
            return "Create";
        }

        [HttpGet]
        public PartialViewResult Show(int id)
        {
            var r = new PersonaRepository();
            
            var persona = r.Find(id);

            return PartialView("Show", persona);
        }
    }
}