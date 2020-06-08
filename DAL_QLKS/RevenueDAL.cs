using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class RevenueDAL
    {
        private static RevenueDAL instance;
        public static RevenueDAL Instance
        {
            get { if (instance == null) instance = new RevenueDAL(); return instance; }
            private set { instance = value; }
        }
        private RevenueDAL() { }
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
