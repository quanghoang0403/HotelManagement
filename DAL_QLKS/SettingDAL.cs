
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAL
{
    public class SettingDAL
    {
            private static SettingDAL instance;
            public static SettingDAL Instance
            {
                get { if (instance == null) instance = new SettingDAL(); return instance; }
                private set { instance = value; }
            }
            private SettingDAL() { }
            public DataTable LoadAmountList()
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAmountList");

            }
            public DataTable LoadCustomerTypeList()
            {         
                return DataProvider.Instance.ExecuteQuery("USP_GetCustomertypeList");
            }
            public void ChangeAmount(Amount amt)
            {
                DataProvider.Instance.ExecuteQuery("USP_DeleteAmount");
                DataProvider.Instance.ExecuteQuery("exec USP_InsertAmount @customer_ratio , @max_customer , @amount_surchage ", new object[] { amt.Customer_ratio, amt.Max_customer , amt.Amount_surchage });
            }
            public DataTable FindByCT(string cus_type)
            {
               return  DataProvider.Instance.ExecuteQuery("exec USP_GetByCustomerType @customer_type", new object[] { cus_type});
            }
            public void AddCustomertype(CustomerType ct)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_AddCustomertype @customer_type , @ratio ", new object[] { ct.Name , ct.Ratio });
        }
            public void DeleteCustomertype(string customer_type)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_DeleteCustomertype @customer_type ", new object[] { customer_type });
        }
            public void UpdateCustomertype(string customer_type, CustomerType ct)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_UpdateCustomertype @customer_type , @ratio ", new object[] { customer_type, ct.Ratio });
            }
    }
}
