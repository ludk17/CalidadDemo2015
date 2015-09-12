using DEMO2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO2015.Controllers
{
    public class ProductController : Controller
    {
       public ViewResult Create()
       {
            return View("Create");
       }

       [HttpPost]
       public ViewResult Create(Product o)
       {
           return View("Create2", o);
       }
    }
}