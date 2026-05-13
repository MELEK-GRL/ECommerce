using ECommerce.Domain.Common;

namespace ECommerce.Domain.Entities;

public class User:BaseEntity
{
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public List<Order> Orders { get; private set; } = new();

    public User(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("User Name boş olamaz!", nameof(username));
        }
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("User email Boş olamaz!", nameof(email));
        }
        if (string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("User password boş olamaz", nameof(password));
        }
        if (password.Length < 6)
        {
            throw new ArgumentException("User Password en az 6 haneli olmalı", nameof(password));
        }
      
        Username = username;
        Email = email;
        Password = password;
        CreatedDate = DateTime.UtcNow;
    }

    public void AddOrder(Order order)
    {
        if (order == null)
        {
            throw new ArgumentException("Order Boş olamaz", nameof(order));
        }
        Orders.Add(order);
    }
}