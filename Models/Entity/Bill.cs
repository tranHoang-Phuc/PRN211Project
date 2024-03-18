using System;
using System.Collections.Generic;

namespace WinFormsApp1.Models.Entity;

public partial class Bill
{
    public int Id { get; set; }

    public bool? Status { get; set; }

    public DateTime? DateCheckIn { get; set; }

    public DateTime? DateCheckOut { get; set; }

    public int? IdTableFood { get; set; }

    public int? EmployeeId { get; set; }

    public virtual ICollection<BillInfo> BillInfos { get; set; } = new List<BillInfo>();

    public virtual Employee? Employee { get; set; }

    public virtual TableFood? IdTableFoodNavigation { get; set; }
}
