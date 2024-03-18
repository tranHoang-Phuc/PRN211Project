﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Repository;

namespace WinFormsApp1
{
    public partial class frmMenuFood : Form
    {
        private FoodCategoryRepository categoryModel = new FoodCategoryRepository();
        private FoodRepository foodModel = new FoodRepository();
        private FoodController foodController = new FoodController();

        public frmMenuFood()
        {
            InitializeComponent();
        }
        private void fMenuFood_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPermissionByIdJob();
                LoadFindFoddName();
                Loadcategory();
                cbFilterDishes.Text = "All";

                List<FoodCategory> listCategoty = categoryModel.GetListCategory();
                listCategoty.RemoveAt(0);
                cbAddCategory.DataSource = listCategoty;
                cbAddCategory.DisplayMember = "Name";
                cbAddCategory.ValueMember = "id";

                cbEditCategory.DataSource = listCategoty;
                cbEditCategory.DisplayMember = "Name";
                cbEditCategory.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //form load

        public void LoadPermissionByIdJob()
        {
            int jobId = (int)frmHome.currentEmployees.JobId;
            if (jobId == 1)  //nhân viên
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        public void Loadcategory()
        {
            List<FoodCategory> listCategoty = categoryModel.GetListCategory();
            cbFilterDishes.DataSource = listCategoty;
            cbFilterDishes.DisplayMember = "Name";
            cbFilterDishes.ValueMember = "id";
        }
        //Load danh sách foodcategory
        public void LoadLsvMenuFood(int id)
        {
            lsvFood.Items.Clear();      //reset lại data của lsv trước khi load loại mới tránh bị đè dữ liệu cũ.
            List<ListViewItem> listViewItems = foodModel.GetListViewItemOfListFood(id);
            foreach (ListViewItem item in listViewItems)
            {
                lsvFood.Items.Add(item);
            }
            cbFindFoodName.Text = string.Empty;
        }
        //Load menufood dựa vào id category
        public void LoadFindFoddName()
        {
            cbFindFoodName.DataSource = foodModel.GetListFoodByCategoryFromDatabase(9);
            cbFindFoodName.DisplayMember = "Name";
            cbFindFoodName.Text = "All";
        }
        private void lsvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvFood.SelectedItems.Count == 1)
                {
                    grbEditFood.Visible = true;     //hiện form chỉnh sửa.
                    txtEditId.Text = lsvFood.SelectedItems[0].SubItems[0].Text;
                    txtEditFoodName.Text = lsvFood.SelectedItems[0].SubItems[1].Text;
                    txtEditImageName.Text = lsvFood.SelectedItems[0].SubItems[2].Text;
                    txtEditPrice.Text = lsvFood.SelectedItems[0].SubItems[3].Text;
                    cbEditCategory.SelectedValue = Convert.ToInt32(lsvFood.SelectedItems[0].SubItems[4].Text);  //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Load item của SelectedItems vào form "chỉnh sửa"

        private void btnEditExit_Click(object sender, EventArgs e)
        {
            grbEditFood.Visible = false;     //ẩn form chỉnh sửa.
        }
        private void btnCloseFormMenuFood_Click(object sender, EventArgs e)
        {
            this.Close();        //Đóng form
        }

        private void cbFilterDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 9;
                ComboBox cb = (ComboBox)sender;
                FoodCategory cate = (FoodCategory)cb.SelectedItem;
                id = cate.Id;       //lấy Id của item hiện tại của cbFillerDishes
                LoadLsvMenuFood(id);    //Load items của lsvMenuFood
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFindFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lsvFood.Items.Clear();
                List<Food> listFood = foodModel.GetListFoodByCategoryFromDatabase(9);
                foreach (Food food in listFood)
                {
                    if (food.Name.Equals(cbFindFoodName.Text))
                    {
                        ListViewItem item = new ListViewItem(food.Id.ToString());
                        item.SubItems.Add(food.Name.ToString());
                        item.SubItems.Add("Updating");
                        item.SubItems.Add(food.Price.ToString());
                        item.SubItems.Add(food.IdCateGory.ToString());
                        lsvFood.Items.Add(item);
                    }
                }
                cbFilterDishes.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Tìm kiếm món ăn theo tên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nameFood = txtNewFoodName.Text;
                if (foodController.FindFoodByName(nameFood))
                {
                    throw new Exception("Tên món ăn đã tồn tại.");
                }
                string imageFood = string.Empty;
                double priceFood = Convert.ToDouble(txtNewPrice.Text);
                int idCategory = Convert.ToInt32(cbAddCategory.SelectedValue);
                foodController.InsertFood(nameFood, imageFood, priceFood, idCategory);
                //
                txtNewFoodName.Text = string.Empty;
                txtNewPrice.Text = string.Empty;
                Loadcategory();
                cbFilterDishes.Text = "All";        //Load lại form chính
                MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Lấy thông tin món ăn mới đc nhập.

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                System.Windows.Forms.Button bt = sender as System.Windows.Forms.Button;
                switch (bt.Text)
                {
                    case "Update":
                        int idFood = Convert.ToInt32(txtEditId.Text);
                        string nameFood = txtEditFoodName.Text;
                        if (foodController.FindFoodByNameBeforUpdate(idFood, nameFood))
                        {
                            throw new Exception("Tên món ăn đã tồn tại.");
                        }
                        string imageFood = string.Empty;
                        double priceFood = Convert.ToDouble(txtEditPrice.Text);
                        int idCategory = Convert.ToInt32(cbEditCategory.SelectedValue);
                        foodController.UpdateFood(idFood, nameFood, priceFood, idCategory);
                        //
                        txtEditFoodName.Text = string.Empty;
                        txtEditPrice.Text = string.Empty;
                        grbEditFood.Visible = false;
                        Loadcategory();
                        cbFilterDishes.Text = "All";
                        MessageBox.Show("Update món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Xóa món":
                        int idDeleteFood = Convert.ToInt32(txtEditId.Text);
                        foodController.DeleteFood(idDeleteFood);
                        grbEditFood.Visible = false;
                        Loadcategory();
                        cbFilterDishes.Text = "All";
                        MessageBox.Show("Xóa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
