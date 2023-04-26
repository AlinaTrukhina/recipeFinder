using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using recipeFinder.Data;
using recipeFinder.Models;

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

        public async Task OnGetAsync()
        {
            if (_context.Recipe != null)
            {
                Recipe = await _context.Recipe.ToListAsync();
            }
        }
    }
}
