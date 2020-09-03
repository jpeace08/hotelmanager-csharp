using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class EMPLOYEE_DAL
    {
        //get list user:
        public static List<EMPLOYEE_DTO> getEmployees(string sqlQuery)
        {
            List<EMPLOYEE_DTO> eMPLOYEE_s;
            EMPLOYEE_DTO employee;
            DataTable tb = DataProvider.Query(sqlQuery);
            if (tb != null && tb.Rows.Count > 0)
            {
                eMPLOYEE_s = new List<EMPLOYEE_DTO>();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    employee = new EMPLOYEE_DTO()
                    {
                        EmployeeCode = int.Parse(tb.Rows[i]["MaNhanVien"].ToString()),
                        EmployeeName = tb.Rows[i]["TenNhanVien"].ToString(),
                        EmployAddress = tb.Rows[i]["DiaChi"].ToString(),
                        EmployeePhone = tb.Rows[i]["SoDienThoai"].ToString(),
                        Username = tb.Rows[i]["TenDangNhap"].ToString(),
                        Password = tb.Rows[i]["MatKhau"].ToString(),
                        RoleCode = int.Parse(tb.Rows[i]["MaPhanQuyen"].ToString())
                    };
                    eMPLOYEE_s.Add(employee);
                }
                return eMPLOYEE_s;
            }
            else
            {
                return null;
            }
        }

        //add employee:
        public static bool addEmployee(EMPLOYEE_DTO empl)
        {
            string sqlExe = "INSERT INTO [dbo].[NHAN_VIEN] VALUES (N'"+empl.EmployeeName+"','"+empl.EmployeePhone+"',N'"+empl.EmployAddress+"','"+empl.Username+"','"+empl.Password+"',"+empl.RoleCode+")";
            return DataProvider.ExeSql(sqlExe);
        }

        //update info employee:
        public static bool updateInfoEmpl(EMPLOYEE_DTO empl)
        {
            string sqlExe = "UPDATE [dbo].[NHAN_VIEN] SET[TenNhanVien] = N'"+empl.EmployeeName+"',[SoDienThoai] = '"+empl.EmployeePhone+"',[DiaChi] = N'"+empl.EmployAddress+"',[TenDangNhap] = '"+empl.Username+"',[MatKhau] = '"+empl.Password+"',[MaPhanQuyen] = "+empl.RoleCode+" WHERE MaNhanVien = "+empl.EmployeeCode+";";
            return DataProvider.ExeSql(sqlExe);
        }

        //del user:
        public static bool delUser(int userCode)
        {
            string sqlExe = "Delete from NHAN_VIEN where MaNhanVien = " + userCode + ";";
            return DataProvider.ExeSql(sqlExe);
        }


        public static bool updatePassWord(EMPLOYEE_DTO empl)
        {
            string sqlExe = "UPDATE [dbo].[NHAN_VIEN] SET [MatKhau] = '" + empl.Password + "' WHERE [MaNhanVien] = "+empl.EmployeeCode+";";
            return DataProvider.ExeSql(sqlExe);
        }
    }
}
