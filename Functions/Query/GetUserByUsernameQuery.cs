using CQRSmediatr.Entities;
using MediatR;

namespace CQRSmediatr.Functions.Query;

public class GetUserByUsernameQuery(string username) : IRequest<User?>
{
    public string Username { get; set; } = username;
}