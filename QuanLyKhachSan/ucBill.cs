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
    public partial class ucBill : UserControl
    {
        private bool Accessibility=true;
        public ucBill()
        {
            InitializeComponent();
            LoadBill();
            panel2.Visible = false;
        }

    #region Xu li phan quyen

        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            if (Accessibility == false)
            {
                panel6.Visible = false;
            }
        }

        #endregion

    #region Xu li chuc nang

        void LoadBill()
        {
            string query = "SELECT * FROM DBO.BILL";
            dtgvListBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void SearchBill(string insert)
        {
            string query = "SELECT * from dbo.BILL where id_bill='" + insert + "' or bill_name='"+insert+"' or bill_address='"+insert+"' or total_money='"+insert+"'";
            dtgvListBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void DeleteBill(string id_bill)
        {
            string query1 = "delete from dbo.BILL_DETAILS where id_bill='" + id_bill + "'";
            string query2 = "delete from dbo.BILL where id_bill='" + id_bill + "'";
            DataProvider.Instance.ExecuteQuery(query1);
            DataProvider.Instance.ExecuteQuery(query2);
            LoadBill();
        }

        void UpdateBill(string id_bill,string bill_name,string bill_address,string total_money)
        {
            string query = "Update dbo.BILL Set bill_name =N'" + bill_name + "',bill_address =N'" + bill_address + "',total_money ='" + total_money + "' Where id_bill ='" + id_bill + "'";
            DataProvider.Instance.ExecuteQuery(query);
            btnCancelEdit.PerformClick();
            LoadBill();
        }

        private void dtgvListBill_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvListBill.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvListBill.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvListBill.Rows[selectedrowindex];
                txbid_bill.Text = Convert.ToString(selectedRow.Cells["id_bill"].Value);
                txbbill_name.Text = Convert.ToString(selectedRow.Cells["bill_name"].Value);
                txbbill_address.Text = Convert.ToString(selectedRow.Cells["bill_address"].Value);
                txbtotal_money.Text = Convert.ToString(selectedRow.Cells["total_money"].Value);
            }
        }

        #endregion

    #region Chuc nang quan li hoa don

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
            SearchBill(txbSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn xóa hóa đơn này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
           switch (result)
           {
               case DialogResult.Yes:
                    DeleteBill(txbid_bill.Text);
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
            txbbill_name.Text = "";
            txbtotal_money.Text = "";
            txbbill_address.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(panel2.Visible==false)
            {
                panel2.Visible = true;
                return;
            }
            UpdateBill(txbid_bill.Text, txbbill_name.Text, txbbill_address.Text, txbtotal_money.Text);
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
