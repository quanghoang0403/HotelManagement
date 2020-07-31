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
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        void ShowInfo(int id_bill, int id_checkin)
        {
            //lvBill.Items.Clear();
            List<infoBill> listBillInfo = infoBillBUS.Instance.GetListBillInfo(id_bill, id_checkin);
            float bill_price = Int32.Parse(txbTotalMoney.Text);
            foreach (infoBill item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Id_room.ToString());
                lvItem.SubItems.Add(item.Date_number.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.Type_ratio.ToString());
                lvItem.SubItems.Add(item.Number_ratio.ToString());
                lvItem.SubItems.Add(item.Total_price.ToString());
                infoBillBUS.Instance.updateCheckin(item.Total_price, id_checkin);
                bill_price += item.Total_price;
                lvBill.Items.Add(lvItem);
            }
            txbTotalMoney.Text = bill_price.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txbName.Text == "" || txbAddress.Text== "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hoặc địa chỉ");
            }
            else
            if (infoBillBUS.Instance.insertBill(txbName.Text, txbAddress.Text))
            {
                MessageBox.Show("Tạo thành công, vui lòng nhập mã phiếu của phòng cần thanh toán");
                lvBill.Items.Clear();
                panel1.Visible = true;
                txbName.ReadOnly = true;
                txbAddress.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Có lỗi khi tạo hóa đơn");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txbIDCheckin.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu");
                return;
            }
            int id_checkin = int.Parse(txbIDCheckin.Text.ToString());
            if (infoBillBUS.Instance.GetStatusCheckin(id_checkin) == 1)
            {
                MessageBox.Show("Phiếu đã được thanh toán");
                return;
            }
            if (infoBillBUS.Instance.GetStatusCheckin(id_checkin) == -1)
            {
                MessageBox.Show("Phiếu không tồn tại");
                return;
            }
            int id_bill = infoBillBUS.Instance.GetMaxIDBill();
            int amount_surchage = infoBillBUS.Instance.GetAmountSurchage();
            int number_customer = infoBillBUS.Instance.GetNumberCustomer(id_checkin);
            float ratio = infoBillBUS.Instance.GetRatioCustomer();
            DateTime date_start = infoBillBUS.Instance.GetDate(id_checkin);
            TimeSpan time = DateTime.Now - date_start;
            int date_number = time.Days + 1;
            if (infoBillBUS.Instance.updateBillInfo(id_bill, id_checkin, amount_surchage, number_customer, ratio, date_number))
            {
                ShowInfo(id_bill, id_checkin);
                MessageBox.Show("Thêm phòng thành công");
                string id_room = infoBillBUS.Instance.GetIdRoom(id_checkin);
                HomeBUS.Instance.updateHomeByCreateBill(id_room);
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(lvBill.Items.Count==0)
            {
                MessageBox.Show("Thêm ID phiếu trước khi xuất hóa đơn");
                return;
            }
            int id_bill = infoBillBUS.Instance.GetMaxIDBill();
            float total_money = Int32.Parse(txbTotalMoney.Text);
            if (infoBillBUS.Instance.updateBill(total_money, id_bill))
            {
                MessageBox.Show("Xuất hóa đơn thành công");
                panel1.Visible = false;
               
                this.Close();
            }
            else
            {
                MessageBox.Show("Xuất hóa thất bại");
            }

        }

        private void txbTotalMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbIDCheckin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && panel1.Visible == false)
            {
                btnStart_Click(sender, e);
            }
        }
    }
}
