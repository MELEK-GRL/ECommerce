using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;

namespace ECommerce.Application.Features.Orders.Commands.CreateOrderCommand;

public class CreateOrderCommandHandler:IRequestHandler<CreateOrderCommand>
{
    private readonly AppDbContext _dbContext;

    public CreateOrderCommandHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var newOrder = new Order(
        request.TotalPrice
            );

        await _dbContext.Orders.AddAsync(newOrder);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}