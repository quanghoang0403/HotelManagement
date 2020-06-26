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
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class ucBill : UserControl
    {
        private bool Is_AdvancedSearch=false;
        private bool only1attribute = true;
        BillBUS _repos = new BillBUS();
        public ucBill()
        {
            InitializeComponent();
            LoadBill();
            panel2.Visible = false;
        }

        #region Xử lí hàm

        private async void LoadBill()
        {
<<<<<<< Updated upstream
            dtgvListBill.DataSource = BillManagementDAO.Instance.LoadBillList();
=======
            var listB = await _repos.GetListBill();
            dtgvListBill.DataSource = listB;

>>>>>>> Stashed changes
        }

        void AdvancedSearch(ref string insert)
        {
            if (checkbox1.Checked == true)
            {
                insert += " bill_name like N'%" + textboxsearch1.Text + "%'";
                only1attribute = false;
            }
            if (checkbox2.Checked == true)
            {
                if (only1attribute == false) insert += " and ";
                insert += " bill_address like N'%" + textboxsearch2.Text + "%'";
                only1attribute = false;
            }
            if (checkbox3.Checked == true)
            {
                if (only1attribute == false) insert += " and ";
                insert += " total_money = '" + textboxsearch3.Text + "'";
                only1attribute = false;
            }
        }

        #endregion

        #region Chức năng quản lí hóa đơn

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "" && panel2.Visible==false)
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                return;
            }
            only1attribute = true;
            string insert="";
            if (panel2.Visible == true)
                AdvancedSearch(ref insert);
            else
            insert = " id_bill='" + txbSearch.Text + "'";
<<<<<<< Updated upstream
            dtgvListBill.DataSource = BillManagementDAO.Instance.SearchBill(insert);
=======
            var listSB = await _repos.GetSearchBill(insert);
            dtgvListBill.DataSource = listSB;
>>>>>>> Stashed changes
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBill();
            checkbox1.Checked = false;
            checkbox2.Checked = false;
            checkbox3.Checked = false;
            textboxsearch1.Text = "";
            textboxsearch2.Text = "";
            textboxsearch3.Text = "";
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            if (Is_AdvancedSearch == false)
            {
                panel2.Visible = true;
                Is_AdvancedSearch = true;
                return;
            }
            else
            {
                panel2.Visible = false;
                Is_AdvancedSearch = false;
                return;
            }
        }

        #endregion

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
