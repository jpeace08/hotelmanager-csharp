namespace hotelmanager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnRooms = new System.Windows.Forms.Panel();
            this.fPnRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdSearchRoom = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdSearchName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mniSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnisExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBookRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnibBookRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnibServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mniToolManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mniReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnihInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnRooms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(872, 384);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.SlateGray;
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.mnMain);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(996, 431);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripTime
            // 
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.groupBox1.Controls.Add(this.cbRoomType);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(3, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại phòng";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(3, 19);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(215, 21);
            this.cbRoomType.TabIndex = 0;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(228, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 394);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.groupBox2.Controls.Add(this.pnRooms);
            this.groupBox2.ForeColor = System.Drawing.Color.Orange;
            this.groupBox2.Location = new System.Drawing.Point(0, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 390);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng";
            // 
            // pnRooms
            // 
            this.pnRooms.Controls.Add(this.fPnRooms);
            this.pnRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRooms.Location = new System.Drawing.Point(3, 16);
            this.pnRooms.Name = "pnRooms";
            this.pnRooms.Size = new System.Drawing.Size(628, 371);
            this.pnRooms.TabIndex = 0;
            // 
            // fPnRooms
            // 
            this.fPnRooms.AutoScroll = true;
            this.fPnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.fPnRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fPnRooms.Location = new System.Drawing.Point(0, 0);
            this.fPnRooms.Name = "fPnRooms";
            this.fPnRooms.Size = new System.Drawing.Size(628, 371);
            this.fPnRooms.TabIndex = 0;
            this.fPnRooms.Paint += new System.Windows.Forms.PaintEventHandler(this.fPnRooms_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 384);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.groupBox3.Controls.Add(this.rdSearchRoom);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.rdSearchName);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.ForeColor = System.Drawing.Color.Orange;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 142);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // rdSearchRoom
            // 
            this.rdSearchRoom.AutoSize = true;
            this.rdSearchRoom.Location = new System.Drawing.Point(133, 57);
            this.rdSearchRoom.Name = "rdSearchRoom";
            this.rdSearchRoom.Size = new System.Drawing.Size(83, 17);
            this.rdSearchRoom.TabIndex = 3;
            this.rdSearchRoom.TabStop = true;
            this.rdSearchRoom.Text = "Theo phòng";
            this.rdSearchRoom.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // rdSearchName
            // 
            this.rdSearchName.AutoSize = true;
            this.rdSearchName.Location = new System.Drawing.Point(6, 57);
            this.rdSearchName.Name = "rdSearchName";
            this.rdSearchName.Size = new System.Drawing.Size(68, 17);
            this.rdSearchName.TabIndex = 2;
            this.rdSearchName.TabStop = true;
            this.rdSearchName.Text = "Theo tên";
            this.rdSearchName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(143, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mnMain
            // 
            this.mnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.mnMain.Dock = System.Windows.Forms.DockStyle.None;
            this.mnMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnMain.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSystem,
            this.mniBookRoom,
            this.mniToolManager,
            this.mniReport,
            this.mniHelp});
            this.mnMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Padding = new System.Windows.Forms.Padding(1, 90, 1, 0);
            this.mnMain.ShowItemToolTips = true;
            this.mnMain.Size = new System.Drawing.Size(124, 384);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "menuStrip1";
            // 
            // mniSystem
            // 
            this.mniSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnisLogin,
            this.mnisLogout,
            this.mnisChangePwd,
            this.toolStripMenuItem1,
            this.mnisExit});
            this.mniSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mniSystem.ForeColor = System.Drawing.Color.Goldenrod;
            this.mniSystem.Image = ((System.Drawing.Image)(resources.GetObject("mniSystem.Image")));
            this.mniSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniSystem.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.mniSystem.Name = "mniSystem";
            this.mniSystem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mniSystem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mniSystem.Size = new System.Drawing.Size(121, 25);
            this.mniSystem.Text = "Hệ thống";
            // 
            // mnisLogin
            // 
            this.mnisLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnisLogin.Name = "mnisLogin";
            this.mnisLogin.Size = new System.Drawing.Size(180, 22);
            this.mnisLogin.Text = "Đăng nhập";
            this.mnisLogin.Click += new System.EventHandler(this.mnisLogin_Click);
            // 
            // mnisLogout
            // 
            this.mnisLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnisLogout.Name = "mnisLogout";
            this.mnisLogout.Size = new System.Drawing.Size(180, 22);
            this.mnisLogout.Text = "Đăng xuất";
            this.mnisLogout.Click += new System.EventHandler(this.mnisLogout_Click);
            // 
            // mnisChangePwd
            // 
            this.mnisChangePwd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnisChangePwd.Name = "mnisChangePwd";
            this.mnisChangePwd.Size = new System.Drawing.Size(180, 22);
            this.mnisChangePwd.Text = "Đổi mật khẩu";
            this.mnisChangePwd.Click += new System.EventHandler(this.mnisChangePwd_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnisExit
            // 
            this.mnisExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnisExit.Name = "mnisExit";
            this.mnisExit.Size = new System.Drawing.Size(180, 22);
            this.mnisExit.Text = "Thoát";
            this.mnisExit.Click += new System.EventHandler(this.mnisExit_Click);
            // 
            // mniBookRoom
            // 
            this.mniBookRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnibBookRoom,
            this.mnibServices});
            this.mniBookRoom.Enabled = false;
            this.mniBookRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mniBookRoom.ForeColor = System.Drawing.Color.Goldenrod;
            this.mniBookRoom.Image = ((System.Drawing.Image)(resources.GetObject("mniBookRoom.Image")));
            this.mniBookRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniBookRoom.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.mniBookRoom.Name = "mniBookRoom";
            this.mniBookRoom.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mniBookRoom.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mniBookRoom.Size = new System.Drawing.Size(121, 25);
            this.mniBookRoom.Text = "Thuê phòng";
            this.mniBookRoom.Visible = false;
            // 
            // mnibBookRoom
            // 
            this.mnibBookRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnibBookRoom.Name = "mnibBookRoom";
            this.mnibBookRoom.Size = new System.Drawing.Size(143, 22);
            this.mnibBookRoom.Text = "Đặt phòng";
            this.mnibBookRoom.Click += new System.EventHandler(this.mnibBookRoom_Click);
            // 
            // mnibServices
            // 
            this.mnibServices.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnibServices.Name = "mnibServices";
            this.mnibServices.Size = new System.Drawing.Size(143, 22);
            this.mnibServices.Text = "Dịch vụ";
            // 
            // mniToolManager
            // 
            this.mniToolManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitRoom,
            this.mnitServices,
            this.mnitUser});
            this.mniToolManager.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mniToolManager.ForeColor = System.Drawing.Color.Goldenrod;
            this.mniToolManager.Image = ((System.Drawing.Image)(resources.GetObject("mniToolManager.Image")));
            this.mniToolManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniToolManager.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.mniToolManager.Name = "mniToolManager";
            this.mniToolManager.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mniToolManager.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mniToolManager.Size = new System.Drawing.Size(121, 25);
            this.mniToolManager.Text = "Quản lý";
            // 
            // mnitRoom
            // 
            this.mnitRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnitRoom.Name = "mnitRoom";
            this.mnitRoom.Size = new System.Drawing.Size(180, 22);
            this.mnitRoom.Text = "Phòng";
            this.mnitRoom.Click += new System.EventHandler(this.mnitRoom_Click);
            // 
            // mnitServices
            // 
            this.mnitServices.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnitServices.Name = "mnitServices";
            this.mnitServices.Size = new System.Drawing.Size(180, 22);
            this.mnitServices.Text = "Dịch vụ";
            this.mnitServices.Click += new System.EventHandler(this.mnitServices_Click);
            // 
            // mnitUser
            // 
            this.mnitUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnitUser.Name = "mnitUser";
            this.mnitUser.Size = new System.Drawing.Size(180, 22);
            this.mnitUser.Text = "Người dùng";
            this.mnitUser.Click += new System.EventHandler(this.mnitUser_Click);
            // 
            // mniReport
            // 
            this.mniReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mniReport.ForeColor = System.Drawing.Color.Goldenrod;
            this.mniReport.Image = ((System.Drawing.Image)(resources.GetObject("mniReport.Image")));
            this.mniReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniReport.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.mniReport.Name = "mniReport";
            this.mniReport.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mniReport.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mniReport.Size = new System.Drawing.Size(121, 25);
            this.mniReport.Text = "Báo cáo";
            this.mniReport.Click += new System.EventHandler(this.mniReport_Click);
            // 
            // mniHelp
            // 
            this.mniHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnihInfo});
            this.mniHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mniHelp.ForeColor = System.Drawing.Color.Goldenrod;
            this.mniHelp.Image = ((System.Drawing.Image)(resources.GetObject("mniHelp.Image")));
            this.mniHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mniHelp.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.mniHelp.Name = "mniHelp";
            this.mniHelp.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.mniHelp.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mniHelp.Size = new System.Drawing.Size(121, 25);
            this.mniHelp.Text = "Trợ giúp";
            // 
            // mnihInfo
            // 
            this.mnihInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnihInfo.Name = "mnihInfo";
            this.mnihInfo.Size = new System.Drawing.Size(137, 22);
            this.mnihInfo.Text = "Thông tin";
            this.mnihInfo.Click += new System.EventHandler(this.mnihInfo_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(996, 431);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnRooms.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mniSystem;
        private System.Windows.Forms.ToolStripMenuItem mnisLogin;
        private System.Windows.Forms.ToolStripMenuItem mnisLogout;
        private System.Windows.Forms.ToolStripMenuItem mnisChangePwd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnisExit;
        private System.Windows.Forms.ToolStripMenuItem mniBookRoom;
        private System.Windows.Forms.ToolStripMenuItem mnibBookRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem mnibServices;
        private System.Windows.Forms.ToolStripMenuItem mniToolManager;
        private System.Windows.Forms.ToolStripMenuItem mnitRoom;
        private System.Windows.Forms.ToolStripMenuItem mnitServices;
        private System.Windows.Forms.ToolStripMenuItem mnitUser;
        private System.Windows.Forms.ToolStripMenuItem mniReport;
        private System.Windows.Forms.ToolStripMenuItem mniHelp;
        private System.Windows.Forms.ToolStripMenuItem mnihInfo;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Panel pnRooms;
        private System.Windows.Forms.FlowLayoutPanel fPnRooms;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdSearchRoom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTime;
    }
}

