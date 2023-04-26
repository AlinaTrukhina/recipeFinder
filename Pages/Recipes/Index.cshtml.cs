using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using recipeFinder.Data;
using recipeFinder.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace recipeFinder.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly recipeFinder.Data.RazorPagesRecipeContext _context;

        public IndexModel(recipeFinder.Data.RazorPagesRecipeContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? RecipeTitle { get; set; }

        public async Task OnGetAsync()
        {
            var recipes = from r in _context.Recipe
                            select r;
                
            if (!string.IsNullOrEmpty(SearchString))
            {
                recipes = recipes.Where(s => s.Title.Contains(SearchString));
            }

            Recipe = await recipes.ToListAsync();
        }
    }
}
