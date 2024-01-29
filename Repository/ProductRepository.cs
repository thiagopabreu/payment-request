using System.Linq.Expressions;
using PaymentsRequests.Context;
using PaymentsRequests.Model;

namespace PaymentsRequests.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
        
    }
    
}