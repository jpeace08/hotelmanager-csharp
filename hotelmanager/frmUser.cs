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
    
    public partial class frmUser : Form
    {

        #region propers:
        private List<ROLE_DTO> roles;
        public List<ROLE_DTO> Roles { get => roles; set => roles = value; }
        public List<EMPLOYEE_DTO> Employees { get => employees; set => employees = value; }

        private List<EMPLOYEE_DTO> employees;
        private int check = -1;
        private int exe = -1;

        #endregion

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            loadRole();
            Employees = EMPLOYEE_BLL.getEmployees("Select * from NHAN_VIEN order by TenNhanVien");
            dgUsers.DataSource = Employees;
        }

        private void loadRole()
        {
            string sqlQuery = "Select * from PHAN_QUYEN as pb order by pb.TenPhanQuyen";
            Roles = ROLE_BLL.getRoles(sqlQuery);

            cbRole.DataSource = Roles;
            cbRole.DisplayMember = "RoleName";
            cbRole.ValueMember = "RoleCode";
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            reSet();
            exe = 0;
            btnSave.Enabled = true;
            btnUserAdd.Enabled = btnUserEdit.Enabled = btnUserDel.Enabled = false;

        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            exe = 1;
            btnSave.Enabled = true;
            btnUserAdd.Enabled = btnUserEdit.Enabled = btnUserDel.Enabled = false;
        }

        private void btnUserDel_Click(object sender, EventArgs e)
        {
            if (txtEmployeeCode.Text == "") return;
            if (EMPLOYEE_BLL.delUser(int.Parse(txtEmployeeCode.Text.Trim())))
            {
                MessageBox.Show("Xóa thành công!");
                EMPLOYEE_DTO empl = Employees.Single(n => n.EmployeeCode == int.Parse(txtEmployeeCode.Text));
                Employees.Remove(empl);
                dgUsers.DataSource = EMPLOYEE_BLL.getEmployees("Select * from NHAN_VIEN order by TenNhanVien");
                reSet();
                check = 1;
            }
            else
            {
                MessageBox.Show("Chưa thể xóa!");
            }
        }


        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }
            if (lowerCase)
            {
                return sb.ToString().ToLower();
            }
            return sb.ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //add employee:
            if (exe == 0)
            {
                EMPLOYEE_DTO empl = new EMPLOYEE_DTO()
                {
                    EmployeeName = txtEmployeeName.Text.Trim(),
                    EmployeePhone = txtEmployeePhone.Text.Trim(),
                    EmployAddress = txtEmployeeAddr.Text.Trim(),
                    Username = RandomString(6,true),
                    Password = "1234",
                    RoleCode = int.Parse(cbRole.SelectedValue.ToString())
                };
                if (EMPLOYEE_BLL.addEmployee(empl))
                {
                    MessageBox.Show("Thêm thành công!");
                    Employees.Add(empl);
                    dgUsers.DataSource = EMPLOYEE_BLL.getEmployees("Select * from NHAN_VIEN order by TenNhanVien");
                    reSet();
                    check = 1;
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                    reSet();
                }
            }
            else if(exe == 1)
            {
                EMPLOYEE_DTO empl = new EMPLOYEE_DTO()
                {
                    EmployeeCode = int.Parse(txtEmployeeCode.Text.Trim()),
                    EmployeeName = txtEmployeeName.Text.Trim(),
                    EmployeePhone = txtEmployeePhone.Text.Trim(),
                    EmployAddress = txtEmployeeAddr.Text.Trim(),
                    Username = txtPassword.Text.Trim(),
                    Password = txtUsername.Text.Trim(),
                    RoleCode = int.Parse(cbRole.SelectedValue.ToString())
                };

                if (EMPLOYEE_BLL.updateInfoEmpl(empl))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    Employees.Clear();
                    Employees = EMPLOYEE_BLL.getEmployees("Select * from NHAN_VIEN order by TenNhanVien");
                    dgUsers.DataSource = Employees;
                    reSet();
                    check = 1;
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }

            exe = -1;
            btnSave.Enabled = false;
            btnUserAdd.Enabled = btnUserEdit.Enabled = btnUserDel.Enabled = true;
        }

        void reSet()
        {
            txtEmployeeCode.Text = txtEmployeePhone.Text = txtEmployeeAddr.Text = txtEmployeeName.Text = txtPassword.Text = txtUsername.Text = "";
            txtEmployeePhone.Focus();
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgUsers.Rows[e.RowIndex];
            txtEmployeeName.Text = row.Cells[1].Value.ToString();
            txtEmployeePhone.Text = row.Cells[2].Value.ToString();
            txtEmployeeAddr.Text = row.Cells[3].Value.ToString();
            txtUsername.Text = row.Cells[4].Value.ToString();
            txtPassword.Text = row.Cells[5].Value.ToString();
            cbRole.SelectedValue = row.Cells[6].Value;
            txtEmployeeCode.Text = row.Cells[0].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            check = -1;
        }
    }
}
