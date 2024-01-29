using PaymentsRequests.Context;
using PaymentsRequests.Model;

namespace PaymentsRequests.Repository;

public class PaymentRepository : Repository<Payment>, IPaymentRepository
{
    public PaymentRepository(AppDbContext context) : base(context)
    {
    }
    
    
}