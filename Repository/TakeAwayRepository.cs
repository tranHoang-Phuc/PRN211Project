using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1.Repository
{
    public class TakeAwayRepository
    {
        public List<Bill> GetListBillofTakeAway_Waitting()
        {
            List<Bill> listFood;
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                listFood = (from bill in db.Bills
                            where bill.IdTableFood == 1 && bill.DateCheckOut == null
                            select bill).ToList();
            }
            return listFood;
        }//lấy bill mang về đang chờ.
        public List<Bill> GetListBillofTakeAway_Finished()
        {
            List<Bill> listFood;
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                listFood = (from bill in db.Bills
                            where bill.IdTableFood == 1 && bill.DateCheckOut != null
                            select bill).ToList();
            }
            return listFood;
        }//lấy bill mang về đã hoàn thành
        public List<BillDetailsCTL> GetBillDetail(int idB)
        {
            List<BillDetailsCTL> listBillDetails = new List<BillDetailsCTL>();
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var varbillDetails = from bi in db.BillInfos
                                     join f in db.Foods on bi.IdFood equals f.Id
                                     join b in db.Bills on bi.IdBill equals b.Id
                                     where b.IdTableFood == 1 && b.Id == idB
                                     group new { bi, f } by new { bi.IdBill, f.Id, f.Name, bi.Count } into g
                                     select new
                                     {
                                         idBill = g.Key.IdBill,
                                         FoodID = g.Key.Id,
                                         name = g.Key.Name,
                                         count = g.Key.Count
                                     };
                foreach (var b in varbillDetails)
                {
                    BillDetailsCTL billDetailsCTL = new BillDetailsCTL(b.idBill, b.FoodID, b.name, b.count);
                    listBillDetails.Add(billDetailsCTL);
                }
            }
            return listBillDetails;
        }
        //lấy danh sách chi tiết bill
        public void CheckOutTABill(int id)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var bill = db.Bills.FirstOrDefault(b => b.Id== id);
                if (bill != null)
                {
                    bill.DateCheckOut = DateTime.Now;
                    db.SaveChanges();
                }
            }
        }
    }
}
