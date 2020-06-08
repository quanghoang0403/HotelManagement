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
            string query = "INSERT INTO ROOMTYPE VALUES('" + roomtype + "','" + price + "')";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteRoomType(string roomtype)
        {
            string query = "delete from dbo.ROOMTYPE where room_type='" + roomtype + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public void UpdateRoomType(string oldroomtype, string oldprice, string newroomtype, string newprice)
        {
            string query = "Update dbo.ROOMTYPE Set room_type ='" + newroomtype + "',price ='" + newprice + "' Where room_type ='" + oldroomtype + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchRoom(string id_room)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select ROOM.id_room,ROOM.room_type,price,notes,statuss from ROOM,ROOMTYPE where id_room='" + id_room + "'and ROOM.room_type=ROOMTYPE.room_type");
            return data;
        }

        public void AddRoom(string id_room, string class_room, string note, string status)
        {
            string query = "INSERT INTO ROOM VALUES('" + id_room + "','" + class_room + "',N'" + note + "','" + status + "')";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteRoom(string id_room)
        {
            string query = "delete from dbo.ROOM where id_room = '" + id_room + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateRoom(string id_room, string class_room, string note, string status)
        {
            string query = "Update dbo.ROOM Set room_type ='" + class_room + "',notes =N'" + note + "',statuss ='" + status + "' Where id_room = '" + id_room + "'";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
