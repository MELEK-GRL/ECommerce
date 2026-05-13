using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.Features.Categories.Queries.GetCategory;

public class GetCategoryQueryHandler:IRequestHandler<GetCategoryQuery,List<Category>>
{
    private readonly AppDbContext _dbContext;

    public GetCategoryQueryHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Category>> Handle(GetCategoryQuery request, CancellationToken command)
    {
        return await _dbContext.Categories.ToListAsync();
    }
}