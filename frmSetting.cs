using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmSetting : Form
    {
        private frmHome frmHome;
        public frmSetting(frmHome frmHome)
        {
            InitializeComponent();
            this.frmHome = frmHome;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Button bt = (Button)sender;
                switch (bt.Text.Trim())
                {
                    case "X":
                        this.Close();
                        break;
                    case "Đăng xuất":
                        DialogResult result = MessageBox.Show("Xác nhận đăng xuất", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                        break;
                    case "Thoát":
                        DialogResult exitResult = MessageBox.Show("Xác nhận Thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (exitResult == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fSetting_Load(object sender, EventArgs e)
        {
            lbAcccountName.Text = frmHome.accountName;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
