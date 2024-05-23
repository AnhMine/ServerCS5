using Microsoft.AspNetCore.Mvc;
using ServerCS5.DTOs;
using ServerCS5.Models;
using ServerCS5.Service.CategoryService;

namespace ServerCS5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("get-category")]
        public IActionResult GetCategories() 
        {
            List<CategoryDTOs> categories = _categoryService.GetCategories();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
        [HttpPost("add-category")]
        public async Task<IActionResult> AddCategory(string name)
        {
            string item = await _categoryService.AddCategory(name);
            return Ok(item);
        }
        [HttpGet("get-categoryById/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            List<Product> listPrd = _categoryService.GetCategoryById(id);
            return Ok(listPrd);
        }

    }
}
