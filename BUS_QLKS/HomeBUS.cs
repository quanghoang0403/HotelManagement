using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class HomeBUS
    {
        private static HomeBUS instance;

        public static HomeBUS Instance
        {
            get { if (instance == null) instance = new HomeBUS(); return HomeBUS.instance; }
            private set { HomeBUS.instance = value; }
        }

        public static int RoomWidth = 170;
        public static int RoomHeight= 170;

        private HomeBUS() { }

        public int GetStatusRoom(string id_room)
        {
            return HomeDAL.Instance.GetStatusRoom(id_room);
        }
        public int GetStatusRoomType(string room_type)
        {
            return HomeDAL.Instance.GetStatusRoomType(room_type);
        }
        public List<Home> LoadRoomList()
        {
            List<Home> RoomList = new List<Home>();
            DataTable data = HomeDAL.Instance.LoadRoomList();
            foreach (DataRow item in data.Rows)
            {
                Home room = new Home(item);
                RoomList.Add(room);
            }
            return RoomList;
        }

        public bool updateHomeByCreateCheckin(string id_room)
        {
            return HomeDAL.Instance.updateHomeByCreateCheckin(id_room);
        }

        public bool updateHomeByCreateBill(string id_room)
        {
            return HomeDAL.Instance.updateHomeByCreateBill(id_room);
        }
        public DataTable LoadRoom()
        {
            return HomeDAL.Instance.LoadRoom();
        }
        public DataTable LoadRoomType()
        {
            return HomeDAL.Instance.LoadRoomType();
        }
    }
}
