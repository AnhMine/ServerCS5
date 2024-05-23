using Microsoft.AspNetCore.Mvc;
using ServerCS5.DTOs;
using ServerCS5.Models;
using ServerCS5.Service.ProductService;

namespace ServerCS5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ServerCS5DbContext _context;
        private readonly IProductService _productService;
        public ProductController(IProductService productService, ServerCS5DbContext context)
        {
            _productService = productService;
            _context = context;
        }
        [HttpGet("get-all-product")]
        public IActionResult GetProduct()
        {
            List<ProductDTOs> list = _productService.GetAllProduct();
            return Ok(list);

        }
        [HttpPost("add-new-products")]
   
        public async Task<IActionResult> AddProductWithImages([FromForm] ProductDTOs productDto, [FromForm] List<IFormFile> images)
        {
            try
            {
                await _productService.AddProductWithImagesAsync(productDto, images);
                return Ok("Product added with images successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }





    }
}
