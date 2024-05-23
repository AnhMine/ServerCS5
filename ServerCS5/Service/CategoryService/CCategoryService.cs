using ServerCS5.Data.CategoryData;
using ServerCS5.DTOs;
using ServerCS5.Models;

namespace ServerCS5.Service.CategoryService
{
    public class CCategoryService : ICategoryService
    {
        private readonly ServerCS5DbContext _context;
        private readonly ICategoryData _categoryData;
        public CCategoryService(ServerCS5DbContext context, ICategoryData categoryData)
        {
            _context = context;
            _categoryData = categoryData;
        }
        public Category ModelItem (string model)
        {
            return new Category { Name = model };
        }
        public async Task<string> AddCategory(string model)
        {
            if(model == null)
            {
                return "Không có dữ liệu";
            }
            Category category = ModelItem (model);
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            return "Thành công thêm dữ liệu";    
        }
        public List<CategoryDTOs> GetCategories()
        {
            List<Category> list = _categoryData.GetAllCategory();
            List<CategoryDTOs> result = new List<CategoryDTOs>();
            foreach (var category in list)
            {
                CategoryDTOs categoryDTOs = new CategoryDTOs()
                {
                    Id = category.Id,
                    Name = category.Name,
                };
                result.Add(categoryDTOs);

            }
            return result;
        }
        public List<Product> GetCategoryById (int id)
        {
            return _categoryData.GetProductsByCategoryId(id);
        }
    }
}
