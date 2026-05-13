namespace ECommerce.Application.Features.Products.Commands.CreateProduct;
using MediatR;
public class CreateProductCommand:IRequest
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Guid CategoryId { get; set; }
}