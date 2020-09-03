using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ROOM_TYPE_BLL
    {
        //load get type-room of hotel:
        public static List<ROOM_TYPE_DTO> getRoomTypes(string sqlQuery)
        {
            return ROOM_TYPE_DAL.getRoomTypes(sqlQuery);
        }
    }
}
