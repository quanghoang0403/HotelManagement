using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class infoBillDAO
    {
        private static infoBillDAO instance;

        public static infoBillDAO Instance
        {
            get { if (instance == null) instance = new infoBillDAO(); return infoBillDAO.instance; }
            private set { infoBillDAO.instance = value; }
        }

        private infoBillDAO() { }

        public List<infoBill> GetListBillInfo(int id_bill, int id_checkin)
        {
            List<infoBill> listBillInfo = new List<infoBill>();

            string query = string.Format("SELECT C.id_room AS ID_ROOM, BD.date_number AS DATE_NUMBER, RT.price AS PRICE, C.type_ratioMAX AS TYPE_RATIO, BD.surchage_ratio AS NUMBER_RATIO, RT.price*C.type_ratioMAX*BD.surchage_ratio*BD.date_number AS TOTAL FROM BILL_DETAILS AS BD, CHECKIN AS C, ROOM AS R, ROOMTYPE AS RT WHERE BD.id_checkin = C.id_checkin and C.id_room = R.id_room and R.room_type = RT.room_type and BD.id_bill = {0} and BD.id_checkin = {1}", id_bill, id_checkin);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                infoBill info = new infoBill(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public string GetIdRoom(int id_checkin)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("select id_room from CHECKIN where id_checkin =" + id_checkin).ToString();
            }
            catch
            {
                return "1";
            }
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(id_bill) from BILL");
            }
            catch
            {
                return 1;
            }
        }

        public int GetAmountSurchage()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select amount_surchage from AMOUNT");
            }
            catch
            {
                return 1;
            }
        }

        public int GetNumberCustomer(int id_checkin)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select number_customer from CHECKIN where id_checkin = " + id_checkin);
            }
            catch
            {
                return 1;
            }
        }

        public float GetRatioCustomer()
        {
            try
            {
                return (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar("Select customer_ratio from AMOUNT").ToString());
            }
            catch
            {
                return 1;
            }
        }

        public DateTime GetDate(int id_checkin)
        {
            try
            {
                return (DateTime)DataProvider.Instance.ExecuteScalar("select date_start from CHECKIN where id_checkin = " + id_checkin);
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public bool updateCheckin(float money, int id_checkin)
        {
            string query = string.Format("update CHECKIN set money_checkin = {0}, status_checkin = 'DONE' where id_checkin = {1}", money, id_checkin);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateBill(float totalmoney, int id_bill)
        {
            string query = string.Format("update BILL set total_money = {0} where id_bill = {1}", totalmoney, id_bill);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool updateBillInfo(int id_bill, int id_checkin, int amount_surchage, int number_customer, float ratio, int date_number)
        {
            if (amount_surchage<=number_customer)
            {
                int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @id_bill , @id_checkin , @date_number , @surchage_ratio ", new object[] { id_bill, id_checkin, date_number, ratio });
                return result > 0;
                //string query = string.Format("update BILL_DETAILS set surchage_ratio = {0}, date_number = {1} where id_bill = {3} and id_checkin = {4}", ratio, date_number);
                //int result = DataProvider.Instance.ExecuteNonQuery(query);
                //return result > 0;
            }
            else
            {
                ratio = 1;
                int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @id_bill , @id_checkin , @date_number , @surchage_ratio ", new object[] { id_bill, id_checkin, date_number, ratio});
                return result > 0;
                //string query = string.Format("update BILL_DETAILS set surchage_ratio = {0}, date_number = {1}", ratio, date_number);
                //int result = DataProvider.Instance.ExecuteNonQuery(query);
                //return result > 0;

            }
        }

        public bool insertBill(string name, string address)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @name , @address ", new object[] { name, address });
            return result > 0;
        }

        //public bool insertBillInfo(int id_bill, int id_checkin, int date_number, float surchage_ratio)
        //{
        //    int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @id_bill , @id_checkin , @date_number , @surchage_ratio ", new object[] { id_bill, id_checkin, date_number, surchage_ratio });
        //    return result > 0;
        //}
    }
}
