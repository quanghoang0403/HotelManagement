using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class infoCheckinDAO
    {
        private static infoCheckinDAO instance;

        public static infoCheckinDAO Instance
        {
            get { if (instance == null) instance = new infoCheckinDAO(); return infoCheckinDAO.instance; }
            private set { infoCheckinDAO.instance = value; }
        }

        private infoCheckinDAO() { }

        public List <infoCheckin> GetListCheckinInfo(int id)
        {
            List<infoCheckin> listCheckinInfo = new List<infoCheckin>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *from CHECKIN_DETAILS where id_checkin=" + id);

            foreach (DataRow item in data.Rows)
            {
                infoCheckin info = new infoCheckin(item);
                listCheckinInfo.Add(info);
            }
            return listCheckinInfo;
        }

        public int GetMaxIDCheckin() // lấy id phòng đang tương tác
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select MAX(id_checkin) from CHECKIN");
            }
            catch
            {
                return 0;
            }
        }

        public int GetAmountCustomer(int id) //lấy số lượng khách 
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select COUNT(*) from CHECKIN_DETAILS WHERE id_checkin=" + id);
            }
            catch
            {
                return 0;
            }
        }

        public float GetMaxRatio(int id) //lấy tỉ lệ phụ thu loại khách lớn nhất
        {
            try
            {
                return (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar("select MAX(ratio) from CHECKIN_DETAILS AS CD, CUSTOMER_TYPE AS CT WHERE CD.customer_type= CT.customer_type and CD.id_checkin = " + id).ToString());
            }
            catch
            {
                return 0;
            }
        }

        public bool insertCheckin(DateTime date,string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertCheckin @date , @id_room ", new object[] {date, id});
            return result > 0;
        }

        public bool updateCheckin(float ratio, int count, int id_checkin)
        {
            string query = string.Format("update CHECKIN set type_ratioMAX = {0}, number_customer = {1} where id_checkin = {2}", ratio, count, id_checkin);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool insertCheckinInfo(string name, string type, string cmnd, string address, int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertCheckinInfo @customer_name , @customer_type , @customer_cmnd , @customer_address , @id_checkin", new object[] { name, type, cmnd, address, id });
            return result > 0;
        }
    }
}
