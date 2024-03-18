using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models.Pojo
{
    public class BillDetail
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public float? TotalPrice { get; set; }
    }
}
