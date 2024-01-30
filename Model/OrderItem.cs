﻿using System.ComponentModel.DataAnnotations;
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
    public Order Order { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int OrderId { get; set; }
    
    public int ProductId { get; set; }
}