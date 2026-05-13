using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Order:BaseEntity
{
    public decimal TotalPrice { get; private set; }
    public List<Product> Products { get; private set; } = new();

    public Order(decimal totalPrice)
    {
        if (totalPrice <= 0)
        {
            throw new ArgumentException("TotalPrice 0 dan büyük olmalı", nameof(totalPrice));
        }
        TotalPrice = totalPrice;
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