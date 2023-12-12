
using DDD.Aggregate;
using DDD.Repository;
namespace DDD.Factory;

public class ClientFactory
{

    public Client CreateClient(Client client, ClientRepository repo)
    {
        repo.AddClient(client);
        return client;
    }
}