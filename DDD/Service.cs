using DDD.Aggregate;
using DDD.Repository;

namespace DDD;

public class Service
{
    private OrderRepository _orderRepository;
    public Service(OrderRepository repo)
    {
        _orderRepository = repo;
    }
    public Order PlaceOrderCommand(int clientId, List<Product> products, Address address, 
        ClientRepository clientRepo)
    {
        var client = clientRepo.GetClient(clientId);
        
        if (client == null)
        {
            Console.WriteLine("Такого клиента не существует");
            return new Order();

        }
        
        var newOrder = new Order
        {
            ClientId = clientId,
            Client = client,
            Address = address,
            StatusOfOrder = "1",
            OrderProducts = products
        };
       
        _orderRepository.AddOrder(newOrder);
        return newOrder;
    }
    
    public bool PayOrderCommand(int orderId)
    {
        var order = _orderRepository.GetOrder(orderId);
        
        if (order != null)
        {
            
            
            order.StatusOfOrder = "2";
            
            return true;
        }
        
        return false;
    }

    public bool ProcessOrderCommand(int orderId)
    {
        var order = _orderRepository.GetOrder(orderId);
        if (order != null)
        {
            order.StatusOfOrder = "3";
            _orderRepository.PutOrder(order);
            return true;
        }

        return false;
    }
    
    public bool DeliverOrderCommand(int orderId)
    {
        //Окончание оформления заказа
        
        var order = _orderRepository.GetOrder(orderId);
        if (order != null)
        {
            order.StatusOfOrder = "4";
            return true;
        }
        
        return false;
    }
}