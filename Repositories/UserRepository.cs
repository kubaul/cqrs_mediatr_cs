using CQRSmediatr.Entities;

namespace CQRSmediatr.Repositories;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users =
    [
        new User("ada.tomaszewska@email.com", "adat", "ada"),
        new User("kubaul@email.com", "kubaul", "kuba"),
        new User("gacekthecat@email.com", "gacekult", "gacek")
    ];
    
    public List<User> GetAll()
        => _users.Where(x => x.IsActive).ToList();

    public User? GetByUsername(string username)
        => _users.Where(x => x.IsActive)
            .FirstOrDefault(x => x.Username == username);

    public bool Delete(string username)
    {
        var user = GetByUsername(username);
        if (user is null)
        {
            return false;
        }
        
        user.Delete();
        return true;
    }
        
}
