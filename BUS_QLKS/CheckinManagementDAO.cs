using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CheckinManagementDAO
    {
        private static CheckinManagementDAO instance;
        public static CheckinManagementDAO Instance
        {
            get { if (instance == null) instance = new CheckinManagementDAO(); return instance; }
            private set { instance = value; }
        }
        private CheckinManagementDAO() { }
        public List<Checkin> LoadCheckinList()
        {
            List<Checkin> CheckinList = new List<Checkin>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCheckinlist");
            foreach (DataRow item in data.Rows)
            {
                Checkin ckin = new Checkin(item);
                CheckinList.Add(ckin);
            }
            return CheckinList;
        }
        public DataTable SearchCheckin(string condition)
        {
            string query = "select * from dbo.CHECKIN where " + condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
