using Microsoft.AspNetCore.Mvc;
using WebApplication1.Modeli;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {

            private readonly ICategoryRepository _repository;

            public CategoryController(ICategoryRepository repository)
            {
                _repository = repository;
            }

            // GET api/category
            [HttpGet]
            public IActionResult GetCategories()
            {
                var categories = _repository.GetAll();
                return Ok(categories); // Return 200 OK with the categories
            }

            // GET api/category/{id}
            [HttpGet("{id:int}")]
            public IActionResult GetCategory(int id)
            {
                var category = _repository.GetById(id);
                if (category == null)
                {
                    return NotFound(); // Return 404 if the category doesn't exist
                }
                return Ok(category); // Return 200 OK with the category
            }

            // POST api/category
            [HttpPost]
            public IActionResult AddCategory([FromBody] CategoryDto category)
            {
                if (category == null)
                {
                    return BadRequest(); // Return 400 Bad Request if the category is null
                }

                _repository.Add(category);
                return CreatedAtAction(nameof(GetCategory), new { id = category.CategoryID }, category); // Return 201 Created with the category details
            }

            // PUT api/category/{id}
            [HttpPut("{id:int}")]
            public IActionResult UpdateCategory(int id, [FromBody] CategoryDto category)
            {
                if (category == null || id != category.CategoryID)
                {
                    return BadRequest(); // Return 400 Bad Request if the input is invalid
                }

                _repository.Update(category);
                return NoContent(); // Return 204 No Content on successful update
            }

            // DELETE api/category/{id}
            [HttpDelete("{id:int}")]
            public IActionResult DeleteCategory(int id)
            {
                _repository.Delete(id);
                return NoContent(); // Return 204 No Content on successful deletion
            }
        
    }
}
