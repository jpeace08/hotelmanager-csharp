using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace hotelmanager
{
    public partial class frmCheckout : Form
    {
        #region propers:

        private ROOM_BOOK_DTO roomBook;
        public ROOM_BOOK_DTO RoomBook { get => roomBook; set => roomBook = value; }
        public BILL_DTO Bill { get => bill; set => bill = value; }
        public List<BILL_DTO> Bills { get => bills; set => bills = value; }

        private BILL_DTO bill;
        private List<BILL_DTO> bills;
        private int check = -1;
        #endregion
        public frmCheckout(ROOM_BOOK_DTO rOOM_BOOK)
        {
            InitializeComponent();
            RoomBook = rOOM_BOOK;
        }

        

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            loadInfobill();
            loadListBill();
        }

        private void loadListBill()
        {
            dgBills.DataSource = CHECKOUT_BLL.getListBills("select * from HOA_DON");
        }

        private void loadInfobill()
        {
            string sqlQuery = "";
            if(RoomBook.BookRoomType == "Theo giờ")
            {
                sqlQuery = "Select tp.MaThuePhong, tp.TenKhachHang,p.MaPhong,lp.DonGiaGio , DATEDIFF(HOUR, tp.NgayGioThue, tp.NgayGioTra) as ThoiGianThue, ISNULL(temp.DonGiaDV, 0) as DonGiaDv from THUE_PHONG as tp inner join PHONG as p on tp.MaPhong = p.MaPhong inner join LOAI_PHONG as lp on p.MaLoai = lp.MaLoai left join ( select tdv1.MaThuePhong , SUM(tdv1.DonGia) as DonGiaDV from THUE_DICH_VU as tdv1 group by tdv1.MaThuePhong ) as [temp] on tp.MaThuePhong = [temp].MaThuePhong where tp.MaThuePhong = " + RoomBook.BookRoomCode + " and tp.LoaiThue = 0; ";
                showInfo(sqlQuery);
            }
            else
            {
                sqlQuery = "Select tp.MaThuePhong, tp.TenKhachHang,p.MaPhong,lp.DonGiaNgay , DATEDIFF(DAYOFYEAR, tp.NgayGioThue, tp.NgayGioTra) as ThoiGianThue, ISNULL(temp.DonGiaDV, 0) as DonGiaDV from THUE_PHONG as tp inner join PHONG as p on tp.MaPhong = p.MaPhong inner join LOAI_PHONG as lp on p.MaLoai = lp.MaLoai left join ( select tdv1.MaThuePhong , SUM(tdv1.DonGia) as DonGiaDV from THUE_DICH_VU as tdv1 group by tdv1.MaThuePhong ) as [temp] on tp.MaThuePhong = [temp].MaThuePhong where tp.MaThuePhong = " + RoomBook.BookRoomCode + " and tp.LoaiThue = 1; ";


                showInfo(sqlQuery);
            }
        }
        void showInfo(string sqlQuery) 
        {
            Bill = CHECKOUT_BLL.getInfoBill(sqlQuery, RoomBook.BookRoomType);
            txtBookRoomCode.Text = Bill.BookRoomCode.ToString();
            txtCustomerName.Text = Bill.CustomerName;
            txtRoomCode.Text = Bill.RoomCode;
            txtRoomCost.Text = Bill.BookRoomCost.ToString();
            txtServicesCost.Text = Bill.ServiceCost.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal cost = (decimal)(Bill.BookRoomCost + Bill.ServiceCost);
            string sqlExe = "INSERT INTO [dbo].[HOA_DON] VALUES ("+Bill.BookRoomCode+","+cost+")";
            if (CHECKOUT_BLL.addBill(sqlExe))
            {
                MessageBox.Show("ok!");
                loadListBill();
                check = 1;
            }
            else
            {
                MessageBox.Show("Not alright!");
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (check == 1) DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }

        
    }
}
