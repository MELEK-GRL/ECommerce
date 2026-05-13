using ECommerce.Domain.Entities;
using MediatR;

namespace ECommerce.Application.Features.Orders.Queries.GetOrderQuery;

public class GetOrderQuery:IRequest<List<Order>>
{
    public decimal TotalPrice { get; set; }
    public Guid OrderId { get; set; }
}