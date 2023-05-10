using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public int CountProtein { get; set; }
    public int CountFat { get; set; }
    public int CountUgl { get; set; }
}