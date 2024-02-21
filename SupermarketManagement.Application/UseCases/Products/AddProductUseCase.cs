using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Products;

public class AddProductUseCase
{
    public AddProductUseCase(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public void Execute(Product product) =>
        _repository.Add(product);
}