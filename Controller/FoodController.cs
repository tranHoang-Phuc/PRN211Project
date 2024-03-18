using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controller
{
    public class FoodController
    {
        private frmTable _fTable;
        private FoodRepository _foodModel;

        public FoodController()
        {
            _fTable = new frmTable();
            _foodModel = new FoodRepository();
        }

        public FoodController(frmTable fTable)
        {
            _fTable = fTable;
            _foodModel = new FoodRepository();
        }

        public void GetListFoodByCategory(int id)
        {
            List<Food> listFood = _foodModel.GetListFoodByCategory(id);
            _fTable.LoadFoodByCategory(listFood);
        }

        public void InsertFood(string nameFood, string imageFood, double priceFood, int idCategory)
        {
            _foodModel.InsertFood(nameFood, imageFood, priceFood, idCategory);
        }
        //
        public void UpdateFood(int idFood, string nameFood, double priceFood, int idCategory)
        {
            _foodModel.UpdateFood(idFood, nameFood, priceFood, idCategory);
        }
        //
        public void DeleteFood(int idFood)
        {
            _foodModel.DeleteFood(idFood);
        }
        //
        public bool FindFoodByName(string foodName)
        {
            return _foodModel.FindFoodByName(foodName);
        }
        //
        public bool FindFoodByNameBeforUpdate(int fId, string fName)
        {
            return _foodModel.FindFoodByNameBeforUpdate(fId, fName);
        }
    }
}
