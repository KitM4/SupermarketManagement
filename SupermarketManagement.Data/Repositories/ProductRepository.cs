using SupermarketManagement.Domain.Models;
using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Data.Repositories;

public class ProductRepository : IProductRepository
{
    public ProductRepository()
    {
        _defaultProducts = new()
        {
            new() { Id = Guid.NewGuid(), Name = "Iced Tea", Quantity = 100, Price = 1.99m, CategoryId = Guid.Empty, Category = null },
            new() { Id = Guid.NewGuid(), Name = "Pepsi", Quantity = 100, Price = 1.99m, CategoryId = Guid.Empty, Category = null },
            new() { Id = Guid.NewGuid(), Name = "Burger", Quantity = 100, Price = 1.99m, CategoryId = Guid.Empty, Category = null },
            new() { Id = Guid.NewGuid(), Name = "Taco", Quantity = 100, Price = 1.99m, CategoryId = Guid.Empty, Category = null },
        };
    }

    private readonly List<Product> _defaultProducts;

    public Product? Get(Guid id)
    {
        return _defaultProducts.FirstOrDefault(product => product.Id == id);
    }

    public IEnumerable<Product> GetAll()
    {
        return _defaultProducts;
    }

    public IEnumerable<Product> GetProductsByCategory(Guid categoryId)
    {
        return _defaultProducts.Where(product => product.CategoryId == categoryId);
    }

    public void Add(Product product)
    {
        _defaultProducts.Add(product);
    }

    public void Delete(Guid id)
    {
        int productIndex = _defaultProducts.FindIndex(product => product.Id == id);

        if (productIndex != -1)
            _defaultProducts.RemoveAt(productIndex);
    }

    public void Update(Product product)
    {
        Product? productToUpdate = Get(product.Id);
        if (productToUpdate != null)
        {
            productToUpdate.Name = product.Name;
            productToUpdate.Quantity = product.Quantity;
            productToUpdate.Price = product.Price;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Category = product.Category;
        }
    }
}