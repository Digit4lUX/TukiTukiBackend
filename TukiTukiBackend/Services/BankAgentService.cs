using TukiTukiBackend.Models;

namespace TukiTukiBackend.Services;

public class BankAgentService : ICRUDService<BankAgent>
{
    
    private List<BankAgent> agents = new List<BankAgent>()
    {
        new BankAgent() { title = "BCP", location = "Lima, Surco"},
        
    };

    public IEnumerable<BankAgent> getAll()
    {
        return agents;
    }

    public BankAgent? getById(int id)
    {
        throw new NotImplementedException();
    }

    public BankAgent create(BankAgent item)
    {
        agents.Add(item);
        return item;
    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }
}