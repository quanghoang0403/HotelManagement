using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using QuanLyKhachSan.DAL;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.DTO;
using System.Data.SqlClient;
namespace Service.Controllers
{
    [Route("api/[controller]")]
    public class RoomTypeController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<RT>> Get()
        {
            List<RT> RoomList = new List<RT>();
            DataTable data = HomeDAL.Instance.LoadRoomType();
            foreach (DataRow item in data.Rows)
            {
                RT room = new RT(item);
                RoomList.Add(room);
            }
            return RoomList;
        }

        [HttpGet("{room_type}")]
        //[Route("id")]
        public RT Get(string room_type)
        {
            DataTable data = RoomManagementDAL.Instance.FindByRT(room_type);
            RT RoomList = new RT(data.Rows[0]);
            return RoomList;
        }

        [HttpPost]
        public void Post([FromBody] RT rt)
        {
            RoomManagementDAL.Instance.AddRoomType(rt);
        }

        [HttpDelete("{room_type}")]
        public void Delete(string room_type)
        {
            RoomManagementDAL.Instance.DeleteRoomType(room_type);
        }

        [HttpPut("{room_type}")]
        public void Put(string  room_type, [FromBody] RT rt)
        {
            RoomManagementDAL.Instance.UpdateRoomType(room_type,rt);
        }
    }
}
