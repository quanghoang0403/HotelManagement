using QuanLyKhachSan.BUS;
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
            List<infoCheckin> listCheckinInfo = infoCheckinBUS.Instance.GetListCheckinInfo(id);
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
            List<CustomerType> listType = CustomerTypeBUS.Instance.GetListType();
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
            if (infoCheckinBUS.Instance.insertCheckinInfo(txbName.Text, cbType.Text, txbCMND.Text, txbAddress.Text, infoCheckinBUS.Instance.GetMaxIDCheckin()))
            {
                ShowInfo(infoCheckinBUS.Instance.GetMaxIDCheckin());
                txbName.Text = "";
                cbType.Text = "";
                txbCMND.Text = "";
                txbAddress.Text = "";
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
                return;
            }
            if(HomeBUS.Instance.GetStatusRoom(txbID.Text)==1)
            {
                MessageBox.Show("Phòng đang được thuê");
                return;
            }
            if(HomeBUS.Instance.GetStatusRoom(txbID.Text) == -1)
            {
                MessageBox.Show("Phòng không tồn tại");
                return;
            }
            
            if (infoCheckinBUS.Instance.insertCheckin(dateStartDate.Value, txbID.Text))
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
            if(lvRoom.Items.Count == 0)
            {
                MessageBox.Show("Thêm khách trước khi xuất phiếu");
                return;
            }
            int id_checkin = infoCheckinBUS.Instance.GetMaxIDCheckin();
            float ratio = infoCheckinBUS.Instance.GetMaxRatio(id_checkin);
            int count = infoCheckinBUS.Instance.GetAmountCustomer(id_checkin);
            if (infoCheckinBUS.Instance.updateCheckin(ratio, count, id_checkin))
            {
                HomeBUS.Instance.updateHomeByCreateCheckin(txbID.Text);
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


        private void fCheckin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panel1.Visible == false)
            {
                btnStart_Click(sender, e);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txbCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lvRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (true)
            {
                e.Handled = true;
            }
        }
    }
}
