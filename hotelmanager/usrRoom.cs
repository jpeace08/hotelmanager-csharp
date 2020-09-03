using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace hotelmanager
{
    public partial class usrRoom : UserControl
    {
        #region propers:
        private ROOM_DTO room;
        public ROOM_DTO Room { get => room; set => room = value; }
        #endregion
        public usrRoom(ROOM_DTO room)
        {
            InitializeComponent();
            Room = room;
        }




        private void usrRoom_Load(object sender, EventArgs e)
        {
            usrlbRoomNumber.Text = Room.RoomCode;
            if(room.Status == "Available")
            {
                pbAvailable.Visible = true;
                pbNotAvailable.Visible = false;
            }
            else
            {
                pbAvailable.Visible = false;
                pbNotAvailable.Visible = true;
            }
        }

        private void pbNotAvailable_Click(object sender, EventArgs e)
        {
            frmBookRoom frmBookRoom = new frmBookRoom(Room);
            //this.ParentForm.Hide();
            if (frmBookRoom.ShowDialog() == DialogResult.OK)
            {
                frmMain.check = 1;
            }
        }

        private void pbAvailable_Click(object sender, EventArgs e)
        {
            frmBookRoom frmBookRoom = new frmBookRoom(Room);
            //this.ParentForm.Hide();
            if (frmBookRoom.ShowDialog() == DialogResult.OK)
            {
                frmMain.check = 1;
            }
        }
    }
}
