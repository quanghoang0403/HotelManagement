using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKhachSan.BUS
{
    public class LoginBUS
    {
        private static LoginBUS instance;

        public static LoginBUS Instance 
        {
            get { if (instance == null) instance = new LoginBUS(); return instance; }
            private set { instance = value; } 
        }

        private LoginBUS() { }

        public bool Login(string userName, string passWord)
        {
            return LoginDAL.Instance.Login(userName, passWord);
        }
    }
}
