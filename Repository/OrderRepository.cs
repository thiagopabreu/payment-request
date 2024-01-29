using PaymentsRequests.Context;
using PaymentsRequests.Model;

namespace PaymentsRequests.Repository;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context) : base(context)
    {
    }
}