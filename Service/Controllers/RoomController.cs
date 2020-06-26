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
    public class RoomController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Home>> Get()
        {
            List<Home> RoomList = new List<Home>();
            DataTable data = HomeDAL.Instance.LoadRoom();
            foreach (DataRow item in data.Rows)
            {
                Home room = new Home(item);
                RoomList.Add(room);
            }
            return RoomList;
        }

        [HttpGet("{id_room}")]
        public Home Get(string id_room)
        {
            DataTable data = RoomManagementDAL.Instance.FindByRoom(id_room);
            Home RoomList = new Home(data.Rows[0]);
            return RoomList;
        }
        [HttpPost]
        public void Post([FromBody] Home r)
        {
            RoomManagementDAL.Instance.AddRoom(r);
        }

        [HttpDelete("{id_room}")]
        public void Delete(string id_room)
        {
            RoomManagementDAL.Instance.DeleteRoom(id_room);
        }


        [HttpPut("{id_room}")]
        public void Put(string id_room, [FromBody] Home r)
        {
            RoomManagementDAL.Instance.UpdateRoom(id_room, r);
        }
    }
}
