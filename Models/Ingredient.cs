using System.ComponentModel.DataAnnotations;

namespace recipeFinder.Models;

public class Ingredient 
{
    public int Id { get; set; }
    public string? Name { get; set; }

}