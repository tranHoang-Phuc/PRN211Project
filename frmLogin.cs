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
using WinFormsApp1.Repository;

namespace WinFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            EmployeeRepository loginModel = new EmployeeRepository();
            LoginController loginController = new LoginController(loginModel);
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Hãy nhập tên đăng nhập và mật khẩu");
                return;
            }
            if (loginController.LoginSuccess(userName, password))
            {
                frmHome.isSucces = true;
                frmHome.accountName = userName;
                frmHome.currentEmployees = loginController.currentEmployees;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!frmHome.isSucces)    //nếu thoát form trực tiếp => thoát chương trình
            {
                Application.Exit();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
