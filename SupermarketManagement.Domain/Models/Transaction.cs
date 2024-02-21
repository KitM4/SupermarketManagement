namespace SupermarketManagement.Domain.Models;

public class Transaction
{
    public required Guid Id { get; set; }

    public required string CashierName { get; set; }

    public required decimal Price { get; set; }

    public required int BeforeQuantity { get; set; }

    public required int SoldQuantity { get; set; }

    public required DateTime TimeStamp { get; set; }

    public required Guid ProductId { get; set; }

    public required virtual Product Product { get; set; }
}