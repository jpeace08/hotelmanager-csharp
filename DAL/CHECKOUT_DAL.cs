using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class CHECKOUT_DAL
    {
        //get info bill:
        public static BILL_DTO getInfoBill(string sqlQuery, string roomBookType)
        {
            DataTable tb = DataProvider.Query(sqlQuery);
            BILL_DTO bill;
            if (tb != null && tb.Rows.Count > 0)
            {
                bill = new BILL_DTO()
                {
                    BookRoomCode = int.Parse(tb.Rows[0]["MaThuePhong"].ToString()),
                    CustomerName = tb.Rows[0]["TenKhachHang"].ToString(),
                    RoomCode = tb.Rows[0]["MaPhong"].ToString(),
                    ServiceCost = decimal.Parse(tb.Rows[0]["DonGiaDV"].ToString()),
                };
                if (roomBookType == "Theo ngày")
                {
                    bill.BookRoomCost = int.Parse(tb.Rows[0]["DonGiaNgay"].ToString()) * int.Parse(tb.Rows[0]["ThoiGianThue"].ToString());
                    if (bill.BookRoomCost == 0) bill.BookRoomCost = int.Parse(tb.Rows[0]["DonGiaNgay"].ToString());
                }
                else if (roomBookType == "Theo giờ")
                {
                    bill.BookRoomCost = 0;
                    for (int i = 0; i < int.Parse(tb.Rows[0]["ThoiGianThue"].ToString()) - 1; i++)
                    {
                        bill.BookRoomCost += (decimal)(int.Parse(tb.Rows[0]["DonGiaGio"].ToString()) * (0.15) * int.Parse(tb.Rows[0]["ThoiGianThue"].ToString()));
                    }
                    bill.BookRoomCost += (int.Parse(tb.Rows[0]["DonGiaGio"].ToString()));
                }
                return bill;
            }
            else return null;
        }

        //add bill:
        public static bool addBill(string sqlExe)
        {
            return DataProvider.ExeSql(sqlExe);
        }

        //get bills:
        public static DataTable getBills(string sqlQuery)
        {
            return DataProvider.Query(sqlQuery);
        }

        //del bills by room:
        public static bool delBillsbyRoom(ROOM_DTO room)
        {
            string sqlExe = "delete from HOA_DON where MaHoaDon IN(select hd.MaHoaDon from HOA_DON as hd inner join(select tp.MaThuePhong from THUE_PHONG as tp inner join PHONG as pon tp.MaPhong = p.MaPhong where p.MaPhong = '"+room.RoomCode+"' and p.TinhTrang = 1)as [temp]on hd.MaThuePhong = temp.MaThuePhong)";
            return DataProvider.ExeSql(sqlExe);
        }
    }
}
