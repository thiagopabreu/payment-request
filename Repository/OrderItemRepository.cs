using PaymentsRequests.Context;
using PaymentsRequests.Model;

namespace PaymentsRequests.Repository;

public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(AppDbContext context) : base(context)
    {
    }
}