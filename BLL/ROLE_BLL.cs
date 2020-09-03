using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BLL
{
    public class ROLE_BLL
    {
        //load get roles:
        public static List<ROLE_DTO> getRoles(string sqlQuery)
        {
            return ROLE_DAL.getRoles(sqlQuery);
        }
    }
}
