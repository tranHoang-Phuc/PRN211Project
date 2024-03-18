using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.DataAccess
{
    public class BillInfoRepository
    {
        public void InseartOrUpdateBillInfo(int idBill, int idFood, int count)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                try
                {
                    var existingBillInfo = db.BillInfos.FirstOrDefault(bi => bi.IdBill == idBill && bi.IdFood == idFood);

                    if (existingBillInfo != null)
                    {
                        existingBillInfo.Count += count;
                        if (existingBillInfo.Count <= 0)
                        {
                            db.BillInfos.Remove(existingBillInfo);
                        }
                    }
                    else
                    {
                        BillInfo newBillInfo = new BillInfo()
                        {
                            IdBill = idBill,
                            IdFood = idFood,
                            Count = count
                        };
                        db.BillInfos.Add(newBillInfo);
                    }

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm hóa đơn");
                }
            }
        }
    }
}
