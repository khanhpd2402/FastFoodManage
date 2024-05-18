using System;
using System.Collections.Generic;

namespace FastFoodManageFormApp.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalMoney { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
