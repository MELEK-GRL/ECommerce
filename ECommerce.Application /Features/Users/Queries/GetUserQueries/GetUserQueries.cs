using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Users.Queries.GetUserQueries;

public class GetUserQueries:IRequest<List<User>>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}