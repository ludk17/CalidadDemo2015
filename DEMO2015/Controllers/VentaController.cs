using DEMO2015.Models;
using DEMO2015.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO2015.Controllers
{
    public class VentaController : Controller
    {
        public ProductoRepository pRepository;
        public VentaController()
        {
            pRepository = new ProductoRepository();
        }
        // GET: Venta
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddProducto(int id, int index)
        {
            var producto = pRepository.Find(id);
            ViewBag.Index = index;
            return PartialView(producto);
        }

        [HttpPost]

        public ViewResult Store(Venta venta)
        {            
            //guardar venta
            return null;
        }

        [HttpGet]
        public double Multiplicar(int numero)
        {
            return numero * 524;
        }
    }
}