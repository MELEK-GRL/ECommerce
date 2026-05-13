using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Product :BaseEntity
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category Category { get; private set; }
    public Product(string name, decimal price,Guid categoryId)
    {
      
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name Boş olamaz!",nameof(name));
        }

        if (price <= 0)
        {
            throw new ArgumentException("Price O dan büyük olmalı!",nameof(price));
        }
        Name = name;
        Price = price;
        CategoryId = categoryId;
        CreatedDate = DateTime.UtcNow;
    }

    
}