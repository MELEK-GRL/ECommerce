using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Order:BaseEntity
{
    public decimal TotalPrice { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
    public List<Product> Products { get; private set; } = new();

    public Order(Guid userId)
    {
 
        TotalPrice = 0;
        UserId = userId;
        CreatedDate = DateTime.UtcNow;
    }

    public void AddProduct(Product product)
    {
        if (product == null)
        {
            throw new ArgumentException("Product boş olamaz", nameof(product));
        }
        Products.Add(product);
        TotalPrice += product.Price;
    }
    
    
}