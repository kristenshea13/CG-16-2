using cheesemvc.Models;
using cheesemvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cheesemvc.Controllers
{
    public class CheeseController : Controller
    {
        public IActionResult Index()
        {
            List<Cheese> cheeses = CheeseData.GetAll();
            return View(cheeses);
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            return View(addCheeseViewModel);
        }

        [HttpPost]
        
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if(ModelState.IsValid)
            {
                Cheese newCheese = new Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type
                };

                CheeseData.Add(newCheese);

                return Redirect("/Cheese");
            }

            return View(addCheeseViewModel);
            
        }

        

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
            Cheese cheese = CheeseData.GetById(cheeseID);
            

            ViewBag.name = cheese.Name;
            ViewBag.description = cheese.Description;
            ViewBag.cheeseID = cheese.CheeseID;
            return View();
            //ask CheeseData for the object with the given cheeseId and put it in the ViewBag.
        }

        [HttpPost]
        public IActionResult Edit(int cheeseID, string name, string description)
        {
            //not complete

            Cheese cheese = CheeseData.GetById(cheeseID);

            cheese.Name = name;
            cheese.Description = description;
            

                return Redirect("/");

        }




    }
}