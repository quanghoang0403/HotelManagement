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
        private bool Accessibility=true;
        public ucCheckin()
        {
            InitializeComponent();
            LoadCheckin();
            panel2.Visible = false;
        }

    #region Xu li phan quyen
        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }
        private void ucCheckin_Load(object sender, EventArgs e)
        {
            if (Accessibility == false)
            {
                panel6.Visible = false;
            }
        }
        #endregion

    #region Xu li chuc nang

        void LoadCheckin()
        {
            string query = "SELECT * FROM DBO.CHECKIN";
            dtgvList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void SearchCheckin(string insert)
        {
            string query = "SELECT * " +
                "from dbo.CHECKIN " +
                "where id_checkin='" + insert
                //+ "' or date_start='" + Convert.ToDateTime(insert)
                + "' or id_room='" + insert
                + "' or money_checkin='" + insert
                +"' or type_ratioMAX='"+ insert 
                + "' or number_customer='" + insert 
                + "' or status_checkin='" + insert +"'";
            dtgvList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void DeleteCheckin(string id_checkin)
        {
            string query1 = "delete from dbo.CHECKIN_DETAILS where id_checkin='" + id_checkin + "'";
            string query2 = "delete from dbo.CHECKIN where id_checkin='" + id_checkin + "'";
            DataProvider.Instance.ExecuteQuery(query1);
            DataProvider.Instance.ExecuteQuery(query2);
            LoadCheckin();
        }

        void UpdateCheckin(string id_checkin,string id_room,string money_checkin,string type_ratioMax,string number_customer,string status_checkin)
        {
            string query = "Update dbo.CHECKIN " +
                "Set id_room ='" + id_room 
                + "',money_checkin ='" + money_checkin
                + "',type_ratioMAX ='" + type_ratioMax
                + "',number_customer ='" + number_customer 
                +"',status_checkin ='" + status_checkin 
                +"' Where id_checkin ='" + id_checkin + "'";
            DataProvider.Instance.ExecuteQuery(query);
            btnCancelEdit.PerformClick();
            LoadCheckin();
        }

        private void dtgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvList.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvList.Rows[selectedrowindex];
                txbid_chekin.Text = Convert.ToString(selectedRow.Cells["id_checkin"].Value);
                txbid_room.Text = Convert.ToString(selectedRow.Cells["id_room"].Value);
                txbmoney_checkin.Text = Convert.ToString(selectedRow.Cells["money_checkin"].Value);
                txbtyperatio_max.Text = Convert.ToString(selectedRow.Cells["type_ratioMAX"].Value);
                txbnumber_customer.Text = Convert.ToString(selectedRow.Cells["number_customer"].Value);
                txbstatus_checkin.Text = Convert.ToString(selectedRow.Cells["status_checkin"].Value);
            }
        }

        #endregion

    #region Chuc nang quan li hoa don

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
            }
            SearchCheckin(txbSearch.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
                return;
            }
            UpdateCheckin(txbid_chekin.Text,txbid_room.Text,txbmoney_checkin.Text,txbtyperatio_max.Text,txbnumber_customer.Text,txbstatus_checkin.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCheckin();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn xóa phiếu thuê phòng này này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
               case DialogResult.Yes:
                    DeleteCheckin(txbid_chekin.Text);
                    break;
               case DialogResult.No:
                    break;
               default:
                    break;
            }
        }
        
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txbid_room.Text = "";
            txbmoney_checkin.Text = "";
            txbtyperatio_max.Text = "";
            txbnumber_customer.Text = "";
            txbstatus_checkin.Text = "";
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
