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
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan
{
    public partial class ucRoom : UserControl
    {
        private bool Accessibility=true;
        RoomTypeBUS _repos = new RoomTypeBUS();
        RoomBUS _reposR = new RoomBUS();
        public ucRoom()
        {
            InitializeComponent();
            LoadRoom();
            LoadRoomType();
            panel13.Visible = false;
            panel5.Visible = false;
            panel17.Visible = false;
            panel4.Visible = false;
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

        private async void LoadRoomType()
        {
            var listRT = await _repos.GetListRoomType();
            dtgvType.DataSource = listRT;
        }

        void CleanTextinRoomType()
        {
            txbNewPrice.Text = "";
            txbTypeRoom.Text = "";
            txbPrice.Text = "";
        }

        #endregion

        #region Hàm hỗ trợ phòng

        private async void LoadRoom()
        {
            var listR = await _reposR.GetListRoom();
            dtgvRoom.DataSource = listR;
        }
        void Search(string id)
        {
            foreach (DataGridViewRow row in dtgvRoom.Rows)
            {
                row.Selected = false;
            }
            string searchValue = id;
            dtgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dtgvRoom.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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
            textbox1.Text = "";
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
            RT rt = new RT(txbTypeRoom.Text, (float)Convert.ToDouble(txbPrice.Text));
            _repos.AddRoomType(rt);
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
                    _repos.DeleteRoomType(txbOldTypeRoom.Text);
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
            if (txbNewPrice.Text == "")
            {
                MessageBox.Show("Loại phòng mới hoặc đơn giá mới chưa được nhập");
                return;
            }
            if (txbNewPrice.Text == txbOldPrice.Text)
            {
                MessageBox.Show("Thông tin chưa được thay đổi !");
                return;
            }
            RT rt = new RT(txbOldTypeRoom.Text, (float)Convert.ToDouble(txbNewPrice.Text));
            _repos.UpdateRoomType(txbOldTypeRoom.Text, rt);
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
            LoadRoomType();
        }

        private void btnCancelRoom_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel17.Visible = false;
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
            Search(txbID.Text);
        }
        
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(panel4.Visible == false)
            {
                panel4.Visible = true;
                panel17.Visible = false;
                btnCancelRoom.Visible = true;
                CleanTextinRoom();
                return;
            }
            if (textbox1.Text == "")
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
            Home r = new Home(textbox1.Text, txbType.Text, txbNotes.Text, txbStatus.Text);
            _reposR.AddRoom(r);
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
                    _reposR.DeleteRoom(txbOldID.Text);
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
                panel17.Visible = true;
                panel4.Visible = false;
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
            Home r = new Home(txbOldID.Text, txbNewType.Text, txbNewNote.Text, txbNewStatus.Text);
            _reposR.UpdateRoom(txbOldID.Text, r);
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

        private void dtgvType_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvType.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvType.Rows[selectedrowindex];
                txbOldTypeRoom.Text = Convert.ToString(selectedRow.Cells["room_type2"].Value);
                txbOldPrice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
            }
        }
    }
}
