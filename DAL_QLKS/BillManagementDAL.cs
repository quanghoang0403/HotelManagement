using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class BillManagementDAL
    {
        private static BillManagementDAL instance;
        public static BillManagementDAL Instance
        {
            get { if (instance == null) instance = new BillManagementDAL(); return instance; }
            private set { instance = value; }
        }
        private BillManagementDAL() { }
        public DataTable LoadBillList()
        {
            
            return DataProvider.Instance.ExecuteQuery("USP_GetBillList");
           
        }
        public DataTable SearchBill(string condition)
        {
            string query = "select * from dbo.BILL where "+condition;
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
