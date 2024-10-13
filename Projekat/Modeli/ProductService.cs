using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

#region zakomentarisi
//namespace Projekat
//{
//    public class ProductService
//    {
//        private readonly HttpClient _httpClient;


//        public ProductService()
//        {
//            _httpClient = new HttpClient
//            {
//                BaseAddress = new Uri("http://localhost:5000/") // Zameni sa tvojim API URL-om
//            };
//        }

//        public async Task<Product> GetProductAsync(int productId)
//        {
//            // GET zahtev za dohvatanje proizvoda sa datim ID-jem
//            var response = await _httpClient.GetAsync($"api/products/{productId}");

//            if (response.IsSuccessStatusCode)
//            {
//                // Deserijalizacija odgovora iz JSON formata u objekt tipa Product
//                var jsonResponse = await response.Content.ReadAsStringAsync();
//                return JsonConvert.DeserializeObject<Product>(jsonResponse);
//            }

//            return null; 
//        }

//        public async Task<bool> CreateProductAsync(Product product)
//        {
//           var json = JsonConvert.SerializeObject(product); 
//            var content = new StringContent(json, Encoding.UTF8, "application/json");

//            var response = await _httpClient.PostAsync("api/products", content);
//            return response.IsSuccessStatusCode; 
//        }

//        public async Task<bool> UpdateProductAsync(int productId, Product product)
//        {
//            var json = JsonConvert.SerializeObject(product);
//            var content = new StringContent(json, Encoding.UTF8, "application/json");

//            // PUT zahtev za ažuriranje proizvoda sa datim ID-jem
//            var response = await _httpClient.PutAsync($"api/products/{productId}", content);
//            return response.IsSuccessStatusCode;
//        }

//        public async Task<bool> DeleteProductAsync(int productId)
//        {
//            // DELETE zahtev za brisanje proizvoda sa datim ID-jem
//            var response = await _httpClient.DeleteAsync($"api/products/{productId}");
//            return response.IsSuccessStatusCode;
//        }

//        public async Task<List<Product>> GetProductsByDateAsync(DateTime startDate, DateTime endDate)
//        {
//            string start = startDate.ToString("yyyy-MM-dd");
//            string end = endDate.ToString("yyyy-MM-dd");

//            var response = await _httpClient.GetAsync($"api/products?startDate={start}&endDate={end}");

//            if (response.IsSuccessStatusCode)
//            {
//                var jsonResponse = await response.Content.ReadAsStringAsync();
//                return JsonConvert.DeserializeObject<List<Product>>(jsonResponse);
//            }

//            return null; // Handle error appropriately if the request fails
//        }
//    }
//}
#endregion
namespace Projekat
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService()
        {
            var baseAddress = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress) 
            };
            List<string> ips = new List<string>();
        }

        public Product GetProduct(int productId)
        {
            var response = _httpClient.GetAsync($"api/products/{productId}").Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Product>(jsonResponse);
            }

            return null;
        }

        public bool CreateProduct(Product product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var response = _httpClient.PostAsync("api/products", content).Result;
            return response.IsSuccessStatusCode;
        }

        public bool UpdateProduct(int productId, Product product)
        {
            var json = JsonConvert.SerializeObject(product);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var response = _httpClient.PutAsync($"api/products/{productId}", content).Result;
            return response.IsSuccessStatusCode;
        }

        public bool DeleteProduct(int productId)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var response = _httpClient.DeleteAsync($"api/products/{productId}").Result;
            return response.IsSuccessStatusCode;
        }

        public List<Product> GetProducts(DateTime? startDate, DateTime? endDate)
        {
            string start = string.Empty;
            string end = string.Empty;

            if (startDate != null)
            {
                DateTime pocetak = (DateTime)startDate;
                start = pocetak.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (endDate != null)
            {
                DateTime kraj = (DateTime)endDate;
                end = kraj.ToString("yyyy-MM-dd HH:mm:ss");
            }


            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            //var response = _httpClient.GetAsync($"api/products/").Result;
            var response = _httpClient.GetAsync($"api/products?datumOd={start}&datumDo={end}").Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Product>>(jsonResponse);
            }

            return null;
        }
    }
}
