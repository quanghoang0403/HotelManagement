using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
     
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPass.Text;
            var canlogin=await AccountBUS.Instance.LoginAccount(userName,passWord);
            if (canlogin == "true")
            {
                fHotelManager f = new fHotelManager();
                this.Hide();
                f.Permission_to_access = IsManager(userName);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        bool IsManager(string username)
        {
            if (PermissionBUS.Instance.Permission(username) == "Manager")
                return true;
            else
                return false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
