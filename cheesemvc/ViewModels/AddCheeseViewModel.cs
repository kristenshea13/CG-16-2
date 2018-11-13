﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cheesemvc.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display (Name="Cheese Type")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description.")]
        public string Description { get; set; }



    }
}
