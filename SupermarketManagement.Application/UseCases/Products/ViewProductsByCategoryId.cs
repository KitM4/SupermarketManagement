using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Products;

public class ViewProductsByCategoryId
{
    public ViewProductsByCategoryId(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public IEnumerable<Product> Execute(Guid categoryId) =>
        _repository.GetProductsByCategory(categoryId);
}