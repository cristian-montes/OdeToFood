using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OdeToFood.OdeToFood.Data;
using OdeToFood.Entities;

namespace OdeToFood.Pages.Restaurants
{
    public class Edit : PageModel
    {
      
        private readonly IRestaurantData restaurantData;
        public Restaurant Restaurant {get; set; }

        public Edit(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }


      public IActionResult OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if(Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
       }
    }
}