using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1.Controller
{
    public class CategoryController
    {
        private frmTable _fTable;
        private FoodCategoryRepository _categoryModel;
        public CategoryController(frmTable fTable)
        {
            _fTable = fTable;
            _categoryModel = new FoodCategoryRepository();
        }

        public void LoadCategory()
        {
            List<FoodCategory> listCategory = _categoryModel.GetListCategory();
            _fTable.LoadListCategory(listCategory);
        }
    }
}
