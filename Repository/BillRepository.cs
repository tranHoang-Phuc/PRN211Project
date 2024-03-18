using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1.DataAccess
{
    public class BillRepository
    {
        public void InsertBill(int idTable)
        {

            try
            {
                using (CoffeemanagerContext db = new CoffeemanagerContext())
                {
                    Bill newBill = new Bill()
                    {
                        DateCheckIn = DateTime.Now,
                        DateCheckOut = null,
                        IdTableFood = idTable,
                        EmployeeId = frmHome.currentEmployees.Id,
                        Status = false
                    };

                    db.Bills.Add(newBill);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm hóa đơn " + ex.Message);
                throw;
            }
        }

        public int GetUnCheckBillIDByTableId(int tableId)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var bill = db.Bills.FirstOrDefault(b => b.IdTableFood == tableId && b.Status.Equals(0));
                if (bill != null)
                {
                    return bill.Id;
                }
                else
                {
                    return -1;
                }
            }
        }


        public int GetMaxIDBill()
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                int maxId = db.Bills.Max(b => b.Id);
                return maxId;
            }
        }

        public List<Menu> GetListMenuTable(int id)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var menuItems = from bi in db.BillInfos
                                join b in db.Bills on bi.IdBill equals b.Id
                                join f in db.Foods on bi.IdFood equals f.Id
                                where b.Status.Equals(0) && b.IdTableFood == id
                                select new Menu
                                {
                                    Name = f.Name,
                                    Count = bi.Count,
                                    Price = (float)f.Price,
                                    TotalPrice = (float)(f.Price * bi.Count)
                                };

                return menuItems.ToList();
            }
        }


        public List<Menu> GetListMenuBill(int idBill)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var menuItems = from bi in db.BillInfos
                                join b in db.Bills on bi.IdBill equals b.Id
                                join f in db.Foods on bi.IdFood equals f.Id
                                where b.Id == idBill
                                select new Menu
                                {
                                    Name = f.Name,
                                    Count = bi.Count,
                                    Price = (float)f.Price,
                                    TotalPrice = (float)(f.Price * bi.Count)
                                };

                return menuItems.ToList();
            }
        }


        public void CheckOut(int id)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var bill = db.Bills.FirstOrDefault(b => b.Id == id);
                if (bill != null && bill.IdTableFood != 1)
                {
                    bill.Status = true;
                    bill.DateCheckOut = DateTime.Now;
                    db.SaveChanges();
                }
                else
                {
                    bill.Status = true;
                    db.SaveChanges();
                }
            }
        }

        public List<BillDetail> GetAllBillCheckoutOfDate(DateTime selectedDateStart, DateTime? selectedDateEnd)
        {
            if (selectedDateStart != DateTime.Now)
            {
                using (CoffeemanagerContext db = new CoffeemanagerContext())
                {
                    var billDetails = from b in db.Bills
                                      join tf in db.TableFoods on b.IdTableFood equals tf.Id
                                      where b.Status.Equals(1) && b.DateCheckIn >= selectedDateStart && b.DateCheckIn <= selectedDateEnd
                                      select new BillDetail
                                      {
                                          Id = b.Id,
                                          TableName = tf.Name,
                                          DateCheckIn = b.DateCheckIn,
                                          DateCheckOut = b.DateCheckOut,
                                          TotalPrice = (float?)(b.BillInfos.Sum(bi => bi.Count * (float)(bi.IdFoodNavigation.Price))) ?? 0
                                      };
                    return billDetails.ToList();
                }
            }
            else
            {
                using (CoffeemanagerContext db = new CoffeemanagerContext())
                {
                    var billDetails = from b in db.Bills
                                      join tf in db.TableFoods on b.IdTableFood equals tf.Id
                                      where b.Status.Equals(1) && b.DateCheckIn == selectedDateStart
                                      select new BillDetail
                                      {
                                          Id = b.Id,
                                          TableName = tf.Name,
                                          DateCheckIn = b.DateCheckIn,
                                          DateCheckOut = b.DateCheckOut,
                                          TotalPrice = (float?)(b.BillInfos.Sum(bi => bi.Count * (float)(bi.IdFoodNavigation.Price))) ?? 0
                                      };
                    return billDetails.ToList();
                }
            }
        }
        public void DeleteTakeAwayBill(int idFB)
        {
            using (CoffeemanagerContext data = new CoffeemanagerContext())
            {
                var billInForToDelete = data.BillInfos.Where(b => b.IdBill == idFB);
                if (billInForToDelete != null)
                {
                    foreach (BillInfo b in billInForToDelete)
                    {
                        data.BillInfos.Remove(b);
                        data.SaveChanges();
                    }
                }
                //
                var billToDelete = data.Bills.SingleOrDefault(b => b.Id == idFB);
                if (billToDelete != null)
                {
                    data.Bills.Remove(billToDelete);
                    data.SaveChanges();
                }
            }

        }
    }
}
