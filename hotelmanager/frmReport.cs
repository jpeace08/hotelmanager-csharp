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
    public partial class frmReport : Form
    {

        #region propers:
        private string choosen;

        public string Choosen { get => choosen; set => choosen = value; }
        #endregion

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            rdMonth.Checked = true;
            Choosen = rdMonth.Checked ? "month" : "year";
            loadBookRooms(Choosen);
        }

        /*private void loadBookRooms(string choosen)
        {
            int time;
            string sqlQuery = "";
            if (choosen == "month")
            {
                time = dtpReportTime.Value.Month;
                sqlQuery = "select * from THUE_PHONG as tp where tp.MaThuePhong IN (select hd.MaThuePhong from HOA_DON as hd) and MONTH(tp.NgayGioTra) = "+time+";";
                dgBookRooms.DataSource = BOOK_ROOM_BLL.getRoomBooks(sqlQuery);

            }
            else if (choosen == "year")
            {
                time = dtpReportTime.Value.Year;
                sqlQuery = "select * from THUE_PHONG as tp where tp.MaThuePhong IN (select hd.MaThuePhong from HOA_DON as hd) and YEAR(tp.NgayGioTra) = " + time + ";";
                dgBookRooms.DataSource = BOOK_ROOM_BLL.getRoomBooks(sqlQuery);
            }
            
        }*/


        private void loadBookRooms(string choosen)
        {
            int time;
            string sqlQuery = "";
            if (choosen == "month")
            {
                time = mcTimer.SelectionRange.Start.Month;
                sqlQuery = "select * from THUE_PHONG as tp where tp.MaThuePhong IN (select hd.MaThuePhong from HOA_DON as hd) and MONTH(tp.NgayGioTra) = " + time + ";";
                dgBookRooms.DataSource = BOOK_ROOM_BLL.getRoomBooks(sqlQuery);

            }
            else if (choosen == "year")
            {
                time = mcTimer.SelectionRange.Start.Year;
                sqlQuery = "select * from THUE_PHONG as tp where tp.MaThuePhong IN (select hd.MaThuePhong from HOA_DON as hd) and YEAR(tp.NgayGioTra) = " + time + ";";
                dgBookRooms.DataSource = BOOK_ROOM_BLL.getRoomBooks(sqlQuery);
            }

        }


        private void dtpReportTime_ValueChanged(object sender, EventArgs e)
        {
            Choosen = rdMonth.Checked ? "month" : "year";
            loadBookRooms(Choosen);
            getRevenueMonth(dtpReportTime.Value.Month, dtpReportTime.Value.Year);
            getRevenueYear(dtpReportTime.Value.Year);
        }

        private void getRevenueMonth(int month, int year)
        {
            string sqlQuery = "select SUM(hd1.TongTien) as [total] from HOA_DON as hd1 inner join (select tp.MaThuePhong from THUE_PHONG as tp where tp.MaThuePhong IN (select hd.MaThuePhong from HOA_DON as hd) and MONTH(tp.NgayGioTra) = "+month+" and YEAR(tp.NgayGioTra) = "+year+") as [temp] on hd1.MaThuePhong = temp.MaThuePhong";
            txtMonthTotal.Text = BOOK_ROOM_BLL.getRevenue(sqlQuery).ToString();
        }

        private void getRevenueYear(int year)
        {
            string sqlQuery = "select SUM(hd1.TongTien) as [total] from HOA_DON as hd1 inner join (select tp.MaThuePhong from THUE_PHONG as tp where tp.MaThuePhong IN (select hd.MaThuePhong from HOA_DON as hd) and YEAR(tp.NgayGioTra) = " + year + ") as [temp] on hd1.MaThuePhong = temp.MaThuePhong";
            txtYearTotal.Text = BOOK_ROOM_BLL.getRevenue(sqlQuery).ToString();
        }

        private void rdMonth_CheckedChanged(object sender, EventArgs e)
        {
            /*Choosen = rdMonth.Checked ? "month" : "year";
            loadBookRooms(Choosen);*/
            Choosen = rdMonth.Checked ? "month" : "year";
            loadBookRooms(Choosen);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcTimer_DateChanged(object sender, DateRangeEventArgs e)
        {
            Choosen = rdMonth.Checked ? "month" : "year";
            loadBookRooms(Choosen);
            getRevenueMonth(mcTimer.SelectionRange.Start.Month, mcTimer.SelectionRange.Start.Year);
            getRevenueYear(mcTimer.SelectionRange.Start.Year);
        }
    }
}
