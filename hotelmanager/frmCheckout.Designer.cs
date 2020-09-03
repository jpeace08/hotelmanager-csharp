namespace hotelmanager
{
    partial class frmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckout));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookRoomCode = new System.Windows.Forms.TextBox();
            this.txtRoomCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServicesCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgBills = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuePhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(75, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuê phòng";
            // 
            // txtBookRoomCode
            // 
            this.txtBookRoomCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookRoomCode.Location = new System.Drawing.Point(165, 151);
            this.txtBookRoomCode.Multiline = true;
            this.txtBookRoomCode.Name = "txtBookRoomCode";
            this.txtBookRoomCode.ReadOnly = true;
            this.txtBookRoomCode.Size = new System.Drawing.Size(181, 20);
            this.txtBookRoomCode.TabIndex = 1;
            // 
            // txtRoomCode
            // 
            this.txtRoomCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomCode.Location = new System.Drawing.Point(165, 111);
            this.txtRoomCode.Multiline = true;
            this.txtRoomCode.Name = "txtRoomCode";
            this.txtRoomCode.ReadOnly = true;
            this.txtRoomCode.Size = new System.Drawing.Size(181, 20);
            this.txtRoomCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(75, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Location = new System.Drawing.Point(165, 198);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(181, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(75, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng";
            // 
            // txtRoomCost
            // 
            this.txtRoomCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomCost.Location = new System.Drawing.Point(165, 243);
            this.txtRoomCost.Multiline = true;
            this.txtRoomCost.Name = "txtRoomCost";
            this.txtRoomCost.ReadOnly = true;
            this.txtRoomCost.Size = new System.Drawing.Size(181, 20);
            this.txtRoomCost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(75, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiền phòng";
            // 
            // txtServicesCost
            // 
            this.txtServicesCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServicesCost.Location = new System.Drawing.Point(165, 284);
            this.txtServicesCost.Multiline = true;
            this.txtServicesCost.Name = "txtServicesCost";
            this.txtServicesCost.ReadOnly = true;
            this.txtServicesCost.Size = new System.Drawing.Size(181, 20);
            this.txtServicesCost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(75, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền dịch vụ";
            // 
            // btnOk
            // 
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOk.ForeColor = System.Drawing.Color.Orange;
            this.btnOk.Location = new System.Drawing.Point(165, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 31);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgBills
            // 
            this.dgBills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(160)))));
            this.dgBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaThuePhong,
            this.TongTien});
            this.dgBills.Location = new System.Drawing.Point(383, 111);
            this.dgBills.Name = "dgBills";
            this.dgBills.Size = new System.Drawing.Size(325, 243);
            this.dgBills.TabIndex = 12;

            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // MaThuePhong
            // 
            this.MaThuePhong.DataPropertyName = "MaThuePhong";
            this.MaThuePhong.HeaderText = "Mã thuê phòng";
            this.MaThuePhong.Name = "MaThuePhong";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(261, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 31);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(787, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgBills);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtServicesCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookRoomCode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookRoomCode;
        private System.Windows.Forms.TextBox txtRoomCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServicesCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgBills;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}