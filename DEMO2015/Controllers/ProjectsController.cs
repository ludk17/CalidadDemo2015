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
        public ViewResult Index()
        {            
            return View("Inicio");
        }

        [HttpPost]
        public string Guardar(Persona o)
        {
            var r = new PersonaRepository();
            r.save(o);
            return String.Format("Id: {0}, Name: {1}, Lastname: {2}, age: {3}, sexo: {4}, comentarios: {5}", o.id, o.name, o.lastname, o.age, o.gender, o.comments);
        }

        [HttpGet]        
        public string Create()
        {
            return "Create";
        }

        [HttpGet]
        public ViewResult Show(int id)
        {
            var r = new PersonaRepository();
            
            var persona = r.Find(id);

            return View("Show", persona);
        }
    }
}