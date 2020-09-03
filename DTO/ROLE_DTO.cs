using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ROLE_DTO
    {
        private int roleCode;
        private string roleName;

        public int RoleCode { get => roleCode; set => roleCode = value; }
        public string RoleName { get => roleName; set => roleName = value; }
    }
}
