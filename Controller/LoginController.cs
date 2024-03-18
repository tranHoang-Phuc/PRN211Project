using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Entity;
using WinFormsApp1.Repository;

namespace WinFormsApp1.Controller
{
    public class LoginController
    {
        private EmployeeRepository _LoginModel;
        public Employee currentEmployees;

        public LoginController(EmployeeRepository loginModel)
        {
            _LoginModel = new EmployeeRepository();
        }
        public bool LoginSuccess(string username, string password)
        {
            Employee user = _LoginModel.LoginSuccess(username, password);
            currentEmployees = user;
            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
