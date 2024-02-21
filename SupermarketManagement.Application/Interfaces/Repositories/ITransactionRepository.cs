using SupermarketManagement.Domain.Models;

namespace SupermarketManagement.Application.Interfaces.Repositories;

public interface ITransactionRepository
{
    public IEnumerable<Transaction> GetTransactionsByCashier(string cashierName);

    public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);

    public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);

    public void Save(string cashierName, decimal price, int beforeQuantity, int soldQuantity, Product product);
}