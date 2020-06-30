using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            CheckinDetails = new HashSet<CheckinDetails>();
        }

        public string CustomerType1 { get; set; }
        public double? Ratio { get; set; }

        public virtual ICollection<CheckinDetails> CheckinDetails { get; set; }
    }
}
