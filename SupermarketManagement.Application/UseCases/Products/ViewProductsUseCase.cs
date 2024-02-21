using SupermarketManagement.Application.Interfaces.Repositories;
using SupermarketManagement.Domain.Models;

namespace SupermarketManagement.Application.UseCases.Products;

public class ViewProductsUseCase
{
    public ViewProductsUseCase(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public IEnumerable<Product> Execute() =>
        _repository.GetAll();
}