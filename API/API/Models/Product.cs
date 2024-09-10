using System;

namespace API.Models;

public class Product
{
    public Product()
    {
        CreatedAt = DateTime.Now;
        Id = Guid.NewGuid().ToString() ;
    }

    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set;}
    public double Price { get; set; }
    public DateTime CreatedAt { get; set; }
}
