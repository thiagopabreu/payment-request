using PaymentsRequests.Model;

namespace PaymentsRequests.DTO;

public class OrderItemDTO
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
}