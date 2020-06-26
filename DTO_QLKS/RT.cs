using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class RT
    {
        public RT()
        {
            this.room_type = "";
            this.price = 0;
        }
        public RT(string Name, float Price)
        {
            this.room_type = Name;
            this.price = Price;
        }

        public RT(DataRow row)
        {
            this.room_type = row["room_type"].ToString();
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private string Name;
        private float Price;

        public string room_type
        {
            get { return Name; }
            set { Name = value; }
        }
        public float price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}

