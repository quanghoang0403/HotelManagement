
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class HomeDAL
    {
        private static HomeDAL instance;

        public static HomeDAL Instance
        {
            get { if (instance == null) instance = new HomeDAL(); return HomeDAL.instance; }
            private set { HomeDAL.instance = value; }
        }

        private HomeDAL() { }

        public int GetStatusRoom(string id_room)
        {
            string query = string.Format("select statuss from ROOM where id_room = @id_room");
            object Status = DataProvider.Instance.ExecuteScalar(query, new object[] { id_room });
            if (Status == null)
                return -1;
            if (Status.ToString() == "USING")
                return 1;
            return 0;
        }

        public DataTable LoadRoomList()
        {
           
           return DataProvider.Instance.ExecuteQuery("USP_GetRoomList");
           
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
        public DataTable LoadRoom()
        {
            string query = "SELECT * FROM DBO.ROOM";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadRoomType()
        {
            string query = "SELECT * FROM DBO.ROOMTYPE";
            return  DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
