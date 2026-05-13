using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
        request.UserId
            );
        var products = await _dbContext.Products.Where(x => request.ProductIds.Contains(x.Id))
            .ToListAsync(cancellationToken);
        foreach (var product in products)
        {
            newOrder.AddProduct(product);
        }
        
        await _dbContext.Orders.AddAsync(newOrder);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}