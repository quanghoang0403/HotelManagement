using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DTO;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class ucRevenue : UserControl
    {
        public ucRevenue()
        {
            InitializeComponent();
            LoadIncomelist();
        }
        private void LoadIncomelist()
        {
            dtgvIncome.DataSource=RevenueBUS.Instance.LoadRevenueList(dateMonth.Value.Month.ToString(), dateMonth.Value.Year.ToString());
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã xuất phiếu thành công !");
        }

        private void dateMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadIncomelist();
        }
    }
}
