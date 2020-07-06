
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            public void ChangeAmount(string customer_ratio,string max_customer,string amount_surchage)
            {
                DataProvider.Instance.ExecuteQuery("USP_DeleteAmount");
                DataProvider.Instance.ExecuteQuery("exec USP_InsertAmount @customer_ratio , @max_customer , @amount_surchage ", new object[] { customer_ratio, max_customer , amount_surchage });
        }
            public void AddCustomertype(string customer_type,float ratio)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_AddCustomertype @customer_type , @ratio ", new object[] { customer_type , ratio });
        }
            public void DeleteCustomertype(string customer_type)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_DeleteCustomertype @customer_type ", new object[] { customer_type });
        }
            public void UpdateCustomertype(string customer_type, float ratio)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_UpdateCustomertype @customer_type , @ratio ", new object[] { customer_type, ratio });
            }
            public void ChangePass(string userName,string passWord)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_ChangePassword @pass , @username ", new object[] { GetMD5(passWord), userName });
            }
            public void Signin(string username, string password, string name, string permission)
            {
                DataProvider.Instance.ExecuteQuery("exec USP_SignIn @name , @username , @pass , @permission ", new object[] { name, username, GetMD5(password), permission });
            }
            public bool CheckAccount(string userName)
            {
                 DataTable result = DataProvider.Instance.ExecuteQuery("USP_CheckAccount @userName ", new object[] { userName });
                 return result.Rows.Count > 0;
            }
            public String GetMD5(string txt)
            {
                 String str = "";
                 Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
                System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                buffer = md5.ComputeHash(buffer);
                foreach (Byte b in buffer)
                {
                    str += b.ToString("X2");
                }
                return str;
            }
    }
}
