using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fHotelManager : Form
    {
        public fHotelManager()
        {
            InitializeComponent();
        }

        private void fHotelManager_Load(object sender, EventArgs e)
        {
            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome2.Visible = true;
        }

        private void itLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itRoom_Click(object sender, EventArgs e)
        {
            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = true;
            ucHome2.Visible = false;
        }

        private void itBill_Click(object sender, EventArgs e)
        {
            ucAccount1.Visible = false;
            ucBill1.Visible = true;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome2.Visible = false;
        }

        private void itCheckin_Click(object sender, EventArgs e)
        {
            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = true;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome2.Visible = false;
        }

        private void itRevenue_Click(object sender, EventArgs e)
        {
            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = true;
            ucRoom1.Visible = false;
            ucHome2.Visible = false;
        }

        private void itAccount_Click(object sender, EventArgs e)
        {
            ucAccount1.Visible = true;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome2.Visible = false;
        }

        private void fHotelManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void itHome_Click(object sender, EventArgs e)
        {
            ucAccount1.Visible = false;
            ucBill1.Visible = false;
            ucCheckin1.Visible = false;
            ucRevenue1.Visible = false;
            ucRoom1.Visible = false;
            ucHome2.Visible = true;
        }
    }   
}
