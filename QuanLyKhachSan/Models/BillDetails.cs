using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class BillDetails
    {
        public int IdBill { get; set; }
        public int IdCheckin { get; set; }
        public int? DateNumber { get; set; }
        public double? SurchageRatio { get; set; }

        public virtual Bill IdBillNavigation { get; set; }
        public virtual Checkin IdCheckinNavigation { get; set; }
    }
}
