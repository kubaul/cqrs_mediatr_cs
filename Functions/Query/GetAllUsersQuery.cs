using CQRSmediatr.Entities;
using MediatR;

namespace CQRSmediatr.Functions.Query;

public class GetAllUsersQuery : IRequest<List<User>>
{
}