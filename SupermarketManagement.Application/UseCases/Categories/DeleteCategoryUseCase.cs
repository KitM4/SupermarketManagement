using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Categories;

public class DeleteCategoryUseCase
{
    public DeleteCategoryUseCase(IRepository<Category> repository)
    {
        _repository = repository;
    }

    private readonly IRepository<Category> _repository;

    public void Execute(Guid id) =>
        _repository.Delete(id);
}