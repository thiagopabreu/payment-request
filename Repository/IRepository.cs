using System.Linq.Expressions;

namespace PaymentsRequests.Repository;

public interface IRepository<T> where T : class
{
    IEnumerable<T> Get();

    Task<T> GetById(int id);

    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}