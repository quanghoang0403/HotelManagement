using System;
using System.Data;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class BillManagementDAO
    {
        private static BillManagementDAO instance;
        public static BillManagementDAO Instance
        {
            get { if (instance == null) instance = new BillManagementDAO(); return instance; }
            private set { instance = value; }
        }
        private BillManagementDAO() { }
        public List<Bill> LoadBillList()
        {
            List<Bill> BillList = new List<Bill>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBillList");
            foreach (DataRow item in data.Rows)
            {
                Bill ib = new Bill(item);
                BillList.Add(ib);
            }
            return BillList;
        }
        public DataTable SearchBill(string condition)
        {
            string query = "select * from dbo.BILL where "+condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
