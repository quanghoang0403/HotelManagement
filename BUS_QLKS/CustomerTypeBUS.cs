using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class CustomerTypeBUS
    {
        private static CustomerTypeBUS instance;

        public static CustomerTypeBUS Instance
        {
            get { if (instance == null) instance = new CustomerTypeBUS(); return CustomerTypeBUS.instance; }
            private set { CustomerTypeBUS.instance = value; }
        }

        private CustomerTypeBUS() { }

        public List<CustomerType> GetListType()
        {
            List<CustomerType> list = new List<CustomerType>();

            DataTable data = CustomerTypeDAL.Instance.GetListType();

            foreach (DataRow item in data.Rows)
            {
                CustomerType info = new CustomerType(item);
                list.Add(info);
            }
            return list;
        }
    }
} 
