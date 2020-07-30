using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class CheckinManagementDAL
    {
        private static CheckinManagementDAL instance;
        public static CheckinManagementDAL Instance
        {
            get { if (instance == null) instance = new CheckinManagementDAL(); return instance; }
            private set { instance = value; }
        }
        private CheckinManagementDAL() { }
        public DataTable LoadCheckinList()
        {
           return DataProvider.Instance.ExecuteQuery("USP_GetCheckinlist");
        }
        public DataTable SearchCheckin(string condition)
        {
            string query = "select * from dbo.CHECKIN where " + condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
