using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class EMPLOYEE_BLL
    {
        //load get list user:
        public static List<EMPLOYEE_DTO> getEmployees(string sqlQuery)
        {
            return EMPLOYEE_DAL.getEmployees(sqlQuery);
        }

        // load add employee:
        public static bool addEmployee(EMPLOYEE_DTO empl)
        {
            return EMPLOYEE_DAL.addEmployee(empl);
        }

        // load update info employee:
        public static bool updateInfoEmpl(EMPLOYEE_DTO empl)
        {
            return EMPLOYEE_DAL.updateInfoEmpl(empl);
        }

        //del user:
        public static bool delUser(int userCode)
        {
            return EMPLOYEE_DAL.delUser(userCode);
        }

        //update pass:
        public static bool updatePassWord(EMPLOYEE_DTO empl)
        {
            return EMPLOYEE_DAL.updatePassWord(empl);
        }
    }
}
