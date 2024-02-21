using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Products;

public class GetProductByIdUseCase
{
    public GetProductByIdUseCase(IProductRepository repository)
    {
        _repository = repository;
    }

    private readonly IProductRepository _repository;

    public Product? Execute(Guid id) =>
        _repository.Get(id);
}