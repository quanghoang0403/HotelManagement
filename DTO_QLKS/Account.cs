using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Account
    {
        public Account()
        {
            this.Display_name = "";
            this.Username = "";
            this.Pass = "";
            this.Permission = "";
        }
        public Account(string display_name, string username, string pass,string permission)
        {
            this.Display_name =display_name;
            this.Username = username;
            this.Pass = pass;
            this.Permission = permission;
        }

        public Account(DataRow row)
        {
            this.Display_name = row["display_name"].ToString();
            this.Username = row["username"].ToString();
            this.Pass= row["pass"].ToString();
            this.Permission = row["permission"].ToString();
        }

        private string display_name;
        private string username;
        private string pass;
        private string permission;

        public string Display_name
        {
            get { return display_name; }
            set { display_name = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Permission
        {
            get { return permission; }
            set { permission = value; }
        }
    }
}
