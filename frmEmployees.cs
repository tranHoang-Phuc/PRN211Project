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
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1
{
    public partial class frmEmployees : Form
    {
        private JobController _jobController;
        private EmployeesController _employeesController;
        private ListViewItem selectedListViewItem;
        public frmEmployees()
        {
            InitializeComponent();
            _jobController = new JobController(this);
            _employeesController = new EmployeesController(this);
            _jobController.LoadListJob();
            _employeesController.loadListEmployees();
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
                            _employeesController.loadListEmployees();
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
                    _employeesController.loadListEmployees();
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
                            _employeesController.loadListEmployees();
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

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Split('@')[1].Contains(".");
        }

        private void btnCloseFormRevenue_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
