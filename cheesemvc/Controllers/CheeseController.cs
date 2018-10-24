using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cheesemvc.Controllers
{
    public class CheeseController : Controller
    {
        static private List<string> Cheeses = new List<string>();

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
        public IActionResult NewCheese(string name)
        {
            Cheeses.Add(name);
            return Redirect("/Cheese");
        }
    }
}