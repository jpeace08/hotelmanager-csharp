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
    public partial class frmServices : Form
    {
        #region propers:
        private List<SERVICE_DTO> services;
        public List<SERVICE_DTO> Services { get => services; set => services = value; }
        public SERVICE_DTO Service { get => service; set => service = value; }

        public ErrorProvider ErrorProvider = new ErrorProvider();
        private SERVICE_DTO service;
        private int check = -1;
        private int exe = -1;
        #endregion
        public frmServices()
        {
            InitializeComponent();
        } 

        private void frmServices_Load(object sender, EventArgs e)
        {
            loadService();
        }

        private void loadService()
        {
            Services = SERVICE_BLL.getServices("Select * from DICH_VU as dv order by dv.TenDV");
            dgServices.DataSource = Services;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            exe = 0;
            txtServiceCode.Enabled = true;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
        void reSet()
        {
            txtServiceCode.Text = txtServiceName.Text = "";
            txtServiceCode.Focus();
            numServiceCost.Value = 1;
        }

        private void dgServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgServices.Rows[e.RowIndex];
            txtServiceCode.Text = row.Cells[0].Value.ToString();
            txtServiceName.Text = row.Cells[1].Value.ToString();
            numServiceCost.Value = int.Parse(row.Cells[2].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            exe = 1;
            btnEdit.Enabled = btnDelete.Enabled = btnAdd.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(exe == 0)
            {
                ErrorProvider.SetError(txtServiceName, "");
                ErrorProvider.SetError(txtServiceCode, "");
                if (txtServiceName.Text == "")
                {
                    ErrorProvider.SetError(txtServiceName, "Not null!");
                }
                if (txtServiceCode.Text == "")
                {
                    ErrorProvider.SetError(txtServiceCode, "Not null!");
                }
                SERVICE_DTO service = new SERVICE_DTO()
                {
                    ServiceCode = txtServiceCode.Text,
                    ServiceName = txtServiceName.Text,
                    ServiceCost = decimal.Parse(numServiceCost.Value.ToString())
                };
                if (SERVICE_BLL.addService(service))
                {
                    MessageBox.Show("Lưu thành công!");
                    loadService();
                    reSet();
                    check = 1;
                }
                else
                {
                    MessageBox.Show("Chưa lưu được!");

                }
            }
            else if (exe == 1)
            {
                Service = new SERVICE_DTO()
                {
                    ServiceCode = txtServiceCode.Text,
                    ServiceName = txtServiceName.Text,
                    ServiceCost = decimal.Parse(numServiceCost.Value.ToString())
                };

                if (SERVICE_BLL.editService(Service))
                {
                    MessageBox.Show("Thành công!");
                    loadService();
                    reSet();
                    check = 1;
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            else if(exe == 2)
            {

            }
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = false;
            exe = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (check == 1) DialogResult = DialogResult.OK;
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            check = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
