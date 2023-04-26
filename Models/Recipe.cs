using System.ComponentModel.DataAnnotations;

namespace recipeFinder.Models;

public class Recipe 
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime AddedDate { get; set; }
    public string? ImgUrl { get; set; }
    public string? Instructions { get; set; }

}