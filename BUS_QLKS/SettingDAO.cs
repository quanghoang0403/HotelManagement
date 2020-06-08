using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class SettingDAO
    {
            private static SettingDAO instance;
            public static SettingDAO Instance
            {
                get { if (instance == null) instance = new SettingDAO(); return instance; }
                private set { instance = value; }
            }
            private SettingDAO() { }
            public List<Amount> LoadAmountList()
            {
                List<Amount> AmountList = new List<Amount>();
                DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAmountList");
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
                DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCustomertypeList");
            foreach (DataRow item in data.Rows)
            {
                CustomerType cst = new CustomerType(item);
                CustomerTypeList.Add(cst);
            }
                return CustomerTypeList;
            }
            public void ChangeAmount(string customer_ratio,string max_customer,string amount_surchage)
            {
                string query1 = "delete from dbo.AMOUNT";
                DataProvider.Instance.ExecuteQuery(query1);
                string query = "INSERT INTO AMOUNT VALUES('" + customer_ratio + "','" + max_customer + "','" + amount_surchage + "')";
                DataProvider.Instance.ExecuteQuery(query);
            }
            public void AddCustomertype(string customer_type,string ratio)
            {
                string query = "INSERT INTO CUSTOMER_TYPE VALUES('" + customer_type + "','" + ratio + "')";
                DataProvider.Instance.ExecuteQuery(query);
            }
            public void DeleteCustomertype(string customer_type)
            {
                string query = "delete from dbo.CUSTOMER_TYPE where customer_type='" + customer_type +"'";
                DataProvider.Instance.ExecuteQuery(query);
            }
            public void UpdateCustomertype(string customer_type, string ratio)
            {
                string query = "Update dbo.CUSTOMER_TYPE Set ratio ='" +ratio+ "' Where customer_type ='" + customer_type + "'";
                DataProvider.Instance.ExecuteQuery(query);
            }
            public void ChangePass(string userName,string passWord)
            {
                string query = "Update dbo.ACCOUNT Set pass = '" + passWord + "' Where username = '" + userName + "'; ";
                DataProvider.Instance.ExecuteQuery(query);
            }
            public void Signin(string username, string password, string name, string permission)
            {
                string query = "INSERT INTO ACCOUNT VALUES(N'" + name + "','" + username + "','" + password + "','" + permission + "')";
                DataProvider.Instance.ExecuteQuery(query);
            }
    }
}
