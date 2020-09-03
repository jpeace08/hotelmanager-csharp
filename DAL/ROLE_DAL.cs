using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ROLE_DAL
    {
        //get roles:
        public static List<ROLE_DTO> getRoles(string sqlQuery)
        {
            List<ROLE_DTO> roles;
            ROLE_DTO role;
            DataTable tb = DataProvider.Query(sqlQuery);
            if(tb != null && tb.Rows.Count > 0)
            {
                roles = new List<ROLE_DTO>();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    role = new ROLE_DTO()
                    {
                        RoleCode = int.Parse(tb.Rows[i]["MaPhanQuyen"].ToString()),
                        RoleName = tb.Rows[i]["TenPhanQuyen"].ToString()
                    };
                    roles.Add(role);
                }
                return roles;
            }
            else
            {
                return null;
            }
        }
    }
}
