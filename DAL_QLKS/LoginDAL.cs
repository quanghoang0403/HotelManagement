
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKhachSan.DAL
{
    public class LoginDAL
    {
        private static LoginDAL instance;

        public static LoginDAL Instance 
        {
            get { if (instance == null) instance = new LoginDAL(); return instance; }
            private set { instance = value; } 
        }

        private LoginDAL() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_LOGIN @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
