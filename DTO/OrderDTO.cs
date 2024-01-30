using PaymentsRequests.Enum;
using PaymentsRequests.Model;

namespace PaymentsRequests.DTO;

public class OrderDTO
{
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
}