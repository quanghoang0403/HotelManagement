using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PermissionDAO
    {
        private static PermissionDAO instance;
        public static PermissionDAO Instance
        {
            get { if (instance == null) instance = new PermissionDAO(); return instance; }
            private set { instance = value; }
        }
        private PermissionDAO() { }
        public string Permission(string username)
        {
            string query = "select permission from dbo.ACCOUNT where username= N'" + username +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            string permission_position = result.Rows[0].Field<string>(0);
            return permission_position;
        }
    }
}
