using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class Account
    {
        public int IdUser { get; set; }
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Permission { get; set; }
    }
}
