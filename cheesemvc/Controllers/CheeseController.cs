using cheesemvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cheesemvc.Controllers
{
    public class CheeseController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();
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

            CheeseData.Add(newCheese);

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
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIDs)
        {
            foreach (int cheeseID in cheeseIDs)
            {
                CheeseData.Remove(cheeseID);
            }

            return Redirect("/");
        }
    }
}