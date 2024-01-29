using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PaymentsRequests.Context;

namespace PaymentsRequests.Repository;

public class Repository<T> : IRepository<T> where T : class
{

    protected AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<T> Get()
    {
        return _context.Set<T>().AsNoTracking().ToList();
    }

    public async Task<T> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}