using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models.Entity;

public partial class Food
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Images { get; set; }

    public double Price { get; set; }

    public int? IdCateGory { get; set; }

    public virtual ICollection<BillInfo> BillInfos { get; set; } = new List<BillInfo>();

    public virtual FoodCategory? IdCateGoryNavigation { get; set; }
}
