using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Application.UseCases.Categories;

public class ViewCategoriesUseCase
{
    public ViewCategoriesUseCase(IRepository<Category> repository)
    {
        _repository = repository;
    }

    private readonly IRepository<Category> _repository;

    public IEnumerable<Category> Execute() =>
        _repository.GetAll();
}