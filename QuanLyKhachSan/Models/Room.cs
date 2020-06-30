using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public partial class Room
    {
        public Room()
        {
            Checkin = new HashSet<Checkin>();
        }

        public string IdRoom { get; set; }
        public string RoomType { get; set; }
        public string Notes { get; set; }
        public string Statuss { get; set; }

        public virtual Roomtype RoomTypeNavigation { get; set; }
        public virtual ICollection<Checkin> Checkin { get; set; }
    }
}
