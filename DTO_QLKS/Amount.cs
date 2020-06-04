using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Amount
    {
        public Amount(float customer_ratio, int max_customer , int amount_surchage)
        {
            this.Customer_ratio= customer_ratio;
            this.Max_customer = max_customer;
            this.Amount_surchage = amount_surchage;
        }

        public Amount(DataRow row)
        {
            this.Max_customer = (int)Convert.ToInt32(row["Max_customer"].ToString());
            this.Customer_ratio = (float)Convert.ToDouble(row["Customer_ratio"].ToString());
            this.Amount_surchage = (int)Convert.ToInt32(row["Amount_surchage"].ToString());
        }

        private float customer_ratio;
        private int max_customer;
        private int amount_surchage;

        public float Customer_ratio
        {
            get { return customer_ratio; }
            set { customer_ratio = value; }
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
