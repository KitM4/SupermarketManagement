using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Categories;

public class GetCategoryByIdUseCase
{
    public GetCategoryByIdUseCase(IRepository<Category> repository)
    {
        _repository = repository;
    }

    private readonly IRepository<Category> _repository;

    public Category? Execute(Guid id) =>
        _repository.Get(id);
}