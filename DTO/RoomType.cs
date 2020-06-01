using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class RoomType
    {
        public RoomType(string name, float price, int max_customer, int amount_surchage)
        {
            this.Name = name;
            this.Ratio = price;
            this.Max_customer = max_customer;
            this.Amount_surchage = amount_surchage;
        }

        public RoomType(DataRow row)
        {
            this.Name = row["room_type"].ToString();
            this.Ratio = (float)Convert.ToDouble(row["price"].ToString());
            this.Max_customer = (int)row["max_customer"];
            this.Amount_surchage = (int)row["amount_surchage"];
        }

        private string name;
        private float price;
        private int max_customer;
        private int amount_surchage;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Ratio
        {
            get { return price; }
            set { price = value; }
        }
        public int Max_customer
        {
            get { return max_customer; }
            set { max_customer = value; }
        }
        public int Amount_surchage
        {
            get { return amount_surchage; }
            set { amount_surchage = value; }
        }
    }
}
