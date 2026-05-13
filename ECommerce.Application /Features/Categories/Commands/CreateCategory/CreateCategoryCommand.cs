using MediatR;

namespace ECommerce.Application.Features.Categories.Commands;

public class CreateCategoryCommand:IRequest
{
    public string Name { get; set; }
    
}