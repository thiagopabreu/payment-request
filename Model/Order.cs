using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PaymentsRequests.Enum;

namespace PaymentsRequests.Model;

[Table("Order")]
public class Order
{
    [Key]
    public int OrderId { get; set; }
    [Required]
    public List<OrderItem> Items { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    public OrderStatus Status { get; set; }
}