
using DDD;
using DDD.Aggregate;
using DDD.Factory;
using DDD.Repository;

var productFactory = new ProductFactory();
var orderFactory = new OrderFactory();
var clientFactory =  new ClientFactory();
            
var productRepository = new ProductRepository();
var orderRepository = new OrderRepository();
var clientRepository =  new ClientRepository();

var service = new Service(orderRepository);

var client = clientFactory.CreateClient(new Client
{
    Id = 1,
    Name = "Dmitry",
    SecondName = "Bolt",
    TypeOfCard = "credit_card",
    TypeOfPay = "MIR",
    Orders = new List<Order>()
}, clientRepository);
            
var product = productFactory.CreateProduct(new Product
{
    Name = "product_1",
    Detaills = "this is first product",
    Quantity = 1,
    Price = 500
}, productRepository);

var listProducts = new List<Product>() { product };

var address = new Address()
{
    City = "Moscow",
    PostalCode = "11332",
    Street = "lenina, 24"
};

var order = service.PlaceOrderCommand(1, listProducts, address, clientRepository);
Console.WriteLine("Заказ размещен");

if (service.PayOrderCommand(order.Id))
{
    Console.WriteLine("Заказ оплачен");

    if (service.ProcessOrderCommand(order.Id))
    {
        Console.WriteLine("Заказ обрабатывается...");
        
        if (service.DeliverOrderCommand(order.Id))
        {
            Console.WriteLine("Заказ успешно доставлен");
        }
        else
        {
            Console.WriteLine("Заказ не доставлен");
        }
    }
}