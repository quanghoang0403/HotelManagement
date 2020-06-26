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
    public class AmountController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Amount>> Get()
        {
            List<Amount> Amountlist = new List<Amount>();
            DataTable data = SettingDAL.Instance.LoadAmountList();
            foreach (DataRow item in data.Rows)
            {
                Amount amt = new Amount(item);
                Amountlist.Add(amt);
            }
            return Amountlist;
        }

        [HttpPost]
        public void Put([FromBody] Amount amt)
        {
            SettingDAL.Instance.ChangeAmount(amt);
        }
    }
}
