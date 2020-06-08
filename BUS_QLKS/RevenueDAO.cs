using System;
using System.Collections.Generic;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RevenueDAO
    {
        private static RevenueDAO instance;
        public static RevenueDAO Instance
        {
            get { if (instance == null) instance = new RevenueDAO(); return instance; }
            private set { instance = value; }
        }
        private RevenueDAO() { }
        public DataTable LoadRevenueList(string month,string year)
        {
            string query= "select distinct ROOMTYPE.room_type,SUM(money_checkin) as Income" +
                " from ROOMTYPE, CHECKIN, ROOM" +
                " where CHECKIN.id_room = ROOM.id_room and ROOM.room_type = ROOMTYPE.room_type" +
                " and MONTH(date_start)="+month+" and YEAR(date_start)= "+year+" group by ROOMTYPE.room_type";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
