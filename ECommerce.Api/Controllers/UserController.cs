using ECommerce.Application.Features.Users.Commands.CreateUserCommand;
using ECommerce.Application.Features.Users.Queries.GetUserQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers;

[ApiController]
[Route("api/users")]
public class UserController:ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _mediator.Send(new GetUserQueries());
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand command)
    {
        await _mediator.Send(command);
        return Ok("User post edildi!");
    }
}