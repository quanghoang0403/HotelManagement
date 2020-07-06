using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

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
            return LoginDAL.Instance.Login(userName, GetMD5(passWord));
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
