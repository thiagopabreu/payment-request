using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentsRequests.Model;

[Table("OrderItem")]
public class OrderItem
{
    [Key]
    public int OrderItemId { get; set; }
    [Required]
    public Product Product { get; set; }
    [Required]
    public int Quantity { get; set; }
}