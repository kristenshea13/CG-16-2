using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cheesemvc.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CheeseID { get; set; }
        private static int nextID = 1;

        public Cheese (string name, string description)
        {
            Name = name;
            Description = description;

        }

        public Cheese ()
        {
            CheeseID = nextID;
            nextID++;
        }


    }
}
