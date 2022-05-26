using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OdeToFood.Entities;
using OdeToFood.OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class Detail : PageModel
    {
        private readonly IRestaurantData restaurantData;

        public Restaurant Restaurant {get; set; }
    
        public Detail(IRestaurantData restaurantData)
        {
            this.restaurantData =  restaurantData;
        }
        public void OnGet(int restaurantId)
        {
            Restaurant = restaurantData.GetById(restaurantId);
        }
    }
}