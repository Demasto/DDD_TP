using DDD.Aggregate;
using DDD.Repository;

namespace DDD.Factory;

public class OrderFactory
{

    public Order CreateOrder(Order order, OrderRepository repo)
    {
        repo.AddOrder(order);
        return order;
    }
}