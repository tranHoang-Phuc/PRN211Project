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
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1
{
    public partial class frmBill : Form
    {
        private BillController _billController;
        private bool[] isSort;
        public frmBill()
        {
            InitializeComponent();
            _billController = new BillController(this);
            if (frmHome.currentEmployees.JobId == 3)
            {
                btnDelete.Enabled = true;
            }
            isSort = new bool[4];
        }

        private void btnCloseFormBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadBillOfDateSelect()
        {
            DateTime selectedDateStart = dtpStart.Value.Date;
            DateTime selectedDateEnd = dtpEnd.Value.Date;
            lsvBill.Items.Clear();
            float total = 0;
            List<BillDetail> listBill = _billController.getListBillOfDate(selectedDateStart, selectedDateEnd);
            foreach (BillDetail billDetail in listBill)
            {
                total += (float)billDetail.TotalPrice;
                ListViewItem lsvItem = new ListViewItem(billDetail.Id.ToString());
                lsvItem.SubItems.Add(billDetail.TableName.ToString());
                lsvItem.SubItems.Add(String.Format("{0:MM/dd/yyyy}", billDetail.DateCheckIn));
                lsvItem.SubItems.Add(billDetail.TotalPrice?.ToString());
                lsvBill.Items.Add(lsvItem);
            }
            txtTotal.Text = total.ToString("c");
        }

        private void btnShow_Click_2(object sender, EventArgs e)
        {
            LoadBillOfDateSelect();
        }

        private void lsvBill_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (lsvBill.SelectedItems.Count > 0)
                {
                    lsvBillDetail.Items.Clear();
                    ListViewItem selectedItem = lsvBill.SelectedItems[0];
                    string id = selectedItem.SubItems[0].Text;
                    List<Menu> listBillInfo = _billController.getListMenuBill(int.Parse(id));
                    foreach (Menu item in listBillInfo)
                    {
                        ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                        lsvItem.SubItems.Add(item.Count.ToString());
                        lsvItem.SubItems.Add(item.Price.ToString("c"));
                        lsvItem.SubItems.Add(item.TotalPrice.ToString("c"));
                        lsvBillDetail.Items.Add(lsvItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    int idBill = int.Parse(lsvBill.SelectedItems[0].Text);
                    _billController.DeleteTakeAwayBill(idBill);
                    LoadBillOfDateSelect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvBill_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int column = e.Column;
            List<dynamic> listBills = lsvBill.Items.Cast<ListViewItem>()
            .Select(item => new
            {
                Id = int.Parse(item.SubItems[0].Text),
                tableName = item.SubItems[1].Text,
                date = DateOnly.Parse(item.SubItems[2].Text),
                price = Convert.ToDecimal(item.SubItems[3].Text)
            }).ToList<dynamic>();
            if (!isSort[column])
            {
                if (column == 0)
                {
                    listBills.Sort((x, y) => y.Id.CompareTo(x.Id)); // GIẢM DẦN
                    isSort[column] = true;
                }
                if (column == 1)
                {
                    listBills.Sort((x, y) => y.tableName.CompareTo(x.tableName));
                    isSort[column] = true;
                }
                if (column == 3)
                {
                    listBills.Sort((x, y) => y.price.CompareTo(x.price));
                    isSort[column] = true;
                }
                if (column == 2)
                {
                    listBills.Sort((x, y) => y.date.CompareTo(x.date));
                    isSort[column] = true;
                }
            }
            else
            {
                if (column == 0)
                {
                    listBills.Sort((x, y) => x.Id.CompareTo(y.Id));
                    isSort[column] = false;
                }
                if (column == 1)
                {
                    listBills.Sort((x, y) => x.tableName.CompareTo(y.tableName));
                    isSort[column] = false;
                }
                if (column == 3)
                {
                    listBills.Sort((x, y) => x.price.CompareTo(y.price));
                    isSort[column] = false;
                }
                if (column == 2)
                {
                    listBills.Sort((x, y) => x.date.CompareTo(y.date));
                    isSort[column] = false;
                }
            }
            LoadBills(listBills);
        }
        public void LoadBills(List<dynamic> listBills)
        {
            lsvBill.Items.Clear();
            foreach (dynamic item in listBills)
            {
                ListViewItem lsvItem = new ListViewItem(item.Id.ToString());
                lsvItem.SubItems.Add(item.tableName);
                lsvItem.SubItems.Add(item.date.ToString());
                lsvItem.SubItems.Add(item.price.ToString());
                lsvBill.Items.Add(lsvItem);
            }
        }
    }
}
