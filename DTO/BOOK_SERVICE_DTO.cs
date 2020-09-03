using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BOOK_SERVICE_DTO
    {
        private int bookServiceCode;
        private string serviceCode;
        private int serviceAmount;
        private decimal bookServiceCost;
        private int bookRoomCode;

        public int BookServiceCode { get => bookServiceCode; set => bookServiceCode = value; }
        public string ServiceCode { get => serviceCode; set => serviceCode = value; }
        public int ServiceAmount { get => serviceAmount; set => serviceAmount = value; }
        
        public int BookRoomCode { get => bookRoomCode; set => bookRoomCode = value; }
        public decimal BookServiceCost { get => bookServiceCost; set => bookServiceCost = value; }
    }
}
