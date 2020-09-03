namespace hotelmanager
{
    partial class usrService
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrService));
            this.imglServices = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbImgService = new System.Windows.Forms.Label();
            this.lbServiceCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imglServices
            // 
            this.imglServices.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglServices.ImageStream")));
            this.imglServices.TransparentColor = System.Drawing.Color.Transparent;
            this.imglServices.Images.SetKeyName(0, "bar-service.png");
            this.imglServices.Images.SetKeyName(1, "meal.png");
            this.imglServices.Images.SetKeyName(2, "car-service.png");
            this.imglServices.Images.SetKeyName(3, "safebox.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbImgService);
            this.panel1.Location = new System.Drawing.Point(20, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 110);
            this.panel1.TabIndex = 0;
            // 
            // lbImgService
            // 
            this.lbImgService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbImgService.ImageList = this.imglServices;
            this.lbImgService.Location = new System.Drawing.Point(0, 0);
            this.lbImgService.Name = "lbImgService";
            this.lbImgService.Size = new System.Drawing.Size(110, 110);
            this.lbImgService.TabIndex = 0;
            // 
            // lbServiceCost
            // 
            this.lbServiceCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbServiceCost.AutoSize = true;
            this.lbServiceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbServiceCost.Location = new System.Drawing.Point(59, 128);
            this.lbServiceCost.Name = "lbServiceCost";
            this.lbServiceCost.Size = new System.Drawing.Size(0, 13);
            this.lbServiceCost.TabIndex = 1;
            this.lbServiceCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbServiceCost);
            this.Controls.Add(this.panel1);
            this.Name = "usrService";
            this.Load += new System.EventHandler(this.usrService_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbImgService;
        private System.Windows.Forms.Label lbServiceCost;
    }
}
