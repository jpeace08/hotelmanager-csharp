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
    public partial class frmMain : Form
    {

        #region propers:
        private EMPLOYEE_DTO employee;
        private static List<ROOM_TYPE_DTO> rOOM_TYPE_DTOs;
        public static List<ROOM_TYPE_DTO> ROOM_TYPE_DTOs { get => rOOM_TYPE_DTOs; set => rOOM_TYPE_DTOs = value; }

        private static List<ROOM_DTO> rOOM_DTOs;
        public static List<ROOM_DTO> ROOM_DTOs { get => rOOM_DTOs; set => rOOM_DTOs = value; }
        public ROOM_DTO Room { get => room; set => room = value; }
        public EMPLOYEE_DTO Employee { get => employee; set => employee = value; }

        public static int check = -1;
        private ROOM_DTO room;
        #endregion

        public frmMain(EMPLOYEE_DTO employee)
        {
            InitializeComponent();
            Employee = employee;
            toolStripTime.ForeColor = Color.Orange;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            addSelectionCbo();
            cbRoomType.SelectedIndex = 4;
            role(Employee);
        }

        void role(EMPLOYEE_DTO empl)
        {
            if(empl.RoleCode != 0)
            {
                mniToolManager.Enabled = false;
                mniToolManager.Visible = false;
            }
            else
            {
                mniToolManager.Enabled = true;
                mniToolManager.Visible = true;
            }
        }

        void addSelectionCbo()
        {
            foreach (var item in getRoomTypeName())
            {
                cbRoomType.Items.Add(item);
            }
        }
        

        private List<string> getRoomTypeName()
        {
            string sqlQuery = "Select * from dbo.LOAI_PHONG as lp order by lp.DonGiaGio";
            rOOM_TYPE_DTOs = ROOM_TYPE_BLL.getRoomTypes(sqlQuery);

            List<string> lsRoomTypeName = new List<string>();

            for (int i = 0; i < rOOM_TYPE_DTOs.Count; i++)
            {
                lsRoomTypeName.Add(rOOM_TYPE_DTOs[i].RoomTypeName);
            }
            lsRoomTypeName.Add("All");

            return lsRoomTypeName;

            /*cbRoomType.DataSource = rOOM_TYPE_DTOs;
            cbRoomType.DisplayMember = "RoomTypeName";
            cbRoomType.ValueMember = "RoomTypeCode";*/
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRoomByType(cbRoomType.SelectedItem.ToString());
        }

        private void getRoomByType(string roomType)
        {
            string sqlQuery;
            if (roomType != "All")
            {
                string param = "";
                
                switch (roomType)
                {
                    case "Standard": param = "Standard"; break;
                    case "Superior": param = "Superior"; break;
                    case "Deluxe": param = "Deluxe"; break;
                    case "Suite": param = "Suite"; break;
                    default:
                        break;
                }
                sqlQuery = "select * from dbo.PHONG as p inner join LOAI_PHONG as lp on p.MaLoai = lp.MaLoai where lp.TenLoai = N'" + param + "' order by p.MaPhong";
            }
            else sqlQuery = "select * from PHONG as p order by p.MaPhong";
            rOOM_DTOs = ROOM_BLL.getRooms(sqlQuery);
            showRoomByType(rOOM_DTOs);
        }
        public void showRoomByType(List<ROOM_DTO> rOOM_DTOs)
        {
            usrRoom usrRoom;
            fPnRooms.Controls.Clear();
            foreach (var item in rOOM_DTOs)
            {
                usrRoom = new usrRoom(item);
                fPnRooms.Controls.Add(usrRoom);
            }
        }

        private void mnibBookRoom_Click(object sender, EventArgs e)
        {

        }

        private void mnitRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom frmRoom = new frmRoom(ROOM_TYPE_DTOs);
            if (frmRoom.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                getRoomByType(cbRoomType.SelectedItem.ToString());
            }
            else
            {
                this.Show();
            }
        }

        private void mnitServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServices frmServices = new frmServices();
            frmServices.ShowDialog();
            this.Show();

        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (frmMain.check == 1)
            {
                getRoomByType(cbRoomType.SelectedItem.ToString());

                frmMain.check = 0;
            }

            toolStripTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void fPnRooms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ROOM_DTO> rooms;
            if (rdSearchRoom.Checked)
            {
                rooms = ROOM_DTOs.Where(n => n.RoomCode.Contains(txtSearch.Text)).ToList();
                if (rooms != null && rooms.Count > 0)
                {
                    fPnRooms.Controls.Clear();
                    for (int i = 0; i < rooms.Count; i++)
                    {
                        usrRoom usrRoom = new usrRoom(rooms[i]);
                        fPnRooms.Controls.Add(usrRoom);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa tìm thấy!");
                }
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else if (rdSearchName.Checked)
            {
                
                string sqlQuery = "select tp.MaPhong from THUE_PHONG as tp inner join PHONG as p on tp.MaPhong = p.MaPhong where tp.TenKhachHang LIKE N'%" + txtSearch.Text + "%' and tp.MaThuePhong NOT IN ( select hd.MaThuePhong from HOA_DON as hd);";
                List<string> roomCodes = ROOM_BLL.getRoomCodes(sqlQuery);
                if (roomCodes!=null && roomCodes.Count > 0)
                {
                    ROOM_DTO room = new ROOM_DTO();
                    rooms = new List<ROOM_DTO>();
                    for (int i = 0; i < roomCodes.Count; i++)
                    {
                        room = ROOM_DTOs.Single(n => n.RoomCode == roomCodes[i].Trim().ToString());
                        rooms.Add(room);
                    }
                    fPnRooms.Controls.Clear();
                    for (int i = 0; i < rooms.Count; i++)
                    {
                        usrRoom usrRoom = new usrRoom(rooms[i]);
                        fPnRooms.Controls.Add(usrRoom);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa tìm thấy!");
                }
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                MessageBox.Show("Chọn phương thức tìm kiếm của bạn!");
            }
        }

        private void mnisExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnisLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void mnitEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void mnitUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser frmUser = new frmUser();
            if(frmUser.ShowDialog() == DialogResult.OK) { this.Show(); }
            else this.Show();

        }

        private void mniReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReport frmReport = new frmReport();

            if(frmReport.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }

        }

        private void mnihInfo_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo();
            this.Hide();
            if (frmInfo.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else this.Show();
        }

        private void mnisLogin_Click(object sender, EventArgs e)
        {

        }

        private void mnisChangePwd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePass changePass = new frmChangePass(Employee);
            if(changePass.ShowDialog() == DialogResult.OK)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }
            else
            {
                this.Show();
                return;
            }
        }
    }
}
