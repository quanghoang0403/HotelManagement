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
    }
}
