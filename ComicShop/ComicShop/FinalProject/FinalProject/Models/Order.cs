using System;
using System.Collections.Generic;

namespace ComicManagement.Models;

public partial class Order
{
    public int Id { get; set; }
    public int? UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? FullName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
