using PaymentsRequests.Model;

namespace PaymentsRequests.DTO;

public class PaymentDTO
{
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public Order Order { get; set; }
}