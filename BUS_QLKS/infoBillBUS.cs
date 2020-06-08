using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class infoBillBUS
    {
        private static infoBillBUS instance;

        public static infoBillBUS Instance
        {
            get { if (instance == null) instance = new infoBillBUS(); return infoBillBUS.instance; }
            private set { infoBillBUS.instance = value; }
        }

        private infoBillBUS() { }

        public List<infoBill> GetListBillInfo(int id_bill, int id_checkin)
        {
            List<infoBill> listBillInfo = new List<infoBill>();

            DataTable data = infoBillDAL.Instance.GetListBillInfo(id_bill, id_checkin);

            foreach (DataRow item in data.Rows)
            {
                infoBill info = new infoBill(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public int GetStatusCheckin(int id_checkin)
        {
            return infoBillDAL.Instance.GetStatusCheckin(id_checkin);
        }

        public string GetIdRoom(int id_checkin)
        {
            return infoBillDAL.Instance.GetIdRoom(id_checkin);
        }

        public int GetMaxIDBill()
        {
            return infoBillDAL.Instance.GetMaxIDBill();
        }

        public int GetAmountSurchage()
        {
            return infoBillDAL.Instance.GetAmountSurchage();
        }

        public int GetNumberCustomer(int id_checkin)
        {
            return infoBillDAL.Instance.GetNumberCustomer(id_checkin);
        }

        public float GetRatioCustomer()
        {
            return infoBillDAL.Instance.GetRatioCustomer();
        }

        public DateTime GetDate(int id_checkin)
        {
            return infoBillDAL.Instance.GetDate(id_checkin);
        }

        public bool updateCheckin(float money, int id_checkin)
        {
            return infoBillDAL.Instance.updateCheckin(money, id_checkin);
        }

        public bool updateBill(float totalmoney, int id_bill)
        {
            return infoBillDAL.Instance.updateBill(totalmoney, id_bill);
        }

        public bool updateBillInfo(int id_bill, int id_checkin, int amount_surchage, int number_customer, float ratio, int date_number)
        {
            return infoBillDAL.Instance.updateBillInfo(id_bill, id_checkin, amount_surchage, number_customer, ratio, date_number);
        }

        public bool insertBill(string name, string address)
        {
            return infoBillDAL.Instance.insertBill(name, address);
        }

        //public bool insertBillInfo(int id_bill, int id_checkin, int date_number, float surchage_ratio)
        //{
        //    int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @id_bill , @id_checkin , @date_number , @surchage_ratio ", new object[] { id_bill, id_checkin, date_number, surchage_ratio });
        //    return result > 0;
        //}
    }
}
