using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class CHECKOUT_BLL
    {
        //load get info bill:
        public static BILL_DTO getInfoBill(string sqlQuery, string roomBookType)
        {
            return CHECKOUT_DAL.getInfoBill(sqlQuery, roomBookType);
        }

        //add bill:
        public static bool addBill(string sqlExe)
        {
            return CHECKOUT_DAL.addBill(sqlExe);
        }

        //load list bill
        public static DataTable getListBills(string sqlQuery)
        {
            return CHECKOUT_DAL.getBills(sqlQuery);
        }

        //load del bills by room:
        public static bool delBillsByRoom(ROOM_DTO room)
        {
            return CHECKOUT_DAL.delBillsbyRoom(room);
        }
    }
}
