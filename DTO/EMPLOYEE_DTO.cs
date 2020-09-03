using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EMPLOYEE_DTO
    {
        private int employeeCode;
        private string employeeName;
        private string employeePhone;
        private string employAddress;
        private string username;
        private string password;
        private int roleCode;

        public int EmployeeCode { get => employeeCode; set => employeeCode = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePhone { get => employeePhone; set => employeePhone = value; }
        public string EmployAddress { get => employAddress; set => employAddress = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int RoleCode { get => roleCode; set => roleCode = value; }
    }
}
