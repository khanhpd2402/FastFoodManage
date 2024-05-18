using System;
using System.Collections.Generic;

namespace FastFoodManageFormApp.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool? Enabled { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public override string ToString()
    {
        return CategoryName;
    }
}
