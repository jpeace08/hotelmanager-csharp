namespace hotelmanager
{
    partial class usrRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrRoom));
            this.usrlbRoomNumber = new System.Windows.Forms.Label();
            this.pbAvailable = new System.Windows.Forms.PictureBox();
            this.pbNotAvailable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // usrlbRoomNumber
            // 
            this.usrlbRoomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usrlbRoomNumber.Location = new System.Drawing.Point(3, 72);
            this.usrlbRoomNumber.Name = "usrlbRoomNumber";
            this.usrlbRoomNumber.Size = new System.Drawing.Size(84, 18);
            this.usrlbRoomNumber.TabIndex = 0;
            this.usrlbRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAvailable
            // 
            this.pbAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pbAvailable.Image")));
            this.pbAvailable.Location = new System.Drawing.Point(11, 0);
            this.pbAvailable.Name = "pbAvailable";
            this.pbAvailable.Size = new System.Drawing.Size(65, 65);
            this.pbAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvailable.TabIndex = 1;
            this.pbAvailable.TabStop = false;
            this.pbAvailable.Click += new System.EventHandler(this.pbAvailable_Click);
            // 
            // pbNotAvailable
            // 
            this.pbNotAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pbNotAvailable.Image")));
            this.pbNotAvailable.Location = new System.Drawing.Point(12, 0);
            this.pbNotAvailable.Name = "pbNotAvailable";
            this.pbNotAvailable.Size = new System.Drawing.Size(65, 65);
            this.pbNotAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotAvailable.TabIndex = 2;
            this.pbNotAvailable.TabStop = false;
            this.pbNotAvailable.Click += new System.EventHandler(this.pbNotAvailable_Click);
            // 
            // usrRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbNotAvailable);
            this.Controls.Add(this.pbAvailable);
            this.Controls.Add(this.usrlbRoomNumber);
            this.Name = "usrRoom";
            this.Size = new System.Drawing.Size(90, 90);
            this.Load += new System.EventHandler(this.usrRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usrlbRoomNumber;
        private System.Windows.Forms.PictureBox pbAvailable;
        private System.Windows.Forms.PictureBox pbNotAvailable;
    }
}
