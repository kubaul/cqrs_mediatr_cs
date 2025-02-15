using MediatR;

namespace CQRSmediatr.Functions.Command;

public class DeleteUserCommand(string username) : IRequest<bool>
{
    public string Username { get; set; } = username;
}
