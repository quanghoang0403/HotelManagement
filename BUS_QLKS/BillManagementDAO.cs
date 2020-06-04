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
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetinfoBillList");
            foreach (DataRow item in data.Rows)
            {
                Bill ib = new Bill(item);
                BillList.Add(ib);
            }
            return BillList;
        }
        public DataTable SearchBill(string condition)
        {
            string query = "select BILL.id_bill,bill_name,bill_address,total_money,id_checkin,date_number,surchage_ratio from dbo.BILL,dbo.BILL_DETAILS where BILL.id_bill=BILL_DETAILS.id_bill"+condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
