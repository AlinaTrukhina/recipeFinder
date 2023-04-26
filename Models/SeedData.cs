using Microsoft.EntityFrameworkCore;
using recipeFinder.Data;

namespace recipeFinder.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesRecipeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesRecipeContext>>()))
        {
            if (context == null || context.Recipe == null)
            {
                throw new ArgumentNullException("Null RazorPagesRecipeContext");
            }

            // Look for any recipes.
            if (context.Recipe.Any())
            {
                return;   // DB has been seeded
            }


            context.Recipe.AddRange(
                new Recipe
                {
                    Title = "Carrot Cake",
                    AddedDate = DateTime.Parse("1989-2-12"),
                    ImgUrl = "https://www.glorioustreats.com/wp-content/uploads/2014/05/best-carrot-cake-recipe-square.jpeg",
                    Ingredients = "Carrots, flour, nuts",
                    Instructions = "Cut up carrots. Bake cake."
                },

                new Recipe
                {
                    Title = "Apple Pie",
                    AddedDate = DateTime.Parse("1984-3-13"),
                    ImgUrl = "https://www.momlovesbaking.com/wp-content/uploads/2020/08/Best-Ever-Apple-Pie-SQ.jpg",
                    Ingredients = "Apples, dough",
                    Instructions = "Cut up apples. Bake pie."
                }
            );
            context.SaveChanges();

            if (context.Recipe.Any())
            {
                return;
            }
        }
    }
}