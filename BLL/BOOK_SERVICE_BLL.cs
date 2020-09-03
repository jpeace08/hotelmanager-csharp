using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BOOK_SERVICE_BLL
    {
        //load book service:
        public static bool bookService(BOOK_SERVICE_DTO bOOK_SERVICE_)
        {
            return BOOK_SERVICE_DAL.bookService(bOOK_SERVICE_);
        } 

        // load get list book services:
        public static List<BOOK_SERVICE_DTO> getBookServices(string sqlQuery)
        {
            return BOOK_SERVICE_DAL.getBookServices(sqlQuery);
        }

        //edit book service:
        public static bool editBookService(BOOK_SERVICE_DTO bOOK_SERVICE_)
        {
            return BOOK_SERVICE_DAL.editBookService(bOOK_SERVICE_);
        }

        //cancel book service:
        public static bool cancelBookService(BOOK_SERVICE_DTO bOOK_SERVICE)
        {
            return BOOK_SERVICE_DAL.cancelBookService(bOOK_SERVICE);
        }

        //del services by room:
        public static bool delServicesByRoom(ROOM_DTO room)
        {
            return BOOK_SERVICE_DAL.delServicesByRoom(room);
        }
    }
}
