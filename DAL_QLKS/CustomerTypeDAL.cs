
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class CustomerTypeDAL
    {
        private static CustomerTypeDAL instance;

        public static CustomerTypeDAL Instance
        {
            get { if (instance == null) instance = new CustomerTypeDAL(); return CustomerTypeDAL.instance; }
            private set { CustomerTypeDAL.instance = value; }
        }

        private CustomerTypeDAL() { }

        public DataTable GetListType()
        {
           return DataProvider.Instance.ExecuteQuery("select *from CUSTOMER_TYPE");
        }
    }
} 
