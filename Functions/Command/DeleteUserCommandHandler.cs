using CQRSmediatr.Repositories;
using MediatR;

namespace CQRSmediatr.Functions.Command;

public class DeleteUserCommandHandler(IUserRepository userRepository) : IRequestHandler<DeleteUserCommand, bool>
{
    public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(userRepository.Delete(request.Username));
    }
}
