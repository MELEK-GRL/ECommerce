using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Categories.Queries.GetCategory;

public class GetCategoryQuery:IRequest<List<Category>>
{
    public string? Name { get; set; }
}