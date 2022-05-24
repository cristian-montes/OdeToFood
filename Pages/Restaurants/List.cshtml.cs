using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Entities;
using OdeToFood.OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        //THERE ARE THE FIELDS OF THE CLASS.
        private readonly IConfiguration config;
        private readonly IRestaurantData restautantData;
        public string Message {get; set; }
        public IEnumerable<Restaurant> Restaurants {get; set; }
        
        // THIS IS THE CONSTRUCTOR OD THE CLASS
        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restautantData =  restaurantData;
        }
        public void OnGet()
        {
            Message = config["Message"];
            Restaurants = restautantData.GetAll();
        }
    }
}
