using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ROOM_BLL
    {
        //load get rooms:
        public static List<ROOM_DTO> getRooms(string sqlQuery)
        {
            return ROOM_DAL.getRooms(sqlQuery);
        }

        //load add room:
        public static bool addRoom(ROOM_DTO room)
        {
            return ROOM_DAL.addRoom(room);
        }

        //load update status room:
        public static bool updateStatusRoom(string sqlQuery)
        {
            return ROOM_DAL.updateStatusRoom(sqlQuery);
        }

        //load get roomCodes:
        public static List<string> getRoomCodes(string sqlQuery)
        {
            return ROOM_DAL.getRoomCodes(sqlQuery);
        }

        //del room by id:
        public static bool delRoomById(ROOM_DTO room)
        {
            return ROOM_DAL.delRoomById(room);
        }

        // load edit room info:
        public static bool updateInfoRoom(ROOM_DTO room, string oldRoomCode)
        {
            return ROOM_DAL.updateInfoRoom(room, oldRoomCode);
        }
    }
}
