using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.DataAccess
{
    public class FoodCategoryRepository
    {
        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> listCategory = GetListCategoryFromDatabase();
            return listCategory;
        }

        private List<FoodCategory> GetListCategoryFromDatabase()
        {
            List<FoodCategory> listCategory;
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                listCategory = db.FoodCategories.ToList();
            }
            return listCategory;
        }
    }
}
