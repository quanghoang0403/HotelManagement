using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class Roomtype
    {
        public Roomtype()
        {
            Room = new HashSet<Room>();
        }

        public string RoomType1 { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<Room> Room { get; set; }
    }
}
