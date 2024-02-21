using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Transactions;

public class GetTodayTransactionsUseCase
{
    public GetTodayTransactionsUseCase(ITransactionRepository repository)
    {
        _repository = repository;
    }

    private readonly ITransactionRepository _repository;

    public IEnumerable<Transaction> Execute(string cashierName) =>
        _repository.GetByDay(cashierName, DateTime.Now);
}
