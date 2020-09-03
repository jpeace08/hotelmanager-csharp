using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class BOOK_SERVICE_DAL
    {
        //book service:))
        public static bool bookService(BOOK_SERVICE_DTO bOOK_SERVICE_)
        {
            string sqlQuery = "INSERT INTO [dbo].[THUE_DICH_VU] VALUES ('"+bOOK_SERVICE_.ServiceCode+"',"+bOOK_SERVICE_.ServiceAmount+","+bOOK_SERVICE_.BookServiceCost+","+bOOK_SERVICE_.BookRoomCode+")";
            if (DataProvider.ExeSql(sqlQuery))
            {
                return true;

                /**
                 * 
                 * .__(.)< (MEOW)
                    \___)   
                 * 
                 */

            }
            else return false;
        }

        // get book service:
        public static List<BOOK_SERVICE_DTO> getBookServices(string sqlQuery)
        {
            List<BOOK_SERVICE_DTO> bookServices;
            BOOK_SERVICE_DTO bookService;
            DataTable tb = DataProvider.Query(sqlQuery);
            if (tb != null && tb.Rows.Count > 0)
            {
                bookServices = new List<BOOK_SERVICE_DTO>();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    bookService = new BOOK_SERVICE_DTO
                    {
                        BookServiceCode = Convert.ToInt32(tb.Rows[i]["MaPhieu"].ToString()),
                        ServiceCode = tb.Rows[i]["MaDV"].ToString(),
                        ServiceAmount = Convert.ToInt32(tb.Rows[i]["SoLuong"].ToString()),
                        BookServiceCost = decimal.Parse(tb.Rows[i]["DonGia"].ToString()),
                        BookRoomCode = Convert.ToInt32(tb.Rows[i]["MaThuePhong"].ToString())
                    };
                    bookServices.Add(bookService);
                }
                return bookServices;
            }
            else return null;
        }

        //edit book service:
        public static bool editBookService(BOOK_SERVICE_DTO bOOK_SERVICE)
        {
            string sqlExe = "UPDATE [dbo].[THUE_DICH_VU] SET MaDV = '"+bOOK_SERVICE.ServiceCode+"', [SoLuong] = " + bOOK_SERVICE.ServiceAmount+",[DonGia] = "+bOOK_SERVICE.BookServiceCost+" WHERE MaPhieu = "+bOOK_SERVICE.BookServiceCode+";";
            if (DataProvider.ExeSql(sqlExe)) return true;
            else
            {
                return false;
            }
        }

        //cancel book service:
        public static bool cancelBookService(BOOK_SERVICE_DTO bOOK_SERVICE)
        {
            string sqlExe = "DELETE FROM [dbo].[THUE_DICH_VU] WHERE MaPhieu = "+bOOK_SERVICE.BookServiceCode+";";
            if (DataProvider.ExeSql(sqlExe)) return true;
            else return false;
        }

        //del services by room:
        public static bool delServicesByRoom(ROOM_DTO room)
        {
            string sqlExe = "delete from THUE_DICH_VU where MaPhieu IN (select tdv.MaPhieu from THUE_DICH_VU as tdv inner join (select tp.MaThuePhong from THUE_PHONG as tp inner join PHONG as pon tp.MaPhong = p.MaPhong where p.MaPhong = '"+room.RoomCode+"' and p.TinhTrang = 1) as [temp]on tdv.MaThuePhong = temp.MaThuePhong)";
            return DataProvider.ExeSql(sqlExe);
        }
    }
}
