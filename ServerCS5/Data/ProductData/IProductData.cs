using ServerCS5.DTOs;
using ServerCS5.Models;

namespace ServerCS5.Data.ProductData
{
    public interface IProductData
    {
        Task<Product> GetProductsById(int id);

    }
}
