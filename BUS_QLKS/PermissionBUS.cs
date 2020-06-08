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
    public class PermissionBUS
    {
        private static PermissionBUS instance;
        public static PermissionBUS Instance
        {
            get { if (instance == null) instance = new PermissionBUS(); return instance; }
            private set { instance = value; }
        }
        private PermissionBUS() { }
        public string Permission(string username)
        {
            return PermissionDAL.Instance.Permission(username);
        }
    }
}
