using DEMO2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEMO2015.Repositories
{
    public class PersonaRepository
    {

        private List<Persona> personas = new List<Persona>{
            new Persona { id = 1, name = "Paolo", lastname = "Guerrero", age = 150},
            new Persona { id = 2, name = "Lionel", lastname = "Messi", age = 150},
            new Persona { id = 3, name = "Cristiano", lastname = "Ronaldo", age = 150},
            new Persona { id = 4, name = "Claudio", lastname = "Pizarro", age = 150},
            new Persona { id = 5, name = "Reimond", lastname = "Manco", age = 150},
            new Persona { id = 6, name = "Negro", lastname = "Mama", age = 150},
        };
        
        public Persona Find(int id)
        {
            return personas.FirstOrDefault(item => item.id == id);
        }

        public void save(Persona persona)
        {
            // Save
        }
    }
}