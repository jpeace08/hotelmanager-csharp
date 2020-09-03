using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ROOM_BOOK_DTO
    {
        private int bookRoomCode;
        private string customerName;
        private string customerId;
        private DateTime timeCheckin;
        private DateTime timeCheckout;
        private string bookRoomType;
        private string roomCode;

        public int BookRoomCode { get => bookRoomCode; set => bookRoomCode = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public DateTime TimeCheckin { get => timeCheckin; set => timeCheckin = value; }
        public DateTime TimeCheckout { get => timeCheckout; set => timeCheckout = value; }
        public string RoomCode { get => roomCode; set => roomCode = value; }
        public string BookRoomType { get => bookRoomType; set => bookRoomType = value; }
    }
}
