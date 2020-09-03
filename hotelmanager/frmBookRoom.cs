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
    public partial class frmBookRoom : Form
    {
        #region propers:
        //frmMain frmMain;
        private ROOM_DTO room;
        public ROOM_DTO Room { get => room; set => room = value; }
        public List<ROOM_BOOK_DTO> ROOM_BOOK_s { get => rOOM_BOOK_s; set => rOOM_BOOK_s = value; }
        public int Index { get => index; set => index = value; }
        public List<SERVICE_DTO> Services { get => services; set => services = value; }
        public SERVICE_DTO Service { get => service; set => service = value; }
        public BOOK_SERVICE_DTO BookService { get => bookService; set => bookService = value; }

        //public frmMain FrmMain { get => frmMain; set => frmMain = value; }
        private List<ROOM_BOOK_DTO> rOOM_BOOK_s;

        private int index;

        private List<SERVICE_DTO> services;
        private SERVICE_DTO service;
        private BOOK_SERVICE_DTO bookService;
        private int check = -1;
        #endregion
        public frmBookRoom(ROOM_DTO room)
        {
            InitializeComponent();
            Room = room;
        }

        

        private void frmBookRoom_Load(object sender, EventArgs e)
        {
            this.Text = "Phòng: "+Room.RoomCode.Trim().ToString();

            loadServices();

            loadDefault();

            setButton();

            loadInfoBookRoom();

            loadListCusOndg();

            showBookServices();

            //tabControl1
            cbServices.SelectedIndex = 0;

        }



        void loadServices()
        {
            string sqlQuery = "select * from DICH_VU order by TenDV;";
            services = SERVICE_BLL.getServices(sqlQuery);

            cbServices.DataSource = services;
            cbServices.DisplayMember = "ServiceName";
            cbServices.ValueMember = "ServiceCode";
        }

        void loadListCusOndg()
        {
            dgCustomerBookRoom.DataSource = BOOK_ROOM_BLL.getListBookRoomById(Room);
        }

        void setButton()
        {
            if(Room.Status == "Available")
            {
                btnBookRoomEditInfo.Enabled = false;
                btnBookRoom.Enabled = btnCancel.Enabled = true;
                btnUseService.Enabled = false;
                btnPay.Enabled = false;
                btnCancel.Enabled = false;
                //tabControl1.TabPages[1]
            }
            else
            {
                btnBookRoom.Enabled = false;
                btnBookRoomEditInfo.Enabled = btnCancel.Enabled = true;
                btnUseService.Enabled = true;
                btnPay.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        void loadInfoBookRoom()
        {
            if(Room.Status == "Not Available")
            {
                showOndg(Room);   
            }
        }

        private bool showOndg(ROOM_DTO room)
        {
            if(ROOM_BOOK_s != null) ROOM_BOOK_s.Clear();
            
            ROOM_BOOK_DTO rOOM_BOOK = BOOK_ROOM_BLL.getInfoBookRoom(Room);
            if (rOOM_BOOK != null)
            {
                ROOM_BOOK_s = new List<ROOM_BOOK_DTO>();
                rOOM_BOOK_s.Add(rOOM_BOOK);
                dgBookRomDetail.DataSource = ROOM_BOOK_s;
                return true;
            }
            else return false;
        }

        void showOnGui(ROOM_BOOK_DTO rOOM_BOOK_)
        {

        }

        void loadDefault()
        {
            cbBookRoomType.Items.AddRange(new string[] { "Theo ngày", "Theo giờ"});
            cbBookRoomType.SelectedIndex = 1;
            txtRoomId.Text = Room.RoomCode.ToString();
            
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            ROOM_BOOK_DTO rOOM_BOOK = new ROOM_BOOK_DTO()
            {
                CustomerName = txtCusName.Text,
                CustomerId = txtCusId.Text,
                TimeCheckin = dtpCheckin.Value,
                TimeCheckout = dtpCheckout.Value,
                BookRoomType = cbBookRoomType.SelectedItem.ToString() == "Theo giờ"?"Theo giờ":"Theo ngày",
                RoomCode = txtRoomId.Text
            };
            if (BOOK_ROOM_BLL.bookRoom(rOOM_BOOK))
            {
                MessageBox.Show("Book room successfully!");

                showOndg(Room);

                loadListCusOndg();

                btnUseService.Enabled = true;

                check = 1;
            }
            else
            {
                MessageBox.Show("!");
                check = -1;
            }
        }

        void reSet()
        {
            txtCusId.Text = txtCusName.Text = "";
            dtpCheckin.Value = dtpCheckout.Value = DateTime.Now;
            txtCusName.Focus();
        }

        private void frmBookRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        
        private void btnBookRoomEditInfo_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(dgBookRomDetail.Rows[Index].Cells["BookRoomCode"].Value.ToString() + "\n" + dgBookRomDetail.Rows[Index].Cells["CustomerName"].Value.ToString());*/

            ROOM_BOOK_DTO rOOM_BOOK_ = new ROOM_BOOK_DTO()
            {
                BookRoomCode = int.Parse(dgBookRomDetail.Rows[Index].Cells["BookRoomCode"].Value.ToString()),
                CustomerName = dgBookRomDetail.Rows[Index].Cells["CustomerName"].Value.ToString(),
                CustomerId = dgBookRomDetail.Rows[Index].Cells["CustomerId"].Value.ToString(),
                TimeCheckin = DateTime.Parse(dgBookRomDetail.Rows[Index].Cells["TimeCheckin"].Value.ToString()),
                TimeCheckout = DateTime.Parse(dgBookRomDetail.Rows[Index].Cells["TimeCheckout"].Value.ToString()),
                BookRoomType = dgBookRomDetail.Rows[Index].Cells["BookRoomType"].Value.ToString(),
                RoomCode = dgBookRomDetail.Rows[Index].Cells["RoomCode"].Value.ToString()
            };

            if (BOOK_ROOM_BLL.updateInfoBookRoomById(rOOM_BOOK_))
            {
                MessageBox.Show("Successful!");

                showOndg(Room);

                loadListCusOndg();
            }
            else
            {
                MessageBox.Show("!");
            }
        }

        private void dgBookRomDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            //MessageBox.Show(dgBookRomDetail.Rows[0].Cells["CustomerName"].Value.ToString());
        }


        private void btnUseService_Click(object sender, EventArgs e)
        {
            if (numServiceNum.Value == 0) return;
            bookServices();
        }

        private void bookServices()
        {
            //MessageBox.Show(Service.ServiceName.ToString());

            if(ROOM_BOOK_s != null && ROOM_BOOK_s.Count > 0 && ROOM_BOOK_s[0] != null)
            {
                BookService = new BOOK_SERVICE_DTO()
                {
                    BookRoomCode = ROOM_BOOK_s[0].BookRoomCode,
                    ServiceAmount = int.Parse(numServiceNum.Value.ToString()),
                    ServiceCode = Service.ServiceCode,
                    BookServiceCost = Service.ServiceCost * int.Parse(numServiceNum.Value.ToString())
                };
            }
            //MessageBox.Show(BookService.BookRoomCode.ToString()+"-"+BookService.BookServiceCost.ToString()+"-"+BookService.ServiceAmount+"-"+BookService.ServiceCode);

            if (BOOK_SERVICE_BLL.bookService(BookService))
            {
                MessageBox.Show("Successful");
                showBookServices();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void showBookServices()
        {
            if (ROOM_BOOK_s != null && ROOM_BOOK_s.Count > 0 && ROOM_BOOK_s[0] != null)
            {
                string sqlQuery = "select * from THUE_DICH_VU as tdv where tdv.MaThuePhong = " + ROOM_BOOK_s[0].BookRoomCode + " order by tdv.MaPhieu DESC;";
                dgBookServices.DataSource = BOOK_SERVICE_BLL.getBookServices(sqlQuery);
            }
            else
            {
                if(Room.Status == "Not Available")
                {
                    string sqlQuery = "UPDATE [dbo].[PHONG] SET [TinhTrang] = 1 WHERE MaPhong = '" + Room.RoomCode + "';";
                    ROOM_BLL.updateStatusRoom(sqlQuery);
                    frmMain.check = 1;

                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            upDateTimeCheckOut(dtpCheckout.Value);

            frmCheckout frmCheckout = new frmCheckout(ROOM_BOOK_s[0]);
            this.Hide();
            if (frmCheckout.ShowDialog() == DialogResult.OK)
            {
                this.Show();


                string sqlQuery = "UPDATE [dbo].[PHONG] SET [TinhTrang] = 1 WHERE MaPhong = '" + Room.RoomCode + "';";
                ROOM_BLL.updateStatusRoom(sqlQuery);
                //frmMain.check = 1;

                ROOM_BOOK_s.Clear();
                dgBookRomDetail.DataSource = null;

                //showOndg(Room);
                //loadListCusOndg();
                dgBookServices.DataSource = null;
                check = 1;
            }
            else check = -1;
        }

        private void upDateTimeCheckOut(DateTime dateTime)
        {
            if(ROOM_BOOK_s != null && ROOM_BOOK_s.Count > 0 && ROOM_BOOK_s[0] != null)
            {
                string sqlExe = "UPDATE [dbo].[THUE_PHONG] SET [NgayGioTra] = '" + dateTime.ToString("yyyy/MM/dd HH:mm") + "' WHERE MaThuePhong = " + ROOM_BOOK_s[0].BookRoomCode + ";";
                BOOK_ROOM_BLL.updateTimeCheckOut(sqlExe);
                showOndg(Room);
                loadListCusOndg();
            }
        }

        private void btnBookRoomExit_Click(object sender, EventArgs e)
        {
            if (Room.Status == "Not Available")
            {
                string sqlQuery = "UPDATE [dbo].[PHONG] SET [TinhTrang] = 1 WHERE MaPhong = '" + Room.RoomCode + "';";
                ROOM_BLL.updateStatusRoom(sqlQuery);
                check = 1;

                bool checkCancel = cancelBookRoom(ROOM_BOOK_s[0]);

                ROOM_BOOK_s.Clear();

                if (checkCancel) MessageBox.Show("Successful!");
                else MessageBox.Show("Unsuccessful!");

                dgBookRomDetail.DataSource = null;
            }
            
        }

        private bool cancelBookRoom(ROOM_BOOK_DTO roombook)
        {
            string sqlExe = "DELETE FROM [dbo].[THUE_PHONG] WHERE MaThuePhong NOT IN (select tdv.MaThuePhong from THUE_DICH_VU as tdv) and MaThuePhong = "+roombook.BookRoomCode+";";
            if (BOOK_ROOM_BLL.cancelBookRoom(sqlExe))
            {
                return true;
            }
            else return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (check == 1) DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            SERVICE_DTO service = cbServices.SelectedItem as SERVICE_DTO;
            BookService.ServiceAmount = int.Parse(numServiceNum.Value.ToString());
            BookService.ServiceCode = cbServices.SelectedValue.ToString();
            BookService.BookServiceCost = numServiceNum.Value * service.ServiceCost;
            if (BOOK_SERVICE_BLL.editBookService(BookService))
            {
                MessageBox.Show("Sửa thành công!");
                showBookServices();
                numServiceNum.Value = 0;
                cbServices.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không sửa được");
            }
        }

        private void dgBookServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0) MessageBox.Show("Không được sửa!");
            else
            {
                DataGridViewRow row = dgBookServices.Rows[0];
                BookService = new BOOK_SERVICE_DTO()
                {
                    BookServiceCode = int.Parse(row.Cells[0].Value.ToString()),
                    ServiceCode = row.Cells[1].Value.ToString(),
                    ServiceAmount = int.Parse(row.Cells[2].Value.ToString()),
                    BookRoomCode = int.Parse(row.Cells[3].Value.ToString()),
                    BookServiceCost = decimal.Parse(row.Cells[4].Value.ToString())
                };

                Service = Services.Single(n => n.ServiceCode == BookService.ServiceCode);
                cbServices.SelectedItem = Service;
                numServiceNum.Value = BookService.ServiceAmount;
            }
        }

        private void btnCancelService_Click(object sender, EventArgs e)
        {
            if (Service != null)
            {
                if (BOOK_SERVICE_BLL.cancelBookService(BookService))
                {
                    MessageBox.Show("Xóa thành công!");
                    showBookServices();
                    numServiceNum.Value = 0;
                    cbServices.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Không xóa được!");
                }
            }
            else return;
        }

        private void cbServices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Service = Services.Single(n => n.ServiceCode == cbServices.SelectedValue.ToString());
            txtServiceCost.Text = Service.ServiceCost.ToString();
        }
    }
}
