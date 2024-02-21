using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.UseCases.Products;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Transactions;

public class RecordTransactionUseCase
{
    public RecordTransactionUseCase(ITransactionRepository repository, GetProductByIdUseCase getProduct)
    {
        _repository = repository;
        _getProduct = getProduct;
    }

    private readonly ITransactionRepository _repository;
    private readonly GetProductByIdUseCase _getProduct;

    public void Execute(string cashierName, Guid productId, int quantity)
    {
        Product? product = _getProduct.Execute(productId);
        if (product != null)
            _repository.Save(cashierName, product.Price, product.Quantity, quantity, product);
    }
}