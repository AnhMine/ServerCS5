using ServerCS5.DTOs;
using ServerCS5.Models;

namespace ServerCS5.Service.ProductService
{
    public interface IProductService
    {
        List<ProductDTOs> GetAllProduct();
        Task  AddProductWithImagesAsync(ProductDTOs item, List<IFormFile> imageFiles);

    }
}
