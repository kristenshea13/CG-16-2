using System.Collections.Generic;
using System.Linq;

namespace cheesemvc.Models
{
    public class CheeseData
    {
        static private List<Cheese> cheeses = new List<Cheese>();

        //getall
        public static List<Cheese> GetAll()
        {
            return cheeses;
        }

        //add
        public static void Add(Cheese newCheese)
        {
            cheeses.Add(newCheese);
        }

        //remove

        public static void Remove(int id)
        {

            Cheese cheeseToRemove = GetById(id);
            cheeses.Remove(cheeseToRemove);
        }



        //getbyID
        public static Cheese GetById(int id)
        {
            return cheeses.Single(x => x.CheeseID == id);
        }


    }
}