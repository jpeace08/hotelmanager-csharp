using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class BOOK_ROOM_DAL
    {
        //add bookroom bill:
        public static bool bookRoom(ROOM_BOOK_DTO rOOM_BOOK)
        {
            int bookRoomType = rOOM_BOOK.BookRoomType.ToString() == "Theo giờ" ? 0 : 1;
            string sqlExe = "INSERT INTO [dbo].[THUE_PHONG] VALUES (N'"+rOOM_BOOK.CustomerName+"','"+rOOM_BOOK.CustomerId+"','"+rOOM_BOOK.TimeCheckin.ToString("yyyy/MM/dd HH:mm")+"','"+rOOM_BOOK.TimeCheckout.ToString("yyyy/MM/dd HH:mm")+"',"+bookRoomType+",'"+rOOM_BOOK.RoomCode+ "');UPDATE [dbo].[PHONG] SET [TinhTrang] = 0 WHERE MaPhong = '"+rOOM_BOOK.RoomCode+"';";
            return DataProvider.ExeSql(sqlExe);
        }

        //get info book room:
        public static ROOM_BOOK_DTO getInfoBookRoomById(ROOM_DTO rOOM_)
        {

            /*
             and DATEDIFF(DAYOFYEAR , GETDATE(), tp.NgayGioTra) >= 0 
             */

            string sqlQuery = "select * from THUE_PHONG as tp where tp.MaPhong ='"+rOOM_.RoomCode+ "' and NOT EXISTS (select hd.MaThuePhong from HOA_DON as hd where hd.MaThuePhong = tp.MaThuePhong);";
            ROOM_BOOK_DTO rOOM_BOOK_;
            DataTable tb = DataProvider.Query(sqlQuery);
            if (tb != null && tb.Rows.Count > 0)
            {
                rOOM_BOOK_ = new ROOM_BOOK_DTO()
                {
                    BookRoomCode = int.Parse(tb.Rows[0]["MaThuePhong"].ToString()),
                    CustomerName = tb.Rows[0]["TenKhachHang"].ToString(),
                    CustomerId = tb.Rows[0]["SoCCCD"].ToString(),
                    TimeCheckin = DateTime.Parse(tb.Rows[0]["NgayGioThue"].ToString()),
                    TimeCheckout = DateTime.Parse(tb.Rows[0]["NgayGioTra"].ToString()),
                    BookRoomType = int.Parse(tb.Rows[0]["LoaiThue"].ToString()) == 0 ? "Theo giờ" : "Theo ngày",
                    RoomCode = tb.Rows[0]["Maphong"].ToString()
                };
                return rOOM_BOOK_;
            }
            else return null;
        }

        //get list book room / room:
        public static List<ROOM_BOOK_DTO> getlistBookRoomById(ROOM_DTO rOOM_)
        {
            List<ROOM_BOOK_DTO> rOOM_BOOK_s = new List<ROOM_BOOK_DTO>();
            string sqlQuery = "select* from THUE_PHONG as tp where tp.MaPhong = '" + rOOM_.RoomCode + "' order by tp.NgayGioTra";
            DataTable tb = DataProvider.Query(sqlQuery);
            ROOM_BOOK_DTO rOOM_BOOK_;
            if(tb != null && tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    rOOM_BOOK_ = new ROOM_BOOK_DTO()
                    {
                        BookRoomCode = int.Parse(tb.Rows[i]["MaThuePhong"].ToString()),
                        CustomerName = tb.Rows[i]["TenKhachHang"].ToString(),
                        CustomerId = tb.Rows[i]["SoCCCD"].ToString(),
                        TimeCheckin = DateTime.Parse(tb.Rows[i]["NgayGioThue"].ToString()),
                        TimeCheckout = DateTime.Parse(tb.Rows[i]["NgayGioTra"].ToString()),
                        BookRoomType = int.Parse(tb.Rows[i]["LoaiThue"].ToString()) == 0 ? "Theo giờ" : "Theo ngày",
                        RoomCode = tb.Rows[i]["Maphong"].ToString()
                    };
                    rOOM_BOOK_s.Add(rOOM_BOOK_);
                }
                return rOOM_BOOK_s;
            }
            return null;
        }

        //update info bookroom:
        public static bool updateInfoBookRoomById(ROOM_BOOK_DTO rOOM_BOOK_)
        {
            string sqlExe = "UPDATE [dbo].[THUE_PHONG] SET [TenKhachHang] = N'" + rOOM_BOOK_.CustomerName + "',[SoCCCD] = '" + rOOM_BOOK_.CustomerId + "',[NgayGioThue] = '" + rOOM_BOOK_.TimeCheckin.ToString("yyyy/MM/dd") + "',[NgayGioTra] = '" + rOOM_BOOK_.TimeCheckout.ToString("yyyy/MM/dd") + "' WHERE [MaThuePhong] = " + rOOM_BOOK_.BookRoomCode + "; ";
            return DataProvider.ExeSql(sqlExe);
        }

        //update time check out:
        public static bool updateTimeCheckOut(string sqlExe)
        {
            if (DataProvider.ExeSql(sqlExe)) return true;
            else return false;
        }

        //del book room:
        public static bool cancelBookRoom(string sqlQuery)
        {
            if (DataProvider.ExeSql(sqlQuery)) return true;
            else
            {
                return false;
            }
        }

        //edit room code on bookroomorder:
        public static bool updateRoomCode(ROOM_DTO room, string oldRoomCode)
        {
            string sqlExe = "UPDATE THUE_PHONG SET MaPhong = '"+room.RoomCode+"' WHERE MaPhong = '"+oldRoomCode+"';";
            return DataProvider.ExeSql(sqlExe);
        }

        //get bookrooms by month/year:
        public static List<ROOM_BOOK_DTO> getRoomBooks(string sqlQuery)
        {
            List<ROOM_BOOK_DTO> roomBooks;
            ROOM_BOOK_DTO roomBook;
            DataTable tb = DataProvider.Query(sqlQuery);
            if (tb != null && tb.Rows.Count > 0)
            {
                roomBooks = new List<ROOM_BOOK_DTO>();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    roomBook = new ROOM_BOOK_DTO()
                    {
                        BookRoomCode = int.Parse(tb.Rows[i]["MaThuePhong"].ToString()),
                        CustomerName = tb.Rows[i]["TenKhachHang"].ToString(),
                        CustomerId = tb.Rows[i]["SoCCCD"].ToString(),
                        TimeCheckin = DateTime.Parse(tb.Rows[i]["NgayGioThue"].ToString()),
                        TimeCheckout = DateTime.Parse(tb.Rows[i]["NgayGioTra"].ToString()),
                        BookRoomType = int.Parse(tb.Rows[i]["LoaiThue"].ToString()) == 0 ? "Theo giờ" : "Theo ngày",
                        RoomCode = tb.Rows[i]["MaPhong"].ToString()
                    };
                    roomBooks.Add(roomBook);
                }
                return roomBooks;
            }
            else return null;
        }

        //get revenue per month/year:
        public static decimal getRevenue(string sqlQuery)
        {
            decimal revenue = 0;
            DataTable tb = DataProvider.Query(sqlQuery);
            if (tb != null && tb.Rows.Count > 0)
            {
                if (tb.Rows[0]["total"].ToString() == "") revenue = 0;
                else revenue = decimal.Parse(tb.Rows[0]["total"].ToString());
                return revenue;
            }
            else return 0;
        }
    }
}
