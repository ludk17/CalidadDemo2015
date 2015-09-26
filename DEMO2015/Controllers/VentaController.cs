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
        public PartialViewResult AddProducto(int id)
        {
            var producto = pRepository.Find(id);
            return PartialView(producto);
        }
        public double Multiplicar(int numero)
        {
            return numero * 524;
        }
    }
}