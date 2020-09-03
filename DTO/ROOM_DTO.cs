using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ROOM_DTO
    {
        private string roomCode;
        private string roomTypeCode;
        private string status;

        public string RoomCode { get => roomCode; set => roomCode = value; }
        public string RoomTypeCode { get => roomTypeCode; set => roomTypeCode = value; }
        public string Status { get => status; set => status = value; }
    }
}
