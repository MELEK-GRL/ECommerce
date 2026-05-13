using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.Features.Users.Queries.GetUserQueries;

public class GetUserQueriesHandler:IRequestHandler<GetUserQueries,List<User>>
{
    private readonly AppDbContext _dbContext;

    public GetUserQueriesHandler(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> Handle(GetUserQueries request, CancellationToken cancellationToken)
    {
        return await _dbContext.Users
            .Include(x => x.Orders)
            .ThenInclude(x => x.Products)
            .ToListAsync(cancellationToken);
    }
}