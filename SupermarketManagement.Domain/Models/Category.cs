namespace SupermarketManagement.Domain.Models;

public class Category
{
    public required Guid Id { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }
}