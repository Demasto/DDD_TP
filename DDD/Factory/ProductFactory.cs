using DDD.Aggregate;
using DDD.Repository;

namespace DDD.Factory;

public class ProductFactory
{
    public Product CreateProduct(Product product, ProductRepository repo)
    {
        repo.AddProduct(product);
        return product;
    }
}