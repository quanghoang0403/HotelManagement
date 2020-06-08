using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class SettingBUS
    {
            private static SettingBUS instance;
            public static SettingBUS Instance
            {
                get { if (instance == null) instance = new SettingBUS(); return instance; }
                private set { instance = value; }
            }
            private SettingBUS() { }
            public List<Amount> LoadAmountList()
            {
                List<Amount> AmountList = new List<Amount>();
                DataTable data = SettingDAL.Instance.LoadAmountList();
                foreach (DataRow item in data.Rows)
                {
                    Amount amount = new Amount(item);
                    AmountList.Add(amount);
                }
                return AmountList;
            }
            public List<CustomerType> LoadCustomerTypeList()
            {
                List<CustomerType> CustomerTypeList = new List<CustomerType>();
                DataTable data = SettingDAL.Instance.LoadCustomerTypeList();
                foreach (DataRow item in data.Rows)
                {
                    CustomerType cst = new CustomerType(item);
                    CustomerTypeList.Add(cst);
                }
                return CustomerTypeList;
            }
            public void ChangeAmount(string customer_ratio,string max_customer,string amount_surchage)
            {
                SettingDAL.Instance.ChangeAmount(customer_ratio, max_customer, amount_surchage);
            }
            public void AddCustomertype(string customer_type,string ratio)
            {
                SettingDAL.Instance.AddCustomertype(customer_type, ratio);
            }
            public void DeleteCustomertype(string customer_type)
            {
                SettingDAL.Instance.DeleteCustomertype(customer_type);
            }
            public void UpdateCustomertype(string customer_type, string ratio)
            {
                SettingDAL.Instance.UpdateCustomertype(customer_type, ratio);
            }
            public void ChangePass(string userName,string passWord)
            {
                SettingDAL.Instance.ChangePass(userName, passWord);
            }
            public void Signin(string username, string password, string name, string permission)
            {
                SettingDAL.Instance.Signin(username, password, name, permission);
            }
    }
}
