using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEMO2015.Models
{
    public class Venta
    {
        public int Id { get; set; }

        public int NumeroVenta { get; set; }

        public DateTime FechaVenta { get; set; }

        public int ClienteId { get; set; }

        public List<Product> Productos { get; set; }
    }
}