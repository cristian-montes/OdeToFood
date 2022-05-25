using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OdeToFood.Entities;

namespace OdeToFood.Pages.Restaurants
{
    public class Detail : PageModel
    {
        public Restaurant Restaurant { get; set; }
    
        public void OnGet()
        {
            Restaurant = new Restaurant();
        }
    }
}