using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models.Entity;

public partial class TableFood
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
