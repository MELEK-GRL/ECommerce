using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class Category:BaseEntity
{
        public string Name { get; private set; }
        public List<Product>Products { get; private set; }

        public Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Category Name boş olamaz!", nameof(name));
            }

            Name = name;
            CreatedDate = DateTime.UtcNow;
        }
}