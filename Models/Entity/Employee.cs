using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models.Entity;

public partial class Employee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public int? JobId { get; set; }

    public DateTime? DateStartWork { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Job? Job { get; set; }
}
