using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAO;

namespace QuanLyKhachSan
{
    public partial class ucAccount : UserControl
    {
        private bool Accessibility=true;
        public ucAccount()
        {
            InitializeComponent();
            LoadAmount();
            LoadCustomerType();
        }

        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        #region Doi mat khau

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "" || txbPassword.Text == "" || txbNewPass.Text == "" || txbReEnterPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin !");
                return;
            }
            else if (txbNewPass.Text == txbPassword.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng mật khẩu hiện tại !");
                return;
            }
            else if (txbNewPass.Text != txbReEnterPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp mật khẩu mới tạo !");
                return;
            }          
            SettingDAO.Instance.ChangePass(txbUserName.Text,txbNewPass.Text);
            MessageBox.Show("Đã đổi thành công !");
            btnRemoveChangePass.PerformClick();
        }

        private void btnRemoveChangePass_Click(object sender, EventArgs e)
        {
            txbUserName.Text = "";
            txbPassword.Text = "";
            txbNewPass.Text = "";
            txbReEnterPass.Text = "";
        }
        
        #endregion

        #region Dang ky

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txbSignin_Username.Text == "" || txbSignin_RePass.Text == "" || txbSignin_Name.Text == "" || txbSignin_Password.Text == "" || comboBox_Permission.Text=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin");
                return;
            }
            else if (txbSignin_Password.Text != txbSignin_RePass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp mật khẩu mới tạo");
                return;
            }
            SettingDAO.Instance.Signin(txbSignin_Username.Text, txbSignin_Password.Text, txbSignin_Name.Text, comboBox_Permission.Text);
            MessageBox.Show("Đã tạo tài khoản thành công !");
            btnRemoveSignin.PerformClick();          
        }

        private void btnRemoveSignin_Click(object sender, EventArgs e)
        {
            txbSignin_Username.Text = "";
            txbSignin_RePass.Text = "";
            txbSignin_Name.Text = "";
            txbSignin_Password.Text = "";
            comboBox_Permission.Text = "";
        }
        
        #endregion


        void LoadAmount()
        {
            dtgvType.DataSource = SettingDAO.Instance.LoadAmountList();
        }
        void LoadCustomerType()
        {
            dtgvCustomertype.DataSource = SettingDAO.Instance.LoadCustomerTypeList();
        }
        private void txbMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbMaxSurcharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnUpdateSetting_Click(object sender, EventArgs e)
        {
            if(txbMax.Text== "" || txbRatio.Text== "" || txbMaxSurcharge.Text== "")
            {
                MessageBox.Show("Không bỏ trống thông tin");
                return;
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if(txbTypeRoom.Text== "" || txbPrice.Text== "")
            {
                MessageBox.Show("Không bỏ trống thông tin");
                return;
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (txbTypeRoom.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên loại khách hàng");
                return;
            }
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (txbTypeRoom.Text == "" || txbPrice.Text == "")
            {
                MessageBox.Show("Không bỏ trống thông tin");
                return;
            }
        }
        
        private void ucAccount_Load(object sender, EventArgs e)
        {
            if (Accessibility == false)
            {
                panel6.Visible = false;
                panel15.Visible = false;
            }
        }

        private void dtgvType_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvType.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvType.Rows[selectedrowindex];
                txbMax.Text = Convert.ToString(selectedRow.Cells["max_customer"].Value);
                txbRatio.Text = Convert.ToString(selectedRow.Cells["customer_ratio"].Value);
                txbMaxSurcharge.Text = Convert.ToString(selectedRow.Cells["amount_surchage"].Value);
            }
        }
    }
}
