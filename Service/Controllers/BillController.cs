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
    public class BillController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Bill>> Get()
        {
            List<Bill> BillList = new List<Bill>();
            DataTable data = BillManagementDAL.Instance.LoadBillList();
            foreach (DataRow item in data.Rows)
            {
                Bill room = new Bill(item);
                BillList.Add(room);
            }
            return BillList;
        }

        [HttpGet ("{condition}")]
        public List<Bill> Get(string condition)
        {
            List<Bill> BillList = new List<Bill>();
            DataTable data = BillManagementDAL.Instance.SearchBill(condition);
            foreach (DataRow item in data.Rows)
            {
                Bill room = new Bill(item);
                BillList.Add(room);
            }
            
            return BillList;
        }
    }
}
