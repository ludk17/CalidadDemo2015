using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DEMO2015.Models;

namespace DEMO2015.Repositories
{
    public class ProductoRepository
    {
        List<Product> productos = new List<Product>{
            new Product{ Id = 1, Nombre = "XboxOne", Precio = 1500, Stock = 10 },
            new Product{ Id = 2, Nombre = "PS4", Precio = 2500, Stock = 10 },
            new Product{ Id = 3, Nombre = "Wii", Precio = 1000, Stock = 10 },
            new Product{ Id = 4, Nombre = "Nintendo 3DS", Precio = 700, Stock = 10 },
            new Product{ Id = 5, Nombre = "Ouya", Precio = 500, Stock = 10 },
        };
        public Product Find(int id)
        {
            return productos.FirstOrDefault(o => o.Id == id);
        }
    }
}