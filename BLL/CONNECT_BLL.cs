using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CONNECT_BLL
    {
        //Check to database:
        public static bool Connect(string strConnect)
        {
            return DataProvider.Connect(strConnect);
        }
    }
}
