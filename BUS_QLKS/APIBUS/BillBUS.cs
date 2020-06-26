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
    public class BillBUS
    {
        public HttpClient _client;
        public HttpResponseMessage _reponse;

        public BillBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Bill>> GetListBill()
        {
            _reponse = await _client.GetAsync($"/api/Bill");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listB = JsonConvert.DeserializeObject<List<Bill>>(json);
            return listB;
        }
        public async Task<List<Bill>> GetSearchBill(string condition)
        {
            _reponse = await _client.GetAsync($"/api/Bill/{condition}");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listSB = JsonConvert.DeserializeObject<List<Bill>>(json);
            return listSB;
        }
    }
}
