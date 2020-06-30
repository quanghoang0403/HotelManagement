using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class CheckinDetails
    {
        public int IdCheckinDetails { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public string CustomerCmnd { get; set; }
        public string CustomerAddress { get; set; }
        public int? IdCheckin { get; set; }

        public virtual CustomerType CustomerTypeNavigation { get; set; }
        public virtual Checkin IdCheckinNavigation { get; set; }
    }
}
