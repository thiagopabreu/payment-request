using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentsRequests.Model;

[Table("Payment")]
public class Payment
{
    [Key]
    public int PaymentId { get; set; }
    [Required]
    public decimal Amount { get; set; }
    [Required]
    public DateTime PaymentDate { get; set; }
    [Required]
    public Order Order { get; set; }
}