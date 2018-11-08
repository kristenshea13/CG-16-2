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
        public IActionResult NewCheese(Cheese newCheese)
        {
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



        public IActionResult Edit(int cheeseID)
        {
            ViewBag.cheeses = CheeseData.GetById(cheeseID);
            return View();
            //ask CheeseData for the object with the given cheeseId and put it in the ViewBag.
        }

        [HttpPost]
        public IActionResult Edit(int cheeseID, string name, string description)
        {
            //not complete

            
            
            




                return Redirect("/");

        }




    }
}