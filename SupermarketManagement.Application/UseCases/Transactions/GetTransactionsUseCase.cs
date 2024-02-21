using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Transactions;

public class GetTransactionsUseCase
{
    public GetTransactionsUseCase(ITransactionRepository repository)
    {
        _repository = repository;
    }

    private readonly ITransactionRepository _repository;

    public IEnumerable<Transaction> Execute(string cashierName, DateTime startDate, DateTime endDate) =>
        _repository.Search(cashierName, startDate, endDate);
}