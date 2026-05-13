using MediatR;

namespace ECommerce.Application.Features.Orders.Commands.CreateOrderCommand;

public class CreateOrderCommand:IRequest
{
    public Guid UserId { get; set; }
    public List<Guid>ProductIds { get; set; }
}