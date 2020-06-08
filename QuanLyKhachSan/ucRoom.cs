using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.BUS;

namespace QuanLyKhachSan
{
    public partial class ucRoom : UserControl
    {
        private bool Accessibility=true;
        public ucRoom()
        {
            InitializeComponent();
            LoadRoom();
            LoadRoomType();
            panel13.Visible = false;
            panel5.Visible = false;
            panel17.Visible = false;
            btnCancelRoomType.Visible = false;
            btnCancelRoom.Visible = false;
            
        }

    #region Xử lí phân quyền

        public bool Permission_to_access
        {
            get { return Accessibility; }
            set { Accessibility = value; }
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            if (Accessibility == false)
            {
                panel2.Visible = false;
                panel6.Visible = false;
            }
        }

    #endregion

    #region Hàm hỗ trợ loại phòng

        void LoadRoomType()
        {
            dtgvType.DataSource = HomeBUS.Instance.LoadRoomType();
        }

        void CleanTextinRoomType()
        {
            txbNewPrice.Text = "";
            txbNewTypeRoom.Text = "";
            txbTypeRoom.Text = "";
            txbPrice.Text = "";
        }

        private void dtgvType_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvType.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvType.Rows[selectedrowindex];
                txbOldTypeRoom.Text = Convert.ToString(selectedRow.Cells["room_type"].Value);
                txbOldPrice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
                txbNewTypeRoom.Text = Convert.ToString(selectedRow.Cells["room_type"].Value);
                txbNewPrice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
            }
        }

    #endregion

    #region Hàm hỗ trợ phòng

        void LoadRoom()
        {
            dtgvRoom.DataSource = HomeBUS.Instance.LoadRoom();
        }

        void CleanTextinRoom()
        {
            txbID.Text = "";
            txbType.Text = "";
            txbNewType.Text = "";
            txbNotes.Text = "";
            txbNewNote.Text = "";
            txbStatus.Text = "";
            txbNewStatus.Text = "";
            txbUnitPrice.Text = "";
        }

        private void dtgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvRoom.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvRoom.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvRoom.Rows[selectedrowindex];
                txbOldID.Text = Convert.ToString(selectedRow.Cells["id_room"].Value);
                txbOldType.Text = Convert.ToString(selectedRow.Cells["room_type"].Value);
                txbOldNote.Text = Convert.ToString(selectedRow.Cells["notes"].Value);
                txbOldStatus.Text = Convert.ToString(selectedRow.Cells["statuss"].Value);
                txbNewType.Text = Convert.ToString(selectedRow.Cells["room_type"].Value);
                txbNewNote.Text = Convert.ToString(selectedRow.Cells["notes"].Value);
                txbNewStatus.Text = Convert.ToString(selectedRow.Cells["statuss"].Value);
            }
        }

    #endregion

    #region Chức năng loại phòng

        private void btnCancelRoomType_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel13.Visible = false;            
            btnCancelRoomType.Visible = false;
            CleanTextinRoomType();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if(panel13.Visible == false)
            {
                btnCancelRoomType.Visible = true;
                panel5.Visible = false;
                panel13.Visible = true;
                CleanTextinRoomType();
                return;
            }  
            if (txbTypeRoom.Text == "" || txbPrice.Text == "")
            {
                MessageBox.Show("Loại phòng hoặc đơn giá chưa được nhập");
                return;
            }
            RoomManagementBUS.Instance.AddRoomType(txbTypeRoom.Text, txbPrice.Text);
            MessageBox.Show("Đã thêm thành công !");
            LoadRoomType();
            btnCancelRoomType.PerformClick();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn xóa loại phòng này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
               case DialogResult.Yes:
                    RoomManagementBUS.Instance.DeleteRoomType(txbOldTypeRoom.Text);
                    LoadRoomType();
                    break;
               case DialogResult.No:
                    break;
               default:
                    break;
            }                
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (panel5.Visible == false)
            {
                panel13.Visible = false;
                panel5.Visible = true;
                btnCancelRoomType.Visible = true;
                return;
            }            
            if (txbNewTypeRoom.Text == "" || txbNewPrice.Text == "")
            {
                MessageBox.Show("Loại phòng mới hoặc đơn giá mới chưa được nhập");
                return;
            }
            if (txbNewTypeRoom.Text == txbOldTypeRoom.Text && txbNewPrice.Text == txbOldPrice.Text)
            {
                MessageBox.Show("Thông tin chưa được thay đổi !");
                return;
            }
            RoomManagementBUS.Instance.UpdateRoomType(txbOldTypeRoom.Text, txbOldPrice.Text, txbNewTypeRoom.Text, txbNewPrice.Text);
            MessageBox.Show("Cập nhật thành công !");
            LoadRoomType();
            LoadRoom();
            btnCancelRoomType.PerformClick();
        }

    #endregion

    #region Chuc nang quan ly phong

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRoom();
        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            panel17.Visible = false;
            btnSearch.Visible = true;
            txbType.ReadOnly = true;
            txbNotes.ReadOnly = true;
            txbStatus.ReadOnly = true;
            btnCancelRoom.Visible = false;
            CleanTextinRoom();         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số phòng");
                return;
            }
            DataTable result=RoomManagementBUS.Instance.SearchRoom(txbID.Text);
            txbType.Text = result.Rows[0].Field<string>(1);
            txbUnitPrice.Text = Convert.ToString(result.Rows[0].Field<Decimal>(2));
            txbNotes.Text = result.Rows[0].Field<string>(3);
            txbStatus.Text = result.Rows[0].Field<string>(4);
        }
        
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(btnSearch.Visible==true || panel17.Visible == true)
            {
                panel14.Visible = true;
                panel17.Visible = false;
                btnCancelRoom.Visible = true;                
                txbType.ReadOnly = false;
                txbNotes.ReadOnly = false;
                txbStatus.ReadOnly = false;
                btnSearch.Visible=false;
                txbUnitPrice.Text = "";
                CleanTextinRoom();
                return;
            }
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID phòng");
                return;
            }    
            else if (txbType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại phòng");
                return;
            }
            else if (txbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trình trạng phòng");
                return;
            }
            RoomManagementBUS.Instance.AddRoom(txbID.Text, txbType.Text, txbNotes.Text, txbStatus.Text);
            MessageBox.Show("Đã thêm thành công !");
            LoadRoom();
            btnCancelRoom.PerformClick();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn xóa phòng này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Yes:
                    RoomManagementBUS.Instance.DeleteRoom(txbOldID.Text);
                    LoadRoom();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if(panel17.Visible==false)
            {
                panel17.Visible=true;
                btnCancelRoom.Visible = true;
                return;
            }
            if (txbOldType.Text==txbNewType.Text && txbOldStatus.Text==txbNewStatus.Text && txbOldNote.Text==txbNewNote.Text)
            {
                MessageBox.Show("Thông tin chưa được thay đổi !");
                return;
            }
            else if (txbNewType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại phòng");
                return;
            }
            else if (txbNewStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trình trạng phòng");
                return;
            }
            RoomManagementBUS.Instance.UpdateRoom(txbOldID.Text,txbNewType.Text, txbNewNote.Text, txbNewStatus.Text);
            MessageBox.Show("Cập nhật thành công !");
            LoadRoom();
            btnCancelRoom.PerformClick();
        }

    #endregion

        private void txbUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
