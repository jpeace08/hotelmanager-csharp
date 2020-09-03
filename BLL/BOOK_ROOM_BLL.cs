using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BOOK_ROOM_BLL
    {
        //load bookroom:
        public static bool bookRoom(ROOM_BOOK_DTO rOOM_BOOK)
        {
            return BOOK_ROOM_DAL.bookRoom(rOOM_BOOK);
        }
        //load get info book room by id:
        public static ROOM_BOOK_DTO getInfoBookRoom(ROOM_DTO rOOM_)
        {
            return BOOK_ROOM_DAL.getInfoBookRoomById(rOOM_);
        }

        //load get info list book room by id:
        public static List<ROOM_BOOK_DTO> getListBookRoomById(ROOM_DTO rOOM_DTO)
        {
            return BOOK_ROOM_DAL.getlistBookRoomById(rOOM_DTO);
        }

        //load update info bookroom:
        public static bool updateInfoBookRoomById(ROOM_BOOK_DTO rOOM_BOOK_)
        {
            return BOOK_ROOM_DAL.updateInfoBookRoomById(rOOM_BOOK_);
        }

        //update time check out:
        public static bool updateTimeCheckOut(string sqlExe)
        {
            return BOOK_ROOM_DAL.updateTimeCheckOut(sqlExe);
        }

        //load cancel book room:
        public static bool cancelBookRoom(string sqlExe)
        {
            return BOOK_ROOM_DAL.cancelBookRoom(sqlExe);
        }

        //load edit room code on bookroomorder:
        public static bool updateRoomCode(ROOM_DTO room, string oldRoomCode)
        {
            return BOOK_ROOM_DAL.updateRoomCode(room, oldRoomCode);
        }

        //load get bookrooms by month/year:
        public static List<ROOM_BOOK_DTO> getRoomBooks(string sqlQuery)
        {
            return BOOK_ROOM_DAL.getRoomBooks(sqlQuery);
        }

        //get revenue per month/year:
        public static decimal getRevenue(string sqlQuery)
        {
            return BOOK_ROOM_DAL.getRevenue(sqlQuery);
        }
    }
}
