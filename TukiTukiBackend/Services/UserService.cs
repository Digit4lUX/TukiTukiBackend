using Microsoft.AspNetCore.Http.HttpResults;
using TukiTukiBackend.Models;

namespace TukiTukiBackend.Services;

public class UserService: ICRUDService<User>
{
    private List<User> users = new List<User>()
    {
        new User("Manuel", "Perez", "perez365@gmail.com", "manuel123", "963571985"),
        new User("Pedro", "Quispe", "pepe43@gmail.com", "pepe123", "967204787")
    };
    
    public IEnumerable<User> getAll()
    {
        throw new NotImplementedException();
    }

    public User? getById(int id)
    {
        throw new NotImplementedException();
    }

    public User create(User user)
    {
        user.id = users.Count + 1;
        users.Add(user);
        return user;
    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }
    
    public User getByEmail(string email)
    {
        return users.FirstOrDefault(u => u.email == email);
    }
}