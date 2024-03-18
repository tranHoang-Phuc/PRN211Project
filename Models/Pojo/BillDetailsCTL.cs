using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models.Pojo
{
    public class BillDetailsCTL
    {
        public int BillId { get; set; }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public BillDetailsCTL(int billID, int foodID, string foodName, int quantity)
        {
            BillId = billID;
            FoodID = foodID;
            FoodName = foodName;
            Quantity = quantity;
        }
        public BillDetailsCTL()
        {
            BillId = 0;
            FoodID = 0;
            FoodName = string.Empty;
            Quantity = 0;
        }
    }
}
