using WebApplication1.Modeli;

namespace WebApplication1.Service
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // GET - Dohvatanje jednog proizvoda
        public async Task<ProductDto> GetProductAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/products/{id}");

            if (response.IsSuccessStatusCode)
            {
                // Use ReadFromJsonAsync instead of ReadAsAsync
                var product = await response.Content.ReadFromJsonAsync<ProductDto>();
                return product;
            }

            return null; // Handle failure scenarios accordingly
        }

        // GET - Dohvatanje svih proizvoda
        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetAsync("api/products");

            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
                return products;
            }

            return null;
        }

        // POST - Dodavanje novog proizvoda
        public async Task<ProductDto> AddProductAsync(ProductDto product)
        {
            var response = await _httpClient.PostAsJsonAsync("api/products", product); // Serijalizuje ProductDto u JSON i šalje kao POST telo

            if (response.IsSuccessStatusCode)
            {
                // Vraća kreirani proizvod iz odgovora (ukoliko API vrati kreirani proizvod)
                var createdProduct = await response.Content.ReadFromJsonAsync<ProductDto>();
                return createdProduct;
            }

            return null;
        }

        // PUT - Ažuriranje postojećeg proizvoda
        public async Task<bool> UpdateProductAsync(int id, ProductDto product)
        {
            if (id != product.ProductID)
            {
                return false; // ID ne odgovara proizvodu
            }

            var response = await _httpClient.PutAsJsonAsync($"api/products/{id}", product); // Serijalizuje ProductDto u JSON i šalje kao PUT telo

            return response.IsSuccessStatusCode;
        }

        // DELETE - Brisanje proizvoda
        public async Task<bool> DeleteProductAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/products/{id}");

            return response.IsSuccessStatusCode; // Vraća true ako je brisanje uspešno
        }
    }
}
