using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentsRequests.Model;

[Table("Product")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    [MaxLength(100, ErrorMessage = "Product pass the maximum lenght")]
    public string Name { get; set; }
    [Required]
    public decimal Price { get; set; }
}