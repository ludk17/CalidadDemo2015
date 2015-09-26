using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEMO2015.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
}