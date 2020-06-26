using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

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
        public void AddRoomType(RT rt)
        {
            DataProvider.Instance.ExecuteQuery("USP_AddRoomType @roomtype , @price ", new object[] { rt.room_type, rt.price});
        }

        public void DeleteRoomType(string roomtype)
        {
            DataProvider.Instance.ExecuteQuery("USP_DeleteRoomType @roomtype", new object[] { roomtype });
        }

        public void UpdateRoomType(string oldroomtype, RT rt)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateRoomType @oldroomtype , @newroomtype , @newprice ", new object[] { oldroomtype, rt.room_type, rt.price });
        }
        public DataTable FindByRT(string roomtype)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetByRoomType @room_type", new object[] { roomtype});
        }
        public void AddRoom(Home r)
        {
            DataProvider.Instance.ExecuteQuery("USP_AddRoom @id_room , @class_room , @note , @status ", new object[] { r.ID, r.Type, r.Notes, r.Status });
        }

        public void DeleteRoom(string id_room)
        {
            DataProvider.Instance.ExecuteQuery("USP_DeleteRoom @id_room", new object[] { id_room });
        }

        public void UpdateRoom(string id_room, Home r)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateRoom @id_room , @class_room , @note , @status ", new object[] { id_room, r.Type, r.Notes , r.Status });
        }

        public DataTable FindByRoom(string id_room)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetByRoom @id_room", new object[] { id_room });
        }
    }
}
