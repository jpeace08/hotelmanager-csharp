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
    public partial class frmLogin : Form
    {
        #region propers:
        private static List<EMPLOYEE_DTO> employees;
        public static List<EMPLOYEE_DTO> Employees { get => employees; set => employees = value; }
        public EMPLOYEE_DTO Employee { get => employee; set => employee = value; }

        private EMPLOYEE_DTO employee;
        public ErrorProvider ErrorProvider = new ErrorProvider();
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            Employees = EMPLOYEE_BLL.getEmployees("Select * from NHAN_VIEN");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ErrorProvider.SetError(txtPwd, "");
            ErrorProvider.SetError(txtUsername, "");
            
            if (txtPwd.Text.Trim() == "") ErrorProvider.SetError(txtPwd, "!");
            if (txtUsername.Text.Trim() == "") ErrorProvider.SetError(txtUsername, "!");
            else
            {
                Employee = Employees.Single(n => n.Username == txtUsername.Text.Trim() && n.Password == txtPwd.Text.Trim());
                if (Employee != null)
                {
                    frmMain frmMain = new frmMain(Employee);

                    frmMain.Show();

                    this.Hide();

                    
                }
            }
        }
        bool check(string emplusr, string emplpwd,string usr, string pwd)
        {
            return emplusr == usr && emplpwd == pwd;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
