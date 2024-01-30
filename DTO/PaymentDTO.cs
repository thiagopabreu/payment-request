using PaymentsRequests.Model;

namespace PaymentsRequests.DTO;

public class PaymentDTO
{
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public int OrderId { get; set; }
}