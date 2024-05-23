using ServerCS5.DTOs;
using ServerCS5.Models;
using System.Data.Entity;

namespace ServerCS5.Data.ProductData
{
    public class CProductData : IProductData
    {
        private readonly ServerCS5DbContext _context;
        public CProductData(ServerCS5DbContext context)
        {
            _context = context;
        }
       
        public async Task<Product> GetProductsById(int id)
        {
            return await _context.Product.FirstOrDefaultAsync(a => a.Id == id);
        }
        

    }
}
