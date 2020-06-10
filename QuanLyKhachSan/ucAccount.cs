using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;

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
            panel17.Visible = false;
            panel13.Visible = false;
            btnCancel.Visible = false;
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
            SettingBUS.Instance.ChangePass(txbUserName.Text,txbNewPass.Text);
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
            SettingBUS.Instance.Signin(txbSignin_Username.Text, txbSignin_Password.Text, txbSignin_Name.Text, comboBox_Permission.Text);
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
            dtgvType.DataSource = SettingBUS.Instance.LoadAmountList();
        }
        void LoadCustomerType()
        {
            dtgvCustomertype.DataSource = SettingBUS.Instance.LoadCustomerTypeList();
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
            SettingBUS.Instance.ChangeAmount(txbRatio.Text, txbMax.Text, txbMaxSurcharge.Text);
            LoadAmount();
            txbRatio.Text = "";
            txbMax.Text = "";
            txbMaxSurcharge.Text = "";
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if(panel13.Visible==false)
            {
                panel13.Visible = true;
                panel17.Visible = false;
                btnCancel.Visible = true;
                CleanCt();
                return;
            }
            if(txbTypeCustomer.Text== "" || txbPrice.Text== "")
            {
                MessageBox.Show("Không bỏ trống thông tin");
                return;
            }
            SettingBUS.Instance.AddCustomertype(txbTypeCustomer.Text, txbPrice.Text);
            MessageBox.Show("Đã thêm thành công !");
            LoadCustomerType();
            btnCancel.PerformClick();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (txbTypeCustomer.Text == "")
            {
                MessageBox.Show("Nhập loại phòng");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn loại khách hàng này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Yes:
                    SettingBUS.Instance.DeleteCustomertype(txbOldct.Text);
                    LoadCustomerType();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if(panel17.Visible==false)
            {
                panel13.Visible = false;
                panel17.Visible = true;
                btnCancel.Visible = true;
                return;
            }
            if (txbOldct.Text == "" || txbOldratio.Text == "")
            {
                MessageBox.Show("Không bỏ trống thông tin");
                return;
            }
            SettingBUS.Instance.UpdateCustomertype(txbOldct.Text,txbOldratio.Text);
            MessageBox.Show("Cập nhật thành công !");
            LoadCustomerType();
            btnCancel.PerformClick();
        }
        
        private void ucAccount_Load(object sender, EventArgs e)
        {
            if (Accessibility == false)
            {
                panel6.Visible = false;
                panel15.Visible = false;
            }
        }

        private void dtgvCustomertype_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCustomertype.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvCustomertype.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvCustomertype.Rows[selectedrowindex];
                txbOldct.Text = Convert.ToString(selectedRow.Cells["Loaikh"].Value);
                txbOldratio.Text = Convert.ToString(selectedRow.Cells["ratio"].Value);
            }
        }
        private void CleanCt()
        {
            txbPrice.Text = "";
            txbTypeCustomer.Text = "";
            txbOldct.Text = "";
            txbOldratio.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanCt();
            panel13.Visible = false;
            panel17.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
