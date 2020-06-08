
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class PermissionDAL
    {
        private static PermissionDAL instance;
        public static PermissionDAL Instance
        {
            get { if (instance == null) instance = new PermissionDAL(); return instance; }
            private set { instance = value; }
        }
        private PermissionDAL() { }
        public string Permission(string username)
        {
            string query = "select permission from dbo.ACCOUNT where username= N'" + username +"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            string permission_position = result.Rows[0].Field<string>(0);
            return permission_position;
        }
    }
}
