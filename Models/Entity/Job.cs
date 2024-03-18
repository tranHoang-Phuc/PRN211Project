using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models.Entity;

public partial class Job
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Salary { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
