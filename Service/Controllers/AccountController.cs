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
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("{username}/{password}")]
        public bool Get(string username,string password)
        {
            return AccountManagementDAL.Instance.Login(username, password);
        }
        [HttpPost]
        public void Post([FromBody] Account rt)
        {
            AccountManagementDAL.Instance.Signup(rt); ;
        }

        [HttpPut]
        public void Put([FromBody] Account acc)
        {
           AccountManagementDAL.Instance.ChangePass(acc);
        }
    }
}
