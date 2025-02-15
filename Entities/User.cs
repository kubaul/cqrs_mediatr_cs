namespace CQRSmediatr.Entities;

public class User(string email, string password, string username)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Email { get; private set; } = email;
    public string Password { get; private set; } = password;
    public string Username { get; private set; } = username;
    public bool IsActive { get; private set; } = true;

    public void Update(string password, string username)
    {
        Password = password;
        Username = username;
    }

    public void Delete()
    {
        IsActive = false;
    }
}
