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
    public partial class usrService : UserControl
    {
        private SERVICE_DTO service;
        public SERVICE_DTO Service { get => service; set => service = value; }

        public usrService(SERVICE_DTO service)
        {
            InitializeComponent();
            Service = service;
        }

        private void usrService_Load(object sender, EventArgs e)
        {
            switch (Service.ServiceName)
            {
                case "Meal":
                    lbImgService.ImageIndex = 1;
                    
                    lbServiceCost.Text = Service.ServiceCost.ToString();
                    break;
                case "Bar Service":
                    lbImgService.ImageIndex = 0;
                    lbServiceCost.Text = Service.ServiceCost.ToString();
                    break;
                case "Car Service":
                    lbImgService.ImageIndex = 2;
                    lbServiceCost.Text = Service.ServiceCost.ToString();
                    break;
                case "Safebox":
                    lbImgService.ImageIndex = 3;
                    lbServiceCost.Text = Service.ServiceCost.ToString();
                    break;
                default:
                    break;
            }
        }

    }
}
