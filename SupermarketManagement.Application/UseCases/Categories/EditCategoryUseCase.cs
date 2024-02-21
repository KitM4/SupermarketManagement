using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Categories;

public class EditCategoryUseCase
{
    public EditCategoryUseCase(IRepository<Category> repository)
    {
        _repository = repository;
    }

    private readonly IRepository<Category> _repository;

    public void Execute(Category category) =>
        _repository.Update(category);
}