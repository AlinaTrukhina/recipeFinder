using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using recipeFinder.Models;

namespace recipeFinder.Data
{
    public class RazorPagesRecipeContext : DbContext
    {
        public RazorPagesRecipeContext (DbContextOptions<RazorPagesRecipeContext> options)
            : base(options)
        {
        }

        public DbSet<recipeFinder.Models.Recipe> Recipe { get; set; } = default!;
    }
}
