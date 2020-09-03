using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class ROOM_TYPE_DAL
    {
        #region propers:
        private static List<ROOM_TYPE_DTO> rOOM_TYPE_DTOs;
        public static List<ROOM_TYPE_DTO> ROOM_TYPE_DTOs { get => rOOM_TYPE_DTOs; set => rOOM_TYPE_DTOs = value; }
        #endregion
        //get room's type of hotel:
        public static List<ROOM_TYPE_DTO> getRoomTypes(string sqlQuery)
        {
            DataTable tbl = DataProvider.Query(sqlQuery);
            if (tbl.Rows.Count > 0 && tbl != null)
            {
                ROOM_TYPE_DTOs = new List<ROOM_TYPE_DTO>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    ROOM_TYPE_DTO rOOM_TYPE_DTO = new ROOM_TYPE_DTO()
                    {
                        RoomTypeCode = tbl.Rows[i]["MaLoai"].ToString(),
                        RoomTypeName = tbl.Rows[i]["TenLoai"].ToString(),
                        CostPerDay = decimal.Parse(tbl.Rows[i]["DonGiaNgay"].ToString()),
                        CostPerHour = decimal.Parse(tbl.Rows[i]["DonGiaGio"].ToString())
                    };
                    rOOM_TYPE_DTOs.Add(rOOM_TYPE_DTO);
                }
                return rOOM_TYPE_DTOs;
            }
            else return null;
        }
    }
}
