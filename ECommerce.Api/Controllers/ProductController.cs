using ECommerce.Application.Features.Products.Commands.CreateProduct;
using ECommerce.Application.Features.Products.Queries.GetProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController:ControllerBase
{
   private readonly IMediator _mediator;

   public ProductController(IMediator mediator)
   {
      _mediator = mediator;
   }

   [HttpGet]
   public async Task<IActionResult> Get()
   {
     var products= await _mediator.Send(new GetProductsQuery());
     return Ok(products);
      return Ok("Product list getirildi.");
   }
   
   [HttpPost]
   public async Task<IActionResult> Create(CreateProductCommand command)
   {
      await _mediator.Send(command);
      return Ok("Product Post edildi");
   }
}