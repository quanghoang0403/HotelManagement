using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CustomerType
    {
        public CustomerType()
        {
            this.Name = "";
            this.Ratio = 0;
        }

        public CustomerType(string name, float ratio)
        {
            this.Name = name;
            this.Ratio = ratio;
        }

        public CustomerType(DataRow row)
        {
            this.Name = row["customer_type"].ToString();
            this.Ratio = (float)Convert.ToDouble(row["ratio"].ToString());
        }

        private string name;
        private float ratio;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Ratio
        {
            get { return ratio; }
            set { ratio = value; }
        }

    }
}
