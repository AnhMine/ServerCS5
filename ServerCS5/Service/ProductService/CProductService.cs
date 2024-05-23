using Microsoft.EntityFrameworkCore;
using ServerCS5.Data.ProductData;
using ServerCS5.DTOs;
using ServerCS5.Models;
using System.Data.Entity;

namespace ServerCS5.Service.ProductService
{
    public class CProductService : IProductService
    {
        private readonly ServerCS5DbContext _context;
        private readonly IProductData _productData;
        public CProductService(ServerCS5DbContext context, IProductData productData)
        {
            _context = context;
            _productData = productData;
        }
        public  List<ProductDTOs> GetAllProduct()
        {
            List<Product> products = _context.Product.ToList();
            List<ProductDTOs> list = new List<ProductDTOs>();
            foreach (var item in products)
            {
                Media media =  _context.Media.FirstOrDefault(a => a.IdProduct == item.Id );
                Image img =  _context.Image.FirstOrDefault(a => a.Id == media.IdImage);
                ProductDTOs newItem = new ProductDTOs()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Hair = item.Hair,
                    Color = item.Color,     
                    Popular = item.Popular,
                    Size = item.Size,
                    Sex = item.Sex,
                    StatusHair = item.StatusHair,
                    Description = item.Description,
                    Link = img.Link,
                };
                list.Add(newItem);

            }
            return list;
        }
        public async Task AddProductWithImagesAsync(ProductDTOs item, List<IFormFile> imageFiles)
        {
            var product = new Product
            {
                Name = item.NameCategory + item.Name,
                Price = item.Price,
                Hair = item.Hair,
                Color = item.Color,
                Popular = item.Popular,
                Size = item.Size,
                Sex = item.Sex,
                StatusHair = item.StatusHair,
                Description = item.Description,
                CategoryId = item.IdCategory,
            };
            _context.Product.Add(product);
            bool isPrimary = true;
            foreach (var imageFile in imageFiles)
            {
                var imageId = await SaveImageAsync(imageFile);
                var media = new Media
                {
                    IdImage = imageId ,
                    IdProduct = product.Id,
                    IsPrimary = isPrimary,
                };
                _context.Media.Add(media);
            }
            isPrimary = false;

            await _context.SaveChangesAsync();
           
        }
        private async Task<int> SaveImageAsync(IFormFile imageFile)
        {
    
            var imagePath = "Path to save image";
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            var image = new Image
            {
                Link = "Path or URL to the saved image"
            };
            _context.Image.Add(image);
            await _context.SaveChangesAsync();
            return image.Id;
        }

    }
}
