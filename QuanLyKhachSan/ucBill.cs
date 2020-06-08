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
        public ucBill()
        {
            InitializeComponent();
            LoadBill();
            panel2.Visible = false;
        }

        #region Xử lí hàm

        void LoadBill()
        {
            dtgvListBill.DataSource = BillManagementDAO.Instance.LoadBillList();
        }

        void AdvancedSearch(ref string insert)
        {
            if (checkbox1.Checked == true)
            {
                insert += checkbox1.Text + " like N'%" + textboxsearch1.Text + "%'";
                only1attribute = false;
            }
            if (checkbox2.Checked == true)
            {
                if (only1attribute == false) insert += " and ";
                insert += checkbox2.Text + " like N'%" + textboxsearch2.Text + "%'";
                only1attribute = false;
            }
            if (checkbox3.Checked == true)
            {
                if (only1attribute == false) insert += " and ";
                insert += checkbox3.Text + " = '" + textboxsearch3.Text + "'";
                only1attribute = false;
            }
        }

        #endregion

        #region Chức năng quản lí hóa đơn

        private void btnSearch_Click(object sender, EventArgs e)
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
            dtgvListBill.DataSource = BillManagementDAO.Instance.SearchBill(insert);
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
