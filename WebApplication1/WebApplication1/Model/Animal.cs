using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Animal
{
    [Required] public int IdAnimal { get; set; }
    [Required] [MaxLength(200)] public string Name { get; set; }
    [Required] [MaxLength(200)] public string Category { get; set; }
    [Required] public int Weight { get; set; }
    [Required] [MaxLength(200)] public string Color { get; set; }
}