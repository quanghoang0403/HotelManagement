using Newtonsoft.Json;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class RoomTypeBUS
    {
        public HttpClient _client;
        public HttpResponseMessage _reponse;

        public RoomTypeBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<RT>> GetListRoomType()
        {
            _reponse = await _client.GetAsync($"/api/RoomType");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listRT = JsonConvert.DeserializeObject<List<RT>>(json);
            return listRT;
        }

        public void AddRoomType(RT rt)
        {
            var rtype = JsonConvert.SerializeObject(rt);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/RoomType", byteContent);
        }

        public void DeleteRoomType(string room_type)
        {
            _client.DeleteAsync($"api/RoomType/{room_type}");
        }

        public async Task<RT> GetRoomType(string room_type)
        {
            _reponse = await _client.GetAsync($"/api/RoomType/{room_type}");
            var json = await _reponse.Content.ReadAsStringAsync();
            var RT = JsonConvert.DeserializeObject<RT>(json);
            return RT;
        }

        public void UpdateRoomType(string room_type,RT rt)
        {
            var rtype = JsonConvert.SerializeObject(rt);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PutAsync($"/api/RoomType/{room_type}", byteContent);
        }
    }
}
