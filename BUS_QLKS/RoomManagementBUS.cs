using System;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class RoomManagementBUS
    {
        private static RoomManagementBUS instance;
        public static RoomManagementBUS Instance
        {
            get { if (instance == null) instance = new RoomManagementBUS(); return instance; }
            private set { instance = value; }
        }
        private RoomManagementBUS() { }
        public void AddRoomType(string roomtype, string price)
        {
            RoomManagementDAL.Instance.AddRoomType(roomtype, price);
        }

        public void DeleteRoomType(string roomtype)
        {
            RoomManagementDAL.Instance.DeleteRoomType(roomtype);
        }
        public void UpdateRoomType(string oldroomtype, string newroomtype, int newprice)
        {
            RoomManagementDAL.Instance.UpdateRoomType(oldroomtype, newroomtype, newprice);
        }

        public DataTable SearchRoom(string id_room)
        {
            return RoomManagementDAL.Instance.SearchRoom(id_room);
        }

        public void AddRoom(string id_room, string class_room, string note, string status)
        {
            RoomManagementDAL.Instance.AddRoom(id_room, class_room, note, status);
        }

        public void DeleteRoom(string id_room)
        {
            RoomManagementDAL.Instance.DeleteRoom(id_room);
        }

        public void UpdateRoom(string id_room, string class_room, string note, string status)
        {
            RoomManagementDAL.Instance.UpdateRoom(id_room, class_room, note, status);
        }
        public bool SearchRoomType(string room_type)
        {
            return RoomManagementDAL.Instance.SearchRoomType(room_type);
        }
    }
}
