using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace OdeToFood.Pages.Restaurants
{
    public class NotFound : PageModel
    {
        private readonly ILogger<NotFound> _logger;

        public NotFound(ILogger<NotFound> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}