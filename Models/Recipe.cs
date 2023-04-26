using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace recipeFinder.Models;

public class Recipe 
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [Display(Name = "Date Added")]
    [DataType(DataType.Date)]
    public DateTime AddedDate { get; set; }

    [Display(Name = "Photo")]
    public string ImgUrl { get; set; } = string.Empty;

    public string? Ingredients { get; set; }
    
    public string? Instructions { get; set; }

}