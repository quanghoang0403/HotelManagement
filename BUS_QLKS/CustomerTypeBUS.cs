using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace QuanLyKhachSan.BUS
{
    public class CustomerTypeBUS
    {
        //private static CustomerTypeBUS instance;

        //public static CustomerTypeBUS Instance
        //{
        //    get { if (instance == null) instance = new CustomerTypeBUS(); return CustomerTypeBUS.instance; }
        //    private set { CustomerTypeBUS.instance = value; }
        //}

        //private CustomerTypeBUS() { }

        //public List<CustomerType> GetListType()
        //{
        //    List<CustomerType> list = new List<CustomerType>();

        //    DataTable data = CustomerTypeDAL.Instance.GetListType();

        //    foreach (DataRow item in data.Rows)
        //    {
        //        CustomerType info = new CustomerType(item);
        //        list.Add(info);
        //    }
        //    return list;
        //}
        public HttpClient _client;
        public HttpResponseMessage _reponse;

        public CustomerTypeBUS()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44398");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<CustomerType>> GetCustomerType()
        {
            _reponse = await _client.GetAsync($"/api/CustomerType");
            var json = await _reponse.Content.ReadAsStringAsync();
            var listCT = JsonConvert.DeserializeObject<List<CustomerType>>(json);
            return listCT;
        }

        public void AddCustomerType(CustomerType r)
        {
            var rtype = JsonConvert.SerializeObject(r);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PostAsync($"/api/CustomerType", byteContent);
        }

        public void DeleteCustomerType(string id_room)
        {
            _client.DeleteAsync($"api/CustomerType/{id_room}");
        }

        public void UpdateCustomerType(string id_room, CustomerType r)
        {
            var rtype = JsonConvert.SerializeObject(r);
            var buffer = Encoding.UTF8.GetBytes(rtype);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            _client.PutAsync($"/api/CustomerType/{id_room}", byteContent);
        }
    }
} 
