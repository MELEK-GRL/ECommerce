using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;

namespace ECommerce.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandHandler:IRequestHandler<CreateProductCommand>
{
    private readonly AppDbContext _dbContext;

    public CreateProductCommandHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var newProduct = new Product(
            request.Name,
            request.Price,
            request.CategoryId
        );
        await _dbContext.Products.AddAsync(newProduct);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}