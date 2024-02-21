using SupermarketManagement.Application.Interfaces.Repositories;

namespace SupermarketManagement.Data.Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    public virtual IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public virtual T? Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public virtual void Add(T item)
    {
        throw new NotImplementedException();
    }

    public virtual void Update(T item)
    {
        throw new NotImplementedException();
    }

    public virtual void Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}