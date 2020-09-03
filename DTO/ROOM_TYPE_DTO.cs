using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ROOM_TYPE_DTO
    {
        private string roomTypeCode;
        private string roomTypeName;
        private decimal costPerHour;
        private decimal costPerDay;

        public string RoomTypeCode { get => roomTypeCode; set => roomTypeCode = value; }
        public string RoomTypeName { get => roomTypeName; set => roomTypeName = value; }
        public decimal CostPerHour { get => costPerHour; set => costPerHour = value; }
        public decimal CostPerDay { get => costPerDay; set => costPerDay = value; }
    }
}
