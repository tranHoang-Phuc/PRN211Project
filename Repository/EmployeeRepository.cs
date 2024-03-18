using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.DataAccess;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;

namespace WinFormsApp1.Repository
{
    public class EmployeeRepository
    {
        public void AddEmployees(Employee newEmployee)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                try
                {
                    db.Employees.Add(newEmployee);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateEmployees(Employee newEmployee)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                try
                {
                    Employee existEmployee = db.Employees.SingleOrDefault(e => e.Id == newEmployee.Id);
                    if (existEmployee != null)
                    {
                        existEmployee.FirstName = newEmployee.FirstName;
                        existEmployee.LastName = newEmployee.LastName;
                        existEmployee.Email = newEmployee.Email;
                        existEmployee.PhoneNumber = newEmployee.PhoneNumber;
                        existEmployee.JobId = newEmployee.JobId;
                        existEmployee.DateStartWork = newEmployee.DateStartWork;
                        existEmployee.UserName = newEmployee.UserName;
                        existEmployee.Password = newEmployee.Password;
                        db.SaveChanges();
                        MessageBox.Show("Update nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi update nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void RemoveEmployee(int id)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                try
                {
                    Employee employee = db.Employees.FirstOrDefault(e => e.Id == id);
                    if (employee != null)
                    {
                        db.Employees.Remove(employee);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa nhân viên" + ex.Message);
                }
            }
        }


        public Employee GetExistEmployees(string email)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {

                var existEmployees = (from e in db.Employees
                                      where e.Email == email
                                      select e).FirstOrDefault();
                return existEmployees;
            }
        }

        public List<EmployeeDetail> GetListEmployees()
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                var listEmployees = from e in db.Employees
                                    join j in db.Jobs on e.JobId equals j.Id
                                    select new EmployeeDetail
                                    {
                                        Id = e.Id,
                                        FirstName = e.FirstName,
                                        LastName = e.LastName,
                                        Email = e.Email,
                                        PhoneNumber = e.PhoneNumber,
                                        Job = j.Name,
                                        IdJob = j.Id,
                                        DateStartWork = e.DateStartWork,
                                        UserName = e.UserName,
                                        Password = e.Password,
                                    };
                return listEmployees.ToList();
            }
        }

        public Employee LoginSuccess(string userName, string password)
        {
            using (CoffeemanagerContext db = new CoffeemanagerContext())
            {
                return db.Employees.Where(e => e.UserName == userName && e.Password == password).FirstOrDefault();
            }
        }
    }
}
