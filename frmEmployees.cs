using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controller;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1
{
    public partial class frmEmployees : Form
    {
        private JobController _jobController;
        private EmployeesController _employeesController;
        private ListViewItem selectedListViewItem;
        private bool[] isSort;
        public frmEmployees()
        {
            InitializeComponent();
            _jobController = new JobController(this);
            _employeesController = new EmployeesController(this);
            _jobController.LoadListJob();
            _employeesController.loadListEmployees(null);
            isSort = new bool[7];
        }

        private void btnCloseFormRevenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadJob(List<Job> listJob)
        {
            cbJobPosition.DataSource = listJob;
            cbJobPosition.DisplayMember = "Name";
            cbJobPosition.ValueMember = "Id";
        }

        public void LoadEmployees(List<EmployeeDetail> listEmployees)
        {
            lsvEmployees.Items.Clear();
            foreach (EmployeeDetail item in listEmployees)
            {
                ListViewItem lsvItem = new ListViewItem(item.Id.ToString());
                lsvItem.SubItems.Add($"{item.FirstName}");
                lsvItem.SubItems.Add($"{item.LastName}");
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber);
                lsvItem.SubItems.Add(item.Job);
                lsvItem.SubItems.Add(item.DateStartWork.ToString());
                lsvItem.SubItems.Add(item.UserName);
                lsvItem.SubItems.Add(item.Password);
                lsvItem.SubItems.Add(item.IdJob.ToString());
                lsvEmployees.Items.Add(lsvItem);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (frmHome.currentEmployees.JobId == 2 || frmHome.currentEmployees.JobId == 3)
                {
                    if (ValidateForm())
                    {
                        Employee newEmployees = new Employee
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            Email = txtEmail.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            DateStartWork = dtpDataStartWork.Value.Date,
                            JobId = (int)cbJobPosition.SelectedValue,
                            UserName = txtUserName.Text,
                            Password = txtPassword.Text,
                        };
                        DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn thêm {newEmployees.FirstName} {newEmployees.LastName} vào vị trí {cbJobPosition.Text}?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            _employeesController.addEmployees(newEmployees);
                            _employeesController.loadListEmployees(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền thêm nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvEmployees.SelectedItems.Count > 0)
                {
                    selectedListViewItem = lsvEmployees.SelectedItems[0];
                    txtId.Text = selectedListViewItem.SubItems[0].Text;
                    txtFirstName.Text = selectedListViewItem.SubItems[1].Text;
                    txtLastName.Text = selectedListViewItem.SubItems[2].Text;
                    txtEmail.Text = selectedListViewItem.SubItems[3].Text;
                    txtPhoneNumber.Text = selectedListViewItem.SubItems[4].Text;
                    cbJobPosition.Text = selectedListViewItem.SubItems[5].Text;
                    dtpDataStartWork.Text = selectedListViewItem.SubItems[6].Text;
                    if (CheckInValidUser(selectedListViewItem.SubItems[0].Text))
                    {
                        txtUserName.Text = selectedListViewItem.SubItems[7].Text;
                        txtPassword.Text = selectedListViewItem.SubItems[8].Text;
                        txtUserName.ReadOnly = false;
                        txtPassword.ReadOnly = false;
                    }
                    else
                    {
                        txtUserName.Text = "Thông tin riêng tư";
                        txtPassword.Text = "Thông tin riêng tư";
                        txtUserName.ReadOnly = true;
                        txtPassword.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckInValidUser(string idEmployees)
        {
            bool isAdmin = frmHome.currentEmployees.JobId == 3;
            bool isCurrentUser = frmHome.currentEmployees.Id.ToString() == idEmployees;
            if (isCurrentUser || isAdmin)
            {
                return true;
            }

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    int jobiIdNew = _jobController.getJobByName(cbJobPosition.Text).Id;
                    Employee newEmployees = new Employee
                    {
                        Id = int.Parse(txtId.Text),
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        DateStartWork = dtpDataStartWork.Value,
                        JobId = jobiIdNew,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                    };
                    _employeesController.updateEmployees(newEmployees);
                    ResetForm();
                    _employeesController.loadListEmployees(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInValidUser(lsvEmployees.SelectedItems[0].SubItems[0].Text))
                {
                    if (lsvEmployees.SelectedItems.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            int idEmployees = int.Parse(lsvEmployees.SelectedItems[0].SubItems[0].Text);
                            _employeesController.removeEmployees(idEmployees);
                            _employeesController.loadListEmployees(null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền xóa nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ResetForm()
        {
            selectedListViewItem = null;
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            cbJobPosition.SelectedIndex = -1;
            dtpDataStartWork.Value = DateTime.Today;
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetForm();
        }


        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập một địa chỉ email hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserName.Text) || _employeesController.IsInvalidUserName(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {

            //return email.Contains("@") && email.Split('@')[1].Contains(".");

            
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCloseFormRevenue_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvEmployees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int column = e.Column;
           
            List<EmployeeDetail> listEmployees = lsvEmployees.Items.Cast<ListViewItem>()
                .Select(item => new EmployeeDetail
            {
                Id = int.Parse(item.SubItems[0].Text),
                FirstName = item.SubItems[1].Text,
                LastName = item.SubItems[2].Text,
                Email = item.SubItems[3].Text,
                PhoneNumber = item.SubItems[4].Text,
                Job = item.SubItems[5].Text,
                DateStartWork = DateTime.Parse(item.SubItems[6].Text),
                UserName = item.SubItems[7].Text,
                Password = item.SubItems[8].Text,
                IdJob = int.Parse(item.SubItems[9].Text)
            }).ToList();

            // isSort[] : mảng để kiểm tra trạng thái sắp xếp của mỗi cột
            if (!isSort[column])
            {
                if (column == 0)
                {
/*
 
 */
                    listEmployees.Sort((x, y) => y.Id.CompareTo(x.Id)); // GIẢM DẦN
                    isSort[column] = true;
                }
                if (column == 1)
                {
                    listEmployees.Sort((x, y) => y.FirstName.CompareTo(x.FirstName));
                    isSort[column] = true;
                }
                if (column == 2)
                {
                    listEmployees.Sort((x, y) => y.LastName.CompareTo(x.LastName));
                    isSort[column] = true;
                }
                if (column == 3)
                {
                    listEmployees.Sort((x, y) => y.Email.CompareTo(x.Email));
                    isSort[column] = true;
                }
                if (column == 4)
                {
                    listEmployees.Sort((x, y) => y.Job.CompareTo(x.Job));
                    isSort[column] = true;
                }
                if (column == 6)
                {
                    listEmployees.Sort((x, y) => y.DateStartWork.Value.CompareTo(x.DateStartWork.Value));
                    isSort[column] = true;
                }
            } else
            {
                if (column == 0)
                {
                    listEmployees.Sort((x, y) => x.Id.CompareTo(y.Id));
                    isSort[column] = false;
                }
                if (column == 1)
                {
                    listEmployees.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                    isSort[column] = false;
                }
                if (column == 2)
                {
                    listEmployees.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                    isSort[column] = false;
                }
                if (column == 3)
                {
                    listEmployees.Sort((x, y) => x.Email.CompareTo(y.Email));
                    isSort[column] = false;
                }
                if (column == 4)
                {
                    listEmployees.Sort((x, y) => x.Job.CompareTo(y.Job));
                    isSort[column] = false;
                }
                if (column == 6)
                {
                    listEmployees.Sort((x, y) => x.DateStartWork.Value.CompareTo(y.DateStartWork.Value));
                    isSort[column] = false;
                }
            }
            LoadEmployees(listEmployees);
        }
    }
}
