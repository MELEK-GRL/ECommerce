using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;

namespace ECommerce.Application.Features.Users.Commands.CreateUserCommand;

public class CreateUserCommandHandler:IRequestHandler<CreateUserCommand>
{
    private readonly AppDbContext _dbContext;

    public CreateUserCommandHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var newUser = new User(
        request.Username,
        request.Email,
        request.Password
            );;
        await _dbContext.AddRangeAsync(newUser);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}