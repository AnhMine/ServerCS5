using ServerCS5.Models;

namespace ServerCS5.Data.CategoryData
{
    public class CCategoryData : ICategoryData
    {
        private readonly ServerCS5DbContext _context;
        public CCategoryData(ServerCS5DbContext context)
        {
            _context = context;
        }
        public List<Category> GetAllCategory() => _context.Category.ToList();
        public List<Product> GetProductsByCategoryId(int id)
        {
            return _context.Product.Where(a => a.Id == id).ToList();
        }
    }
}
