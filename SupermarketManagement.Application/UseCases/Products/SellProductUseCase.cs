using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;
using SupermarketManagement.Application.UseCases.Transactions;

namespace SupermarketManagement.Application.UseCases.Products;

public class SellProductUseCase
{
    public SellProductUseCase(IRepository<Product> repository, RecordTransactionUseCase recordTransaction)
    {
        _repository = repository;
        _recordTransaction = recordTransaction;
    }

    private readonly IRepository<Product> _repository;
    private readonly RecordTransactionUseCase _recordTransaction;

    public void Execute(string cashierName, Guid productId, int quantityToSell)
    {
        Product? product = _repository.Get(productId);
        if (product != null)
        {
            _recordTransaction.Execute(cashierName, productId, quantityToSell);

            product.Quantity -= quantityToSell;
            _repository.Update(product);
        }
    }
}