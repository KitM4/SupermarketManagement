using SupermarketManagement.Domain.Models;

namespace SupermarketManagement.Application.Interfaces.Repositories;

public interface IProductRepository
{
    public Product? Get(Guid id);

    public IEnumerable<Product> GetAll();

    public IEnumerable<Product> GetProductsByCategory(Guid categoryId);

    public void Add(Product product);

    public void Delete(Guid id);

    public void Update(Product product);
}