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
    public class CheckinBUS
    {
        public HttpClient _client;
        public HttpResponseMessage _reponse;

        public CheckinBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Checkin>> GetListCheckin()
        {
            _reponse = await _client.GetAsync($"/api/Checkin");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listCK = JsonConvert.DeserializeObject<List<Checkin>>(json);
            return listCK;
        }
        public async Task<List<Checkin>> GetSearchCheckin(string condition)
        {
            _reponse = await _client.GetAsync($"/api/Checkin/{condition}");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listSCK = JsonConvert.DeserializeObject<List<Checkin>>(json);
            return listSCK;
        }
    }
}
