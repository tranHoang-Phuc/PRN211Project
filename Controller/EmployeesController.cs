using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Models.Pojo;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controller
{
    public class EmployeesController
    {
        private EmployeeRepository _employeesModel;
        private frmEmployees _fEmployees;
        public EmployeesController(frmEmployees fEmployees)
        {
            _employeesModel = new EmployeeRepository();
            _fEmployees = fEmployees;
        }

        public void addEmployees(Employee newEmployee)
        {
            Employee exitsEmployees = _employeesModel.GetExistEmployees(newEmployee.Email);
            if (exitsEmployees != null)
            {
                MessageBox.Show($"Email {exitsEmployees.Email} đã tồn tại vui long chọn một email khác");
            }
            else
            {
                _employeesModel.AddEmployees(newEmployee);
            }

        }

        public void loadListEmployees()
        {
            List<EmployeeDetail> listEmployees = _employeesModel.GetListEmployees();
            _fEmployees.LoadEmployees(listEmployees);
        }

        public void updateEmployees(Employee newEmployees)
        {
            _employeesModel.UpdateEmployees(newEmployees);
        }

        public void removeEmployees(int idEmployees)
        {
            _employeesModel.RemoveEmployee(idEmployees);
        }
    }   
}
