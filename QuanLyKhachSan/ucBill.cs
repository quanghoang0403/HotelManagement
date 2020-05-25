using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ucBill : UserControl
    {
        public ucBill()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txbSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
