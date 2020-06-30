
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    public class infoCheckinDAL
    {
        private static infoCheckinDAL instance;

        public static infoCheckinDAL Instance
        {
            get { if (instance == null) instance = new infoCheckinDAL(); return infoCheckinDAL.instance; }
            private set { infoCheckinDAL.instance = value; }
        }

        private infoCheckinDAL() { }

        public DataTable GetListCheckinInfo(int id)
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetListCheckinInfo @id ", new object[] { id });
        }

        public int GetMaxIDCheckin() // lấy id phòng đang tương tác
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("USP_GetMaxIDCheckin");
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
                return (int)DataProvider.Instance.ExecuteScalar("USP_GetAmountCustomer @id " , new object[] { id });
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
                return (float)Convert.ToDouble(DataProvider.Instance.ExecuteScalar("USP_GetMaxRatio @id ", new object[] { id }).ToString());
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
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateRatioCheckin @ratio , @count , @id_checkin ", new object[] { ratio, count , id_checkin });
            return result > 0;
        }


        public bool insertCheckinInfo(string name, string type, string cmnd, string address, int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_InsertCheckinInfo @customer_name , @customer_type , @customer_cmnd , @customer_address , @id_checkin", new object[] { name, type, cmnd, address, id });
            return result > 0;
        }
    }
}
