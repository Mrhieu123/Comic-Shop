using System;
using System.Collections.Generic;

namespace ComicManagement.Models;

public partial class Product
{
    public int Id { get; set; }

    public int? Cid { get; set; }

    public string? Title { get; set; }

    public decimal? Price { get; set; }

    public string? ProductUrl { get; set; }

    public string? Author { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category? CidNavigation { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}
