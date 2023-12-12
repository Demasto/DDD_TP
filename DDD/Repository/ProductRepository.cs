using DDD.Aggregate;

namespace DDD.Repository;

public class ProductRepository
{
    private readonly List<Product> _db = new();
    
    public void AddProduct(Product product)
    {
        _db.Add(product);
    }

    public Product? GetProduct(int id)
    {
        return _db.FirstOrDefault(c => c.Id == id);
    }
    
    public IEnumerable<Product> GetOrders()
    {
        return _db;
    }
}