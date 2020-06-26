using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    public class CustomerTypeController : Controller
    {    
        [HttpGet]
        public ActionResult<IEnumerable<CustomerType>> Get()
        {
            List<CustomerType> CTlist = new List<CustomerType>();
            DataTable data = SettingDAL.Instance.LoadCustomerTypeList();
            foreach (DataRow item in data.Rows)
            {
                CustomerType ct = new CustomerType(item);
                CTlist.Add(ct);
            }
            return CTlist;
        }

        [HttpGet ("{cus_type}")]
        public ActionResult<CustomerType> Get(string cus_type)
        {
            DataTable data = SettingDAL.Instance.FindByCT(cus_type);
            CustomerType RoomList = new CustomerType(data.Rows[0]);
            return RoomList;
        }

        [HttpPost]
        public void Post([FromBody] CustomerType ct)
        {
            SettingDAL.Instance.AddCustomertype(ct);
        }

        [HttpDelete("{cus_type}")]
        public void Delete(string cus_type)
        {
            SettingDAL.Instance.DeleteCustomertype(cus_type);
        }

        [HttpPut("{cus_type}")]
        public void Put(string cus_type, [FromBody] CustomerType ct)
        {
            SettingDAL.Instance.UpdateCustomertype(cus_type, ct);
        }
    }
}
