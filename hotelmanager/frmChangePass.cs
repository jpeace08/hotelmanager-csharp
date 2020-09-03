using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace hotelmanager
{
    public partial class frmChangePass : Form
    {
        #region propers:
        private EMPLOYEE_DTO empl;
        public EMPLOYEE_DTO Empl { get => empl; set => empl = value; }
        private ErrorProvider ErrorProvider = new ErrorProvider();
        #endregion
        public frmChangePass(EMPLOYEE_DTO empl)
        {
            InitializeComponent();
            Empl = empl;
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ErrorProvider.SetError(txtOldPass, "");
            if(txtOldPass.Text.Trim() != empl.Password)
            {
                ErrorProvider.SetError(txtOldPass, "Incorrect!");
                return;
            }
            Empl.Password = txtNewPass.Text.Trim();
            if (updatePassWord(Empl))
            {
                MessageBox.Show("Cập nhật  thành công!");
                DialogResult = DialogResult.OK;


            }
            else
            {
                MessageBox.Show("Lỗi trong quá trình cập nhật!");
                DialogResult = DialogResult.Cancel;
            }
            
        }

        private bool updatePassWord(EMPLOYEE_DTO empl)
        {
            return EMPLOYEE_BLL.updatePassWord(empl);
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Trim() != txtConfirmPass.Text.Trim())
            {
                ErrorProvider.SetError(txtConfirmPass, "!");
            }
            else ErrorProvider.SetError(txtConfirmPass, "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
