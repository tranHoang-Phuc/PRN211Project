using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.Repository
{
    public class TableRepository
    {
        public List<TableFood> GetListTable()
        {
            try
            {
                using (CoffeemanagerContext db = new CoffeemanagerContext())
                {
                    List<TableFood> listTable = db.TableFoods.ToList();
                    return listTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lấy danh sách bàn" + ex);
                throw;
            }
        }

        public bool AddTable(string nameTable)
        {
            try
            {
                using (CoffeemanagerContext db = new CoffeemanagerContext())
                {
                    TableFood table = new TableFood
                    {
                        Name = nameTable,
                        Status = false
                    };
                    db.TableFoods.Add(table);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thêm bàn" + ex);
                return false;
            }

        }

        public void ChangeStatus(int tableId)
        {
            using(var context = new CoffeemanagerContext())
            {
                var table = context.TableFoods.Find(tableId);
                if (table.Status.Value == false)
                {
                    table.Status = true;

                }
                context.SaveChanges();
            }
        }

        public void ChangeStatusToFalse(int tableId)
        {
            using (var context = new CoffeemanagerContext())
            {
                var table = context.TableFoods.Find(tableId);
                if (table.Status.Value == true)
                {
                    table.Status = false;

                }
                context.SaveChanges();
            }
        }
    }
}
