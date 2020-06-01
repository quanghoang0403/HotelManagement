using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CustomerTypeDAO
    {
        private static CustomerTypeDAO instance;

        public static CustomerTypeDAO Instance
        {
            get { if (instance == null) instance = new CustomerTypeDAO(); return CustomerTypeDAO.instance; }
            private set { CustomerTypeDAO.instance = value; }
        }

        private CustomerTypeDAO() { }

        public List<CustomerType> GetListType()
        {
            List<CustomerType> list = new List<CustomerType>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *from CUSTOMER_TYPE");

            foreach (DataRow item in data.Rows)
            {
                CustomerType info = new CustomerType(item);
                list.Add(info);
            }
            return list;
        }
    }
} 
