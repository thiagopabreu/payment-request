using PaymentsRequests.Model;

namespace PaymentsRequests.DTO;

public class OrderItemDTO
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}