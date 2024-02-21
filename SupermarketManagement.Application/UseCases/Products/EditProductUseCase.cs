using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Products;

public class EditProductUseCase
{
    public EditProductUseCase(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public void Execute(Product product) =>
        _repository.Update(product);
}