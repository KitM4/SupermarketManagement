namespace SupermarketManagement.Application.Interfaces.Repositories;

public interface IRepository<T> where T : class
{
    public IEnumerable<T> GetAll();

    public T? Get(Guid id);

    public void Add(T item);

    public void Update(T item);

    public void Delete(Guid id);
}