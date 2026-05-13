using MediatR;

namespace ECommerce.Application.Features.Orders.Commands.CreateOrderCommand;

public class CreateOrderCommand:IRequest
{
    public decimal TotalPrice { get; set; }
}