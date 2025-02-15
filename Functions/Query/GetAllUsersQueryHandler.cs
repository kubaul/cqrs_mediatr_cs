using CQRSmediatr.Entities;
using CQRSmediatr.Repositories;
using MediatR;

namespace CQRSmediatr.Functions.Query;

public class GetAllUsersQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUsersQuery, List<User>>
{
    public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(userRepository.GetAll());
    }
}