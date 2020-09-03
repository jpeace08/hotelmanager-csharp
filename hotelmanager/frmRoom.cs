using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace hotelmanager
{
    public partial class frmRoom : Form
    {
        #region propers:
        private ROOM_DTO room;
        private ROOM_TYPE_DTO roomType;
        private string roomCode;
        private List<ROOM_TYPE_DTO> roomTypes;
        public List<ROOM_TYPE_DTO> RoomTypes { get => roomTypes; set => roomTypes = value; }
        public List<ROOM_DTO> Rooms { get => rooms; set => rooms = value; }
        public ROOM_TYPE_DTO RoomType { get => roomType; set => roomType = value; }
        public string RoomCode { get => roomCode; set => roomCode = value; }
        public int RoomStatus { get => roomStatus; set => roomStatus = value; }
        public ROOM_DTO Room { get => room; set => room = value; }

        private int roomStatus;

        private List<ROOM_DTO> rooms;
        public ErrorProvider ErrorProvider = new ErrorProvider();
        private int check = -1;
        private int exe;
        #endregion
        public frmRoom(List<ROOM_TYPE_DTO> roomTypes)
        {
            InitializeComponent();
            RoomTypes = roomTypes;
        }



        private void frmRoom_Load(object sender, EventArgs e)
        {
            loadDefault();
        }

        private void loadDefault()
        {
            cbRoomStatus.Items.AddRange(new string[] { "Available", "Not available" });


            cbRoomTypes.DataSource = RoomTypes;
            cbRoomTypes.DisplayMember = "RoomTypeName";
            cbRoomTypes.ValueMember = "RoomTypeCode";

            cbRoomTypes.SelectedIndex = 0;
            cbRoomStatus.SelectedIndex = 0;

            RoomCode = "STD";
            RoomStatus = 1;
            getRooms(RoomCode, RoomStatus);
        }

        private void cbRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomCode = cbRoomTypes.SelectedValue.ToString();
            if (cbRoomStatus.SelectedItem == null)
            {
                RoomStatus = 1;
            }
            else
            {
                RoomStatus = cbRoomStatus.SelectedItem.ToString() == "Available" ? 1 : 0;
            }
            getRooms(RoomCode, RoomStatus);
        }

        private void getRooms(string roomCode, int roomStatus)
        {

            Rooms = ROOM_BLL.getRooms("Select * from PHONG as p where p.MaLoai = '" + roomCode + "' and p.TinhTrang = " + RoomStatus + ";");
            dgRooms.DataSource = Rooms;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            exe = 0;
            txtRoomCode.Enabled = cbRoomStatus.Enabled = cbRoomTypes.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        void reSet()
        {
            txtRoomCode.Text = "";
            txtRoomCode.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            exe = 1;
            cbRoomTypes.Enabled = false;
            txtRoomCode.Enabled = cbRoomStatus.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (Room == null) return;
            if (Room.Status == "Not Available") { MessageBox.Show("Phòng đang được sử dụng!"); return; }
            BOOK_SERVICE_BLL.delServicesByRoom(Room);
            CHECKOUT_BLL.delBillsByRoom(Room);

            string sqlExe_1 = "UPDATE [dbo].[PHONG] SET [TinhTrang] = 1 WHERE MaPhong = '" + Room.RoomCode + "';";
            ROOM_BLL.updateStatusRoom(sqlExe_1);
            string sqlExe_2 = "DELETE FROM [dbo].[THUE_PHONG] WHERE MaPhong ='" + Room.RoomCode + "';";

            BOOK_ROOM_BLL.cancelBookRoom(sqlExe_2);

            if (ROOM_BLL.delRoomById(Room))
            {
                MessageBox.Show("Xóa thành công!");
                getRooms(RoomCode, RoomStatus);
                reSet();
                check = 1;

            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }
            /*if(BOOK_SERVICE_BLL.delServicesByRoom(Room) && CHECKOUT_BLL.delBillsByRoom(Room))
            {
                string sqlExe_1 = "UPDATE [dbo].[PHONG] SET [TinhTrang] = 1 WHERE MaPhong = '" + Room.RoomCode + "';";
                ROOM_BLL.updateStatusRoom(sqlExe_1);
                string sqlExe_2 = "DELETE FROM [dbo].[THUE_PHONG] WHERE MaPhong ='"+Room.RoomCode+"';";
                if (BOOK_ROOM_BLL.cancelBookRoom(sqlExe_2))
                {
                    if (ROOM_BLL.delRoomById(Room)) MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa!");
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            if(check == 1) DialogResult = DialogResult.OK;
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            check = -1;
        }

        private void cbRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomCode = cbRoomTypes.SelectedValue.ToString();
            if (cbRoomStatus.SelectedItem == null)
            {
                RoomStatus = 1;
            }
            else
            {
                RoomStatus = cbRoomStatus.SelectedItem.ToString() == "Available" ? 1 : 0;
            }
            getRooms(RoomCode, RoomStatus);
        }

        private void dgRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgRooms.Rows[e.RowIndex];
            Room = new ROOM_DTO()
            {
                RoomCode = row.Cells[0].Value.ToString(),
                RoomTypeCode = row.Cells[1].Value.ToString(),
                Status = row.Cells[2].Value.ToString()
            };
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(exe == 0)
            {
                ErrorProvider.SetError(txtRoomCode, "");
                if (txtRoomCode.Text.Trim() == "")
                {
                    ErrorProvider.SetError(txtRoomCode, "Not null!");
                    //MessageBox.Show("Not null!");
                }
                else
                {

                    ROOM_DTO room = new ROOM_DTO()
                    {
                        RoomCode = txtRoomCode.Text.Trim(),
                        RoomTypeCode = cbRoomTypes.SelectedValue.ToString().Trim(),
                        Status = cbRoomStatus.SelectedItem.ToString().Trim()
                    };
                    if (ROOM_BLL.addRoom(room))
                    {
                        MessageBox.Show("Thành công!");
                        getRooms(RoomCode, RoomStatus);
                        reSet();
                        check = 1;
                    }
                    else
                    {
                        MessageBox.Show("Không thành công!");
                        check = 0;
                    }
                }
            }
            else if(exe == 1)
            {
                if (Room == null) return;
                if (Room.Status == "Not Available") { MessageBox.Show("Phòng đang được sử dụng!"); return; }
                string roomCode = Room.RoomCode;
                string roomStatus = Room.Status;
                string roomTypeCode = Room.RoomTypeCode;

                Room = new ROOM_DTO()
                {
                    RoomCode = txtRoomCode.Text,
                    RoomTypeCode = roomTypeCode,
                    Status = cbRoomStatus.SelectedItem.ToString()
                };

                BOOK_ROOM_BLL.updateRoomCode(Room, roomCode);
                if (ROOM_BLL.updateInfoRoom(Room, roomCode))
                {
                    MessageBox.Show("Sửa thành công!");
                    getRooms(RoomCode, RoomStatus);
                    reSet();
                    check = 1;
                }
                else MessageBox.Show("Không sửa được!");
                cbRoomTypes.Enabled = true;
            }
            else if( exe == 2)
            {
                
            }

            txtRoomCode.Enabled = cbRoomStatus.Enabled = cbRoomTypes.Enabled = false;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
            btnSave.Enabled = false ;
        }
    }
}
