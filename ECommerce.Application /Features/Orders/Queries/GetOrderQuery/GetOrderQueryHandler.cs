using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.Features.Orders.Queries.GetOrderQuery;

public class GetOrderQueryHandler:IRequestHandler<GetOrderQuery,List<Order>>
{
    private readonly AppDbContext _dbContext;

    public GetOrderQueryHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Order>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Orders.ToListAsync();
    }
}