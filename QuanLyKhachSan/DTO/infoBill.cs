using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class infoBill
    {
        public infoBill(string name, int date_number, float price, float type_ratio, float number_ratio, float total_price)
        {
            this.Id_room = name;
            this.Date_number = date_number;
            this.Price= price;
            this.Type_ratio = type_ratio;
            this.Number_ratio = number_ratio;
            this.Total_price = total_price;
        }

        public infoBill(DataRow row)
        {
            this.Id_room = row["ID_ROOM"].ToString();
            this.Price = (float)Convert.ToDouble(row["PRICE"].ToString());
            this.Date_number = (int)row["DATE_NUMBER"];
            this.Type_ratio = (float)Convert.ToDouble(row["TYPE_RATIO"].ToString());
            this.Number_ratio = (float)Convert.ToDouble(row["NUMBER_RATIO"].ToString());
            this.Total_price = (float)Convert.ToDouble(row["TOTAL"].ToString());
        }

        private string id_room;
        private int date_number;
        private float price;
        private float type_ratio;
        private float number_ratio;
        private float total_price;

        public string Id_room
        {
            get { return id_room; }
            set { id_room = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Date_number
        {
            get { return date_number; }
            set { date_number = value; }
        }

        public float Type_ratio
        {
            get { return type_ratio; }
            set { type_ratio = value; }
        }
        public float Number_ratio
        {
            get { return number_ratio; }
            set { number_ratio = value; }
        }
        public float Total_price
        {
            get { return total_price; }
            set { total_price = value; }
        }
    }
}
