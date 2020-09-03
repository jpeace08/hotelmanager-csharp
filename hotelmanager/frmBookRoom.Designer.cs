namespace hotelmanager
{
    partial class frmBookRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Đặt phòng", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgBookRomDetail = new System.Windows.Forms.DataGridView();
            this.BookRoomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsvBookRoomDetail = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnListServices = new System.Windows.Forms.Panel();
            this.dgBookServices = new System.Windows.Forms.DataGridView();
            this.BookServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookRoomCodee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookServiceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panal = new System.Windows.Forms.Panel();
            this.numServiceNum = new System.Windows.Forms.NumericUpDown();
            this.pnServices = new System.Windows.Forms.Panel();
            this.btnCancelService = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditService = new System.Windows.Forms.Button();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUseService = new System.Windows.Forms.Button();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgCustomerBookRoom = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBookRoomEditInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBookRoomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imglRoom = new System.Windows.Forms.ImageList(this.components);
            this.MaThuePhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuePhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookRomDetail)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnListServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookServices)).BeginInit();
            this.panal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServiceNum)).BeginInit();
            this.pnServices.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerBookRoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 479);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.btnBookRoom);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnBookRoomEditInfo);
            this.panel3.ForeColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(333, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 476);
            this.panel3.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(452, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.dgBookRomDetail);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel7.Location = new System.Drawing.Point(0, 299);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(519, 123);
            this.panel7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Orange;
            this.label8.Location = new System.Drawing.Point(-1, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Khách hàng hiện tại:";
            // 
            // dgBookRomDetail
            // 
            this.dgBookRomDetail.AllowUserToAddRows = false;
            this.dgBookRomDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(160)))));
            this.dgBookRomDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBookRomDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookRomDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookRoomCode,
            this.CustomerName,
            this.CustomerId,
            this.TimeCheckin,
            this.TimeCheckout,
            this.BookRoomType,
            this.RoomCode});
            this.dgBookRomDetail.Location = new System.Drawing.Point(2, 34);
            this.dgBookRomDetail.Name = "dgBookRomDetail";
            this.dgBookRomDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgBookRomDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgBookRomDetail.Size = new System.Drawing.Size(516, 107);
            this.dgBookRomDetail.TabIndex = 0;
            this.dgBookRomDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookRomDetail_CellClick);
            // 
            // BookRoomCode
            // 
            this.BookRoomCode.DataPropertyName = "BookRoomCode";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            this.BookRoomCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.BookRoomCode.HeaderText = "Mã đặt phòng";
            this.BookRoomCode.Name = "BookRoomCode";
            this.BookRoomCode.ReadOnly = true;
            this.BookRoomCode.Visible = false;
            this.BookRoomCode.Width = 5;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Khách hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 143;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "Số CCCD";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 83;
            // 
            // TimeCheckin
            // 
            this.TimeCheckin.DataPropertyName = "TimeCheckin";
            this.TimeCheckin.HeaderText = "Ngày thuê phòng";
            this.TimeCheckin.Name = "TimeCheckin";
            this.TimeCheckin.Width = 71;
            // 
            // TimeCheckout
            // 
            this.TimeCheckout.DataPropertyName = "TimeCheckout";
            this.TimeCheckout.HeaderText = "Ngày trả phòng";
            this.TimeCheckout.Name = "TimeCheckout";
            this.TimeCheckout.Width = 71;
            // 
            // BookRoomType
            // 
            this.BookRoomType.DataPropertyName = "BookRoomType";
            this.BookRoomType.HeaderText = "Loại thuê phòng";
            this.BookRoomType.Name = "BookRoomType";
            this.BookRoomType.ReadOnly = true;
            this.BookRoomType.Width = 60;
            // 
            // RoomCode
            // 
            this.RoomCode.DataPropertyName = "RoomCode";
            this.RoomCode.HeaderText = "Phòng";
            this.RoomCode.Name = "RoomCode";
            this.RoomCode.ReadOnly = true;
            this.RoomCode.Width = 50;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl1);
            this.panel6.Location = new System.Drawing.Point(-4, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 282);
            this.panel6.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 293);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.tabPage1.Controls.Add(this.lsvBookRoomDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(524, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiểt";
            // 
            // lsvBookRoomDetail
            // 
            this.lsvBookRoomDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.lsvBookRoomDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvBookRoomDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Đặt phòng";
            listViewGroup1.Name = "lsvgBookRoom";
            this.lsvBookRoomDetail.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lsvBookRoomDetail.HideSelection = false;
            this.lsvBookRoomDetail.Location = new System.Drawing.Point(3, 3);
            this.lsvBookRoomDetail.Name = "lsvBookRoomDetail";
            this.lsvBookRoomDetail.Size = new System.Drawing.Size(518, 261);
            this.lsvBookRoomDetail.TabIndex = 0;
            this.lsvBookRoomDetail.UseCompatibleStateImageBehavior = false;
            this.lsvBookRoomDetail.View = System.Windows.Forms.View.Details;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.tabPage3.Controls.Add(this.pnListServices);
            this.tabPage3.Controls.Add(this.panal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(524, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dịch vụ";
            // 
            // pnListServices
            // 
            this.pnListServices.Controls.Add(this.dgBookServices);
            this.pnListServices.Location = new System.Drawing.Point(181, 0);
            this.pnListServices.Name = "pnListServices";
            this.pnListServices.Size = new System.Drawing.Size(336, 250);
            this.pnListServices.TabIndex = 1;
            // 
            // dgBookServices
            // 
            this.dgBookServices.AllowUserToAddRows = false;
            this.dgBookServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(160)))));
            this.dgBookServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBookServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookServiceCode,
            this.ServiceCode,
            this.ServiceAmount,
            this.BookRoomCodee,
            this.BookServiceCost});
            this.dgBookServices.Location = new System.Drawing.Point(0, 14);
            this.dgBookServices.Name = "dgBookServices";
            this.dgBookServices.Size = new System.Drawing.Size(330, 222);
            this.dgBookServices.TabIndex = 0;
            this.dgBookServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBookServices_CellClick);
            // 
            // BookServiceCode
            // 
            this.BookServiceCode.DataPropertyName = "BookServiceCode";
            this.BookServiceCode.HeaderText = "Mã ";
            this.BookServiceCode.Name = "BookServiceCode";
            this.BookServiceCode.ReadOnly = true;
            this.BookServiceCode.Visible = false;
            this.BookServiceCode.Width = 5;
            // 
            // ServiceCode
            // 
            this.ServiceCode.DataPropertyName = "ServiceCode";
            this.ServiceCode.HeaderText = "Mã dịch vụ";
            this.ServiceCode.Name = "ServiceCode";
            this.ServiceCode.ReadOnly = true;
            // 
            // ServiceAmount
            // 
            this.ServiceAmount.DataPropertyName = "ServiceAmount";
            this.ServiceAmount.HeaderText = "Số lượng";
            this.ServiceAmount.Name = "ServiceAmount";
            this.ServiceAmount.ReadOnly = true;
            // 
            // BookRoomCodee
            // 
            this.BookRoomCodee.DataPropertyName = "BookRoomCode";
            this.BookRoomCodee.HeaderText = "Mã đặt phòng";
            this.BookRoomCodee.Name = "BookRoomCodee";
            this.BookRoomCodee.ReadOnly = true;
            this.BookRoomCodee.Visible = false;
            this.BookRoomCodee.Width = 5;
            // 
            // BookServiceCost
            // 
            this.BookServiceCost.DataPropertyName = "BookServiceCost";
            this.BookServiceCost.HeaderText = "Đơn giá";
            this.BookServiceCost.Name = "BookServiceCost";
            this.BookServiceCost.ReadOnly = true;
            // 
            // panal
            // 
            this.panal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.panal.Controls.Add(this.numServiceNum);
            this.panal.Controls.Add(this.pnServices);
            this.panal.Controls.Add(this.cbServices);
            this.panal.Location = new System.Drawing.Point(0, 0);
            this.panal.Name = "panal";
            this.panal.Size = new System.Drawing.Size(174, 250);
            this.panal.TabIndex = 0;
            // 
            // numServiceNum
            // 
            this.numServiceNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.numServiceNum.ForeColor = System.Drawing.Color.Orange;
            this.numServiceNum.Location = new System.Drawing.Point(75, 94);
            this.numServiceNum.Name = "numServiceNum";
            this.numServiceNum.Size = new System.Drawing.Size(96, 22);
            this.numServiceNum.TabIndex = 3;
            // 
            // pnServices
            // 
            this.pnServices.Controls.Add(this.btnCancelService);
            this.pnServices.Controls.Add(this.label10);
            this.pnServices.Controls.Add(this.btnEditService);
            this.pnServices.Controls.Add(this.txtServiceCost);
            this.pnServices.Controls.Add(this.label9);
            this.pnServices.Controls.Add(this.btnUseService);
            this.pnServices.Location = new System.Drawing.Point(0, 51);
            this.pnServices.Name = "pnServices";
            this.pnServices.Size = new System.Drawing.Size(174, 199);
            this.pnServices.TabIndex = 2;
            // 
            // btnCancelService
            // 
            this.btnCancelService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelService.Location = new System.Drawing.Point(9, 162);
            this.btnCancelService.Name = "btnCancelService";
            this.btnCancelService.Size = new System.Drawing.Size(162, 23);
            this.btnCancelService.TabIndex = 5;
            this.btnCancelService.Text = "Cancel";
            this.btnCancelService.UseVisualStyleBackColor = true;
            this.btnCancelService.Click += new System.EventHandler(this.btnCancelService_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số lượng";
            // 
            // btnEditService
            // 
            this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditService.Location = new System.Drawing.Point(9, 125);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(162, 23);
            this.btnEditService.TabIndex = 4;
            this.btnEditService.Text = "Edit";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(75, 2);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.ReadOnly = true;
            this.txtServiceCost.Size = new System.Drawing.Size(97, 22);
            this.txtServiceCost.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(6, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá";
            // 
            // btnUseService
            // 
            this.btnUseService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseService.Location = new System.Drawing.Point(9, 87);
            this.btnUseService.Name = "btnUseService";
            this.btnUseService.Size = new System.Drawing.Size(162, 23);
            this.btnUseService.TabIndex = 1;
            this.btnUseService.Text = "Order";
            this.btnUseService.UseVisualStyleBackColor = true;
            this.btnUseService.Click += new System.EventHandler(this.btnUseService_Click);
            // 
            // cbServices
            // 
            this.cbServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.cbServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServices.ForeColor = System.Drawing.Color.Orange;
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(6, 14);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(165, 21);
            this.cbServices.TabIndex = 0;
            this.cbServices.SelectionChangeCommitted += new System.EventHandler(this.cbServices_SelectionChangeCommitted);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.tabPage2.Controls.Add(this.dgCustomerBookRoom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(524, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách ";
            // 
            // dgCustomerBookRoom
            // 
            this.dgCustomerBookRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.dgCustomerBookRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCustomerBookRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerBookRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuePhong,
            this.KhachHang,
            this.CCCD,
            this.NgayThuePhong,
            this.NgayTraPhong,
            this.MaPhong,
            this.LoaiThue});
            this.dgCustomerBookRoom.Location = new System.Drawing.Point(3, 3);
            this.dgCustomerBookRoom.Name = "dgCustomerBookRoom";
            this.dgCustomerBookRoom.ReadOnly = true;
            this.dgCustomerBookRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomerBookRoom.Size = new System.Drawing.Size(513, 242);
            this.dgCustomerBookRoom.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.Orange;
            this.btnPay.Location = new System.Drawing.Point(226, 437);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(83, 30);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRoom.ForeColor = System.Drawing.Color.Orange;
            this.btnBookRoom.Location = new System.Drawing.Point(0, 437);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(83, 30);
            this.btnBookRoom.TabIndex = 2;
            this.btnBookRoom.Text = "Đặt phòng";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Orange;
            this.btnCancel.Location = new System.Drawing.Point(339, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnBookRoomExit_Click);
            // 
            // btnBookRoomEditInfo
            // 
            this.btnBookRoomEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRoomEditInfo.ForeColor = System.Drawing.Color.Orange;
            this.btnBookRoomEditInfo.Location = new System.Drawing.Point(113, 437);
            this.btnBookRoomEditInfo.Name = "btnBookRoomEditInfo";
            this.btnBookRoomEditInfo.Size = new System.Drawing.Size(83, 30);
            this.btnBookRoomEditInfo.TabIndex = 3;
            this.btnBookRoomEditInfo.Text = "Sửa";
            this.btnBookRoomEditInfo.UseVisualStyleBackColor = true;
            this.btnBookRoomEditInfo.Click += new System.EventHandler(this.btnBookRoomEditInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(31, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 476);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(0, 263);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 210);
            this.panel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRoomId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(0, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 185);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phòng";
            // 
            // txtRoomId
            // 
            this.txtRoomId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.txtRoomId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtRoomId.Location = new System.Drawing.Point(79, 24);
            this.txtRoomId.Multiline = true;
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(75, 23);
            this.txtRoomId.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(22, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phòng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cbBookRoomType);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtCusId);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtpCheckout);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dtpCheckin);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtCusName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 267);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(-3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phiếu đặt phòng";
            // 
            // cbBookRoomType
            // 
            this.cbBookRoomType.BackColor = System.Drawing.Color.Azure;
            this.cbBookRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBookRoomType.FormattingEnabled = true;
            this.cbBookRoomType.Location = new System.Drawing.Point(123, 200);
            this.cbBookRoomType.Name = "cbBookRoomType";
            this.cbBookRoomType.Size = new System.Drawing.Size(169, 21);
            this.cbBookRoomType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(4, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại thuê";
            // 
            // txtCusId
            // 
            this.txtCusId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCusId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCusId.Location = new System.Drawing.Point(123, 76);
            this.txtCusId.Multiline = true;
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(169, 20);
            this.txtCusId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(4, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số CCCD";
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckout.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dtpCheckout.Location = new System.Drawing.Point(123, 160);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(169, 20);
            this.dtpCheckout.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(4, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày trả phòng";
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.CalendarMonthBackground = System.Drawing.Color.SlateGray;
            this.dtpCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckin.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dtpCheckin.Location = new System.Drawing.Point(123, 119);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(169, 20);
            this.dtpCheckin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(4, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày thuê phòng";
            // 
            // txtCusName
            // 
            this.txtCusName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCusName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCusName.Location = new System.Drawing.Point(123, 36);
            this.txtCusName.Multiline = true;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(169, 20);
            this.txtCusName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // imglRoom
            // 
            this.imglRoom.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglRoom.ImageSize = new System.Drawing.Size(16, 16);
            this.imglRoom.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MaThuePhong
            // 
            this.MaThuePhong.DataPropertyName = "BookRoomCode";
            this.MaThuePhong.HeaderText = "Mã thuê";
            this.MaThuePhong.Name = "MaThuePhong";
            this.MaThuePhong.ReadOnly = true;
            this.MaThuePhong.Visible = false;
            this.MaThuePhong.Width = 5;
            // 
            // KhachHang
            // 
            this.KhachHang.DataPropertyName = "CustomerName";
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CustomerId";
            this.CCCD.HeaderText = "Căn cước công dân";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // NgayThuePhong
            // 
            this.NgayThuePhong.DataPropertyName = "TimeCheckin";
            this.NgayThuePhong.HeaderText = "Ngày thuê phòng";
            this.NgayThuePhong.Name = "NgayThuePhong";
            this.NgayThuePhong.ReadOnly = true;
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.DataPropertyName = "TimeCheckout";
            this.NgayTraPhong.HeaderText = "Ngày Trả Phòng";
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "RoomCode";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Visible = false;
            this.MaPhong.Width = 5;
            // 
            // LoaiThue
            // 
            this.LoaiThue.DataPropertyName = "BookRoomType";
            this.LoaiThue.HeaderText = "Loại thuê";
            this.LoaiThue.Name = "LoaiThue";
            this.LoaiThue.ReadOnly = true;
            // 
            // frmBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBookRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBookRoom_FormClosed);
            this.Load += new System.EventHandler(this.frmBookRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookRomDetail)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnListServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookServices)).EndInit();
            this.panal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numServiceNum)).EndInit();
            this.pnServices.ResumeLayout(false);
            this.pnServices.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerBookRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBookRoomType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBookRoomEditInfo;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.ListView lsvBookRoomDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgCustomerBookRoom;
        private System.Windows.Forms.DataGridView dgBookRomDetail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnListServices;
        private System.Windows.Forms.DataGridView dgBookServices;
        private System.Windows.Forms.Panel panal;
        private System.Windows.Forms.Button btnUseService;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Panel pnServices;
        private System.Windows.Forms.NumericUpDown numServiceNum;
        private System.Windows.Forms.ImageList imglRoom;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancelService;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookRoomCodee;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookServiceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookRoomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCode;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThue;
    }
}