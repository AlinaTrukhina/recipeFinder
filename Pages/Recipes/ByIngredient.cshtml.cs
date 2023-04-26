using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace recipeFinder.Pages.Recipes
{
    public class ByIngredient : PageModel
    {
        private readonly ILogger<ByIngredient> _logger;

        public ByIngredient(ILogger<ByIngredient> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}