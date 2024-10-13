#region zakomentarisi
//using Microsoft.AspNetCore.Mvc;
//using System.Net;
//using WebApplication1.Modeli;

//namespace WebApplication1.Controllers
//{
//    public class ProductsContoller
//    {
//        [ApiController]
//        [Route("api/[controller]")]
//        public class ProductsController : ControllerBase
//        {
//            private readonly IProductRepository _repository;

//            public ProductsController(IProductRepository repository)
//            {
//                _repository = repository;
//            }

//            // GET api/products
//            [HttpGet]
//            public async Task<IActionResult> GetProducts()
//            {
//                var products = await _repository.GetAllAsync();
//                return Ok(products); // Return 200 OK with the products
//            }

//            // GET api/products/{id}
//            [HttpGet("{id:int}")]
//            public async Task<IActionResult> GetProduct(int id)
//            {
//                var product = await _repository.GetByIdAsync(id);
//                if (product == null)
//                {
//                    return NotFound(); // Return 404 if the product doesn't exist
//                }
//                return Ok(product); // Return 200 OK with the product
//            }

//            // POST api/products
//            [HttpPost]
//            public async Task<IActionResult> AddProduct([FromBody] ProductDto product)
//            {
//                if (product == null)
//                {
//                    return BadRequest(); // Return 400 Bad Request if the product is null
//                }

//                await _repository.AddAsync(product);
//                return CreatedAtAction(nameof(GetProduct), new { id = product.ProductID }, product); // Return 201 Created with the product details
//            }

//            // PUT api/products/{id}
//            [HttpPut("{id:int}")]
//            public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDto product)
//            {
//                if (product == null || id != product.ProductID)
//                {
//                    return BadRequest(); // Return 400 Bad Request if the input is invalid
//                }

//                await _repository.UpdateAsync(product);
//                return NoContent(); // Return 204 No Content on successful update
//            }

//            // DELETE api/products/{id}
//            [HttpDelete("{id:int}")]
//            public async Task<IActionResult> DeleteProduct(int id)
//            {
//                await _repository.DeleteAsync(id);
//                return NoContent(); // Return 204 No Content on successful deletion
//            }
//        }
//    }
//}
#endregion
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Modeli;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET api/products
        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //    var products = _repository.GetAll();
        //    return Ok(products); // Return 200 OK with the products
        //}
        [HttpGet]
        public IActionResult GetProducts(DateTime? datumOd, DateTime? datumDo)
        {
            var products = _repository.GetProductsByDateRange(datumOd, datumDo);
            return Ok(products);
        }

        // GET api/products/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetProduct(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
            {
                return NotFound(); // Return 404 if the product doesn't exist
            }
            return Ok(product); // Return 200 OK with the product
        }

        // POST api/products
        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDto product)
        {
            if (product == null)
            {
                return BadRequest(); // Return 400 Bad Request if the product is null
            }

            _repository.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductID }, product); // Return 201 Created with the product details
        }

        // PUT api/products/{id}
        [HttpPut("{id:int}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductDto product)
        {
            if (product == null || id != product.ProductID)
            {
                return BadRequest(); // Return 400 Bad Request if the input is invalid
            }

            _repository.Update(product);
            return NoContent(); // Return 204 No Content on successful update
        }

        // DELETE api/products/{id}
        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id)
        {
            _repository.Delete(id);
            return NoContent(); // Return 204 No Content on successful deletion
        }
    }
}
