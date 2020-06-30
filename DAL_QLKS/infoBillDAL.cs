
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class infoBillDAL
    {
        private static infoBillDAL instance;

        public static infoBillDAL Instance
        {
            get { if (instance == null) instance = new infoBillDAL(); return infoBillDAL.instance; }
            private set { infoBillDAL.instance = value; }
        }

        private infoBillDAL() { }

        public DataTable GetListBillInfo(int id_bill, int id_checkin)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListBillInfo @id_bill , @id_checkin", new object[] { id_bill, id_checkin });
        }

        public int GetStatusCheckin(int id_checkin)
        {
            object Status = DataProvider.Instance.ExecuteScalar("USP_GetStatusCheckin @id_checkin ", new object[] { id_checkin });
            if (Status == null)
                return -1;
            if (Status.ToString() == "DONE")
                return 1;
            return 0;
        }

        public string GetIdRoom(int id_checkin)
        {
            try
            {
                return DataProvider.Instance.ExecuteScalar("USP_GetIdRoom @id_checkin ", new object[] { id_checkin }).ToString();
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
                return (int)DataProvider.Instance.ExecuteScalar("USP_GetMaxIDBill");
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
                return (int)DataProvider.Instance.ExecuteScalar("USP_GetAmountSurchage");
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
                return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumberCustomer @id_checkin ", new object[] { id_checkin });
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
                return (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar("USP_GetRatioCustomer").ToString());
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
                return (DateTime)DataProvider.Instance.ExecuteScalar("exec USP_GetDate @id_checkin", new object[] { id_checkin });
            }
            catch
            {
                return DateTime.Now;
            }
        }

        public bool updateCheckin(float money, int id_checkin)
        {
            string status_checkin = "DONE";
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateCheckin @money , @status , @id_checkin ", new object[] { money, status_checkin, id_checkin });
            return result > 0;
        }

        public bool updateBill(float totalmoney, int id_bill)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateBill @totalmoney , @id_bill ", new object[] { totalmoney, id_bill });
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
