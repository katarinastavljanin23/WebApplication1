using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Projekat
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService()
        {
            var baseAddress = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress) // Replace with your actual API URL
            };
        }

        public Category GetCategory(int categoryId)
        {
            // Synchronous GET request to retrieve category by ID
            var response = _httpClient.GetAsync($"api/Category/{categoryId}").Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Category>(jsonResponse);
            }

            return null;
        }

        public bool CreateCategory(Category category)
        {
            var json = JsonConvert.SerializeObject(category);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            // Synchronous POST request to create a new category
            var response = _httpClient.PostAsync("api/Category", content).Result;
            return response.IsSuccessStatusCode;
        }

        public bool UpdateCategory(int categoryId, Category category)
        {
            var json = JsonConvert.SerializeObject(category);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            // Synchronous PUT request to update an existing category
            var response = _httpClient.PutAsync($"api/Category/{categoryId}", content).Result;
            return response.IsSuccessStatusCode;
        }

        public bool DeleteCategory(int categoryId)
        {
            // Synchronous DELETE request to delete a category by ID
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var response = _httpClient.DeleteAsync($"api/Category/{categoryId}").Result;
            return response.IsSuccessStatusCode;
        }

        public List<Category> GetCategoriesByDate(DateTime startDate, DateTime endDate)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var response = _httpClient.GetAsync($"api/Category").Result;
            //var response = _httpClient.GetAsync($"api/categories?startDate={start}&endDate={end}").Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<Category>>(jsonResponse);
            }

            return null;
        }
    }
}
