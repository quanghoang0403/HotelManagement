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
    public class AmountBUS
    {
        public HttpClient _client;
        public HttpResponseMessage _reponse;

        public AmountBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Amount>> GetAmount()
        {
            _reponse = await _client.GetAsync($"/api/Amount");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listA = JsonConvert.DeserializeObject<List<Amount>>(json);
            return listA;
        }
        public void ChangeAmount(Amount amt)
        {
            var rtype = JsonConvert.SerializeObject(amt);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/Amount", byteContent);
        }
    }
}
