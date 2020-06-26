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
    public class CheckinController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Checkin>> Get()
        {
            List<Checkin> Checkinlist = new List<Checkin>();
            DataTable data = CheckinManagementDAL.Instance.LoadCheckinList();
            foreach (DataRow item in data.Rows)
            {
                Checkin ck = new Checkin(item);
                Checkinlist.Add(ck);
            }
            return Checkinlist;
        }

        [HttpGet("{condition}")]
        public List<Checkin> Get(string condition)
        {
            List<Checkin> Checkinlist = new List<Checkin>();
            DataTable data = CheckinManagementDAL.Instance.SearchCheckin(condition);
            foreach (DataRow item in data.Rows)
            {
                Checkin ck = new Checkin(item);
                Checkinlist.Add(ck);
            }

            return Checkinlist;
        }
    }
}
