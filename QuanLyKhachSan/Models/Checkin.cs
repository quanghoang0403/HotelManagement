using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class Checkin
    {
        public Checkin()
        {
            BillDetails = new HashSet<BillDetails>();
            CheckinDetails = new HashSet<CheckinDetails>();
        }

        public int IdCheckin { get; set; }
        public DateTime DateStart { get; set; }
        public string IdRoom { get; set; }
        public decimal? MoneyCheckin { get; set; }
        public double? TypeRatioMax { get; set; }
        public int? NumberCustomer { get; set; }
        public string StatusCheckin { get; set; }

        public virtual Room IdRoomNavigation { get; set; }
        public virtual ICollection<BillDetails> BillDetails { get; set; }
        public virtual ICollection<CheckinDetails> CheckinDetails { get; set; }
    }
}
