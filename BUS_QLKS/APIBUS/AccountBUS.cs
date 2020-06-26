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
    public class AccountBUS
    {
        public HttpClient _client;
        public HttpResponseMessage _reponse;
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; }
            private set { instance = value; }
        }
        public AccountBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<string> LoginAccount(string Username,string Password)
        {
            _reponse = await _client.GetAsync($"/api/Account/{Username}/{Password}");
            var json = await _reponse.Content.ReadAsStringAsync();
            var loginok = JsonConvert.DeserializeObject<string>(json);
            return loginok;
        }
        public void SignupAccount(Account acc)
        {
            var rtype = JsonConvert.SerializeObject(acc);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/Account", byteContent);
        }

        public void ChangePassWord(Account acc)
        {
            var rtype = JsonConvert.SerializeObject(acc);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PutAsync($"/api/Account", byteContent);
        }
    }
}
