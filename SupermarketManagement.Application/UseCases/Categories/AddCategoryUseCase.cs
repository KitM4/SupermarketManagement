using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Categories;

public class AddCategoryUseCase
{
    public AddCategoryUseCase(IRepository<Category> repository)
    {
        _repository = repository;
    }

    private readonly IRepository<Category> _repository;

    public void Execute(Category category) =>
        _repository.Add(category);
}