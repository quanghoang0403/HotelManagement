using QuanLyKhachSan.DAO;
using QuanLyKhachSan.DTO;
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
    public partial class fCheckin : Form
    {
        public fCheckin()
        {
            InitializeComponent();
            LoadType();
            panel1.Visible = false;
        }

        void ShowInfo(int id)
        {
            lvRoom.Items.Clear();
            List<infoCheckin> listCheckinInfo = infoCheckinDAO.Instance.GetListCheckinInfo(id);
            foreach (infoCheckin item in listCheckinInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Name.ToString());
                lvItem.SubItems.Add(item.CMND.ToString());
                lvItem.SubItems.Add(item.Type.ToString());
                lvItem.SubItems.Add(item.Address.ToString());
                lvRoom.Items.Add(lvItem);
            }
        }

        void LoadType()
        {
            List<CustomerType> listType = CustomerTypeDAO.Instance.GetListType();
            cbType.DataSource = listType;
            cbType.DisplayMember = "name";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txbName.Text == "" || cbType.Text== "" || txbCMND.Text== "" || txbAddress.Text== "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                return ;
            }
            if (infoCheckinDAO.Instance.insertCheckinInfo(txbName.Text, cbType.Text, txbCMND.Text, txbAddress.Text, infoCheckinDAO.Instance.GetMaxIDCheckin()))
            {
                ShowInfo(infoCheckinDAO.Instance.GetMaxIDCheckin());

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khách hàng");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txbID.Text=="")
            {
                MessageBox.Show("Vui lòng nhập ID phòng");
            }
            else
            if (infoCheckinDAO.Instance.insertCheckin(dateStartDate.Value, txbID.Text))
            {
                MessageBox.Show("Tạo thành công, vui lòng nhập thông tin khách hàng");
                panel1.Visible = true;
                txbID.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Có lỗi khi tạo phiếu");
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int id_checkin = infoCheckinDAO.Instance.GetMaxIDCheckin();
            float ratio = infoCheckinDAO.Instance.GetMaxRatio(id_checkin);
            int count = infoCheckinDAO.Instance.GetAmountCustomer(id_checkin);
            if (infoCheckinDAO.Instance.updateCheckin(ratio, count, id_checkin))
            {
                HomeDAO.Instance.updateHomeByCreateCheckin(txbID.Text);
                string output = string.Format("Xuất phiếu thành công, mã phiếu của bạn là {0}", id_checkin);
                MessageBox.Show(output);
                panel1.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xuất phiếu");
            }
        }

        private void txbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
