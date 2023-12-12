using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Aggregate;

public class Product
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Detaills { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
}
