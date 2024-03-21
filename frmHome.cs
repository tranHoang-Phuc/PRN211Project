﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models.Entity;

namespace WinFormsApp1
{
    public partial class frmHome : Form
    {
        public static bool isSucces = false;
        public static string accountName;
        public static Employee currentEmployees;
        public frmHome()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if(!isSucces)
            {
                Application.Exit();
            }
            InitializeComponent();
        }
        bool sidebarExpand;
        private Form currentChildForm; // Biến để lưu trữ form con hiện tại
        private void OpenChildForm(Form childForm)       //hàm mở form con.
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Đóng form con hiện tại nếu đã tồn tại
            }
            currentChildForm = childForm;       //gán form con hiện tại bằng form truyền vào
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;       //bỏ phần tittle của form
            childForm.Dock = DockStyle.Fill;        //căn giữa
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //
        }
        // hàm đổi màu button khi nhấn.
        private void ChangeColorBtn(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6)
        {
            b1.BackColor = Color.DeepSkyBlue;
            b2.BackColor = Color.Transparent;
            b3.BackColor = Color.Transparent;
            b4.BackColor = Color.Transparent;
            b5.BackColor = Color.Transparent;
            b6.BackColor = Color.Transparent;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.Text.Trim())
            {
                case "Tại quán":
                    OpenChildForm(new frmTable());
                    ChangeColorBtn(btnHome, btnBill, btnMenu, btnRevenua, btnTakeAway, btnSetting);
                    break;
                case "Mang đi":
                    OpenChildForm(new frmTakeaway());
                    ChangeColorBtn(btnTakeAway, btnBill, btnHome, btnMenu, btnRevenua, btnSetting);
                    break;
                case "Thực đơn":
                    OpenChildForm(new frmMenuFood());
                    ChangeColorBtn(btnMenu, btnBill, btnHome, btnRevenua, btnTakeAway, btnSetting);
                    break;
                case "Hóa đơn":
                    OpenChildForm(new frmBill());
                    ChangeColorBtn(btnBill, btnHome, btnMenu, btnRevenua, btnTakeAway, btnSetting);
                    break;
                case "Nhân sự":
                    if (currentEmployees.JobId == 2 || currentEmployees.JobId == 3)
                    {
                        OpenChildForm(new frmEmployees());
                        ChangeColorBtn(btnRevenua, btnBill, btnHome, btnMenu, btnTakeAway, btnSetting);
                    }
                    break;
                case "Cài đặt":
                    ChangeColorBtn(btnSetting, btnBill, btnHome, btnMenu, btnTakeAway, btnRevenua);
                    frmSetting f = new frmSetting(this);
                    f.Location = new Point(20, 500);
                    f.ShowDialog();
                    break;
            }

        }

        //hàm mở rộng và thu nhỏ thanh menu (bên trái)
        bool pnLeft_miniSize = false;
        private void ptbMenu_Click(object sender, EventArgs e)
        {
            if (pnLeft_miniSize)
            {
                pnLeft.Size = new Size(219, pnLeft.Size.Height);
                pnLeft_miniSize = false;
            }
            else
            {
                pnLeft.Size = new Size(50, pnLeft.Size.Height);
                pnLeft_miniSize = true;
            }
        }
        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy sự kiện đóng form
                }
            }
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            lbAccountName.Text = accountName;
        }
    }
}
