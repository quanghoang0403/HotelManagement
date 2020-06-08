using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class CheckinManagementBUS
    {
        private static CheckinManagementBUS instance;
        public static CheckinManagementBUS Instance
        {
            get { if (instance == null) instance = new CheckinManagementBUS(); return instance; }
            private set { instance = value; }
        }
        private CheckinManagementBUS() { }
        public List<Checkin> LoadCheckinList()
        {
            List<Checkin> CheckinList = new List<Checkin>();
            DataTable data = CheckinManagementDAL.Instance.LoadCheckinList();
            foreach (DataRow item in data.Rows)
            {
                Checkin ckin = new Checkin(item);
                CheckinList.Add(ckin);
            }
            return CheckinList;
        }
        public DataTable SearchCheckin(string condition)
        {
            return CheckinManagementDAL.Instance.SearchCheckin(condition);
        }
    }
}
