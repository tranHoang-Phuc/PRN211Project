using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.Repository
{
    public class FoodRepository
    {
        public List<Food> GetListFoodByCategory(int id)
        {
            List<Food> listFood = GetListFoodByCategoryFromDatabase(id);
            return listFood;
        }

        public List<Food> GetListFoodByCategoryFromDatabase(int id)
        {
            List<Food> listFood;
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                if (id != 9)
                {
                    listFood = (from food in db.Foods where food.IdCateGory == id select food).ToList();
                }
                else 
                {
                    listFood = (from food in db.Foods where food.IdCateGory < id select food).ToList();
                }
            }
            return listFood;
        }
        public List<ListViewItem> GetListViewItemOfListFood(int id)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            List<Food> listFood = GetListFoodByCategoryFromDatabase(id);
            foreach (Food food in listFood)
            {
                ListViewItem item = new ListViewItem(food.Id.ToString());
                item.SubItems.Add(food.Name.ToString());
                item.SubItems.Add("Updating");
                item.SubItems.Add(food.Price.ToString());
                item.SubItems.Add(food.IdCateGory.ToString());
                listViewItems.Add(item);
            }
            return listViewItems;
        }
        //lấy ra danh sách dạng ListViewItem (Công).
        public void InsertFood(string nameFood, string imageFood, double priceFood, int idCategory)
        {
            Food food = new Food()
            {
                Name = nameFood,
                Images = imageFood,
                Price = priceFood,
                IdCateGory = idCategory
            };
            using (CoffeemanagerContext data = new CoffeemanagerContext())
            {
                try
                {
                    data.Foods.Add(food);
                    data.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Chèn thêm 1 food
        public void UpdateFood(int idFood, string nameFood, double priceFood, int idCategory)
        {
            using (CoffeemanagerContext data = new CoffeemanagerContext())
            {
                try
                {
                    var foodToUpdate = data.Foods.SingleOrDefault(f => f.Id == idFood);
                    if (foodToUpdate != null)
                    {
                        foodToUpdate.Id = idFood;
                        foodToUpdate.Name = nameFood; // thay tên mới của món ăn
                        foodToUpdate.Images = string.Empty;
                        foodToUpdate.Price = priceFood; // thay giá mới của món ăn
                        foodToUpdate.IdCateGory = idCategory;
                        data.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        //update 1 món ăn dựa trên id món
        public void DeleteFood(int idFood)
        {
            using (CoffeemanagerContext data = new CoffeemanagerContext())
            {
                try
                {
                    var foodToDelete = data.Foods.SingleOrDefault(f => f.Id == idFood);
                    if (foodToDelete != null)
                    {
                        data.Foods.Remove(foodToDelete);
                        data.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //xóa 1 món ăn theo id truyền vào
        public bool FindFoodByName(string foodName)
        {
            using (CoffeemanagerContext data = new CoffeemanagerContext())
            {
                var food = data.Foods.Where(f => f.Name == foodName).FirstOrDefault();
                if (food != null)
                {
                    return true;
                }
                return false;
            }
        }
        //xác nhận tên món ăn mới đã tồn tại hay chưa
        public bool FindFoodByNameBeforUpdate(int fId, string fName)
        {
            using (CoffeemanagerContext data = new CoffeemanagerContext())
            {
                var food = (from i in data.Foods
                            where i.Name == fName && i.Id != fId
                            select i).FirstOrDefault();
                if (food != null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
