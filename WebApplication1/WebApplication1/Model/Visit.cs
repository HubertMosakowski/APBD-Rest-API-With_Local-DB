namespace WebApplication1.Models;

using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;


public class Visit
{
    [Required] public Animal Animal { get; set; }
    [Required] public DateTime Date { get; set; }
    [Required] [MaxLength(200)] public string Description { get; set; }
    [Required] public int Price { get; set; }
}