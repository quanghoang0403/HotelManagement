using System;
using System.Collections.Generic;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class RevenueBUS
    {
        private static RevenueBUS instance;
        public static RevenueBUS Instance
        {
            get { if (instance == null) instance = new RevenueBUS(); return instance; }
            private set { instance = value; }
        }
        private RevenueBUS() { }
        public DataTable LoadRevenueList(string month,string year)
        {
            return RevenueDAL.Instance.LoadRevenueList(month, year);
        }
    }
}
