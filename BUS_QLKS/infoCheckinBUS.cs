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
    public class infoCheckinBUS
    {
        private static infoCheckinBUS instance;

        public static infoCheckinBUS Instance
        {
            get { if (instance == null) instance = new infoCheckinBUS(); return infoCheckinBUS.instance; }
            private set { infoCheckinBUS.instance = value; }
        }

        private infoCheckinBUS() { }

        public List <infoCheckin> GetListCheckinInfo(int id)
        {
            List<infoCheckin> listCheckinInfo = new List<infoCheckin>();

            DataTable data = infoCheckinDAL.Instance.GetListCheckinInfo(id);

            foreach (DataRow item in data.Rows)
            {
                infoCheckin info = new infoCheckin(item);
                listCheckinInfo.Add(info);
            }
            return listCheckinInfo;
        }

        public int GetMaxIDCheckin() // lấy id phòng đang tương tác
        {
            return infoCheckinDAL.Instance.GetMaxIDCheckin();
        }

        public int GetAmountCustomer(int id) //lấy số lượng khách 
        {
            return infoCheckinDAL.Instance.GetAmountCustomer(id);
        }

        public float GetMaxRatio(int id) //lấy tỉ lệ phụ thu loại khách lớn nhất
        {
            return infoCheckinDAL.Instance.GetMaxRatio(id);
        }

        public bool insertCheckin(DateTime date,string id)
        {
            return infoCheckinDAL.Instance.insertCheckin(date, id);
        }

        public bool updateCheckin(float ratio, int count, int id_checkin)
        {
            return infoCheckinDAL.Instance.updateCheckin(ratio, count, id_checkin);
        }


        public bool insertCheckinInfo(string name, string type, string cmnd, string address, int id)
        {
            return infoCheckinDAL.Instance.insertCheckinInfo(name, type, cmnd, address, id);
        }
    }
}
