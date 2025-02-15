using CQRSmediatr.Entities;

namespace CQRSmediatr.Repositories;

public interface IUserRepository
{
    public List<User> GetAll();
    public User? GetByUsername(string username);
    public bool Delete(string username);
}
