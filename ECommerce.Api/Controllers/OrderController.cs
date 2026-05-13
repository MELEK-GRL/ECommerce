using ECommerce.Application.Features.Orders.Commands.CreateOrderCommand;
using ECommerce.Application.Features.Orders.Queries.GetOrderQuery;
using ECommerce.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers;

[ApiController]
[Route("api/orders")]

public class OrderController:ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var orders = await _mediator.Send(new GetOrderQuery());
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand command)
    {
        await _mediator.Send(command);
        return Ok("Order post oldu!");
    }

    

}