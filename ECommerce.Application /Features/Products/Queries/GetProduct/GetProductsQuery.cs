using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Products.Queries.GetProduct;

public class GetProductsQuery:IRequest<List<Product>>
{
    public string? Search { get; set; }
}