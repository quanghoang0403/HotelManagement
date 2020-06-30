using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetails = new HashSet<BillDetails>();
        }

        public int IdBill { get; set; }
        public string BillName { get; set; }
        public string BillAddress { get; set; }
        public string TotalMoney { get; set; }

        public virtual ICollection<BillDetails> BillDetails { get; set; }
    }
}
