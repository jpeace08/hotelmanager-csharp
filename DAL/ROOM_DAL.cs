using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAL
{
    public class ROOM_DAL
    {
        #region propers:
        
        #endregion
        //get rooms:
        public static List<ROOM_DTO> getRooms(string sqlQuery)
        {
            List<ROOM_DTO> lstRooms;
            ROOM_DTO room;
            DataTable tbl = DataProvider.Query(sqlQuery);
            
            if (tbl != null && tbl.Rows.Count > 0)
            {
                lstRooms = new List<ROOM_DTO>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    room = new ROOM_DTO()
                    {
                        RoomCode = tbl.Rows[i]["MaPhong"].ToString(),
                        RoomTypeCode = tbl.Rows[i]["MaLoai"].ToString(),
                        Status = bool.Parse(tbl.Rows[i]["TinhTrang"].ToString()) == true ? "Available" : "Not Available"
                    };
                    lstRooms.Add(room);
                }
                return lstRooms;
            }
            else return null;
        }
        //add room:
        public static bool addRoom(ROOM_DTO room)
        {
            int status = room.Status == "Available" ? 1 : 0;
            string sqlExe = "INSERT INTO [dbo].[PHONG] VALUES ('"+room.RoomCode+"','"+room.RoomTypeCode+"',1)";
            if (DataProvider.ExeSql(sqlExe))
            {
                return true;
            }
            else return false;
        }

        //update status room:
        public static bool updateStatusRoom(string sqlQuery)
        {
            return DataProvider.ExeSql(sqlQuery);
        }

        //get list room search by room'scode from customer'sname:
        public static List<string> getRoomCodes(string sqlQuery)
        {
            DataTable tb = DataProvider.Query(sqlQuery);
            List<string> roomCodes;
            if (tb != null && tb.Rows.Count > 0)
            {
                roomCodes = new List<string>();
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    roomCodes.Add(tb.Rows[i]["MaPhong"].ToString());
                }
                return roomCodes;
            }
            else return null;
        }

        //del room by room code:
        public static bool delRoomById(ROOM_DTO room)
        {
            string sqlExe = "delete from PHONG where MaPhong = '"+room.RoomCode+"';";
            return DataProvider.ExeSql(sqlExe);
        }


        //edit room info:
        public static bool updateInfoRoom(ROOM_DTO room, string oldRoomCode)
        {
            string sqlExe = "UPDATE PHONG SET MaPhong = '"+room.RoomCode+"', TinhTrang = 1 WHERE MaPhong = '"+oldRoomCode+"';";
            return DataProvider.ExeSql(sqlExe);
        }

    }
}
