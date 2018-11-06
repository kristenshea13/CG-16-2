using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using cheesemvc.Models;

namespace cheesemvc.Controllers
{
    public class CheeseController : Controller
    {
        static private List<Cheese> Cheeses = new List<Cheese>();

        public IActionResult Index()
        {
            ViewBag.cheeses = Cheeses;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {


            Cheese newCheese = new Cheese
            {
                Name = name,
                Description = description
            };

            Cheeses.Add(newCheese);

            return Redirect("/Cheese");
        }

        

        //public IActionResult Delete(Cheese[] deleteCheeses)
        //{
        //    foreach (Cheese cheese in deleteCheeses)
        //    {
        //        Cheeses.Remove(cheese);
        //    }

        //    return Redirect("/Cheese");

        //}

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = Cheeses;
            return View();

        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIDs)
        {

            foreach (int cheeseID in cheeseIDs)
            {
                Cheeses.RemoveAll(x => x.CheeseID == cheeseID);
            }

            return Redirect("/");
        }


    }
}
