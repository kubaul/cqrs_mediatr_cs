using CQRSmediatr.Entities;
using CQRSmediatr.Repositories;
using MediatR;

namespace CQRSmediatr.Functions.Query;

public class GetUserByUsernameQueryHandler(IUserRepository userRepository)
    : IRequestHandler<GetUserByUsernameQuery, User?>
{
    public Task<User?> Handle(GetUserByUsernameQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(userRepository.GetByUsername(request.Username));
    }
}