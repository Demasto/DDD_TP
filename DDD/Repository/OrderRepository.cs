using DDD.Aggregate;

namespace DDD.Repository;

public class OrderRepository
{
    private readonly List<Order> _db = new();
    
    public void AddOrder(Order order)
    {
        _db.Add(order);
    }

    public Order? GetOrder(int id)
    {
        return _db.FirstOrDefault(c => c.Id == id);
    }
    
    public bool PutOrder(Order order)
    {
        var index = _db.FindIndex(c => c.Id == order.Id);
        
        if (index == -1)
        {
            return false;
        }
        
        _db[index] = order;
        return true;
    }
    
    public IEnumerable<Order> GetOrders()
    {
        return _db;
    }
}