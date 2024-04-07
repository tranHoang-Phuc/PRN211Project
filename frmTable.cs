using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1
{
    public partial class frmTable : Form
    {
        private TableController _tableController;
        private CategoryController _categoryController;
        private FoodController _foodController;
        private BillController _billController;
        private readonly BillInfoController _billInfoController;
        public frmTable()
        {
            InitializeComponent();
            _tableController = new TableController(this);
            _categoryController = new CategoryController(this);
            _foodController = new FoodController(this);
            _billController = new BillController(this);
            _billInfoController = new BillInfoController();
            _tableController.LoadTable();
            _categoryController.LoadCategory();
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem option1 = new ToolStripMenuItem("Thêm bàn");
            option1.Click += AddTable_Click;
            contextMenuStrip.Items.Add(option1);
            this.ContextMenuStrip = contextMenuStrip;
        }

        public void LoadTable(List<TableFood> listTable)
        {
            try
            {
                flpTable.Controls.Clear();
                int tableCount = 0;
                int tableActive = 0;
                int tableEmpty = 0;
                tableCount = listTable.Count;
                foreach (TableFood table in listTable)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button() { Width = 100, Height = 100 };
                    button.Text = table.Name + Environment.NewLine + (table.Status.HasValue ? (table.Status.Value ? "Có khách" : "Trống") : "Không rõ");
                    button.Font = new Font("Arial", 10, FontStyle.Regular);
                    button.Tag = table;
                    button.Margin = new Padding(10);
                    button.Click += table_Click;
                    button.MouseDown += tableMouseDown;
                    flpTable.Controls.Add(button);
                    if (table.Status.HasValue)
                    {
                        bool status = table.Status.Value;
                        if (status)
                        {
                            button.BackColor = Color.Green;
                            button.ForeColor = Color.White;
                            tableActive++;
                        }
                        else
                        {
                            button.BackColor = Color.White;
                            tableEmpty++;
                        }
                    }
                    txtTableActive.Text = (tableCount - tableEmpty).ToString();
                    txtTableEmpty.Text = tableEmpty.ToString();
                    txtTableCount.Text = tableCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                ToolStripMenuItem option1 = new ToolStripMenuItem("Thêm bàn");
                contextMenuStrip.Items.Add(option1);
                contextMenuStrip.Show(this, e.Location);
            }
        }

        public void LoadListCategory(List<FoodCategory> listCategory)
        {
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        public void LoadFoodByCategory(List<Food> listFood)
        {
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
                if (cb.SelectedItem == null)
                {
                    return;
                }
                FoodCategory selected = cb.SelectedItem as FoodCategory;
                id = selected.Id;
                _foodController.GetListFoodByCategory(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void table_Click(object sender, EventArgs e)
        {
            try
            {
                int tableID = ((sender as System.Windows.Forms.Button).Tag as TableFood).Id;
                lsvBill.Tag = (sender as System.Windows.Forms.Button).Tag;
                txtNameTable.Text = ((sender as System.Windows.Forms.Button).Tag as TableFood).Name;

                ShowBill(tableID);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            float totalPrice = 0;
            List<Menu> listBillInfo = _billController.getListMenuBill(id);
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("c"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
                lsvBill.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }
            _tableController.LoadTable();
            txtTotalPrice.Text = totalPrice.ToString("c");
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                TableFood table = lsvBill.Tag as TableFood;
                if (table != null)
                {
                    int idBill = _billController.GetUnCheckBill(table.Id);
                    int idFood = (cbFood.SelectedItem as Food).Id;
                    int count = (int)nmFoodCount.Value;
                    if (idBill == -1)
                    {
                        _billController.insertBill(table.Id);
                        _billInfoController.insertBillInfo(_billController.getMaxIdBill(), idFood, count);
                    }
                    else
                    {
                        _billInfoController.insertBillInfo(idBill, idFood, count);
                    }
                    _tableController.ChangeStatus(table.Id);
                    _tableController.LoadTable();
                    ShowBill(table.Id);
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn bàn nào!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                TableFood table = lsvBill.Tag as TableFood;
                if (table != null)
                {
                    int idBill = _billController.GetUnCheckBill((int)table.Id);
                    if (idBill != -1)
                    {
                        if (MessageBox.Show($"Bạn có chắc thanh toán hóa đơn cho bàn {table.Name}.", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            _billController.checkOut(idBill);
                            ShowBill(table.Id);
                            _tableController.ChangeStatusToFalse(table.Id);
                            _tableController.LoadTable();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Bàn không có hóa đơn nào cần thanh toán!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fTable_Load(object sender, EventArgs e)
        {

        }


        

        private void AddTable_Click(object sender, EventArgs e)
        {
            frmAddTable f = new frmAddTable(this);
            f.ShowDialog();
            _tableController.LoadTable();
            lsvBill.Clear();
        }

        private void btnCloseFormTable_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
