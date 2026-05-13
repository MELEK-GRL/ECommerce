using MediatR;

namespace ECommerce.Application.Features.Users.Commands.CreateUserCommand;

public class CreateUserCommand:IRequest
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
}