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
            dtgvRoom.DataSource = HomeDAO.Instance.LoadRoom();
        }

    #region Xu li phan quyen

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

    #region Xu li chuc nang trong loai phong

        void LoadRoomType()
        {

            dtgvType.DataSource = HomeDAO.Instance.LoadRoomType();
        }

        void CleanTextinRoomType()
        {
            txbNewPrice.Text = "";
            txbNewTypeRoom.Text = "";
            txbTypeRoom.Text = "";
            txbPrice.Text = "";
        }

        void AddRoomType(string roomtype, string price)
        {
            string query = "INSERT INTO ROOMTYPE VALUES('" + roomtype + "','" + price + "')";
            DataProvider.Instance.ExecuteQuery(query);
            btnCancelRoomType.PerformClick();
            LoadRoomType();
        }

        void DeleteRoomType(string roomtype)
        {
            string query = "delete from dbo.ROOMTYPE where room_type='" + roomtype + "'";
            DataProvider.Instance.ExecuteQuery(query);
            LoadRoomType();
        }

        void UpdateRoomType(string oldroomtype, string oldprice, string newroomtype, string newprice)
        {
            string query = "Update dbo.ROOMTYPE Set room_type ='" + newroomtype + "',price ='" + newprice + "' Where room_type ='" + oldroomtype + "'";
            DataProvider.Instance.ExecuteQuery(query);
            btnCancelRoomType.PerformClick();
            LoadRoomType();
        }

        private void dtgvType_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvType.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvType.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvType.Rows[selectedrowindex];
                txbOldTypeRoom.Text = Convert.ToString(selectedRow.Cells["room_type"].Value);
                txbOldPrice.Text = Convert.ToString(selectedRow.Cells["price"].Value);
            }
        }

    #endregion

    #region Xu li chuc nang trong quan li phong

        void LoadRoom()
        {
            string query = "SELECT * FROM DBO.ROOM";
            dtgvRoom.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
        }

        void Search(string id_room)
        {
            string query1 = "Select * from dbo.ROOM where id_room='" + id_room + "'";
            DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);
            txbType.Text = result1.Rows[0].Field<string>(1);
            string query2 = "Select price from dbo.ROOMTYPE where room_type='" + txbType.Text + "'";
            DataTable result2 = DataProvider.Instance.ExecuteQuery(query2);
            txbUnitPrice.Text = Convert.ToString(result2.Rows[0].Field<Decimal>(0));
            txbNotes.Text = result1.Rows[0].Field<string>(2);
            txbStatus.Text = result1.Rows[0].Field<string>(3);
        }

        void AddRoom(string id_room, string class_room, string note, string status)
        {
            string query = "INSERT INTO ROOM VALUES('" + id_room + "','" + class_room + "',N'" + note + "','" + status + "')";
            DataProvider.Instance.ExecuteQuery(query);
            btnCancelRoom.PerformClick();
            LoadRoom();
        }

        void DeleteRoom(string id_room)
        {
            string query = "delete from dbo.ROOM where id_room = '" + id_room + "'";
            DataProvider.Instance.ExecuteQuery(query);
            LoadRoom();
        }

        void UpdateRoom(string id_room, string class_room, string note, string status)
        {
            string query = "Update dbo.ROOM Set room_type ='" + class_room + "',notes =N'" + note + "',statuss ='" + status + "' Where id_room = '" + id_room + "'";
            DataProvider.Instance.ExecuteQuery(query);
            btnCancelRoom.PerformClick();
            LoadRoom();
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
            }
        }

    #endregion

    #region Chuc nang Loai phong

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
            AddRoomType(txbTypeRoom.Text, txbPrice.Text);           
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn xóa loại phòng này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
               case DialogResult.Yes:
                    DeleteRoomType(txbOldTypeRoom.Text);
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
            UpdateRoomType(txbOldTypeRoom.Text, txbOldPrice.Text, txbNewTypeRoom.Text, txbNewPrice.Text);
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
            Search(txbID.Text);
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
            AddRoom(txbID.Text, txbType.Text, txbNotes.Text, txbStatus.Text);
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn là muốn xóa phòng này ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            switch (result)
            {
                case DialogResult.Yes:
                    DeleteRoom(txbOldID.Text);
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
            UpdateRoom(txbOldID.Text,txbNewType.Text, txbNewNote.Text, txbNewStatus.Text);
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
