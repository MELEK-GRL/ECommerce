using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;

namespace ECommerce.Application.Features.Categories.Commands;

public class CreateCategoryCommandHandler:IRequestHandler<CreateCategoryCommand>
{
    private readonly AppDbContext _dbContext;
    

    public CreateCategoryCommandHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    public async Task<Unit> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var newCategory=new Category(
            request.Name
            );
        await _dbContext.Categories.AddAsync(newCategory);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }

    
}