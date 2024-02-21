using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Products;

public class DeleteProductUseCase
{
    public DeleteProductUseCase(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public void Execute(Guid id) =>
        _repository.Delete(id);
}