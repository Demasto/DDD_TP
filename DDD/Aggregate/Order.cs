using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Aggregate;

public class Order
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public int ClientId { get; set; }
    
    [Required]
    public Address Address { get; set; }
    
    [Required]
    public string StatusOfOrder { get; set; }
    
    [Required]
    public Client Client { get; set; }
    
    public ICollection<Product> OrderProducts { get; set; }
}



public class Address
{
    [Required]
    public string City { get; set; }
    [Required]
    public string Street { get; set; }
    [Required]
    public string PostalCode { get; set; }
}

