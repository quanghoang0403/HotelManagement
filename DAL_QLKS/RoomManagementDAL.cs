using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class RoomManagementDAL
    {
        private static RoomManagementDAL instance;
        public static RoomManagementDAL Instance
        {
            get { if (instance == null) instance = new RoomManagementDAL(); return instance; }
            private set { instance = value; }
        }
        private RoomManagementDAL() { }
        public void AddRoomType(string roomtype, string price)
        {
            DataProvider.Instance.ExecuteQuery("USP_AddRoomType @roomtype , @price ", new object[] { roomtype, price});
        }

        public void DeleteRoomType(string roomtype)
        {
            DataProvider.Instance.ExecuteQuery("USP_DeleteRoomType @roomtype", new object[] { roomtype });
        }

        public void UpdateRoomType(string oldroomtype, string newroomtype, int newprice)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateRoomType @oldroomtype , @newroomtype , @newprice ", new object[] { oldroomtype, newroomtype, newprice });
        }

        public DataTable SearchRoom(string id_room)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select ROOM.id_room,ROOM.room_type,price,notes,statuss from ROOM,ROOMTYPE where id_room='" + id_room + "'and ROOM.room_type=ROOMTYPE.room_type");
            return data;
        }

        public void AddRoom(string id_room, string class_room, string note, string status)
        {
            DataProvider.Instance.ExecuteQuery("USP_AddRoom @id_room , @class_room , @note , @status ", new object[] { id_room, class_room, note, status });
        }

        public void DeleteRoom(string id_room)
        {
            DataProvider.Instance.ExecuteQuery("USP_DeleteRoom @id_room", new object[] { id_room });
        }

        public void UpdateRoom(string id_room, string class_room, string note, string status)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateRoom @id_room , @class_room , @note , @status ", new object[] { id_room, class_room, note , status });
        }
        public bool SearchRoomType(string room_type)
        {
            object roomtype = DataProvider.Instance.ExecuteScalar("exec USP_GetStatus @room_type ", new object[] { room_type });
            if (roomtype == null)
                return false;
            return true;
        }
    }
}
