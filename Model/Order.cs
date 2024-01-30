using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using PaymentsRequests.Enum;

namespace PaymentsRequests.Model;

[Table("Order")]
public class Order
{

    public Order()
    {
        Items = new Collection<OrderItem>();
    }
    
    [Key]
    public int OrderId { get; set; }
    [Required]
    public DateTime OrderDate { get; set; }
    [Required]
    public OrderStatus Status { get; set; }
    public Collection<OrderItem> Items { get; set; }
}