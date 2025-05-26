using System;
using System.Collections.Generic;

namespace eGearStore.DataAccess;

public partial class Order
{
    public int OrderId { get; set; }

    public string? UserId { get; set; }

    public decimal TotalPrice { get; set; }

    public string? OrderStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User? User { get; set; }
}
