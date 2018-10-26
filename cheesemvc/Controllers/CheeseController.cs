using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cheesemvc.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();

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
            Cheeses.Add(name, description);
            return Redirect("/Cheese");
        }

        [HttpPost]

        public IActionResult Delete(string[] deleteCheeses)
        {
            foreach (string cheese in deleteCheeses)
            {
                Cheeses.Remove(cheese);
            }

            return Redirect("/Cheese");

        }


    }
}