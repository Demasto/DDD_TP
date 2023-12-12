using DDD.Aggregate;

namespace DDD.Repository;

public class ClientRepository
{
    private readonly List<Client> _db = new();

    public void AddClient(Client client)
    {
        _db.Add(client);
    }

    public Client? GetClient(int id)
    {
        return _db.FirstOrDefault(c => c.Id == id);
    }
    
    public IEnumerable<Client> GetClients()
    {
        return _db;
    }
}