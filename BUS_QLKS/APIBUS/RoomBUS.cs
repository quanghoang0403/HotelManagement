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
    public class RoomBUS
    {
        public HttpClient _client;
        public HttpResponseMessage _reponse;

        public RoomBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Home>> GetListRoom()
        {
            _reponse = await _client.GetAsync($"/api/Room");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listR = JsonConvert.DeserializeObject<List<Home>>(json);
            return listR;
        }

        public void AddRoom(Home r)
        {
            var rtype = JsonConvert.SerializeObject(r);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/Room", byteContent);
        }

        public void DeleteRoom(string id_room)
        {
            _client.DeleteAsync($"api/Room/{id_room}");
        }

        public async Task<Home> GetRoom(string id_room)
        {
            _reponse = await _client.GetAsync($"/api/Room/{id_room}");
            var json = await _reponse.Content.ReadAsStringAsync();
            var RT = JsonConvert.DeserializeObject<Home>(json);
            return RT;
        }

        public void UpdateRoom(string id_room, Home r)
        {
            var rtype = JsonConvert.SerializeObject(r);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PutAsync($"/api/Room/{id_room}", byteContent);
        }
    }
}
