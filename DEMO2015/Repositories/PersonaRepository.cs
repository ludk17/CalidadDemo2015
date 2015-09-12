using DEMO2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEMO2015.Repositories
{
    public class PersonaRepository
    {      
        
        public Persona Find(int id)
        {

            return new Persona
            {
                id = 1,
                name = "Paolo",
                lastname = "Guerrero",
                age = 150
            };

        }

        public void save(Persona persona)
        {
            // Save
        }
    }
}