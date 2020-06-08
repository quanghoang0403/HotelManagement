using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Checkin
    {
        public Checkin(int id_checkin, string date_start, string id_room, string money_checkin, float type_ratioMAX, int number_customer, string status_checkin)
        {
            this.Id_checkin = id_checkin;
            this.Date_start = date_start;
            this.Id_room = id_room;
            this.Money_checkin = money_checkin;
            this.Type_ratioMAX = type_ratioMAX;
            this.Number_customer = number_customer;
            this.Status_checkin = status_checkin;
        }

        public Checkin(DataRow row)
        {
            this.Id_checkin = Convert.ToInt32(row["id_checkin"].ToString());
            this.Date_start = Convert.ToDateTime(row["date_start"]).ToString("d");
            this.Id_room = row["id_room"].ToString();
            this.Money_checkin = row["money_checkin"].ToString();
            this.Type_ratioMAX = (float)Convert.ToDouble(row["type_ratioMAX"].ToString());          
            this.Number_customer = (int)Convert.ToInt32(row["number_customer"].ToString());
            this.Status_checkin = row["status_checkin"].ToString();
        }

        private int id_checkin;
        private string date_start;
        private string id_room;
        private string money_checkin;
        private float type_ratioMAX;
        private int number_customer;
        private string status_checkin;

        public int Id_checkin
        {
            get { return id_checkin; }
            set { id_checkin = value; }
        }

        public string Date_start
        {
            get { return date_start; }
            set { date_start = value; }
        }
        public string Id_room
        {
            get { return id_room; }
            set { id_room = value; }
        }

        public string Money_checkin
        {
            get { return money_checkin; }
            set { money_checkin = value; }
        }
        public float Type_ratioMAX
        {
            get { return type_ratioMAX; }
            set { type_ratioMAX = value; }
        }
        public int Number_customer
        {
            get { return number_customer; }
            set { number_customer = value; }
        }
        public string Status_checkin
        {
            get { return status_checkin; }
            set { status_checkin = value; }
        }
    }
}
