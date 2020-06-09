
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
            DataTable result = DataProvider.Instance.ExecuteQuery("USP_GetPermission @username ", new object[] { username } );
            string permission_position = result.Rows[0].Field<string>(0);
            return permission_position;
        }
    }
}
