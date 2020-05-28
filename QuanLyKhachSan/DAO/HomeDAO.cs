using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class HomeDAO
    {
        private static HomeDAO instance;

        public static HomeDAO Instance
        {
            get { if (instance == null) instance = new HomeDAO(); return HomeDAO.instance; }
            private set { HomeDAO.instance = value; }
        }

        public static int RoomWidth = 170;
        public static int RoomHeight= 170;

        private HomeDAO() { }

        public int GetStatusRoom()
        {
            return 0;
        }

        public List<Home> LoadRoomList()
        {
            List<Home> RoomList = new List<Home>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");
            foreach (DataRow item in data.Rows)
            {
                Home room = new Home(item);
                RoomList.Add(room);
            }
            return RoomList;
        }

        public bool updateHomeByCreateCheckin(string id_room)
        {
            string query = string.Format("update ROOM set statuss = 'USING' where id_room = {0}", id_room);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateHomeByCreateBill(string id_room)
        {
            string query = string.Format("update ROOM set statuss = 'EMPTY' where id_room = {0}", id_room);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
