using System;
using System.Collections.Generic;

namespace FastFoodManageFormApp.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? Quantity { get; set; }

    public decimal? Price { get; set; }

    public bool? Enabled { get; set; }

    public byte[]? Image { get; set; }

    public virtual Category Category { get; set; } = null!;
}
