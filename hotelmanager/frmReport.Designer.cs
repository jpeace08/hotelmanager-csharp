namespace hotelmanager
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpReportTime = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mcTimer = new System.Windows.Forms.MonthCalendar();
            this.rdYear = new System.Windows.Forms.RadioButton();
            this.rdMonth = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtYearTotal = new System.Windows.Forms.TextBox();
            this.txtMonthTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgBookRooms = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookRooms)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpReportTime);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 70);
            this.panel1.TabIndex = 0;
            // 
            // dtpReportTime
            // 
            this.dtpReportTime.CustomFormat = "dd/MM/yyyy";
            this.dtpReportTime.Enabled = false;
            this.dtpReportTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpReportTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReportTime.Location = new System.Drawing.Point(814, 44);
            this.dtpReportTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpReportTime.Name = "dtpReportTime";
            this.dtpReportTime.Size = new System.Drawing.Size(168, 22);
            this.dtpReportTime.TabIndex = 0;
            this.dtpReportTime.Visible = false;
            this.dtpReportTime.ValueChanged += new System.EventHandler(this.dtpReportTime_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mcTimer);
            this.panel2.Controls.Add(this.rdYear);
            this.panel2.Controls.Add(this.rdMonth);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgBookRooms);
            this.panel2.Location = new System.Drawing.Point(15, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 455);
            this.panel2.TabIndex = 1;
            // 
            // mcTimer
            // 
            this.mcTimer.Location = new System.Drawing.Point(809, 18);
            this.mcTimer.Name = "mcTimer";
            this.mcTimer.TabIndex = 5;
            this.mcTimer.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcTimer_DateChanged);
            // 
            // rdYear
            // 
            this.rdYear.AutoSize = true;
            this.rdYear.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdYear.Location = new System.Drawing.Point(929, 235);
            this.rdYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdYear.Name = "rdYear";
            this.rdYear.Size = new System.Drawing.Size(49, 17);
            this.rdYear.TabIndex = 4;
            this.rdYear.TabStop = true;
            this.rdYear.Text = "Năm";
            this.rdYear.UseVisualStyleBackColor = true;
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMonth.Location = new System.Drawing.Point(809, 235);
            this.rdMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Size = new System.Drawing.Size(56, 17);
            this.rdMonth.TabIndex = 3;
            this.rdMonth.TabStop = true;
            this.rdMonth.Text = "Tháng";
            this.rdMonth.UseVisualStyleBackColor = true;
            this.rdMonth.CheckedChanged += new System.EventHandler(this.rdMonth_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.txtYearTotal);
            this.panel4.Controls.Add(this.txtMonthTotal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(809, 273);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 175);
            this.panel4.TabIndex = 2;
            // 
            // txtYearTotal
            // 
            this.txtYearTotal.Location = new System.Drawing.Point(3, 133);
            this.txtYearTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYearTotal.Name = "txtYearTotal";
            this.txtYearTotal.Size = new System.Drawing.Size(161, 22);
            this.txtYearTotal.TabIndex = 3;
            // 
            // txtMonthTotal
            // 
            this.txtMonthTotal.Location = new System.Drawing.Point(3, 48);
            this.txtMonthTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMonthTotal.Name = "txtMonthTotal";
            this.txtMonthTotal.Size = new System.Drawing.Size(161, 22);
            this.txtMonthTotal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu(Năm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu (Tháng)";
            // 
            // dgBookRooms
            // 
            this.dgBookRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(160)))));
            this.dgBookRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBookRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookRooms.Location = new System.Drawing.Point(33, 18);
            this.dgBookRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgBookRooms.Name = "dgBookRooms";
            this.dgBookRooms.Size = new System.Drawing.Size(725, 430);
            this.dgBookRooms.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(15, 551);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 56);
            this.panel3.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(884, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(78)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1041, 610);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê, báo cáo";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookRooms)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdYear;
        private System.Windows.Forms.RadioButton rdMonth;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtYearTotal;
        private System.Windows.Forms.TextBox txtMonthTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReportTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MonthCalendar mcTimer;
        private System.Windows.Forms.DataGridView dgBookRooms;
    }
}