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
        public ucRoom()
        {
            InitializeComponent();
            LoadRoom();
            LoadRoomType();
        }

        void LoadRoom()
        {
            string query = "SELECT * FROM DBO.ROOM";
            dtgvRoom.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadRoomType()
        {
            string query = "SELECT * FROM DBO.ROOMTYPE";
            dtgvType.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (txbTypeRoom.Text == "" || txbPrice.Text == "")
            {
                MessageBox.Show("Loại phòng hoặc đơn giá chưa được nhập");
                return;
            }
               
           
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (txbTypeRoom.Text == "")
            {
                MessageBox.Show("Loại phòng chưa được nhập");
                return;
            }
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (txbTypeRoom.Text == "" || txbPrice.Text == "")
            {
                MessageBox.Show("Loại phòng hoặc đơn giá chưa được nhập");
                return;
            }
                
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số phòng");
                return;
            }
               

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
           
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID phòng");
                return;
            }    
            else
            if (txbType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại phòng");
                return;
            }
            else
            if (txbUnitPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return;
            }
            else
            if (txbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trình trạng phòng");
                return;
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID phòng");
                return;
            }
                
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID phòng");
                return;
            }
            else
          if (txbType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập loại phòng");
                return;
            }
            else
          if (txbUnitPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return;
            }
            else
          if (txbStatus.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trình trạng phòng");
                return;
            }
        }

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
