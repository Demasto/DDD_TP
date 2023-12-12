using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Aggregate;

public class Client
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string SecondName { get; set; }
    
    [Required]
    public string TypeOfCard { get; set; }
    
    [Required]
    public string TypeOfPay { get; set; }
    
    public ICollection<Order> Orders { get; set; }
    
}

