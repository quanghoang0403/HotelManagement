using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Home
    {
        public Home(string id_room, string room_type, string notes, string statuss)
        {
            this.ID = id_room;
            this.Notes = notes;
            this.Type = room_type;
            this.Status = statuss;
        }

        public Home(DataRow row)
        {
            this.ID = row["id_room"].ToString();
            this.Type = row["room_type"].ToString();
            this.Notes = row["notes"].ToString();
            this.Status = row["statuss"].ToString();
        }

        private string iD;
        private string type;
        private string notes;
        private string status;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Notes 
        {
            get { return notes; }
            set { notes = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
