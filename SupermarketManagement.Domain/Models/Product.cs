namespace SupermarketManagement.Domain.Models;

public class Product
{
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public required int Quantity { get; set; }

    public required decimal Price { get; set; }

    public Guid CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}