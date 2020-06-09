using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class RevenueDAL
    {
        private static RevenueDAL instance;
        public static RevenueDAL Instance
        {
            get { if (instance == null) instance = new RevenueDAL(); return instance; }
            private set { instance = value; }
        }
        private RevenueDAL() { }
        public DataTable LoadRevenueList(string month, string year)
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadRevenue @month , @year ", new object[] { month, year});
        }
    }
}
