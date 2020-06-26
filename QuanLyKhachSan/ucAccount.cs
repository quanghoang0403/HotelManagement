using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
using QuanLyKhachSan.DAO;
=======
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
>>>>>>> Stashed changes

namespace QuanLyKhachSan
{
    public partial class ucAccount : UserControl
    {
        private bool Accessibility=true;
        AmountBUS _repos = new AmountBUS();
        CustomerTypeBUS _reposCT = new CustomerTypeBUS();
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
<<<<<<< Updated upstream
            }          
            SettingDAO.Instance.ChangePass(txbUserName.Text,txbNewPass.Text);
=======
            }
            Account acc = new Account("", txbUserName.Text, txbNewPass.Text, "");
            AccountBUS.Instance.ChangePassWord(acc);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            SettingDAO.Instance.Signin(txbSignin_Username.Text, txbSignin_Password.Text, txbSignin_Name.Text, comboBox_Permission.Text);
=======
            Account acc=new Account(txbSignin_Name.Text, txbSignin_Username.Text, txbSignin_Password.Text, comboBox_Permission.Text);
            AccountBUS.Instance.SignupAccount(acc);
>>>>>>> Stashed changes
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


        private async void LoadAmount()
        {
<<<<<<< Updated upstream
            dtgvType.DataSource = SettingDAO.Instance.LoadAmountList();
=======
            var listA = await _repos.GetAmount();
            dtgvType.DataSource = listA;
>>>>>>> Stashed changes
        }
        private async void LoadCustomerType()
        {
<<<<<<< Updated upstream
            dtgvCustomertype.DataSource = SettingDAO.Instance.LoadCustomerTypeList();
=======
            var listCT = await _reposCT.GetCustomerType();
            dtgvCustomertype.DataSource = listCT;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            SettingDAO.Instance.ChangeAmount(txbRatio.Text, txbMax.Text, txbMaxSurcharge.Text);
            LoadAmount();
=======
            Amount amt = new Amount((float)Convert.ToDouble(txbRatio.Text),Convert.ToInt32(txbMax.Text),Convert.ToInt32(txbMaxSurcharge.Text));
            _repos.ChangeAmount(amt);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            SettingDAO.Instance.AddCustomertype(txbTypeCustomer.Text, txbPrice.Text);
=======
            CustomerType ct = new CustomerType(txbTypeCustomer.Text, (float)Convert.ToDouble(txbPrice.Text));
            _reposCT.AddCustomerType(ct);
>>>>>>> Stashed changes
            MessageBox.Show("Đã thêm thành công !");
            LoadCustomerType();
            btnCancel.PerformClick();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn loại khách hàng này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Yes:
<<<<<<< Updated upstream
                    SettingDAO.Instance.DeleteCustomertype(txbOldct.Text);
                    LoadCustomerType();
=======
                    _reposCT.DeleteCustomerType(txbOldct.Text);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            SettingDAO.Instance.UpdateCustomertype(txbOldct.Text,txbOldratio.Text);
=======
            CustomerType ct=new CustomerType(txbOldct.Text, float.Parse(txbOldratio.Text));
            _reposCT.UpdateCustomerType(txbOldct.Text, ct);
>>>>>>> Stashed changes
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
                txbOldct.Text = Convert.ToString(selectedRow.Cells["name"].Value);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAmount();
            LoadCustomerType();
        }

        private void dtgvCustomertype_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCustomertype.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvCustomertype.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvCustomertype.Rows[selectedrowindex];
                txbOldct.Text = Convert.ToString(selectedRow.Cells["Loaikh"].Value);
            }
        }
    }
}
