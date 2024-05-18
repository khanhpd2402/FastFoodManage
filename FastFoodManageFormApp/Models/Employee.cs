using System;
using System.Collections.Generic;

namespace FastFoodManageFormApp.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string AccountName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public bool? Gender { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? HireDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public decimal? Salary { get; set; }

    public int Role { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
