using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BILL_DTO
    {
        private int billCode;
        private string customerName;
        private string roomCode;
        private int bookRoomCode;
        private decimal bookRoomCost;
        private decimal serviceCost;

        public int BillCode { get => billCode; set => billCode = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string RoomCode { get => roomCode; set => roomCode = value; }
        public int BookRoomCode { get => bookRoomCode; set => bookRoomCode = value; }
        public decimal BookRoomCost { get => bookRoomCost; set => bookRoomCost = value; }
        public decimal ServiceCost { get => serviceCost; set => serviceCost = value; }
    }
}
