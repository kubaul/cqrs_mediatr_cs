using CQRSmediatr.Entities;
using CQRSmediatr.Functions.Command;
using CQRSmediatr.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSmediatr.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController(IMediator mediator) : Controller
{
    [HttpGet("[action]")]
    public async Task<ActionResult<List<User>>> GetAll()
    {
        var request = new GetAllUsersQuery();
        var result = await mediator.Send(request);

        return result;
    }

    [HttpGet("[action]/{username}")]
    public async Task<ActionResult<User?>> GetByUsername(string username)
    {
        var request = new GetUserByUsernameQuery(username);
        var result = await mediator.Send(request);

        return result;
    }

    [HttpGet("[action]/{username}")]
    public async Task<ActionResult<bool>> Delete(string username)
    {
        var request = new DeleteUserCommand(username);
        var result = await mediator.Send(request);

        return result;
    }
}