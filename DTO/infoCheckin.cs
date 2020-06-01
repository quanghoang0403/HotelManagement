using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class infoCheckin
    {
        public infoCheckin(string name, string type, string cmnd, string address, int id_checkin)
        {
            this.CMND = cmnd;
            this.Type = type;
            this.Name = name;
            this.Address = address;
            this.ID_checkin = id_checkin;
        }

        public infoCheckin(DataRow row)
        {
            this.Name = row["customer_name"].ToString();
            this.CMND = row["customer_cmnd"].ToString();
            this.Type = row["customer_type"].ToString();
            this.Address = row["customer_address"].ToString();
            this.ID_checkin = (int)row["id_checkin"];
        }

        private string name;
        private string type;
        private string cMND;
        private string address;
        private int iD_checkin;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int ID_checkin
        {
            get { return iD_checkin; }
            set { iD_checkin = value; }
        }
    }
}
