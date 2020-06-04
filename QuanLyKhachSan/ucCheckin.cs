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
    public partial class ucCheckin : UserControl
    {
        private bool only1searchattribute = true;
        private bool Is_AdvancedSearch = false;
        public ucCheckin()
        {
            InitializeComponent();
            LoadCheckin();
            panel2.Visible = false;
        }

        #region Xử lí hàm

        void LoadCheckin()
        {
            dtgvList.DataSource=CheckinManagementDAO.Instance.LoadCheckinList();
        }

        void AdvancedSearch(ref string insert)
        {
            if (checkbox1.Checked == true)
            {
                insert += checkbox1.Text + " = '" + textboxsearch1.Value.Date.ToString("d") + "'";
                only1searchattribute = false;
            }
            if (checkbox2.Checked == true)
            {
                if(only1searchattribute==false)
                {
                    insert += "and ";
                }
                insert +=checkbox2.Text + " = '" + textboxsearch2.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox3.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=checkbox3.Text + " = '" + textboxsearch3.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox4.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=checkbox4.Text + " = '" + textboxsearch4.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox5.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=checkbox5.Text + " = '" + textboxsearch5.Text + "'";
                only1searchattribute = false;
            }
            if (checkbox6.Checked == true)
            {
                if (only1searchattribute == false)
                {
                    insert += "and ";
                }
                insert +=checkbox6.Text + " = '" + textboxsearch6.Text + "'";
                only1searchattribute = false;
            }
        }

        #endregion

        #region Chức năng quản lí phiếu thuê

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "" && panel2.Visible == false)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
                return;
            }
            only1searchattribute = true;
            string insert = "";
            if (panel2.Visible == true)
                AdvancedSearch(ref insert);
            else
                insert = " id_checkin='" + txbSearch.Text + "'";
            dtgvList.DataSource = CheckinManagementDAO.Instance.SearchCheckin(insert);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCheckin();
            checkbox1.Checked = false;
            checkbox2.Checked = false;
            checkbox3.Checked = false;
            checkbox4.Checked = false;
            checkbox5.Checked = false;
            checkbox6.Checked = false;
            textboxsearch1.Value = DateTime.Now;
            textboxsearch2.Text = "";
            textboxsearch3.Text = "";
            textboxsearch4.Text = "";
            textboxsearch5.Text = "";
            textboxsearch6.Text = "";
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }     
    }
}
