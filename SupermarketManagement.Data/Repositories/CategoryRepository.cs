using SupermarketManagement.Domain.Models;

namespace SupermarketManagement.Data.Repositories;

public class CategoryRepository : BaseRepository<Category>
{
    public CategoryRepository()
    {
        _defaultCategories = new()
        {
            new() { Id = Guid.NewGuid(), Name = "Beverage", Description = "Beverage description" },
            new() { Id = Guid.NewGuid(), Name = "Bakery", Description = "Bakery description" },
            new() { Id = Guid.NewGuid(), Name = "Meat", Description = "Meat description" },
            new() { Id = Guid.NewGuid(), Name = "Drinks", Description = "Drinks description" },
            new() { Id = Guid.NewGuid(), Name = "Fast food", Description = "Fast food description" },
        };
    }

    private readonly List<Category> _defaultCategories;

    public override IEnumerable<Category> GetAll()
    {
        return _defaultCategories;
    }

    public override Category? Get(Guid id)
    {
        return _defaultCategories.FirstOrDefault(category => category.Id == id);
    }

    public override void Add(Category item)
    {
        if (!_defaultCategories.Any(c => c.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase)))
            _defaultCategories.Add(item);
    }

    public override void Update(Category item)
    {
        Category? categoryToUpdate = Get(item.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = item.Name;
            categoryToUpdate.Description = item.Description;
        }
    }

    public override void Delete(Guid id)
    {
        int categoryIndex = _defaultCategories.FindIndex(category => category.Id == id);

        if (categoryIndex != -1)
            _defaultCategories.RemoveAt(categoryIndex);
    }
}