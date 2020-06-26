
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAL
{
    public class AccountManagementDAL
    {
        private static AccountManagementDAL instance;

        public static AccountManagementDAL Instance 
        {
            get { if (instance == null) instance = new AccountManagementDAL(); return instance; }
            private set { instance = value; } 
        }

        private AccountManagementDAL() { }

        public bool Login(string userName, string passWord)
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("USP_LOGIN @userName , @passWord ", new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
        public void ChangePass(Account acc)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_ChangePassword @pass , @username ", new object[] { acc.Pass, acc.Username });
        }
        public void Signup(Account acc)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_SignIn @name , @username , @pass , @permission ", new object[] { acc.Display_name, acc.Username, acc.Pass, acc.Permission });
        }
    }
}
