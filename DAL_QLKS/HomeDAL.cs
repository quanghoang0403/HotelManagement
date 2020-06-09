
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
            object Status = DataProvider.Instance.ExecuteScalar("exec USP_GetStatus @id_room ", new object[] { id_room });
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
            string status = "USING";
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateHome @id_room , @statuss ", new object[] { id_room, status });
            return result > 0;
        }

        public bool updateHomeByCreateBill(string id_room)
        {
            string status = "EMPTY";
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateHome @id_room , @statuss ", new object[] { id_room, status });
            return result > 0;
        }
        public DataTable LoadRoom()
        {
            string query = "USP_GetRoom";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadRoomType()
        {
            string query = "USP_GetRoomType";
            return  DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
