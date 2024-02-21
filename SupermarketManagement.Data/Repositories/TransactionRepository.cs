using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Data.Repositories;

public class TransactionRepository : ITransactionRepository
{
    public TransactionRepository()
    {
        _transactions = new List<Transaction>();
    }

    private readonly List<Transaction> _transactions;

    public IEnumerable<Transaction> GetTransactionsByCashier(string cashierName)
    {
        return string.IsNullOrWhiteSpace(cashierName) ? _transactions :
            _transactions.Where(transaction => 
            string.Equals(transaction.CashierName, cashierName, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
    {
        if (string.IsNullOrWhiteSpace(cashierName))
        {
            return _transactions.Where(transaction => transaction.TimeStamp.Date == date.Date);
        }
        else
        {
            return _transactions.Where(transaction =>
                string.Equals(transaction.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                transaction.TimeStamp.Date == date.Date);
        }
    }

    public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
    {
        if (string.IsNullOrWhiteSpace(cashierName))
        {
            return _transactions.Where(transaction => transaction.TimeStamp >= startDate.Date &&
            transaction.TimeStamp <= endDate.Date.AddDays(1).Date);
        }
        else
        {
            return _transactions.Where(transaction =>
                string.Equals(transaction.CashierName, cashierName, StringComparison.OrdinalIgnoreCase) &&
                transaction.TimeStamp >= startDate.Date && transaction.TimeStamp <= endDate.Date.AddDays(1).Date);
        }
    }

    public void Save(string cashierName, decimal price, int beforeQuantity, int soldQuantity, Product product)
    {
        _transactions.Add(new()
        {
            Id = Guid.NewGuid(),
            TimeStamp = DateTime.UtcNow,
            Price = price,
            BeforeQuantity = beforeQuantity,
            SoldQuantity = soldQuantity,
            CashierName = cashierName,
            ProductId = product.Id,
            Product = product,
        });
    }
}