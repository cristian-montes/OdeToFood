using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OdeToFood.OdeToFood.Data;
using OdeToFood.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OdeToFood.Pages.Restaurants
{
    public class Edit : PageModel
    {
      
        private readonly IRestaurantData restaurantData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Restaurant Restaurant {get; set; }
        public IEnumerable<SelectListItem> Cuisines {get; set; }

        public Edit(IRestaurantData restaurantData, IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }


      public IActionResult OnGet(int restaurantId)
        {
            Cuisines  = htmlHelper.GetEnumSelectList<CuisineType>();
            Restaurant = restaurantData.GetById(restaurantId);
            if(Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
       }


        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                restaurantData.Update(Restaurant);
                restaurantData.Commit();
                return RedirectToPage("./Detail", new { restaurantId = Restaurant.Id});
            }
            Cuisines  = htmlHelper.GetEnumSelectList<CuisineType>();
            return Page();
        }


    }
}